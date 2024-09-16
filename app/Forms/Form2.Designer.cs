namespace app.Forms
{
    partial class Form2
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_GeraQr = new System.Windows.Forms.Button();
            this.btn_CarregarFt = new System.Windows.Forms.Button();
            this.btn_Guardar = new Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ComBox_Curso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_trienio = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_previsualização = new System.Windows.Forms.Label();
            this.PixBx_Qrcode = new Krypton.Toolkit.KryptonPictureBox();
            this.PixBx_FotoAluno = new Krypton.Toolkit.KryptonPictureBox();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_Qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_FotoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txt_trienio);
            this.panel6.Controls.Add(this.ComBox_Curso);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txt_nome);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_numero);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btn_GeraQr);
            this.panel6.Controls.Add(this.btn_CarregarFt);
            this.panel6.Controls.Add(this.btn_Guardar);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(13, 13);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1087, 616);
            this.panel6.TabIndex = 91;
            // 
            // btn_GeraQr
            // 
            this.btn_GeraQr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GeraQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_GeraQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GeraQr.FlatAppearance.BorderSize = 0;
            this.btn_GeraQr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_GeraQr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_GeraQr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_GeraQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GeraQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GeraQr.ForeColor = System.Drawing.Color.White;
            this.btn_GeraQr.Location = new System.Drawing.Point(153, 430);
            this.btn_GeraQr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GeraQr.Name = "btn_GeraQr";
            this.btn_GeraQr.Size = new System.Drawing.Size(234, 51);
            this.btn_GeraQr.TabIndex = 91;
            this.btn_GeraQr.Text = "Criar Código QR";
            this.btn_GeraQr.UseVisualStyleBackColor = false;
            this.btn_GeraQr.Click += new System.EventHandler(this.btn_GeraQr_Click);
            // 
            // btn_CarregarFt
            // 
            this.btn_CarregarFt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CarregarFt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_CarregarFt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CarregarFt.FlatAppearance.BorderSize = 0;
            this.btn_CarregarFt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_CarregarFt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CarregarFt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CarregarFt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CarregarFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CarregarFt.ForeColor = System.Drawing.Color.White;
            this.btn_CarregarFt.Location = new System.Drawing.Point(153, 371);
            this.btn_CarregarFt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CarregarFt.Name = "btn_CarregarFt";
            this.btn_CarregarFt.Size = new System.Drawing.Size(234, 51);
            this.btn_CarregarFt.TabIndex = 90;
            this.btn_CarregarFt.Text = "Carregar Foto";
            this.btn_CarregarFt.UseVisualStyleBackColor = false;
            this.btn_CarregarFt.Click += new System.EventHandler(this.btn_CarregarFt_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Guardar.CornerRoundingRadius = 20F;
            this.btn_Guardar.Location = new System.Drawing.Point(153, 489);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(234, 51);
            this.btn_Guardar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_Guardar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_Guardar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Guardar.StateCommon.Border.Rounding = 20F;
            this.btn_Guardar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_Guardar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btn_Guardar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.TabIndex = 88;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Values.Text = "Criar";
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Criar Cartão";
            // 
            // ComBox_Curso
            // 
            this.ComBox_Curso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComBox_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Curso.FormattingEnabled = true;
            this.ComBox_Curso.Items.AddRange(new object[] {
            "Técnico de Logística",
            "Técnico de Gestão e Prog. de Sistemas Informáticos",
            "Técnico de Turismo",
            "Técnico de Comunicação, Marketing, Relações Públicas e Publicidade",
            "Técnico de Comércio",
            "Animador Sociocultural"});
            this.ComBox_Curso.Location = new System.Drawing.Point(153, 319);
            this.ComBox_Curso.Margin = new System.Windows.Forms.Padding(4);
            this.ComBox_Curso.Name = "ComBox_Curso";
            this.ComBox_Curso.Size = new System.Drawing.Size(304, 26);
            this.ComBox_Curso.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(150, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "Curso";
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(153, 169);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(304, 24);
            this.txt_nome.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(150, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Número:";
            // 
            // txt_numero
            // 
            this.txt_numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(153, 219);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(256, 24);
            this.txt_numero.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(150, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Triénio:";
            // 
            // txt_trienio
            // 
            this.txt_trienio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_trienio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trienio.Location = new System.Drawing.Point(153, 269);
            this.txt_trienio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trienio.Name = "txt_trienio";
            this.txt_trienio.Size = new System.Drawing.Size(256, 24);
            this.txt_trienio.TabIndex = 100;
            this.txt_trienio.TextChanged += new System.EventHandler(this.txt_trienio_TextChanged);
            this.txt_trienio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trienio_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbl_previsualização);
            this.panel1.Controls.Add(this.PixBx_Qrcode);
            this.panel1.Controls.Add(this.PixBx_FotoAluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(682, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 614);
            this.panel1.TabIndex = 102;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_previsualização
            // 
            this.lbl_previsualização.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_previsualização.AutoSize = true;
            this.lbl_previsualização.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previsualização.ForeColor = System.Drawing.Color.White;
            this.lbl_previsualização.Location = new System.Drawing.Point(31, 26);
            this.lbl_previsualização.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_previsualização.Name = "lbl_previsualização";
            this.lbl_previsualização.Size = new System.Drawing.Size(343, 52);
            this.lbl_previsualização.TabIndex = 61;
            this.lbl_previsualização.Text = "Prévisualização";
            // 
            // PixBx_Qrcode
            // 
            this.PixBx_Qrcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PixBx_Qrcode.Location = new System.Drawing.Point(103, 371);
            this.PixBx_Qrcode.Margin = new System.Windows.Forms.Padding(4);
            this.PixBx_Qrcode.Name = "PixBx_Qrcode";
            this.PixBx_Qrcode.Size = new System.Drawing.Size(200, 200);
            this.PixBx_Qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixBx_Qrcode.TabIndex = 1;
            this.PixBx_Qrcode.TabStop = false;
            // 
            // PixBx_FotoAluno
            // 
            this.PixBx_FotoAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PixBx_FotoAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PixBx_FotoAluno.Image = global::app.Properties.Resources.pessoa;
            this.PixBx_FotoAluno.Location = new System.Drawing.Point(103, 126);
            this.PixBx_FotoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.PixBx_FotoAluno.Name = "PixBx_FotoAluno";
            this.PixBx_FotoAluno.Size = new System.Drawing.Size(200, 200);
            this.PixBx_FotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PixBx_FotoAluno.TabIndex = 0;
            this.PixBx_FotoAluno.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1113, 642);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_Qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_FotoAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_GeraQr;
        private System.Windows.Forms.Button btn_CarregarFt;
        private Krypton.Toolkit.KryptonButton btn_Guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_trienio;
        private System.Windows.Forms.ComboBox ComBox_Curso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_previsualização;
        private Krypton.Toolkit.KryptonPictureBox PixBx_Qrcode;
        private Krypton.Toolkit.KryptonPictureBox PixBx_FotoAluno;
    }
}