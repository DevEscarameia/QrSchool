using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace app
{
    public partial class FrmPrevisualizarCartão : Form
    {
        private byte[] imagemBytes;

        public FrmPrevisualizarCartão(string nome, string numero, string trienio, string curso, Image ftAluno, Image qrcode, byte[] imagemBytes)
        {
            InitializeComponent();

            lbl_nome.Text = nome;
            lbl_numero.Text = numero;
            lbl_trienio.Text = trienio;
            lbl_Curso.Text = curso;
            PicBox_ftAluno.Image = ftAluno;
            PixBox_qrcode.Image = qrcode;

            this.imagemBytes = imagemBytes;
        }


        private void btn_guardarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um objeto Alunos
                Alunos alunos = new Alunos();
                alunos.T_NOME = lbl_nome.Text;
                alunos.N_NUMERO = lbl_numero.Text;
                alunos.N_TRIENIO = lbl_trienio.Text;
                alunos.T_CURSO = lbl_Curso.Text;
                alunos.I_FTALUNO = imagemBytes;
                alunos.I_QRCODE = imagemBytes;

                // Define o nome do arquivo e o diretório onde o PDF será salvo
                string nomeArquivo = $"{lbl_nome.Text}_{lbl_numero.Text}.pdf";
                string caminhoPasta = @"C:\Users\duart\OneDrive\Ambiente de Trabalho\ERASMUS";
                string caminhoCompleto = Path.Combine(caminhoPasta, nomeArquivo);

                // Configura o objeto SaveFileDialog para definir o nome padrão do arquivo e o diretório inicial
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = nomeArquivo;
                saveFileDialog.InitialDirectory = caminhoPasta;

                // Mostra a caixa de diálogo SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Configura as configurações da impressora para o caminho selecionado pelo usuário
                    printDocument1.PrinterSettings.PrintToFile = true;
                    printDocument1.PrinterSettings.PrintFileName = saveFileDialog.FileName;

                    // Define as configurações da página e lida com o evento PrintPage para desenhar o conteúdo
                    printDocument1.DefaultPageSettings.Landscape = true;
                    printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                    // Inicia o processo de impressão (que, na verdade, irá salvar o PDF no caminho especificado)
                    printDocument1.Print();

                    // Salva o aluno no banco de dados
                    Banco.CriarAluno(alunos);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                // Obtém o tamanho do cartão
                int cartaoWidthPx = 170;
                int cartaoHeightPx = 113;

                // Ajusta a orientação do papel
                e.PageSettings.Landscape = false;

                // Cria um bitmap com o conteúdo do pnl_cartao
                Bitmap bmpCartao = new Bitmap(pnl_cartao.Width, pnl_cartao.Height);
                pnl_cartao.DrawToBitmap(bmpCartao, new Rectangle(0, 0, pnl_cartao.Width, pnl_cartao.Height));

                // Cria um bitmap com o conteúdo do pnl_Qrcode
                Bitmap bmpQrcode = new Bitmap(pnl_Qrcode.Width, pnl_Qrcode.Height);
                pnl_Qrcode.DrawToBitmap(bmpQrcode, new Rectangle(0, 0, pnl_Qrcode.Width, pnl_Qrcode.Height));

                // Desenha o bitmap do pnl_cartao no documento de impressão
                e.Graphics.DrawImage(bmpCartao, 0, 0, cartaoWidthPx, cartaoHeightPx);
                e.Graphics.DrawImage(bmpQrcode, 170, 0, cartaoWidthPx, cartaoHeightPx);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao imprimir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_cartao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComBox_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica qual item está selecionado na ComboBox
            string selectedItem = ComBox_Dimensao.SelectedItem.ToString();

            // Define as dimensões da PictureBox com base no item selecionado
            switch (selectedItem)
            {
                case "Normal":
                    PicBox_ftAluno.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Zoom":
                    PicBox_ftAluno.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "StretchImage":
                    PicBox_ftAluno.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "CenterImage":
                    PicBox_ftAluno.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "AutoSize":
                    PicBox_ftAluno.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                default:
                    // Se o item selecionado não corresponder a nenhum dos casos anteriores,
                    // pode ser útil definir um comportamento padrão ou lidar com isso de outra forma
                    break;
            }
        }
    }
}
