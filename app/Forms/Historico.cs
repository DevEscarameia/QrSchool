using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class Historico : Form
    {
        private Form1 mainForm;

        public Historico(Form1 form1)
        {
            mainForm = form1;
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            tbl_historico.DataSource = Banco.ObterHistorico();
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
        private void tbl_historico_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se o índice da linha é válido
            {
                // Obtém o DataRow da linha selecionada
                DataRow selectedRow = ((DataRowView)tbl_historico.Rows[e.RowIndex].DataBoundItem).Row;

                // Passa os dados para o novo formulário
                var form = new Historico2(selectedRow, mainForm); // Ordem corrigida
                openChildForm(form);
            }
        }

        

        private void tbl_historico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tbl_historico.Columns[e.ColumnIndex].Name == "Data")
            {
                if (e.Value != null)
                {
                    // Formatar a hora para exibição
                    e.Value = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy");
                }
            }
        }

        private void txt_FiltroProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_FiltroProfessor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FiltroProfessor.Text))
            {
                DataTable reservas = Banco.ObterHistorico();
                tbl_historico.DataSource = reservas;
            }
            else
            {
                string filtroProfessor = txt_FiltroProfessor.Text.Trim();
                DataTable reservas = Banco.ObterReservasPorProfessor(filtroProfessor);
                tbl_historico.DataSource = reservas;
            }
        }

      

        private void apagarhistorico_Click(object sender, EventArgs e)
        {
            string data1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string data2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            if (!DateTime.TryParse(data1, out DateTime d1) || !DateTime.TryParse(data2, out DateTime d2))
            {
                MessageBox.Show("Por favor, insere datas válidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (d1 > d2)
            {
                MessageBox.Show("A data inicial não pode ser maior que a final!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult res = MessageBox.Show($"Apagar histórico de {d1:yyyy-MM-dd} a {d2:yyyy-MM-dd}?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarHistorico(d1.ToString("yyyy-MM-dd"), d2.AddDays(1).ToString("yyyy-MM-dd")); // inclui a data final
                tbl_historico.DataSource = Banco.ObterHistorico();
                
            }
        }


        

     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            string dataSelecionada = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            tbl_historico.DataSource = Banco.ObterReservasPorData(dataSelecionada);
        }


        private void btn_todas_Click(object sender, EventArgs e)
        {
            tbl_historico.DataSource = Banco.ObterHistorico();
        }
    }
}
