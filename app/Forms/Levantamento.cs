using app.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace app
{
    public partial class Levantamento : Form
    {
        private Form1 mainForm;
       
        public Levantamento(Form1 form1, DataRow selectedRow)
        {
            InitializeComponent();
            mainForm = form1;
            // Exemplo de como preencher os controles do formulário com os dados do DataRow
            txt_professor.Text = selectedRow["Professor"].ToString();
            txt_horaInicio.Text = selectedRow["Inicio"].ToString();
            txt_horaFim.Text = selectedRow["Fim"].ToString();
            txt_turma.Text = selectedRow["Turma"].ToString();
            txt_quantidade.Text = selectedRow["Portateis"].ToString();
            txt_data.Text = DateTime.Parse(selectedRow["Data"].ToString()).ToString("dd/MM/yyyy");
            txt_IdRequisiçao.Text = selectedRow["ID"].ToString();

        }

        private void tbl_levantamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void Levantamento_Load(object sender, EventArgs e)
        {
            int idRequisicao;
            int.TryParse(txt_IdRequisiçao.Text, out idRequisicao);

            Levantamentos levantamento = new Levantamentos
            {
                N_IDREQUISIÇÃO = idRequisicao
            };

            tbl_levantamentos.DataSource = Banco.TodasRequisiçõesFeitas(levantamento);
            txt_descriçao.Text = Banco.ObterDescriçaoReservas(idRequisicao);

            tbl_levantamentos.CellFormatting += tbl_levantamentos_CellFormatting;

            // Focar na TextBox de Aluno
            txt_IdAluno.Focus();
        }

        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainForm.PanelPrincipal.Controls.Add(childForm); // Usando a propriedade pública
            mainForm.PanelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            openChildForm(new ListaReservas(mainForm));
        }


        private void levantar()
        {
            try
            {
                int idAluno = int.Parse(txt_IdAluno.Text);
                int idPortatil = int.Parse(txt_IdPortatil.Text);
                int idRequisiçao = int.Parse(txt_IdRequisiçao.Text);
                int maxLevantamentos = int.Parse(txt_quantidade.Text);

                int levantamentosAtuais = Banco.ObterQuantidadeLevantamentos(idRequisiçao);

                if (levantamentosAtuais >= maxLevantamentos)
                {
                    mostrarNotificaçao("AVISO", "O número máximo foi atingido!");
                    return;
                }

                // Verifica se já existe um levantamento com este aluno ou portátil nesta requisição
                string mensagemErro = Banco.VerificarLevantamentoExistente(idRequisiçao, idAluno, idPortatil);

                if (!string.IsNullOrEmpty(mensagemErro))
                {
                    MessageBox.Show(mensagemErro, "Erro de Levantamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Levantamento da requisição atual
                Levantamentos levantamentoPrincipal = new Levantamentos
                {
                    N_IDREQUISIÇÃO = idRequisiçao,
                    N_IDALUNO = idAluno,
                    N_IDPORTATIL = idPortatil,
                    T_PROFESSOR = txt_professor.Text,
                    D_DATALEVANTAMENTO = DateTime.Now.Date,
                    N_HORALEVANTAMENTO = DateTime.Now.ToString("HH:mm:ss"),
                    T_STATUS = "Levantado"
                };

                Banco.NovoLevantamento(levantamentoPrincipal);

                // 2. Obter outras requisições iguais (exceto a atual)
                DateTime dataRequisicao;
                if (!DateTime.TryParse(txt_data.Text, out dataRequisicao))
                {
                    MessageBox.Show("Data inválida. Por favor, insira uma data válida.", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Requisições requisicaoAtual = new Requisições
                {
                    T_PROFESSORRESPONSAVEL = txt_professor.Text,
                    T_TURMA = txt_turma.Text, // Asegura que tens esse txt_turma no formulário
                    N_NºPORTATEIS = maxLevantamentos,
                    T_DATAREQUISIÇÃO = dataRequisicao // Passa a data convertida
                };

                DataTable reservasIguais = Banco.ObterReservasIguais(requisicaoAtual, idRequisiçao);


                foreach (DataRow row in reservasIguais.Rows)
                {
                    int idRequisicaoIgual = Convert.ToInt32(row["ID"]);

                    // Verifica se já existe levantamento para essa reserva igual
                    string erro = Banco.VerificarLevantamentoExistente(idRequisicaoIgual, idAluno, idPortatil);

                    if (string.IsNullOrEmpty(erro))
                    {
                        Levantamentos lev = new Levantamentos
                        {
                            N_IDREQUISIÇÃO = idRequisicaoIgual,
                            N_IDALUNO = idAluno,
                            N_IDPORTATIL = idPortatil,
                            T_PROFESSOR = txt_professor.Text,
                            D_DATALEVANTAMENTO = DateTime.Now.Date,
                            N_HORALEVANTAMENTO = DateTime.Now.ToString("HH:mm:ss"),
                            T_STATUS = "Levantado"
                        };

                        Banco.NovoLevantamento(lev);
                    }
                }

                // Atualiza a tabela
                tbl_levantamentos.DataSource = Banco.TodasRequisiçõesFeitas(levantamentoPrincipal);

                mostrarNotificaçao("SUCESSO", "Levantamento realizado com sucesso para todas as reservas iguais!");

                // Limpar campos
                txt_IdAluno.Text = "";
                txt_IdPortatil.Text = "";
                txt_IdAluno.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado. Por favor, tente novamente.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Limpa as TextBoxs e foca na txt_IdAluno
                txt_IdAluno.Text = "";
                txt_IdPortatil.Text = "";
                txt_IdAluno.Focus();
            }
        }

        private void btn_Levantar_Click(object sender, EventArgs e)
        {
            levantar();
        }
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (tbl_levantamentos.CurrentRow != null)
            {
                string horaCompleta = tbl_levantamentos.CurrentRow.Cells["Hora de Levantamento"].Value.ToString();
                string dataOriginal = tbl_levantamentos.CurrentRow.Cells["Data de Levantamento"].Value.ToString();
                string professor = tbl_levantamentos.CurrentRow.Cells["Professor"].Value.ToString();
                string idAluno = tbl_levantamentos.CurrentRow.Cells["ID Aluno"].Value.ToString();
                string idPortatil = tbl_levantamentos.CurrentRow.Cells["ID Portátil"].Value.ToString();

                // Converter data para o formato yyyy-MM-dd
                DateTime dataConvertida = DateTime.Parse(dataOriginal);
                string dataFormatada = dataConvertida.ToString("yyyy-MM-dd");

                // Garantir que a hora está no formato HH:mm:ss
                string horaFormatada = DateTime.Parse(horaCompleta).ToString("HH:mm:ss");

                DialogResult res = MessageBox.Show("Apagar este levantamento específico?", "Confirmação", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Banco.ApagarLevantamentoEspecifico(horaFormatada, dataFormatada, professor, idAluno, idPortatil);
                    mostrarNotificaçao("SUCESSO", "Levantamento apagado com sucesso!");

                    tbl_levantamentos.Rows.Remove(tbl_levantamentos.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para apagar.");
            }
        }


        private void btn_Entregas_Click(object sender, EventArgs e)
        {
            DataRow entregaRow = CriarEntregaRow(); // Criar DataRow com os dados necessários
            openChildForm(new Entregas(mainForm, entregaRow)); // Passar os dados para o form Entregas
        }

        // Método para criar um DataRow com os dados dos levantamentos
        private DataRow CriarEntregaRow()
        {
            DataTable table = new DataTable(); // Cria uma tabela temporária
            table.Columns.Add("Professor", typeof(string));
            table.Columns.Add("Inicio", typeof(string));
            table.Columns.Add("Fim", typeof(string));
            table.Columns.Add("Turma", typeof(string));
            table.Columns.Add("Portateis", typeof(string));
            table.Columns.Add("Data", typeof(string));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("HoraLevantamento", typeof(string));  // Adiciona a coluna HoraLevantamento


            DataRow row = table.NewRow(); // Preenche o DataRow com os dados do formulário atual
            row["Professor"] = txt_professor.Text;
            row["Inicio"] = txt_horaInicio.Text;
            row["Fim"] = txt_horaFim.Text;
            row["Turma"] = txt_turma.Text;
            row["Portateis"] = txt_quantidade.Text;
            row["Data"] = txt_data.Text;
            row["ID"] = txt_IdRequisiçao.Text;
            row["HoraLevantamento"] = DateTime.Now.ToString("HH:mm:ss");  // Passa a hora de levantamento
    
            return row;
        }

    

        private void txt_IdAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Quando a pistola enviar Enter
            {
                txt_IdPortatil.Focus(); // Passa automaticamente para a segunda TextBox
                e.Handled = true; // Evita o beep
            }
        }

        private void txt_IdPortatil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Quando a pistola en0viar Enter
            {
                levantar();
            }
        }

        private void tbl_levantamentos_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tbl_levantamentos.Columns[e.ColumnIndex].Name == "Hora de Levantamento")
            {
                if (e.Value != null)
                {
                    // Formatar a hora para exibição
                    e.Value = DateTime.Parse(e.Value.ToString()).ToString("HH:mm");
                }
            }
            // Verifica se a coluna é a que indica "Estado"
            if (tbl_levantamentos.Columns[e.ColumnIndex].Name == "Estado")
            {
                // Obtém o valor da célula
                object cellValue = tbl_levantamentos.Rows[e.RowIndex].Cells["Estado"].Value;

                // Verifica se o valor não é nulo ou vazio
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString().Trim()))
                {
                    // Converte o valor para string, remove espaços e para minúsculas
                    string estado = cellValue.ToString().Trim().ToLower();

                    // Define a cor com base no estado
                    if (estado == "levantado")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(254, 32, 32); // Não entregue
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (estado == "entregue")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(126, 244, 130); // Entregue
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Caso o valor não corresponda a "entregue" ou "não entregue", cor neutra
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.White;
                    }
                }
                else
                {
                    // Para células vazias, aplicamos uma cor neutra
                    e.CellStyle.BackColor = Color.Gray;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

       
    }


}

