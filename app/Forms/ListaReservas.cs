using app.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class ListaReservas : Form
    {
        private DataTable originalData;
        private DataTable currentData;  
        private Form1 mainForm;
        public ListaReservas(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            PopularComboBoxProfessores();
            PopularComboBoxHoraFim();
            PopularComboBoxHoraInicio();
            PopularComboBoxTurmas();
        }
        public void PopularComboBoxTurmas()
        {
            try
            {
                DataTable dtTurmas = Banco.ObterNomeTurmas();
                Combox_Turma.Items.Clear();

                if (dtTurmas != null && dtTurmas.Rows.Count > 0)
                {
                    foreach (DataRow row in dtTurmas.Rows)
                    {
                        Combox_Turma.Items.Add(row["T_TURMA"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as Turmas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }
        public void PopularComboBoxProfessores()
        {
            try
            {
                // Chama o método para obter os professores
                DataTable dtProfessores = Banco.ObterProfessores();

                // Limpa a ComboBox antes de adicionar novos itens
                ComBox_Professor.Items.Clear();

                // Verifica se há professores retornados
                if (dtProfessores != null && dtProfessores.Rows.Count > 0)
                {
                    // Adiciona cada nome de professor à ComboBox
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
        private void ListaReservas_Load(object sender, EventArgs e)
        {
            originalData = Banco.TodasRequisições(); 
            currentData = originalData.Copy();       
            Tbl_ListaReservas.DataSource = currentData;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            if (Tbl_ListaReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleciona uma reserva para apagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idReserva = Tbl_ListaReservas.SelectedRows[0].Cells["ID"].Value.ToString();

            DialogResult res = MessageBox.Show("Apagar reserva?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Banco.ApagarRequisição(idReserva);
                    Tbl_ListaReservas.Rows.RemoveAt(Tbl_ListaReservas.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao apagar reserva: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void PopularComboBoxHoraInicio()
        {
            try
            {
                DataTable dtHoraInicio = Banco.ObterHorarioInicio();
                ComBox_HInicio.Items.Clear();

                if (dtHoraInicio != null && dtHoraInicio.Rows.Count > 0)
                {
                    foreach (DataRow row in dtHoraInicio.Rows)
                    {
                        // Converte o valor para exibir apenas a hora e os minutos
                        string horaFormatada = DateTime.Parse(row["T_HORAINICIO"].ToString()).ToString("HH:mm");
                        ComBox_HInicio.Items.Add(horaFormatada);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma hora de início encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as horas de início: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopularComboBoxHoraFim()
        {
            try
            {
                DataTable dtHoraFim = Banco.ObterHorarioFim();
                ComBox_HFim.Items.Clear();

                if (dtHoraFim != null && dtHoraFim.Rows.Count > 0)
                {
                    foreach (DataRow row in dtHoraFim.Rows)
                    {
                        string horaFormatada = DateTime.Parse(row["T_HORAFIM"].ToString()).ToString("HH:mm");
                        ComBox_HFim.Items.Add(horaFormatada);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma hora de fim encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as horas de fim: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                var form = new Levantamento(mainForm, selectedRow);
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(txt_Id.Text)  || string.IsNullOrWhiteSpace(txt_NPortateis.Text))
            {
                mostrarNotificaçao("AVISO", "Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            int indiceInicio = ComBox_HInicio.SelectedIndex;
            int indiceFim = ComBox_HFim.SelectedIndex;

            // Verifica se o fim é o imediatamente seguinte ao início
            if (indiceFim != indiceInicio)
            {
                MessageBox.Show("A hora de fim deve ser imediatamente a seguir à hora de início.", "Horário inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int linha = Tbl_ListaReservas.SelectedRows[0].Index;
            Requisições r = new Requisições
            {
                N_IDREQUISIÇÃO = Convert.ToInt32(txt_Id.Text),
                T_PROFESSORRESPONSAVEL = ComBox_Professor.SelectedItem.ToString(),
                T_HORAINICIO = ComBox_HInicio.SelectedItem.ToString(),
                T_HORAFIM = ComBox_HFim.SelectedItem.ToString(),
                T_TURMA = Combox_Turma.SelectedItem.ToString(),
                N_NºPORTATEIS = Convert.ToInt32(txt_NPortateis.Text),
                T_DATAREQUISIÇÃO = Tp_Data.Value
            };

            try
            {
                Banco.AtualizarRequisições(r);
                mostrarNotificaçao("SUCESSO", "Reserva atualizada com sucesso!");
                Tbl_ListaReservas.DataSource = Banco.TodasRequisições();
                Tbl_ListaReservas.CurrentCell = Tbl_ListaReservas[0, linha];
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Erro ao atualizar a reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tbl_ListaReservas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            
            if (dgv.SelectedRows.Count > 0)
            {
 
               
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

               
                DataTable dt = Banco.ObterReservas();

                // Procure na DataTable pelo utilizador com o ID correspondente
                DataRow[] rows = dt.Select("N_IDREQUISIÇÃO = '" + vid + "'");

                if (rows.Length > 0)
                {
                    var selectedRow = (DataRowView)Tbl_ListaReservas.SelectedRows[0].DataBoundItem;
                    txt_Id.Text = selectedRow["ID"].ToString();
                    ComBox_Professor.Text = selectedRow["Professor"].ToString();
                    ComBox_HInicio.Text = selectedRow["Inicio"].ToString();
                    ComBox_HFim.Text = selectedRow["Fim"].ToString();
                    Combox_Turma.Text = selectedRow["Turma"].ToString();
                    txt_NPortateis.Text = selectedRow["Portateis"].ToString();
                    Tp_Data.Value = Convert.ToDateTime(selectedRow["Data"]);

                }
            }
        }
        private void txt_FiltroProfessor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FiltroProfessor.Text))
            {
                DataTable reservas = Banco.TodasRequisições();
                Tbl_ListaReservas.DataSource = reservas;
            }
            else
            {
                string filtroProfessor = txt_FiltroProfessor.Text.Trim();
                DataTable reservas = Banco.ObterReservasPorProfessor2(filtroProfessor);
                Tbl_ListaReservas.DataSource = reservas;
            }
        }
        private void txt_filtroData_TextChanged(object sender, EventArgs e)
        {
            
        }
      

        private void Tbl_ListaReservas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Tbl_ListaReservas.Columns[e.ColumnIndex].Name == "Data")
            {
                if (e.Value != null)
                {
                    // Formatar a hora para exibição
                    e.Value = DateTime.Parse(e.Value.ToString()).ToString("yyyy/MM/dd");
                }
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            string dataSelecionada = dateTimePicker3.Value.ToString("yyyy-MM-dd");
            Tbl_ListaReservas.DataSource = Banco.ObterReservasPorData2(dataSelecionada);
        }

        private void btn_todas_Click(object sender, EventArgs e)
        {
            Tbl_ListaReservas.DataSource = Banco.TodasRequisições();
        }
    }
}
