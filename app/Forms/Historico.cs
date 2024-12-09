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

        private void txt_filtroData_TextChanged(object sender, EventArgs e)
        {
            // Se a TextBox estiver vazia, exibe todas as reservas
            if (string.IsNullOrWhiteSpace(txt_filtroData.Text))
            {
                // Chama o método para obter todas as reservas
                DataTable reservas = Banco.ObterHistorico();
                tbl_historico.DataSource = reservas;
                return; // Impede que o código abaixo seja executado quando estiver vazio
            }

            // Se o comprimento da TextBox for menor que 10, exibe todas as reservas
            if (txt_filtroData.Text.Length < 10)
            {
                DataTable reservas = Banco.ObterHistorico();
                tbl_historico.DataSource = reservas;
                return;
            }

            // Verifica se o texto tem o comprimento correto para a data (yyyy-MM-dd)
            if (txt_filtroData.Text.Length == 10)
            {
                if (DateTime.TryParseExact(txt_filtroData.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime dataReserva))
                {
                    // Chama o método para obter as reservas filtradas por data
                    DataTable reservas = Banco.ObterReservasPorData(dataReserva);

                    // Exibe os resultados na DataGridView
                    tbl_historico.DataSource = reservas;
                }
            }
        }

        private void tbl_historico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (tbl_historico.Columns[e.ColumnIndex].Name == "Data")
            {
                if (e.Value != null)
                {
                    // Formatar a hora para exibição
                    e.Value = DateTime.Parse(e.Value.ToString()).ToString("yyyy-MM-dd");
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

        private void txt_filtroData_Click(object sender, EventArgs e)
        {
            txt_filtroData.SelectionStart = 0;
        }
    }
}
