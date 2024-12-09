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
    public partial class Historico2 : Form
    {
        private Form1 mainForm;
        private DataRow selectedRow;

        public Historico2(DataRow selectedRow, Form1 form1)
        {
            InitializeComponent();
            this.mainForm = form1;
            this.selectedRow = selectedRow;

            // Preenche os campos com os dados da linha selecionada
            txt_professor.Text = selectedRow["Professor"].ToString();
            txt_horaInicio.Text = selectedRow["Inicio"].ToString();
            txt_horaFim.Text = selectedRow["Fim"].ToString();
            txt_turma.Text = selectedRow["Turma"].ToString();
            txt_quantidade.Text = selectedRow["Portateis"].ToString();
            txt_data.Text = DateTime.Parse(selectedRow["Data"].ToString()).ToString("dd/MM/yyyy");
            txt_IdRequisiçao.Text = selectedRow["ID"].ToString();

        }

        private void tbl_historico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Historico2_Load(object sender, EventArgs e)
        {
            int idRequisicao;
            int.TryParse(txt_IdRequisiçao.Text, out idRequisicao);

            Levantamentos levantamento = new Levantamentos
            {
                N_IDREQUISIÇÃO = idRequisicao
            };

            tbl_historico.DataSource = Banco.TodasRequisiçõesFeitas(levantamento);
            tbl_historico.CellFormatting += tbl_historico_CellFormatting;

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
            openChildForm(new Historico(mainForm));
        }

        private void tbl_historico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (tbl_historico.Columns[e.ColumnIndex].Name == "Hora de Levantamento")
            {
                if (e.Value != null)
                {
                    // Formatar a hora para exibição
                    e.Value = DateTime.Parse(e.Value.ToString()).ToString("HH:mm");
                }
            }
        }
    }

}
