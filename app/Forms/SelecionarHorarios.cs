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
    public partial class SelecionarHorarios : Form
    {
        
        public string HorarioSelecionado { get; private set; }
        private DateTime dataSelecionada;

        public SelecionarHorarios(DateTime data)
        {
            dataSelecionada = data;
            InitializeComponent();
            btn_horario1.Tag = "08:30-09:30";
            btn_horario2.Tag = "09:40-10:40";
            btn_horario3.Tag = "11:00-12:00";
            btn_horario4.Tag = "12:00-13:00";
            btn_horario5.Tag = "14:00-15:00";
            btn_horario6.Tag = "15:10-16:10";
            btn_horario7.Tag = "16:15-17:15";
            AtualizarCores();


        }
        private void BotaoHorario_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;
            if (botao != null && botao.Tag != null)
            {
                // Extrai o horário do botão
                string horario = botao.Tag.ToString();

                // Divide o horário para obter o início e o fim
                string[] horarios = horario.Split('-');
                if (horarios.Length == 2)
                {
                    string horarioInicio = horarios[0].Trim();
                    string horarioFim = horarios[1].Trim();
                    // Abre a janela para visualizar as reservas
                    VisualizarReservas visualizarReservas = new VisualizarReservas(horarioInicio, horarioFim, dataSelecionada);
                    visualizarReservas.Show();

                    // Define o resultado do diálogo e fecha o formulário
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void AtualizarCores()
        {
            List<Button> botoes = new List<Button>
    {
        btn_horario1,
        btn_horario2,
        btn_horario3,
        btn_horario4,
        btn_horario5,
        btn_horario6,
        btn_horario7
    };

            foreach (Button botao in botoes)
            {
                if (botao.Tag != null)
                {
                    string horario = botao.Tag.ToString();
                    string[] horarios = horario.Split('-');
                    if (horarios.Length == 2)
                    {
                        string horaInicio = horarios[0].Trim();
                        string horaFim = horarios[1].Trim();

                        // Obtém os dados de reservas e portáteis
                        DataTable dtReservas = Banco.ObterReservasPorHorario(dataSelecionada, horaInicio, horaFim);
                        DataTable dtPortateis = Banco.ObterNumeroPortateis();

                        // Calcula o número de portáteis reservados e disponíveis
                        int totalReservados = dtReservas.Rows.Count > 0 && dtReservas.Rows[0]["TotalPortateis"] != DBNull.Value
                                              ? Convert.ToInt32(dtReservas.Rows[0]["TotalPortateis"])
                                              : 0;

                        int totalDisponiveis = dtPortateis.Rows.Count > 0 && dtPortateis.Rows[0]["NºDisponiveis"] != DBNull.Value
                                              ? Convert.ToInt32(dtPortateis.Rows[0]["NºDisponiveis"])
                                              : 40; // Supondo que o limite é 40

                        // Atualiza a cor do botão com base no estado
                        if (totalReservados == 0)
                        {
                            botao.BackColor = Color.FromArgb(126, 244, 130); // Disponível
                        }
                        else if (totalReservados < totalDisponiveis)
                        {
                            botao.BackColor = Color.FromArgb(245, 245,91); // Parcialmente reservado
                        }
                        else
                        {
                            botao.BackColor = Color.FromArgb(254, 32, 32); // Totalmente reservado
                        }
                    }
                }
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelecionarHorarios_Load(object sender, EventArgs e)
        {

        }
    }
}
