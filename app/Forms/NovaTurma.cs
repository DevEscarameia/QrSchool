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
    public partial class NovaTurma : Form
    {
        private Form1 mainForm;
        public NovaTurma(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            PopularComboBoxProfessores();
        }
        public void PopularComboBoxProfessores()
        {
            try
            {
                DataTable dtProfessores = Banco.ObterProfessores();
                ComBox_Professor.Items.Clear();

                if (dtProfessores != null && dtProfessores.Rows.Count > 0)
                {
                    foreach (DataRow row in dtProfessores.Rows)
                    {
                        ComBox_Professor.Items.Add(row["T_NOMEPROFESSOR"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os professores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void NovaTurma_Load(object sender, EventArgs e)
        {
            Tbl_Turmas.DataSource = Banco.ObterTurmas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new EditarTurmas(mainForm));
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_turma.Text)  || ComBox_Professor.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            if (string.IsNullOrWhiteSpace(ComBox_Curso.Text))
            {
                MessageBox.Show("Por favor, indique um curso.");
                return;
            }


            Turma turma = new Turma()
            {
                T_TURMA = txt_turma.Text,
                T_CURSO = ComBox_Curso.Text,
                T_DIRETORTURMA = ComBox_Professor.SelectedItem.ToString(),
            };

            Banco.NovaTurma(turma);
            AtualizarTabelaTurmas();
            txt_turma.Text = string.Empty;
            ComBox_Curso.SelectedIndex = -1;
            ComBox_Professor.SelectedIndex = -1;
        }

        private void AtualizarTabelaTurmas()
        {
            // Defina a fonte de dados
            Tbl_Turmas.DataSource = Banco.ObterTurmas();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            txt_turma.Text = string.Empty;
            ComBox_Curso.SelectedIndex = -1;
            ComBox_Professor.SelectedIndex = -1;
        }

        private void txt_turma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
