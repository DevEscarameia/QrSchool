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

namespace app
{
    public partial class CriarCartao : Form
    {
        // Criar uma instância do formulário Form1
        
        // Campos
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

        // Construtor
        public CriarCartao()
        {
            InitializeComponent();
            txt_trienio.KeyPress += txt_trienio_KeyPress;
            txt_trienio.TextChanged += txt_trienio_TextChanged;
            txt_trienio.MaxLength = 7;

        }

        private void txt_nome_Enter(object sender, EventArgs e)
        {
            if (txt_nome.Text == "Nome")
            {
                txt_nome.Text = "";
                txt_nome.ForeColor = Color.Black;
            }
        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

       

        private void txt_nome_Leave(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                txt_nome.Text = "Nome";
                txt_nome.ForeColor = Color.Black;
            }
        }

        private void txt_numero_Enter(object sender, EventArgs e)
        {
            if (txt_numero.Text == "Número")
            {
                txt_numero.Text = "";
                txt_numero.ForeColor = Color.Black;
            }
        }

        private void txt_numero_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_numero_Leave(object sender, EventArgs e)
        {
            if (txt_numero.Text == "")
            {
                txt_numero.Text = "Número";
                txt_numero.ForeColor = Color.Black;
            }
        }

        private void txt_trienio_Enter(object sender, EventArgs e)
        {
            if (txt_trienio.Text == "Triénio")
            {
                txt_trienio.Text = "";
                txt_trienio.ForeColor = Color.Black;
            }
        }

        private void txt_trienio_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_trienio_TextChanged(object sender, EventArgs e)
        {
            if (txt_trienio.Text.Length == 4 && txt_trienio.Text[3] != '/')
            {
                txt_trienio.Text = txt_trienio.Text.Insert(4, "/");
                txt_trienio.SelectionStart = txt_trienio.Text.Length;
            }
        }

        private void txt_trienio_KeyPress(object sender, KeyPressEventArgs e)
        {
             
        }

        private void txt_trienio_Leave(object sender, EventArgs e)
        {
            if (txt_trienio.Text == "")
            {
                txt_trienio.Text = "Triénio";
                txt_trienio.ForeColor = Color.Black;
            }
        }

        private void txt_trienio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txt_trienio.Text.Length == 4 && txt_trienio.Text[3] != '/')
            {
                txt_trienio.Text = txt_trienio.Text.Insert(4, "/");
                txt_trienio.SelectionStart = txt_trienio.Text.Length;
            }
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

            if (txt_nome.Text == "Nome" || txt_numero.Text == "Número" || txt_trienio.Text == "Triénio" || ComBox_Curso.Text == "Curso")
            {
                MessageBox.Show("Preencha todos os campos antes de Criar o QRCode.");
                return;
            }

            string textData = $"{txt_nome.Text} {txt_numero.Text} {ComBox_Curso.SelectedItem}";

            string outputFilePath = $"C:\\YourFolderPath\\QrCode_{txt_nome.Text}_{txt_numero.Text}.png";

            // Chama o método GerarQRCode
            try
            {
                CriarQRCode criarQRCode = new CriarQRCode(PixBx_Qrcode);
                criarQRCode.GerarQRCode(textData, outputFilePath);

                // Carrega os bytes da imagem
                using (FileStream fs = new FileStream(outputFilePath, FileMode.Open, FileAccess.Read))
                {
                    imagemBytes2 = new byte[fs.Length];
                    fs.Read(imagemBytes2, 0, (int)fs.Length);
                }

                // Exibe a imagem no PictureBox
                using (MemoryStream ms = new MemoryStream(imagemBytes2))
                {
                    PixBx_FotoAluno.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
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

            // Restaura os valores iniciais nos campos
            txt_nome.Text = "Nome";
            txt_numero.Text = "Número";
            txt_trienio.Text = "Triénio";
            ComBox_Curso.Text = "Curso";
            PixBx_FotoAluno.Image = app.Properties.Resources.pessoa;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
