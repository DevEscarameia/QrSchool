using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Levantamento : Form
    {
        private Form1 mainForm;
        public Levantamento(Form1 form1,DataRow selectedRow)
        {
            InitializeComponent();
            mainForm = form1;
            // Exemplo de como preencher os controles do formulário com os dados do DataRow
            txt_professor.Text = selectedRow["T_PROFESSORRESPONSAVEL"].ToString();
            txt_hora.Text = selectedRow["T_HORARIO"].ToString();
            txt_turma.Text = selectedRow["T_TURMA"].ToString();
            txt_quantidade.Text = selectedRow["N_NºPORTATEIS"].ToString();
            // Continue preenchendo os demais controles conforme necessário
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void Levantamento_Load(object sender, EventArgs e)
        {
            tbl_levantamentos.DataSource = Banco.TodasRequisiçõesFeitas();
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
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            openChildForm(new ListaReservas(mainForm));
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tbl_Utilizadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
