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
            string idReserva = Tbl_ListaReservas.SelectedRows[0].Cells["ID"].Value.ToString();
            DialogResult res = MessageBox.Show("Apagar reserva?", "Apagar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Banco.ApagarRequisição(idReserva);
                Tbl_ListaReservas.Rows.RemoveAt(Tbl_ListaReservas.SelectedRows[0].Index);
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
            if (string.IsNullOrWhiteSpace(txt_Id.Text) || string.IsNullOrWhiteSpace(txt_turma.Text) || string.IsNullOrWhiteSpace(txt_NPortateis.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int linha = Tbl_ListaReservas.SelectedRows[0].Index;
            Requisições r = new Requisições
            {
                N_IDREQUISIÇÃO = Convert.ToInt32(txt_Id.Text),
                T_PROFESSORRESPONSAVEL = ComBox_Professor.SelectedItem.ToString(),
                T_HORAINICIO = ComBox_HInicio.SelectedItem.ToString(),
                T_HORAFIM = ComBox_HFim.SelectedItem.ToString(),
                T_TURMA = txt_turma.Text,
                N_NºPORTATEIS = Convert.ToInt32(txt_NPortateis.Text),
                T_DATAREQUISIÇÃO = Tp_Data.Value
            };

            try
            {
                Banco.AtualizarRequisições(r);
                MessageBox.Show("Reserva atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txt_turma.Text = selectedRow["Turma"].ToString();
                    txt_NPortateis.Text = selectedRow["Portateis"].ToString();
                    Tp_Data.Value = Convert.ToDateTime(selectedRow["Data"]);

                }
            }
        }
    }
}
