using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace app
{
    public partial class RegistarReservas : Form
    {
        public RegistarReservas()
        {
            InitializeComponent();
            PopularComboBoxProfessores();
          
        }
        private void txt_NPortateis_Leave(object sender, EventArgs e)
        {
            if (txt_NPortateis.Text == "")
            {
                txt_NPortateis.Text = "Nº Portateis";
                txt_NPortateis.ForeColor = Color.Black;
            }
        }
        private void txt_NPortateis_Enter(object sender, EventArgs e)
        {
            if (txt_NPortateis.Text == "Nº Portateis")
            {
                txt_NPortateis.Text = "";
                txt_NPortateis.ForeColor = Color.Black;
            }
        }
        private void PopularComboBoxProfessores()
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
        private void btn_requisitar_Click_1(object sender, EventArgs e)
        {
               

                // Criar uma instância da classe Requisições
                Requisições requisições = new Requisições();

            // Definir os atributos da requisição
            // Definir os atributos da requisição
            requisições.N_NºPORTATEIS = Convert.ToInt32(txt_NPortateis.Text);
            requisições.T_TURMA = txt_turma.Text;
            requisições.T_PROFESSORRESPONSAVEL = ComBox_Professor.SelectedItem.ToString();
            requisições.T_HORARIO = ComBox_Horario.SelectedItem.ToString();
            requisições.T_DATAREQUISIÇÃO = Tp_Data.Value.Date; // Apenas a data, sem a hora


            txt_NPortateis.Text = "Nº Portateis";
                txt_turma.Text = "Turma";
                ComBox_Professor.Text = "Professor";
                ComBox_Horario.Text = "Horario";

                // Chamar a função NovaRequisição para inserir no banco de dados
                Banco.NovaRequisição(requisições);
            
            
        }

        private void txt_turma_Leave(object sender, EventArgs e)
        {
            if (txt_turma.Text == "")
            {
                txt_turma.Text = "Turma";
                txt_turma.ForeColor = Color.Black;
            }
        } 
        private void txt_turma_Enter(object sender, EventArgs e)
        {
            if (txt_turma.Text == "Turma")
            {
                txt_turma.Text = "";
                txt_turma.ForeColor = Color.Black;
            }
        }
        private void txt_turma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
        private void txt_NPortateis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
