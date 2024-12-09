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
    public partial class VisualizarReservas : Form
    {
        private string horarioInicio;
        private string horarioFim;
        private DateTime data;
        public VisualizarReservas(string horarioInicio, string horarioFim, DateTime data)
        {
            InitializeComponent();
            this.horarioInicio = horarioInicio;
            this.horarioFim = horarioFim;
            this.data = data;
            // Atualiza a tabela ao carregar o formulário
            AtualizarTabela();
            AtualizarNumeroPortateisReservados();
            
        }

        private void AtualizarTabela()
        {
            RegistarReservas registarReservas  = new RegistarReservas();
            
            DataTable reservas = Banco.ObterReservasPorHorario_Data(horarioInicio, horarioFim, data);
            // Preencher a tabela (supondo que você tenha um DataGridView)
            Tbl_ListaReservas.DataSource = reservas;
            if (reservas.Rows.Count == 0)
            {
            }

        }
        private void AtualizarNumeroPortateisReservados()
        {
            

            // Chama a função para obter o total de portáteis reservados
            DataTable dtReservas = Banco.ObterReservasPorHorario(data, horarioInicio, horarioFim);

            // Obtém o total de portáteis reservados
            int totalReservados = dtReservas.Rows.Count > 0 && dtReservas.Rows[0]["TotalPortateis"] != DBNull.Value
                                  ? Convert.ToInt32(dtReservas.Rows[0]["TotalPortateis"])
                                  : 0;

            // Atualiza a TextBox com o número de portáteis reservados
            txt_numeropcs.Text = totalReservados.ToString();
            

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void VisualizarReservas_Load(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }

}
