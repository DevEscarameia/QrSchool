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
    public partial class NovoProfessor : Form
    {
        private Form1 mainForm;
        public NovoProfessor(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }
        private void NovoProfessor_Load(object sender, EventArgs e)
        {
            Tbl_Professores.DataSource = Banco.ObterTodosProfessores();
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
        private void btn_EditarProfessor_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarProfessores(mainForm));
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_professor.Text))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
           Professor professor = new Professor()
            {
                T_NOMEPROFESSOR = txt_professor.Text,
               
            };

            Banco.NovoProfessor(professor);
            Tbl_Professores.DataSource = Banco.ObterTodosProfessores();
            txt_professor.Text = string.Empty;
        }

       
    }
}
