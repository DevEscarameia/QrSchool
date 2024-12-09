using app.Forms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace app
{
    public partial class EditarUtilizadores : Form
    {
        private static byte[] imagemBytes; // Declare como estático para acessar em outro lugar
        public static byte[] GetImagemBytes()
        {
            return imagemBytes;
        }

        public EditarUtilizadores()
        {
            InitializeComponent();

        }

        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }

        private void EditarUtilizadores_Load(object sender, EventArgs e)
        {
            Tbl_Utilizadores.DataSource = Banco.UtilizadoresIdNome();
            Tbl_Utilizadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Tbl_Utilizadores.CurrentRow.DefaultCellStyle.BackColor = Color.Orange;
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Tbl_Utilizadores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // Verifique se há pelo menos uma linha selecionada
            if (dgv.SelectedRows.Count > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = Banco.ObterTodosUtilizadores();

                DataRow[] rows = dt.Select("N_IDUTILIZADOR = '" + vid + "'");

                if (rows.Length > 0)
                {
                    txt_Id.Text = rows[0].Field<Int64>("N_IDUTILIZADOR").ToString();
                    txt_nomeUtilizador.Text = rows[0].Field<string>("T_NOMEUTILIZADOR").ToString();
                    txt_Senha.Text = rows[0].Field<string>("T_SENHAUTILIZADOR").ToString();
                    ComBox_nivel.Text = rows[0].Field<Int64>("N_NIVELUTILIZADOR").ToString();
                    byte[] imagemBytes = rows[0].Field<byte[]>("I_FTUTILIZADOR");
                    if (imagemBytes != null && imagemBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            PixBox_Ftutilizador.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Caso não haja imagem disponível, você pode definir uma imagem padrão ou exibir uma mensagem
                        PixBox_Ftutilizador.Image = null; // ou defina uma imagem padrão, se aplicável
                    }

                }
            }
        }

       

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Utilizador u = new Utilizador();
            DialogResult res = MessageBox.Show("Apagar Utilizador?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarUtilizador(txt_Id.Text);
                Tbl_Utilizadores.Rows.Remove(Tbl_Utilizadores.CurrentRow);
            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = Tbl_Utilizadores.SelectedRows[0].Index;
            Utilizador u = new Utilizador();
            u.N_IDUTILIZADOR = Convert.ToInt32(txt_Id.Text);
            u.T_NOMEUTILIZADOR = txt_nomeUtilizador.Text;
            u.T_SENHAUTILIZADOR = txt_Senha.Text;
            u.N_NIVELUTILIZADOR = Convert.ToInt32(ComBox_nivel.SelectedItem.ToString());
            u.I_FTUTILIZADOR = imagemBytes;
            try
            {
                Banco.AtualizarUtilizador(u);
                mostrarNotificaçao("SUCESSO", "Utilizador atualizado com sucesso!");

                Tbl_Utilizadores.DataSource = Banco.UtilizadoresIdNome();
                Tbl_Utilizadores.CurrentCell = Tbl_Utilizadores[0, linha];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar o utilizador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CarregarFt_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Selecione a Foto do Utilizador";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string origemCompleto = openFileDialog.FileName;

                try
                {
                    using (FileStream fs = new FileStream(origemCompleto, FileMode.Open, FileAccess.Read))
                    {
                        imagemBytes = new byte[fs.Length];
                        fs.Read(imagemBytes, 0, (int)fs.Length);
                    }

                    // Exibe a imagem no PictureBox
                    using (MemoryStream ms = new MemoryStream(imagemBytes))
                    {
                        PixBox_Ftutilizador.Image = Image.FromStream(ms);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao carregar a imagem: {ex.Message}");
                }
            }
        }
    }
}
