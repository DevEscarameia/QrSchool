namespace app.Forms
{
    partial class Notificação
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.messageBord = new System.Windows.Forms.Panel();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.Timer_notificacao = new System.Windows.Forms.Timer(this.components);
            this.Timer_Esconder = new System.Windows.Forms.Timer(this.components);
            this.PicBox_Icon = new System.Windows.Forms.PictureBox();
            this.Timer_Pausa = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // messageBord
            // 
            this.messageBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(155)))), ((int)(((byte)(55)))));
            this.messageBord.Location = new System.Drawing.Point(-11, -4);
            this.messageBord.Name = "messageBord";
            this.messageBord.Size = new System.Drawing.Size(15, 88);
            this.messageBord.TabIndex = 0;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(44, 17);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(42, 20);
            this.lbl_tipo.TabIndex = 1;
            this.lbl_tipo.Text = "Type";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(45, 37);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(96, 17);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "Toast Message";
            // 
            // Timer_notificacao
            // 
            this.Timer_notificacao.Interval = 50;
            this.Timer_notificacao.Tick += new System.EventHandler(this.Timer_notificacao_Tick);
            // 
            // Timer_Esconder
            // 
            this.Timer_Esconder.Interval = 50;
            this.Timer_Esconder.Tick += new System.EventHandler(this.Timer_Esconder_Tick);
            // 
            // PicBox_Icon
            // 
            this.PicBox_Icon.Image = global::app.Properties.Resources.accept;
            this.PicBox_Icon.Location = new System.Drawing.Point(11, 21);
            this.PicBox_Icon.Name = "PicBox_Icon";
            this.PicBox_Icon.Size = new System.Drawing.Size(27, 25);
            this.PicBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_Icon.TabIndex = 0;
            this.PicBox_Icon.TabStop = false;
            // 
            // Timer_Pausa
            // 
            this.Timer_Pausa.Interval = 1000;
            this.Timer_Pausa.Tick += new System.EventHandler(this.Timer_Pausa_Tick);
            // 
            // Notificação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 74);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.PicBox_Icon);
            this.Controls.Add(this.messageBord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notificação";
            this.Text = "Notificação";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Notificação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel messageBord;
        private System.Windows.Forms.PictureBox PicBox_Icon;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Timer Timer_notificacao;
        private System.Windows.Forms.Timer Timer_Esconder;
        private System.Windows.Forms.Timer Timer_Pausa;
    }
}