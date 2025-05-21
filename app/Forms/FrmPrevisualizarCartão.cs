using app;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace app
{
    public partial class FrmPrevisualizarCartão : Form
    {
        private byte[] imagemCartaoBytes;

        public FrmPrevisualizarCartão(string nome, string numero, string trienio, string curso, Image ftAluno, Image qrcode, byte[] imagemCartaoBytes)
        {
            InitializeComponent();

            lbl_nome.Text = nome;
            lbl_numero.Text = numero;
            lbl_trienio.Text = trienio;
            lbl_Curso.Text = curso;
            PicBox_ftAluno.Image = ftAluno;
            PixBox_qrcode.Image = qrcode;

            this.imagemCartaoBytes = imagemCartaoBytes;
        }

        private byte[] ConverterImagemParaBytes(Image imagem)
        {
            if (imagem == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imagem.Save(ms, ImageFormat.Png); // Garante que a imagem seja salva no formato PNG
                return ms.ToArray();
            }
        }


        private byte[] GerarImagemCartao()
        {
            using (Bitmap bmpCartao = new Bitmap(pnl_cartao.Width, pnl_cartao.Height))
            {
                // Cria um contexto gráfico para desenhar o conteúdo do painel no bitmap
                using (Graphics g = Graphics.FromImage(bmpCartao))
                {
                    pnl_cartao.DrawToBitmap(bmpCartao, new Rectangle(0, 0, pnl_cartao.Width, pnl_cartao.Height));
                }
                return ConverterImagemParaBytes(bmpCartao);
            }
        }
        private byte[] GerarImagemCartaoAtras()
        {
            using (Bitmap bmpCartaoAtras = new Bitmap(pnl_Qrcode.Width, pnl_Qrcode.Height))
            {
                // Cria um contexto gráfico para desenhar o conteúdo do painel no bitmap
                using (Graphics g = Graphics.FromImage(bmpCartaoAtras))
                {
                    pnl_Qrcode.DrawToBitmap(bmpCartaoAtras, new Rectangle(0, 0, pnl_Qrcode.Width, pnl_Qrcode.Height));
                }
                return ConverterImagemParaBytes(bmpCartaoAtras);
            }
        }
        private void btn_guardarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Converte imagens para byte arrays
                byte[] fotoAlunoBytes = ConverterImagemParaBytes(PicBox_ftAluno.Image);
                byte[] qrcodeBytes = GerarImagemCartaoAtras();
                byte[] cartaoBytes = GerarImagemCartao();


                // Cria um objeto Alunos
                Alunos alunos = new Alunos
                {
                    T_NOME = lbl_nome.Text,
                    N_NUMERO = lbl_numero.Text,
                    N_TRIENIO = lbl_trienio.Text,
                    T_CURSO = lbl_Curso.Text,
                    I_FTALUNO = fotoAlunoBytes,
                    I_QRCODE = qrcodeBytes,
                    I_CARTAO = cartaoBytes
                };

                // Salva o aluno no banco de dados
                Banco.CriarAluno(alunos);

              
               MessageBox.Show("Dados do cartão guardados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao guardar os dados do cartão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
