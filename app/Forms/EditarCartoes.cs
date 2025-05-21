using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class EditarCartoes : Form
    {
        private Form1 mainForm; 
        private bool isSwitching = false;
        private string valorId;
        private static byte[] imagemBytes;
        public static byte[] GetImagemBytes()
        {
            return imagemBytes;
        }

        public EditarCartoes(Form1 form1, DataRow selectedRow, string valorId,string nome, string numero, string trienio,string curso, byte[] imagemBytesFtAluno, byte[] imagemBytesQrCode)
        {
            InitializeComponent();
            mainForm = form1;
            lbl_numero.Text = numero;
            txt_numero.Text = numero.ToString();
            lbl_Curso.Text = curso;
            ComBox_Curso.Text = curso;
            lbl_nome.Text = nome;
            txt_Nome.Text = nome;
            txt_trienio.Text = trienio;
            lbl_trienio.Text = trienio;
            using (MemoryStream ms = new MemoryStream(imagemBytesFtAluno))
            {
                PicBox_ftAluno.Image = Image.FromStream(ms);
            }
            
            using (MemoryStream m = new MemoryStream(imagemBytesQrCode))
            {
                PixBox_qrcode.Image = Image.FromStream(m);
            }
          this.valorId = valorId;
           txt_trienio.MaxLength = 7;
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
        private void EditarCartoes_Load(object sender, EventArgs e)
        {
            pnl_cartao.Visible = true;
            pnl_Qrcode.Visible = false;

        }

        private void pnl_cartao_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Garantir que os painéis existem e estão na posição correta
                pnl_cartao.Visible = false;
                pnl_Qrcode.Visible = true;
                pnl_Qrcode.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alternar para o painel QRCode: " + ex.Message);
            }
        }

        private void pnl_Qrcode_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pnl_cartao.Visible = true;
                pnl_Qrcode.Visible = false;
                pnl_cartao.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alternar para o painel Cartão: " + ex.Message);
            }
        }

        private void btn_CarregarFt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Selecione a Foto do Aluno";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string origemCompleto = openFileDialog.FileName;

                try
                {
                    // Lê o arquivo de imagem e converte para um array de bytes
                    using (FileStream fs = new FileStream(origemCompleto, FileMode.Open, FileAccess.Read))
                    {
                        imagemBytes = new byte[fs.Length];
                        fs.Read(imagemBytes, 0, (int)fs.Length);
                    }

                    // Exibe a imagem carregada no PictureBox
                    using (MemoryStream ms = new MemoryStream(imagemBytes))
                    {
                        PicBox_ftAluno.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao carregar a imagem: {ex.Message}");
                }
            }
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int idInt = int.TryParse(valorId, out int result) ? result : 0;

            try
            {
                byte[] cartaoBytes = GerarImagemCartao();

                // Obter os dados do formulário
                Alunos alunos = new Alunos()
                {
                    // ID do cartão
                    Id_Cartão = idInt,
                    T_NOME = txt_Nome.Text,
                    N_NUMERO = lbl_numero.Text,
                    N_TRIENIO = txt_trienio.Text,
                    T_CURSO = ComBox_Curso.Text,
                    I_FTALUNO = imagemBytes, // Atribui a nova imagem se foi carregada
                    I_CARTAO = cartaoBytes
                };

                // Verifique se uma nova imagem foi carregada
                if (imagemBytes == null || imagemBytes.Length == 0)
                {
                    // Se nenhuma nova imagem foi carregada, você pode buscar a imagem existente do banco de dados
                    DataTable dt = Banco.TodosCartões(); // Supondo que você tenha um método para obter todos os alunos
                    DataRow[] rows = dt.Select("N_IDCARTAO = '" + idInt + "'");
                    if (rows.Length > 0)
                    {
                        alunos.I_FTALUNO = rows[0].Field<byte[]>("I_FTALUNO"); // Mantém a imagem existente
                    }
                }

                // Atualizar o cartão no banco de dados
                Banco.AtualizarCartão(alunos);
               
                // Mostrar notificação de sucesso
                mostrarNotificaçao("SUCESSO", "Cartão editado com sucesso!");
            }
            catch (Exception ex)
            {
                mostrarNotificaçao("ERRO", "Erro ao salvar o cartão");
                MessageBox.Show($"Ocorreu um erro ao salvar o cartão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txt_trienio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_trienio.Text.Length == 4 && txt_trienio.Text[3] != '/')
            {
                txt_trienio.Text = txt_trienio.Text.Insert(4, "/");
                txt_trienio.SelectionStart = txt_trienio.Text.Length;
            }
        }

        private void PixBox_qrcode_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pnl_cartao.Visible = true;
                pnl_Qrcode.Visible = false;
                pnl_cartao.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alternar para o painel Cartão: " + ex.Message);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            openChildForm(new ListaCartões(mainForm));
        }
    }
}
