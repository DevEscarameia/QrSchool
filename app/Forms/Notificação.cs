using System;
using System.Drawing;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class Notificação : Form
    {
        private int notificacaoX;
        private int notificacaoY;
        private int tempoVisibilidade = 1000; // Duração da pausa

        public Notificação(string tipo, string message)
        {
            InitializeComponent();
            lbl_tipo.Text = tipo;
            lbl_message.Text = message;

            // Define a cor de fundo baseada no tipo
            switch (tipo)
            {
                case "SUCESSO":
                    messageBord.BackColor = Color.FromArgb(57, 155, 53);
                    PicBox_Icon.Image = Properties.Resources.accept;
                    break;
                case "ERRO":
                    messageBord.BackColor = Color.FromArgb(227, 50, 45);
                    PicBox_Icon.Image = Properties.Resources.multiply;
                    break;
                case "INFO":
                    messageBord.BackColor = Color.FromArgb(18, 136, 191);
                    PicBox_Icon.Image = Properties.Resources.info;
                    break;
                case "AVISO":
                    messageBord.BackColor = Color.FromArgb(245, 171, 35);
                    PicBox_Icon.Image = Properties.Resources.caution;
                    break;
            }

            Timer_notificacao.Interval = 1;
            Timer_Pausa.Interval = 10;
            Timer_Esconder.Interval = 1;

            Timer_notificacao.Tick += Timer_notificacao_Tick;
            Timer_Pausa.Tick += Timer_Pausa_Tick;
            Timer_Esconder.Tick += Timer_Esconder_Tick;
        }

        private void Notificação_Load(object sender, EventArgs e)
        {
            DefinirPosicaoInicial();
            AutoScaleMode = AutoScaleMode.Dpi;

        }

        private void DefinirPosicaoInicial()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            notificacaoX = screenWidth - this.Width - 1; // Margem direita
            notificacaoY = screenHeight; // Fora da tela, na parte inferior

            this.Location = new Point(notificacaoX, notificacaoY);
            Timer_notificacao.Start(); // Subir a notificação
        }

        private void Timer_notificacao_Tick(object sender, EventArgs e)
        {
            notificacaoY -= 2; // Subir
            this.Location = new Point(notificacaoX, notificacaoY);

            if (notificacaoY <= Screen.PrimaryScreen.WorkingArea.Height - this.Height - 30)
            {
                Timer_notificacao.Stop();
                Timer_Pausa.Start(); // Pausa antes de descer
            }
        }

        private void Timer_Pausa_Tick(object sender, EventArgs e)
        {
            tempoVisibilidade -= Timer_Pausa.Interval;
            if (tempoVisibilidade <= 10)
            {
                Timer_Pausa.Stop();
                Timer_Esconder.Start(); // Descer a notificação
            }
        }

        private void Timer_Esconder_Tick(object sender, EventArgs e)
        {
            notificacaoY += 2; // Descer
            this.Location = new Point(notificacaoX, notificacaoY);

            if (notificacaoY > Screen.PrimaryScreen.WorkingArea.Height)
            {
                Timer_Esconder.Stop();
                this.Close(); // Fechar a notificação
            }
        }
        private static void mostrarNotificaçao(string tipo, string message)
        {
            Notificação notificação = new Notificação(tipo, message);
            notificação.Show();
        }

    }
}
