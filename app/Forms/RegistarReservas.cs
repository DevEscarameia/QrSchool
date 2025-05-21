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
            PopularComboBoxTurmas();
            PopularComboBoxHoraFim();
            lbl_ano.Text = DateTime.Today.Year.ToString();
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            clickTimer = new Timer();
            clickTimer.Interval += SystemInformation.DoubleClickTime;
            clickTimer.Tick += (s, e) =>
            {
                clickTimer.Stop();
                clickCount = 0;
            };
        }
        private void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
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
        public void PopularComboBoxTurmas()
        {
            try
            {
                DataTable dtTurmas = Banco.ObterNomeTurmas();
                txt_turma.Items.Clear();

                if (dtTurmas != null && dtTurmas.Rows.Count > 0)
                {
                    foreach (DataRow row in dtTurmas.Rows)
                    {
                        txt_turma.Items.Add(row["T_TURMA"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter as Turmas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Valida os dados inseridos pelo utilizador
                if (!ValidarEntrada()) return;


                // Obtém a data selecionada para a reserva
                DateTime dataReserva = Tp_Data.Value.Date;
                // Obtém as horas de início e fim selecionadas
                string horaInicio = ComBox_HInicio.SelectedItem.ToString();
                string horaFim = ComBox_HFim.SelectedItem.ToString();

                int indiceInicio = ComBox_HInicio.SelectedIndex;
                int indiceFim = ComBox_HFim.SelectedIndex;

                // Verifica se o fim é o imediatamente seguinte ao início
                if (indiceFim != indiceInicio )
                {
                    MessageBox.Show("A hora de fim deve ser imediatamente a seguir à hora de início.", "Horário inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Chama a função que retorna o total de portáteis já reservados para o horário escolhido
                DataTable dtReservas = Banco.ObterReservasPorHorario(dataReserva, horaInicio, horaFim);
                // Obtém o número total de portáteis disponíveis na escola
                DataTable dtPortateis = Banco.ObterNumeroPortateis();

                // Verifica quantos portáteis já estão reservados para o horário selecionado
                int totalReservados = dtReservas.Rows.Count > 0 && dtReservas.Rows[0]["TotalPortateis"] != DBNull.Value
                                      ? Convert.ToInt32(dtReservas.Rows[0]["TotalPortateis"])
                                      : 0;

                // Obtém o número total de portáteis disponíveis
                int portateisDisponiveis = dtPortateis.Rows.Count > 0 && dtPortateis.Rows[0]["NºDisponiveis"] != DBNull.Value
                                      ? Convert.ToInt32(dtPortateis.Rows[0]["NºDisponiveis"])
                                      : 0;

                // Obtém o número de portáteis que o utilizador deseja reservar
                int numeroPortateis = Convert.ToInt32(txt_NPortateis.Text);
                int portateisdisponiveis = portateisDisponiveis - totalReservados;
                // Verifica se o número total de portáteis reservados (os já existentes + os novos) não ultrapassa o limite disponível
                if (totalReservados + numeroPortateis > portateisDisponiveis)
                {
                    MessageBox.Show("Não é possível realizar a reserva. O número total de portáteis reservados excede " + portateisDisponiveis + " e tem "+ portateisdisponiveis + " disponiveis para reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Criação do objeto de requisição com os dados inseridos pelo utilizador
                Requisições requisicoes = new Requisições
                {
                    N_NºPORTATEIS = numeroPortateis,
                    T_TURMA = txt_turma.Text,
                    T_PROFESSORRESPONSAVEL = ComBox_Professor.SelectedItem.ToString(),
                    T_HORAINICIO = horaInicio,
                    T_HORAFIM = horaFim,
                    T_DATAREQUISIÇÃO = dataReserva,
                    T_DESCRIÇAO = txt_descriçao.Text
                };

                // Regista a requisição principal na base de dados
                Banco.NovaRequisição(requisicoes);

                int indiceHoraFim = ComBox_HFim.Items.IndexOf(horaFim);

                // Verifica quantos blocos (horas) devem ser adicionados
                int blocos = 0;
                if (checkBox_2h.Checked) blocos = 1;
                else if (checkBox_3h.Checked) blocos = 2;
                else if (checkBox_4h.Checked) blocos = 3;

                // Garante que há blocos suficientes disponíveis
                if (indiceHoraFim != -1 && (indiceHoraFim + blocos) < ComBox_HInicio.Items.Count)
                {
                    for (int i = 1; i <= blocos; i++)
                    {
                        string proximaHoraInicio = ComBox_HInicio.Items[indiceHoraFim + i].ToString();
                        string proximaHoraFim = ComBox_HFim.Items[indiceHoraFim + i].ToString();

                        Requisições novaRequisicao = new Requisições
                        {
                            N_NºPORTATEIS = numeroPortateis,
                            T_TURMA = txt_turma.Text,
                            T_PROFESSORRESPONSAVEL = ComBox_Professor.SelectedItem.ToString(),
                            T_HORAINICIO = proximaHoraInicio,
                            T_HORAFIM = proximaHoraFim,
                            T_DATAREQUISIÇÃO = dataReserva,
                            T_DESCRIÇAO = txt_descriçao.Text
                        };

                        Banco.NovaRequisição(novaRequisicao);
                    }

                }


              

                // Limpa os campos do formulário após a reserva ser concluída
                LimparCampos();
                // Exibe uma notificação de sucesso ao utilizador
                mostrarNotificaçao("SUCESSO", "Requisição efetuada com sucesso!");
            }
            catch (Exception ex)
            {
                // Caso ocorra um erro, exibe uma mensagem ao utilizador
                MessageBox.Show("Ocorreu um erro ao efetuar a requisição: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimparCampos()
        {
            txt_NPortateis.Text = "";
            txt_turma.SelectedIndex = -1;
            ComBox_Professor.SelectedIndex = -1;
            ComBox_HInicio.SelectedIndex = -1;
            ComBox_HFim.SelectedIndex = -1;
            checkBox_2h.Checked = false;
            checkBox_3h.Checked = false;
            checkBox_4h.Checked = false;
            txt_descriçao.Text = "";
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

                    // Remover o evento de clique anterior, se houver
                    botao.Click -= botao_Click; // Remove o evento anterior
                    botao.Click += botao_Click; // Adiciona o evento novamente
                }
                else
                {
                    botao.Visible = false;
                }
            }
        }

        private void botao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            diaSelecionado = int.Parse(botao.Text);
            DateTime novaData = new DateTime(anoSelecionado, mesSelecionado, diaSelecionado);
            Tp_Data.Value = novaData;

            // Destacar o dia selecionado
            DestacarDia(botao);

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
                SelecionarHorarios selecionarHorarios = new SelecionarHorarios(novaData);
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
            // Seleciona o mês e o dia atual ao carregar o formulário
            mesSelecionado = DateTime.Today.Month;
            anoSelecionado = DateTime.Today.Year;
            lbl_ano.Text = anoSelecionado.ToString();
            lbl_mes.Text = ObterNomeMes(mesSelecionado);
            diaSelecionado = DateTime.Today.Day;
            Tp_Data.Value = DateTime.Today; // Define a data do DateTimePicker para hoje
            atualizarBotaoCalendario(); // Atualiza o calendário para o mês e ano corretos
            DestacarDia((Button)tableLayoutPanel1.GetControlFromPosition(diaSelecionado % 7, diaSelecionado / 7)); // Destaca o dia atual
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void ComBox_HInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }

}
