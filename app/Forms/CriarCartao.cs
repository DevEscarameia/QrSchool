using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class CriarCartao : Form
    {
        // Fields
        public Int32 Id_Cartão;
        public string T_NOME;
        public string N_NUMERO;
        public string N_TRIENIO;
        public string T_CURSO;
        public Image I_FTALUNO;
        public byte[] imagemBytes1;
        public byte[] imagemBytes2;

        public byte[] GetImagemBytes1()
        {
            return imagemBytes1;
        }

        public byte[] GetImagemBytes2()
        {
            return imagemBytes2;
        }

        public CriarCartao()
        {
            InitializeComponent();
            txt_trienio.KeyPress += txt_trienio_KeyPress;
            txt_trienio.TextChanged += txt_trienio_TextChanged;
            txt_trienio.MaxLength = 7;
        }

        private void btn_CarregarFt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Selecione a Foto do Utilizador";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string origemCompleto = openFileDialog.FileName;

                        using (FileStream fs = new FileStream(origemCompleto, FileMode.Open, FileAccess.Read))
                        {
                            imagemBytes1 = new byte[fs.Length];
                            fs.Read(imagemBytes1, 0, (int)fs.Length);
                        }

                        // Exibe a imagem no PictureBox
                        using (MemoryStream ms = new MemoryStream(imagemBytes1))
                        {
                            PixBx_FotoAluno.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao carregar a imagem: {ex.Message}");
                    }
                }
            }
        }

        private void btn_GeraQr_Click(object sender, EventArgs e)
        {
            // Monta o texto que será convertido em QR Code
            string textData = $"{txt_nome.Text} {txt_numero.Text} {ComBox_Curso.SelectedItem}";

            // Define o caminho de saída para o arquivo do QR Code
            string outputFilePath = $"C:\\YourFolderPath\\QrCode_{txt_nome.Text}_{txt_numero.Text}.png";

            try
            {
                // Chama o método para gerar o QR Code
                CriarQRCode criarQRCode = new CriarQRCode(PixBx_Qrcode);
                criarQRCode.GerarQRCode(textData, outputFilePath);

                // Libera a imagem antiga no PictureBox (evita o erro de GDI+)
                if (PixBx_Qrcode.Image != null)
                {
                    PixBx_Qrcode.Image.Dispose();
                    PixBx_Qrcode.Image = null;
                }

                // Lê os bytes da imagem do QR Code gerada
                using (FileStream fs = new FileStream(outputFilePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] imagemBytes2 = new byte[fs.Length];
                    fs.Read(imagemBytes2, 0, (int)fs.Length);

                    // Exibe a nova imagem no PictureBox
                    using (MemoryStream ms = new MemoryStream(imagemBytes2))
                    {
                        PixBx_Qrcode.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso algo dê errado
                MessageBox.Show($"Ocorreu um erro ao gerar o QR code: {ex.Message}");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Verifica se algum dos campos ainda tem os valores iniciais
            if (txt_nome.Text == "Nome" || txt_numero.Text == "Número" || txt_trienio.Text == "Triénio" || ComBox_Curso.Text == "Curso")
            {
                MessageBox.Show("Preencha todos os campos antes de prosseguir.");
                return;
            }

            // Obtém os valores dos campos
            string nome = txt_nome.Text;
            string numero = txt_numero.Text;
            string trienio = txt_trienio.Text;
            string curso = ComBox_Curso.SelectedItem.ToString();
            Image ftAluno = PixBx_FotoAluno.Image;
            Image qrcode = PixBx_Qrcode.Image;

            // Cria uma instância do FrmPrevisualizarCartão passando os valores
            FrmPrevisualizarCartão frmPrevisualizarCartão = new FrmPrevisualizarCartão(nome, numero, trienio, curso, ftAluno, qrcode, imagemBytes2);
            frmPrevisualizarCartão.Show();



        }

        private void txt_trienio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_trienio.Text.Length == 4 && txt_trienio.Text[3] != '/')
            {
                txt_trienio.Text = txt_trienio.Text.Insert(4, "/");
                txt_trienio.SelectionStart = txt_trienio.Text.Length;
            }
        }

        private void txt_trienio_TextChanged(object sender, EventArgs e)
        {
            if (txt_trienio.Text.Length == 4 && txt_trienio.Text[3] != '/')
            {
                txt_trienio.Text = txt_trienio.Text.Insert(4, "/");
                txt_trienio.SelectionStart = txt_trienio.Text.Length;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
