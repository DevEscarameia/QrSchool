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
    public partial class EditarProfessores : Form
    {
        private Form1 mainForm;
        public EditarProfessores(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void EditarProfessores_Load(object sender, EventArgs e)
        {
            Tbl_Professores.DataSource = Banco.ObterTodosProfessores();
        }
        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }
        private void Tbl_Professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // Verifique se há pelo menos uma linha selecionada
            if (dgv.SelectedRows.Count > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = Banco.ObterTodosProfessores();

                DataRow[] rows = dt.Select("ID = '" + vid + "'");

                if (rows.Length > 0)
                {
                    txt_Id.Text = rows[0].Field<Int64>("ID").ToString();
                    txt_professor.Text = rows[0].Field<string>("Professor").ToString();
                   
                }
            }
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
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Apagar Professor?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarProfessor(txt_Id.Text);
                Tbl_Professores.Rows.Remove(Tbl_Professores.CurrentRow);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = Tbl_Professores.SelectedRows[0].Index;
            Professor p = new Professor();
            p.N_IDPROFESSOR = Convert.ToInt32(txt_Id.Text);
            p.T_NOMEPROFESSOR =txt_professor.Text;
           

            try
            {
                Banco.AtualizarProfessor(p);
                mostrarNotificaçao("SUCESSO", "Professor atualizado com sucesso!");

                // Atualiza a grid e seleciona a linha modificada
                Tbl_Professores.DataSource = Banco.ObterTodosProfessores();
                Tbl_Professores.CurrentCell = Tbl_Professores[0, linha];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar o professor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NovoProfessor(mainForm));
        }
    }
}
