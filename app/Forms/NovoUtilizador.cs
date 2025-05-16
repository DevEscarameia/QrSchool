using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace app
{
    public partial class NovoUtilizador : Form
    {
        private static byte[] imagemBytes; // Declare como estático para acessar em outro lugar

        public static byte[] GetImagemBytes()
        {
            return imagemBytes;
        }
        private Form1 mainForm;

        public NovoUtilizador(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
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
       
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CarregarFt_Click_1(object sender, EventArgs e)
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
        private void btn_salvarUtilizador_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nomeUtilizador.Text) || string.IsNullOrWhiteSpace(txt_Senha.Text) || ComBox_nivel.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            Utilizador utilizador = new Utilizador
            {
                T_NOMEUTILIZADOR = txt_nomeUtilizador.Text,
                T_SENHAUTILIZADOR = txt_Senha.Text,
                N_NIVELUTILIZADOR = Convert.ToInt32(ComBox_nivel.SelectedItem.ToString()),
                I_FTUTILIZADOR = imagemBytes
            };

            Banco.NovoUtilizador(utilizador);
            AtualizarTabelaUtilizadores();
        }

        private void AtualizarTabelaUtilizadores()
        {
            // Defina a fonte de dados
            Tbl_Utilizadores.DataSource = Banco.TodosUtilizadores();
        }

        private void NovoUtilizador_Load(object sender, EventArgs e)
        {
            // Carrega os dados na DataGridView
            Tbl_Utilizadores.DataSource = Banco.TodosUtilizadores();

            // Limpa qualquer seleção inicial
            Tbl_Utilizadores.ClearSelection();

            // Manipulador de evento CellClick para desmarcar a célula clicada
            Tbl_Utilizadores.CellClick += (s, ev) =>
            {
                if (ev.RowIndex == -1) // Verifica se não é um cabeçalho de coluna
                    Tbl_Utilizadores.ClearSelection();
            };

            // Manipulador de evento SelectionChanged para desmarcar qualquer seleção
            Tbl_Utilizadores.SelectionChanged += (s, ev) =>
            {
                Tbl_Utilizadores.ClearSelection();
            };
        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_nomeUtilizador.Text = string.Empty;
            txt_Senha.Text = string.Empty;
            ComBox_nivel.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarUtilizadores(mainForm));

        }
    }
}
