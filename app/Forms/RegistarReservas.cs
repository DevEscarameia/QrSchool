using app.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace app
{
    public partial class RegistarReservas : Form
    {
        private int anoSelecionado = DateTime.Today.Year;
        private int mesSelecionado = DateTime.Today.Month;
        private int diaSelecionado = DateTime.Today.Day;
        private int clickCount = 0;
     
        public RegistarReservas()
        {
            InitializeComponent();
            PopularComboBoxProfessores();
            PopularComboBoxHoraInicio();
            PopularCalendario();
            PopularComboBoxHoraFim();
            lbl_ano.Text = DateTime.Today.Year.ToString();
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            clickTimer = new Timer();
            clickTimer.Interval = SystemInformation.DoubleClickTime;
            clickTimer.Tick += (s, e) =>
            {
                clickTimer.Stop();
                clickCount = 0;
            };
        }

        private string ObterNomeMes(int mes)
        {
            return new DateTime(anoSelecionado, mes, 1).ToString("MMMM");
        }

        private void txt_NPortateis_Leave(object sender, EventArgs e)
        {
            if (txt_NPortateis.Text == "")
            {
                txt_NPortateis.Text = "Nº Portáteis";
                txt_NPortateis.ForeColor = Color.Black;
            }
        }

        private void txt_NPortateis_Enter(object sender, EventArgs e)
        {
            if (txt_NPortateis.Text == "Nº Portáteis")
            {
                txt_NPortateis.Text = "";
                txt_NPortateis.ForeColor = Color.Black;
            }
        }

        public void PopularComboBoxProfessores()
        {
            try
            {
                DataTable dtProfessores = Banco.ObterProfessores();
                ComBox_Professor.Items.Clear();

                if (dtProfessores != null && dtProfessores.Rows.Count > 0)
                {
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

        private bool ValidarEntrada()
        {
            int numeroPortateis;
            if (string.IsNullOrEmpty(txt_turma.Text) || ComBox_Professor.SelectedItem == null || ComBox_HInicio.SelectedItem == null || ComBox_HFim.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de continuar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txt_NPortateis.Text, out numeroPortateis) || numeroPortateis <= 0)
            {
                MessageBox.Show("Por favor, insira um número válido de portáteis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }

        private void ValidarPortateis()
        {

        }

        private void btn_requisitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarEntrada()) return;

                DateTime dataReserva = Tp_Data.Value.Date;
                string horaInicio = ComBox_HInicio.SelectedItem.ToString();
                string horaFim = ComBox_HFim.SelectedItem.ToString();

                // Chama a função para obter o total de portáteis reservados
                DataTable dtReservas = Banco.ObterReservasPorHorario(dataReserva, horaInicio, horaFim);
                DataTable dtPortateis = Banco.ObterNumeroPortateis();
                // Obtém o total de portáteis reservados
                int totalReservados = dtReservas.Rows.Count > 0 && dtReservas.Rows[0]["TotalPortateis"] != DBNull.Value
                                      ? Convert.ToInt32(dtReservas.Rows[0]["TotalPortateis"])
                                      : 0;

                int portateisDisponiveis = dtPortateis.Rows.Count > 0 && dtPortateis.Rows[0]["NºDisponiveis"] != DBNull.Value
                                      ? Convert.ToInt32(dtPortateis.Rows[0]["NºDisponiveis"])
                                      : 0;

                int numeroPortateis = Convert.ToInt32(txt_NPortateis.Text);

                // Verifica se o total de portáteis reservados + novos portáteis não excede 40
                if (totalReservados + numeroPortateis > portateisDisponiveis)
                {
                    MessageBox.Show("Não é possível realizar a reserva. O número total de portáteis reservados excede " + portateisDisponiveis + ".", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Criação do objeto de requisição
                Requisições requisicoes = new Requisições
                {
                    N_NºPORTATEIS = numeroPortateis,
                    T_TURMA = txt_turma.Text,
                    T_PROFESSORRESPONSAVEL = ComBox_Professor.SelectedItem.ToString(),
                    T_HORAINICIO = horaInicio,
                    T_HORAFIM = horaFim,
                    T_DATAREQUISIÇÃO = dataReserva
                };

                if (checkBox1.Checked)
                {
                    int indiceHoraFim = ComBox_HFim.Items.IndexOf(horaFim);

                    if (indiceHoraFim != -1 && indiceHoraFim < ComBox_HInicio.Items.Count - 2)
                    {
                        // Define o próximo horário corretamente
                        string proximaHoraInicio = ComBox_HInicio.Items[indiceHoraFim + 1].ToString();
                        string proximaHoraFim = ComBox_HFim.Items[indiceHoraFim + 1].ToString();

                        // Criação do objeto de nova requisição
                        Requisições novaRequisicao = new Requisições
                        {
                            N_NºPORTATEIS = numeroPortateis,
                            T_TURMA = txt_turma.Text,
                            T_PROFESSORRESPONSAVEL = ComBox_Professor.SelectedItem.ToString(),
                            T_HORAINICIO = proximaHoraInicio,
                            T_HORAFIM = proximaHoraFim,
                            T_DATAREQUISIÇÃO = dataReserva
                        };

                        // Registra a nova requisição
                        Banco.NovaRequisição(novaRequisicao);
                    }
                }
                // Registra a nova requisição
                Banco.NovaRequisição(requisicoes);

                LimparCampos();
                MessageBox.Show("Requisição efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar a requisição: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txt_NPortateis.Text = "";
            txt_turma.Text = "";
            ComBox_Professor.Text = "";
            ComBox_HInicio.Text = "";
            ComBox_HFim.Text = "";
        }

        private int diasNoMes;
        private int diaDaSemana;

        private void PopularCalendario()
        {
            diasNoMes = DateTime.DaysInMonth(anoSelecionado, mesSelecionado);
            DateTime data = new DateTime(anoSelecionado, mesSelecionado, 1);
            diaDaSemana = (int)data.DayOfWeek;
            if (diaDaSemana == 0) diaDaSemana = 7;

            int inicio = diaDaSemana - 1;

            for (int i = 0; i < 42; i++)
            {
                Button botao = (Button)tableLayoutPanel1.GetControlFromPosition(i % 7, i / 7);

                if (i >= inicio && i < inicio + diasNoMes)
                {
                    botao.Text = (i - inicio + 1).ToString();
                    botao.Visible = true;
                    botao.Click += botao_Click;
                    

                }
                else
                {
                    botao.Visible = false;
                }
            }
        }
       
        private void botao_Click(object sender, EventArgs e)
        {
            DateTime dataSelecionada = Tp_Data.Value;
            Button botao = (Button)sender;
            diaSelecionado = int.Parse(botao.Text);
            DateTime novaData = new DateTime(anoSelecionado, mesSelecionado, diaSelecionado);
            Tp_Data.Value = novaData;

            clickCount++;
            if (clickCount == 1)
            {
                clickTimer.Start();
            }
            else if (clickCount == 2)
            {
                clickTimer.Stop();
                clickCount = 0;
                // Ação para duplo clique
                SelecionarHorarios selecionarHorarios = new SelecionarHorarios(dataSelecionada);
                selecionarHorarios.Show();
            }
        }

        private void atualizarBotaoCalendario()
        {
            PopularCalendario();
        }

        private void Pic_Direita_Click(object sender, EventArgs e)
        {
            anoSelecionado++;
            lbl_ano.Text = anoSelecionado.ToString();
            atualizarBotaoCalendario();
        }

        private void Pic_Esquerda_Click(object sender, EventArgs e)
        {
            anoSelecionado--;
            lbl_ano.Text = anoSelecionado.ToString();
            atualizarBotaoCalendario();
        }

        private void destacarMes(string lblName)
        {
            for (int i = 1; i <= 12; i++)
            {
                Label lbl1 = this.Controls.Find("label" + i.ToString(), true).FirstOrDefault() as Label;
                lbl1.Font = new Font(lbl1.Font, FontStyle.Regular);
            }

            Label lbl = this.Controls.Find(lblName, true).FirstOrDefault() as Label;
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            mesSelecionado = 1;
            destacarMes("label1");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            mesSelecionado = 2;
            destacarMes("label2");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mesSelecionado = 3;
            destacarMes("label3");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            mesSelecionado = 4;
            destacarMes("label4");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            mesSelecionado = 5;
            destacarMes("label5");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            mesSelecionado = 6;
            destacarMes("label6");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            mesSelecionado = 7;
            destacarMes("label7");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            mesSelecionado = 8;
            destacarMes("label8");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            mesSelecionado = 9;
            destacarMes("label9");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            mesSelecionado = 10;
            destacarMes("label10");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            mesSelecionado = 11;
            destacarMes("label11");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            mesSelecionado = 12;
            destacarMes("label12");
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            atualizarBotaoCalendario();
        }
       
        private void RegistarReservas_Load(object sender, EventArgs e)
        {

        }
        private void DestacarDia(Button botao)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = DefaultBackColor;
                }
            }
            botao.BackColor = Color.LightBlue; // Destaque para o botão selecionado.
        }
    }

}
