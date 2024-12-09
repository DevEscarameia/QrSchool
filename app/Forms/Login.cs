using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class Login : Form
    {
        public DataTable dt = new DataTable();
        public Form1 form1;
        public Login(Form1 f)
        {
            InitializeComponent();

            form1 = f;

        }

        private void txt_palavraPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_utilizador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            string nomeUtilizador = txt_utilizador.Text;
            string palavraPass = txt_palavraPass.Text;

            if (nomeUtilizador == "" || palavraPass == "")
            {
                MessageBox.Show("Utilizador ou senha inválidos");
                txt_utilizador.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_utilizadores WHERE T_NOMEUTILIZADOR='" + nomeUtilizador + "' AND T_SENHAUTILIZADOR='" + palavraPass + "'";
            DataTable dt = Banco.consulta(sql);

            if (dt.Rows.Count == 1)
            {
                // Criando uma instância de Utilizador e preenchendo com os dados do usuário logado
                Utilizador utilizador = new Utilizador
                {
                    T_NOMEUTILIZADOR = dt.Rows[0]["T_NOMEUTILIZADOR"].ToString(),
                    N_NIVELUTILIZADOR = Convert.ToInt32(dt.Rows[0]["N_NIVELUTILIZADOR"])

                };

                Globais.nivel = Convert.ToInt32(dt.Rows[0]["N_NIVELUTILIZADOR"]);
                form1.SetNomeUtilizador(utilizador.T_NOMEUTILIZADOR);
                byte[] imagemBytes = (byte[])dt.Rows[0]["I_FTUTILIZADOR"];

                // Passando os bytes da imagem para o Form1
                form1.SetImagemUtilizador(imagemBytes);

                // Define o resultado do diálogo como DialogResult.OK
                this.DialogResult = DialogResult.OK;
                // Fecha o formulário de login
                this.Close();
            }
            else
            {
                MessageBox.Show("Utilizador ou senha inválidos");
                txt_utilizador.Focus();
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_palavraPass.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void txt_utilizador_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_palavraPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
