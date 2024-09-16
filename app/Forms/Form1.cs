using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using app.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        private Point originalLocation;
        private Size originalSize;
        private Color originalBackColor;
        private UserControl activeControl;
        private Login login;
        public Panel PanelPrincipal // Propriedade pública para acessar o panelPrincipal
        {
            get { return panelPrincipal; }
        }
        public string NomeUtilizador { get; set; }
         public Form1()
        {
            InitializeComponent();
            // Cria uma instância do formulário de login
            login = new Login(this);
           
            // Exibe o formulário de login
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Continua exibindo o formulário principal
            }
            else
            {
                // Fecha o aplicativo se o usuário não fez login
                this.Close();
            }
            hideSubMenu();

        }

        private void hideSubMenu()
        {
            panelCartoes.Visible = false;
            panelReservas.Visible = false;
            paneLManutençao.Visible = false;
            panel_equipamentos.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void SetNomeUtilizador(string nomeUtilizador)
        {
            NomeUtilizador = nomeUtilizador;
            lbl_NomeUtilizador.Text = nomeUtilizador;
        }
        public void SetImagemUtilizador(byte[] imagemBytes)
        {
            if (imagemBytes != null && imagemBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    // Convertendo bytes em imagem
                    Image imagem = Image.FromStream(ms);
                    // Definindo a imagem no PictureBox ou em outro controle adequado
                    pictureBox1.Image = imagem;
                }
            }
            
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void lbl_NomeUtilizador_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            originalLocation = panelPrincipal.Location;
            originalSize = panelPrincipal.Size;
            originalBackColor = panelPrincipal.BackColor;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_listaCartoes_Click(object sender, EventArgs e)
        {

            openChildForm(new ListaCartões());
            hideSubMenu();
        }

        private void btn_RegistarReservas_Click(object sender, EventArgs e)
        {

            openChildForm(new RegistarReservas());
            hideSubMenu();

        }

        private void btn_ListaReservas_Click(object sender, EventArgs e)
        {

            openChildForm(new ListaReservas(this));
            hideSubMenu();
        }

        private void btn_NovoUtilizador_Click(object sender, EventArgs e)
        {
            openChildForm(new NovoUtilizador());
            hideSubMenu();
        }

        private void btn_GerenciarUtilizadores_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarUtilizadores());
            hideSubMenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == 3)
            {
                showSubMenu(paneLManutençao);
            }
            else
            {
                MessageBox.Show("Acesso de Administrador");
            }
        }
        private void btn_Cartoes_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == 1 || Globais.nivel == 3)
            {
                showSubMenu(panelCartoes);
            }
            else
            {
                MessageBox.Show("Acesso da Secretaria");
            }
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == 2 || Globais.nivel == 3)
            {
                showSubMenu(panelReservas);
            }
            else
            {
                MessageBox.Show("Acesso da Repografia");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Fecha apenas o formulário principal
            this.Hide();

            // Exibe o formulário principal
           

            // Mostra o formulário de login novamente
            login.ShowDialog();
            panelPrincipal.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void openChildControl(UserControl childControl)
        {
            // Fecha o controle filho atual, se houver
            if (activeControl != null)
            {
                panelPrincipal.Controls.Remove(activeControl);
                activeControl.Dispose();
            }

            // Define o novo controle filho como ativo
            activeControl = childControl;

            // Define as propriedades do controle filho
            childControl.Dock = DockStyle.Fill;

            // Adiciona o controle filho ao painel
            panelPrincipal.Controls.Add(childControl);

            // Exibe o controle filho
            childControl.BringToFront();
            childControl.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            if (Globais.nivel == 1 || Globais.nivel == 3)
            {
                showSubMenu(panel_equipamentos);
            }
            else
            {
                MessageBox.Show("Acesso da Repografia");
            }
        }

        private void btn_computadores_Click(object sender, EventArgs e)
        {

        }
    }
}
