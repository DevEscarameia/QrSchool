using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class Entregas : Form
    {
        private Form1 mainForm;
        public Entregas(Form1 form1, DataRow selectedRow)
        {
            mainForm = form1;
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
        private Form activeForm = null;
        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }
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
        private void tbl_levantamentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        int idRequisicao;
        private void Entregas_Load(object sender, EventArgs e)
        {

            int.TryParse(txt_IdRequisiçao.Text, out idRequisicao);

            Levantamentos levantamento = new Levantamentos
            {
                N_IDREQUISIÇÃO = idRequisicao
            };


            tbl_Entregas.DataSource = Banco.TodasRequisiçoesEntregues(levantamento);
            tbl_Entregas.CellFormatting += tbl_levantamentos_CellFormatting;

            txt_IdAluno.Focus();
        }

        private void txt_IdAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_IdPortatil.Focus();
                e.Handled = true;
            }
        }

        private void txt_IdPortatil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_IdPortatil.Focus();
                entregar();

            }
        }
        private void entregar()
        {
            try
            {
                int idAluno = int.Parse(txt_IdAluno.Text);
                int idPortatil = int.Parse(txt_IdPortatil.Text);
                int idRequisiçao = int.Parse(txt_IdRequisiçao.Text);
                int maxEntregas = int.Parse(txt_quantidade.Text);

                int EntregasAtuais = Banco.ContarEntregas(idRequisiçao);

                if (EntregasAtuais >= maxEntregas)
                {
                    mostrarNotificaçao("AVISO", "O número máximo foi atingido!");

                    return;
                }

                bool levantamentoExistente = Banco.VerificarLevantamento(idRequisicao, idAluno, idPortatil);
                if (!levantamentoExistente)
                {
                    mostrarNotificaçao("AVISO", "Levantamento não encontrado!");
                    return;
                }

                // Verifica se já existe um levantamento com este aluno ou portátil nesta requisição
                string mensagemErro = Banco.VerificarEntregaExistente(idRequisiçao, idAluno, idPortatil);

                if (!string.IsNullOrEmpty(mensagemErro))
                {
                    MessageBox.Show(mensagemErro, "Erro de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Entrega entrega = new Entrega
                {
                    N_IDREQUISIÇÃO = idRequisiçao,
                    N_IDALUNO = idAluno,
                    N_IDPORTATIL = idPortatil,
                    T_PROFESSOR = txt_professor.Text,
                    D_DATAENTREGA = DateTime.Now.Date,
                    N_HORAENTREGA = DateTime.Now.ToString("HH:mm:ss"),
                    T_STATUS = "Entregue"
                };

                // Atualizar a tabela após a entrega
                

                Banco.NovaEntrega(entrega);


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
                    N_NºPORTATEIS = maxEntregas,
                    T_DATAREQUISIÇÃO = dataRequisicao // Passa a data convertida
                };

                DataTable reservasIguais = Banco.ObterReservasIguais(requisicaoAtual, idRequisiçao);


                foreach (DataRow row in reservasIguais.Rows)
                {
                    int idRequisicaoIgual = Convert.ToInt32(row["ID"]);

                    // Verifica se já existe levantamento para essa reserva igual
                    string erro = Banco.VerificarEntregaExistente(idRequisicaoIgual, idAluno, idPortatil);

                    if (string.IsNullOrEmpty(erro))
                    {
                        Entrega ent = new Entrega
                        {
                            N_IDREQUISIÇÃO = idRequisicaoIgual,
                            N_IDALUNO = idAluno,
                            N_IDPORTATIL = idPortatil,
                            T_PROFESSOR = txt_professor.Text,
                            D_DATAENTREGA = DateTime.Now.Date,
                            N_HORAENTREGA = DateTime.Now.ToString("HH:mm:ss"),
                            T_STATUS = "Entregue"
                        };

                        Banco.NovaEntrega(ent);
                    }
                }

                mostrarNotificaçao("SUCESSO", "Entrega realizado com sucesso!");
                Levantamentos levantamento = new Levantamentos
                {
                    N_IDREQUISIÇÃO = idRequisiçao
                };
                tbl_Entregas.DataSource = Banco.TodasRequisiçoesEntregues(levantamento);
                txt_IdAluno.Text = ("");
                txt_IdPortatil.Text = ("");
                txt_IdAluno.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Formato inválido: {ex.Message}", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro de banco de dados: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Erro SQL: {ex.ToString()}"); // Log detalhado do erro SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Erro Inesperado: {ex.ToString()}"); // Log detalhado do erro inesperado
            }
            finally
            {
                // Limpa as TextBoxs e foca na txt_IdAluno, sempre
                txt_IdAluno.Text = "";
                txt_IdPortatil.Text = "";
                txt_IdAluno.Focus();
            }
        }
        private void btn_Levantar_Click(object sender, EventArgs e)
        {
            entregar();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (tbl_Entregas.CurrentRow != null)
            {
                string idLevantamento = tbl_Entregas.CurrentRow.Cells["ID"].Value.ToString();
                string horaCompleta = tbl_Entregas.CurrentRow.Cells["Hora de Entrega"].Value.ToString();
                string dataOriginal = tbl_Entregas.CurrentRow.Cells["Data de Entrega"].Value.ToString();
                string professor = tbl_Entregas.CurrentRow.Cells["Professor"].Value.ToString();

                DateTime dataConvertida = DateTime.Parse(dataOriginal);
                string dataFormatada = dataConvertida.ToString("yyyy-MM-dd");

                // Garantir que a hora está no formato HH:mm:ss
                string horaFormatada = DateTime.Parse(horaCompleta).ToString("HH:mm:ss");


                DialogResult res = MessageBox.Show("Apagar Entrega?", "Apagar", MessageBoxButtons.YesNo);


                if (res == DialogResult.Yes)
                {
                    Banco.ApagarEntrega(idLevantamento, horaFormatada, dataFormatada, professor);
                    mostrarNotificaçao("SUCESSO", "Entrega apagado com sucesso!");
                    tbl_Entregas.Rows.Remove(tbl_Entregas.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para apagar.");
            }
        }
        
        private void tbl_Entregas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tbl_Entregas.Columns[e.ColumnIndex].Name == "Hora de Entrega")
            {
                if (e.Value != null)
                {
                    // Formatar a hora para exibição
                    e.Value = DateTime.Parse(e.Value.ToString()).ToString("HH:mm");
                }
            }
            // Verifica se a coluna é a que indica "Estado"
            if (tbl_Entregas.Columns[e.ColumnIndex].Name == "Estado")
            {
                // Obtém o valor da célula
                object cellValue = tbl_Entregas.Rows[e.RowIndex].Cells["Estado"].Value;

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
        private DataRow CriarLevantamentoRow()
        {
            DataTable table = new DataTable(); // Cria uma tabela temporária
            table.Columns.Add("Professor", typeof(string));
            table.Columns.Add("Inicio", typeof(string));
            table.Columns.Add("Fim", typeof(string));
            table.Columns.Add("Turma", typeof(string));
            table.Columns.Add("Portateis", typeof(string));
            table.Columns.Add("Data", typeof(string));
            table.Columns.Add("ID", typeof(int));

            DataRow row = table.NewRow(); // Preenche o DataRow com os dados do formulário atual
            row["Professor"] = txt_professor.Text;
            row["Inicio"] = txt_horaInicio.Text;
            row["Fim"] = txt_horaFim.Text;
            row["Turma"] = txt_turma.Text;
            row["Portateis"] = txt_quantidade.Text;
            row["Data"] = txt_data.Text;
            row["ID"] = txt_IdRequisiçao.Text;

            return row;
        }
        private void btn_Levantamentos_Click(object sender, EventArgs e)
        {
            DataRow entregaRow = CriarLevantamentoRow(); // Criar DataRow com os dados necessários
            openChildForm(new Levantamento(mainForm, entregaRow));
        }
    }
}
