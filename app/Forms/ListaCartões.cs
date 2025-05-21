using app.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace app
{
    public partial class ListaCartões : Form
    {
        private Form1 mainForm;
        public ListaCartões(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            // Desabilitar a seleção de linha
            Tbl_ListaCartões.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // ou None para evitar a seleção de linhas
            Tbl_ListaCartões.DataSource = Banco.ObterCartões();
            // Adicionar a coluna booleana de seleção antes de carregar os dados
            if (!Tbl_ListaCartões.Columns.Contains("Selecionar"))
            {
                DataGridViewCheckBoxColumn selecionarColuna = new DataGridViewCheckBoxColumn();
                selecionarColuna.Name = "Selecionar";
                selecionarColuna.HeaderText = "Selecionar";
                selecionarColuna.Width = 50;
                Tbl_ListaCartões.Columns.Add(selecionarColuna);
            }

            // Carregar dados na grid


            // Permitir que a coluna de checkbox seja editável
            foreach (DataGridViewColumn coluna in Tbl_ListaCartões.Columns)
            {
                if (coluna.Name == "Selecionar")
                {
                    coluna.ReadOnly = false; // Permitir edição apenas na coluna de checkbox
                }
                else
                {
                    coluna.ReadOnly = true; // Deixar as outras colunas somente leitura
                }
            }
            PopularComboBoxTurmas();
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
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(userControl);
            userControl.BringToFront();
        }
        public void PopularComboBoxTurmas()
        {
            try
            {
                DataTable dtTurmas = Banco.ObterNomeTurmas();
                ComBox_turma.Items.Clear();

                if (dtTurmas != null && dtTurmas.Rows.Count > 0)
                {
                    foreach (DataRow row in dtTurmas.Rows)
                    {
                        ComBox_turma.Items.Add(row["T_TURMA"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as Turmas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListaCartões_Load(object sender, EventArgs e)
        {
        }
        private void Tbl_ListaCartões_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (Tbl_ListaCartões.CurrentCell is DataGridViewCheckBoxCell)
            {
                Tbl_ListaCartões.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void Tbl_ListaCartões_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Garantir que a mudança ocorreu na coluna de checkbox
            if (e.ColumnIndex == Tbl_ListaCartões.Columns["Selecionar"].Index && e.RowIndex >= 0)
            {
                bool isChecked = Convert.ToBoolean(Tbl_ListaCartões.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                Console.WriteLine($"Linha {e.RowIndex}: Checkbox = {isChecked}");
            }
        }



        private void Tbl_ListaCartões_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignorar erros de conversão
            e.ThrowException = false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            string idAluno = Tbl_ListaCartões.SelectedRows[0].Cells["ID"].Value.ToString();
            DialogResult res = MessageBox.Show("Apagar Cartão?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarAluno(idAluno);
                Tbl_ListaCartões.Rows.RemoveAt(Tbl_ListaCartões.SelectedRows[0].Index);
            }
        }

        private void Tbl_ListaCartões_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // Verifique se a linha clicada é válida
            if (e.RowIndex >= 0)
            {
                // Obter o valor da célula "ID"
                var valorId = dgv.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                // Verifique se o valor é nulo ou se é do tipo esperado
                if (valorId != null && valorId is string)
                {
                    string idSelecionado = valorId.ToString();

                    // Executar a consulta completa para obter os dados detalhados
                    DataTable dt = Banco.TodosCartões();

                    // Localizar o registro correspondente na consulta
                    DataRow[] rows = dt.Select($"N_IDCARTAO = '{idSelecionado}'");

                    if (rows.Length > 0)
                    {
                        // Recuperar os dados detalhados
                        string nome = rows[0].Field<string>("T_NOME");
                        string numero = rows[0].Field<string>("N_NUMERO");
                        string trienio = rows[0].Field<string>("N_TRIENIO");
                        string curso = rows[0].Field<string>("T_CURSO");
                        byte[] imagemBytesFtAluno = rows[0].Field<byte[]>("I_FTALUNO");
                        byte[] imagemBytesQrCode = rows[0].Field<byte[]>("I_QRCODE");

                        // Passar os dados para o formulário de edição
                        var editarCartoesForm = new EditarCartoes(mainForm, rows[0], valorId, nome, numero, trienio, curso, imagemBytesFtAluno, imagemBytesQrCode);
                        openChildForm(editarCartoesForm);
                    }
                    else
                    {
                        MessageBox.Show("Os dados detalhados não foram encontrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido ou nulo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      

        private void txt_turma_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ComBox_turma.Text))
            {
                DataTable cartoes = Banco.ObterCartões();
                Tbl_ListaCartões.DataSource = cartoes;
            }
            else
            {

                string filtroTurma = ComBox_turma.Text.Trim();
                DataTable cartoes = Banco.ObterCartãoesPorTurma(filtroTurma);
                Tbl_ListaCartões.DataSource = cartoes;
            }
        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                DataTable cartoes = Banco.ObterCartões();
                Tbl_ListaCartões.DataSource = cartoes;
            }
            else
            {

                string filtroTurma = txt_Nome.Text.Trim();
                DataTable cartoes = Banco.ObterCartãoesPorAluno(filtroTurma);
                Tbl_ListaCartões.DataSource = cartoes;
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idsSelecionados = new List<int>();

                foreach (DataGridViewRow row in Tbl_ListaCartões.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Selecionar"].Value))
                    {
                        if (int.TryParse(row.Cells["ID"].Value.ToString(), out int id))
                        {
                            idsSelecionados.Add(id);
                        }
                    }
                }

                if (idsSelecionados.Count == 0)
                {
                    MessageBox.Show("Nenhum cartão selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable cartoesSelecionados = Banco.ObterCartõesSelecionados(idsSelecionados);

                using (MemoryStream ms = new MemoryStream()) // Cria um MemoryStream para armazenar temporariamente o PDF
                {
                    // Cria um documento PDF com tamanho A4 e sem margens (0,0,0,0)
                    Document document = new Document(PageSize.A4, 0, 0, 0, 0);
                    PdfWriter writer = PdfWriter.GetInstance(document, ms); // Associa o documento ao MemoryStream
                    document.Open(); // Abre o documento para escrita

                    // Cria uma tabela com 2 colunas (uma para a frente e outra para o verso dos cartões)
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 87; // Define a largura da tabela como 82% da página
                    table.SetWidths(new float[] { 1, 1 }); // Define a largura das colunas como iguais (1:1)

                    int contador = 0; // Contador para acompanhar quantos cartões foram adicionados

                    // Percorre todas as linhas da tabela 'cartoesSelecionados' (cartões escolhidos para impressão)
                    foreach (DataRow row in cartoesSelecionados.Rows)
                    {
                        // Obtém as imagens da frente e do verso do cartão a partir da base de dados
                        byte[] imagemFrente = row.Field<byte[]>("I_CARTAO");
                        byte[] imagemVerso = row.Field<byte[]>("I_QRCODE");

                        // Converte os arrays de bytes em imagens para o iTextSharp
                        iTextSharp.text.Image imgFrente = iTextSharp.text.Image.GetInstance(imagemFrente);
                        iTextSharp.text.Image imgVerso = iTextSharp.text.Image.GetInstance(imagemVerso);

                        // Ajusta o tamanho das imagens para 8,50 cm x 5,50 cm (convertido para pontos: 241 x 156)
                        imgFrente.ScaleAbsolute(255f, 164f);
                        imgVerso.ScaleAbsolute(255f, 164f);

                        // Cria células da tabela para armazenar as imagens da frente e do verso
                        PdfPCell cellFrente = new PdfPCell(imgFrente)
                        {
                            Border = iTextSharp.text.Rectangle.NO_BORDER, // Remove as bordas da célula
                            Padding = 1 // Adiciona um pequeno espaçamento interno
                        };

                        PdfPCell cellVerso = new PdfPCell(imgVerso)
                        {
                            Border = iTextSharp.text.Rectangle.NO_BORDER,
                            Padding = 1
                        };

                        // Adiciona as células (frente e verso) à tabela
                        table.AddCell(cellFrente);
                        table.AddCell(cellVerso);
                        contador++; // Incrementa o contador de cartões adicionados

                        // Quando atingir 10 cartões (5 filas), adiciona a tabela ao documento e inicia uma nova página
                        if (contador % 10 == 0)
                        {
                            document.Add(table); // Adiciona a tabela à página atual
                            document.NewPage(); // Cria uma nova página

                            // Reinicia a tabela para a nova página
                            table = new PdfPTable(2);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 1, 1 });
                        }
                    }

                    // Se ainda houver cartões não impressos na última página, adiciona a tabela restante ao documento
                    if (contador % 10 != 0)
                    {
                        document.Add(table);
                    }

                    document.Close(); // Fecha o documento PDF

                    // Abre um novo formulário 'PreImpressao' para pré-visualizar o PDF gerado
                    openChildForm(new PreImpressao(mainForm, ms.ToArray()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar o PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_todas_Click(object sender, EventArgs e)
        {
            bool existePeloMenosUmaDesmarcada = false;

            // Verifica se há pelo menos uma checkbox desmarcada
            foreach (DataGridViewRow row in Tbl_ListaCartões.Rows)
            {
                if (row.Cells["Selecionar"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    if (!(checkBoxCell.Value is bool marcada) || !marcada)
                    {
                        existePeloMenosUmaDesmarcada = true;
                        break;
                    }
                }
            }

            // Define o novo estado (true se havia pelo menos uma desmarcada, false caso contrário)
            bool novoEstado = existePeloMenosUmaDesmarcada;

            // Aplica o novo estado a todas as linhas
            foreach (DataGridViewRow row in Tbl_ListaCartões.Rows)
            {
                if (row.Cells["Selecionar"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    checkBoxCell.Value = novoEstado;
                }
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Tbl_ListaCartões.DataSource = Banco.ObterCartões();
            ComBox_turma.SelectedItem = 0;
            txt_Nome.Text = "";
        }
    }
}
