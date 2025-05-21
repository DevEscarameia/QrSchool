using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class EditarTurmas : Form
    {
        private Form1 mainForm;
        public EditarTurmas(Form1 form1)
        {
            InitializeComponent();
           mainForm = form1;
        }
        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
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
        private void EditarTurmas_Load(object sender, EventArgs e)
        {
            Tbl_Turmas.DataSource = Banco.ObterTurmas();
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
        private void Tbl_Turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // Verifique se há pelo menos uma linha selecionada
            if (dgv.SelectedRows.Count > 0)
            {
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = Banco.ObterTodasTurmas();

                DataRow[] rows = dt.Select("N_IDTURMA = '" + vid + "'");

                if (rows.Length > 0)
                {
                    txt_Id.Text = rows[0].Field<Int64>("N_IDTURMA").ToString();
                    txt_turma.Text = rows[0].Field<string>("T_TURMA").ToString();
                    ComBox_Curso.Text = rows[0].Field<string>("T_CURSO").ToString();
                    ComBox_Professor.Text = rows[0].Field<string>("T_DIRETORTURMA").ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NovaTurma(mainForm));
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show("Apagar Turma?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarTurma(txt_Id.Text);
                Tbl_Turmas.Rows.Remove(Tbl_Turmas.CurrentRow);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = Tbl_Turmas.SelectedRows[0].Index;
            Turma t = new Turma();
            t.N_IDTURMA = Convert.ToInt32(txt_Id.Text);
            t.T_TURMA = txt_turma.Text;
            t.T_DIRETORTURMA = ComBox_Professor.SelectedItem.ToString();
            t.T_CURSO = ComBox_Curso.Text;
        

            try
            {
                Banco.AtualizarTurma(t);
                mostrarNotificaçao("SUCESSO", "Turma atualizada com sucesso!");

                // Atualiza a grid e seleciona a linha modificada
                Tbl_Turmas.DataSource = Banco.ObterTurmas();
                Tbl_Turmas.CurrentCell = Tbl_Turmas[0, linha];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar a turma: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
