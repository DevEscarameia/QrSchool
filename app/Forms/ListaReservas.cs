using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class ListaReservas : Form
    {
        private DataTable originalData;
        private DataTable currentData;  // Armazena os dados atuais exibidos no DataGridView
        private Form1 mainForm;
        public ListaReservas(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            PopularComboBoxTurma();
            PopularComboBoxProfessores();
            PopularComboBoxDataRequisição();
        }

        private void ListaReservas_Load(object sender, EventArgs e)
        {
            Tbl_ListaReservas.DataSource = Banco.TodasRequisições();
            originalData = Banco.TodasRequisições(); // Armazena os dados originais
            currentData = originalData.Copy();       // Cria uma cópia dos dados originais
            Tbl_ListaReservas.DataSource = currentData;
        }


        private void PopularComboBoxDataRequisição()
        {
            try
            {
                DataTable dtData = Banco.ObterDataRequisição();
                ComBox_Data.Items.Clear();

                if (dtData != null && dtData.Rows.Count > 0)
                {
                    foreach (DataRow row in dtData.Rows)
                    {
                        // Obtenha a data do banco de dados
                        DateTime data = Convert.ToDateTime(row["T_DATAREQUISIÇÃO"]);

                        // Formate a data para exibir apenas a parte da data (sem a parte da hora)
                        string dataFormatada = data.ToString("yyyy-MM-dd");

                        // Adicione a data formatada à ComboBox
                        ComBox_Data.Items.Add(dataFormatada);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as Datas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopularComboBoxProfessores()
        {
            try
            {
                DataTable dtProfessor = Banco.ObterProfessores();
                ComBox_Professor.Items.Clear();

                if (dtProfessor != null && dtProfessor.Rows.Count > 0)
                {
                    foreach (DataRow row in dtProfessor.Rows)
                    {
                        // Obtenha a data do banco de dados
                        ComBox_Professor.Items.Add(row["T_NOMEPROFESSOR"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter os Professores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopularComboBoxTurma()
        {
            try
            {
                // Chama o método para obter as Turmas
                DataTable dtTurmas = Banco.ObterTurmas();

                // Limpa a ComboBox antes de adicionar novos itens
                ComBox_Turmas.Items.Clear();

                // Verifica se há turmas retornadas
                if (dtTurmas != null && dtTurmas.Rows.Count > 0)
                {
                    // Adiciona cada nome de turma à ComboBox
                    foreach (DataRow row in dtTurmas.Rows)
                    {
                        ComBox_Turmas.Items.Add(row["T_TURMA"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as Turmas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComBox_Turmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turmaSelecionada = ComBox_Turmas.SelectedItem.ToString();
            DataTable dtReservas = Banco.ObterReservasPorTurma(turmaSelecionada);
            AtualizarDataGridView(dtReservas);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentData = originalData.Copy();  // Restaura os dados atuais para os dados originais
            Tbl_ListaReservas.DataSource = currentData;
            ComBox_Data.Text = "Data";
            ComBox_Turmas.Text = "Turma";
            ComBox_Professor.Text = "Professor";
            ComBox_Horario.Text = "Horário";
        }

        private void ComBox_Data_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dataSelecionada = ComBox_Data.SelectedItem.ToString();
            DataTable dtReservas = Banco.ObterReservasPorData(dataSelecionada);
            AtualizarDataGridView(dtReservas);
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            string idReserva = Tbl_ListaReservas.SelectedRows[0].Cells["N_IDREQUISIÇÃO"].Value.ToString();
            DialogResult res = MessageBox.Show("Apagar reserva?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarRequisição(idReserva);
                Tbl_ListaReservas.Rows.RemoveAt(Tbl_ListaReservas.SelectedRows[0].Index);
            }
        }

        private void ComBox_Horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string horaSelecionada = ComBox_Horario.SelectedItem.ToString();
            DataTable dtReservas = Banco.ObterReservasPorHora(horaSelecionada);
            AtualizarDataGridView(dtReservas);
        }

        private void ComBox_Professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string professorSelecionado = ComBox_Professor.SelectedItem.ToString();
            DataTable dtReservas = Banco.ObterReservasPorProfessor(professorSelecionado);
            AtualizarDataGridView(dtReservas);
        }
        private void AtualizarDataGridView(DataTable dt)
        {
            // Atualiza a exibição dos dados
            Tbl_ListaReservas.DataSource = dt;
        }

        private void Tbl_ListaReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se o índice da linha é válido
            {
                // Obtem o DataRow da linha selecionada
                DataRow selectedRow = ((DataRowView)Tbl_ListaReservas.Rows[e.RowIndex].DataBoundItem).Row;

                // Passa os dados para o formulário de levantamento
                var form = new Levantamento(mainForm,selectedRow);
                openChildForm(form);
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
    }
}

