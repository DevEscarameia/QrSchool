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
            // Obtém o nome de utilizador e a palavra-passe inseridos nos campos de texto
            string nomeUtilizador = txt_utilizador.Text;
            string palavraPass = txt_palavraPass.Text;

            // Verifica se algum dos campos está vazio
            if (nomeUtilizador == "" || palavraPass == "")
            {
                // Exibe uma mensagem de erro e foca novamente no campo do utilizador
                MessageBox.Show("Utilizador ou senha inválidos");
                txt_utilizador.Focus();
                return; // Interrompe a execução do método
            }

            // Query SQL para verificar se o utilizador e a palavra-passe existem na base de dados
            string sql = "SELECT * FROM tb_utilizadores WHERE T_NOMEUTILIZADOR='" + nomeUtilizador + "' AND T_SENHAUTILIZADOR='" + palavraPass + "'";

            // Executa a consulta e armazena o resultado numa DataTable
            DataTable dt = Banco.consulta(sql);

            // Verifica se foi encontrado exatamente um registo correspondente
            if (dt.Rows.Count == 1)
            {
                // Cria uma instância da classe Utilizador e preenche os dados do utilizador autenticado
                Utilizador utilizador = new Utilizador
                {
                    T_NOMEUTILIZADOR = dt.Rows[0]["T_NOMEUTILIZADOR"].ToString(),
                    N_NIVELUTILIZADOR = Convert.ToInt32(dt.Rows[0]["N_NIVELUTILIZADOR"])
                };

                // Atualiza a variável global com o nível do utilizador autenticado
                Globais.nivel = Convert.ToInt32(dt.Rows[0]["N_NIVELUTILIZADOR"]);

                // Define o nome do utilizador no Form1
                form1.SetNomeUtilizador(utilizador.T_NOMEUTILIZADOR);

                // Obtém a imagem do utilizador a partir da base de dados e converte-a para um array de bytes
                byte[] imagemBytes = (byte[])dt.Rows[0]["I_FTUTILIZADOR"];

                // Passa a imagem do utilizador para o Form1
                form1.SetImagemUtilizador(imagemBytes);

                // Define o resultado do diálogo como DialogResult.OK, indicando que o login foi bem-sucedido
                this.DialogResult = DialogResult.OK;

                // Fecha o formulário de login
                this.Close();
            }
            else
            {
                // Exibe uma mensagem de erro se as credenciais estiverem incorretas
                MessageBox.Show("Utilizador ou senha inválidos");

                // Foca novamente no campo do nome de utilizador para nova tentativa
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
