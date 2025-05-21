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

        private void btn_GerarQr_Click(object sender, EventArgs e)
        {
            // Monta o texto que será convertido em QR Code
            string textData = txt_numero.Text;
            if (string.IsNullOrEmpty(textData))
            {
                MessageBox.Show("Por favor, preencha o número antes de criar o QR Code.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Chama o método para gerar o QR Code
                CriarQRCode criarQRCode = new CriarQRCode(PixBx_Qrcode);
                criarQRCode.GerarQRCode(textData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar QR Code: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Verifica se algum dos campos ainda tem os valores iniciais ou está vazio
            if (string.IsNullOrWhiteSpace(txt_nome.Text) || txt_nome.Text == "Nome" ||
                string.IsNullOrWhiteSpace(txt_numero.Text) || txt_numero.Text == "Número" ||
                string.IsNullOrWhiteSpace(txt_trienio.Text) || txt_trienio.Text == "Triénio" ||
                PixBx_FotoAluno.Image == null || PixBx_Qrcode.Image == null)
            {
                MessageBox.Show("Preencha todos os campos antes de prosseguir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém os valores dos campos
            string nome = txt_nome.Text.Trim();
            string numero = txt_numero.Text.Trim();
            string trienio = txt_trienio.Text.Trim();
            string curso = ComBox_Curso.Text;
            Image ftAluno = PixBx_FotoAluno.Image;
            Image qrcode = PixBx_Qrcode.Image;

            // Limpa os campos após a criação do formulário
            txt_nome.Text = "";
            txt_numero.Text = "";
            txt_trienio.Text = "";
            ComBox_Curso.SelectedIndex = -1;
            PixBx_FotoAluno.Image = app.Properties.Resources.pessoa;
            PixBx_Qrcode.Image = null;

            // Cria e exibe a instância do formulário de pré-visualização
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
