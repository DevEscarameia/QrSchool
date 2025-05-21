namespace app.Forms
{
    partial class CriarCartao
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
            this.btn_criar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_trienio = new System.Windows.Forms.TextBox();
            this.ComBox_Curso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GerarQr = new System.Windows.Forms.Button();
            this.btn_CarregarFt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_previsualização = new System.Windows.Forms.Label();
            this.PixBx_Qrcode = new Krypton.Toolkit.KryptonPictureBox();
            this.PixBx_FotoAluno = new Krypton.Toolkit.KryptonPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_Qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_FotoAluno)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_criar);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.txt_trienio);
            this.panel6.Controls.Add(this.ComBox_Curso);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txt_nome);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txt_numero);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btn_GerarQr);
            this.panel6.Controls.Add(this.btn_CarregarFt);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(774, 610);
            this.panel6.TabIndex = 91;
            // 
            // btn_criar
            // 
            this.btn_criar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_criar.FlatAppearance.BorderSize = 0;
            this.btn_criar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_criar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_criar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criar.ForeColor = System.Drawing.Color.Black;
            this.btn_criar.Location = new System.Drawing.Point(269, 494);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(232, 62);
            this.btn_criar.TabIndex = 102;
            this.btn_criar.Text = "Criar Cartão";
            this.btn_criar.UseVisualStyleBackColor = false;
            this.btn_criar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(239, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "Triénio:";
            // 
            // txt_trienio
            // 
            this.txt_trienio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_trienio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trienio.Location = new System.Drawing.Point(243, 226);
            this.txt_trienio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trienio.Name = "txt_trienio";
            this.txt_trienio.Size = new System.Drawing.Size(291, 24);
            this.txt_trienio.TabIndex = 99;
            this.txt_trienio.TextChanged += new System.EventHandler(this.txt_trienio_TextChanged);
            this.txt_trienio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trienio_KeyPress);
            // 
            // ComBox_Curso
            // 
            this.ComBox_Curso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBox_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Curso.FormattingEnabled = true;
            this.ComBox_Curso.Items.AddRange(new object[] {
            "Técnico de Logística",
            "Técnico de Gestão e Prog. de Sistemas Informáticos",
            "Técnico de Turismo",
            "Técnico de Gestão",
            "Técnico de Informática de Gestão",
            "Técnico de Comunicação, Marketing, Relações Públicas e Publicidade",
            "Técnico de Comércio",
            "Animador Sociocultural"});
            this.ComBox_Curso.Location = new System.Drawing.Point(243, 276);
            this.ComBox_Curso.Margin = new System.Windows.Forms.Padding(4);
            this.ComBox_Curso.Name = "ComBox_Curso";
            this.ComBox_Curso.Size = new System.Drawing.Size(291, 26);
            this.ComBox_Curso.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(239, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "Curso";
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(243, 126);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(291, 24);
            this.txt_nome.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(239, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 96;
            this.label3.Text = "Número:";
            // 
            // txt_numero
            // 
            this.txt_numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(243, 176);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(291, 24);
            this.txt_numero.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(239, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GerarQr
            // 
            this.btn_GerarQr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GerarQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_GerarQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GerarQr.FlatAppearance.BorderSize = 0;
            this.btn_GerarQr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_GerarQr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_GerarQr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_GerarQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GerarQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GerarQr.ForeColor = System.Drawing.Color.Black;
            this.btn_GerarQr.Location = new System.Drawing.Point(269, 415);
            this.btn_GerarQr.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GerarQr.Name = "btn_GerarQr";
            this.btn_GerarQr.Size = new System.Drawing.Size(232, 62);
            this.btn_GerarQr.TabIndex = 91;
            this.btn_GerarQr.Text = "Criar Código QR";
            this.btn_GerarQr.UseVisualStyleBackColor = false;
            this.btn_GerarQr.Click += new System.EventHandler(this.btn_GerarQr_Click);
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
            this.btn_CarregarFt.ForeColor = System.Drawing.Color.Black;
            this.btn_CarregarFt.Location = new System.Drawing.Point(269, 336);
            this.btn_CarregarFt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CarregarFt.Name = "btn_CarregarFt";
            this.btn_CarregarFt.Size = new System.Drawing.Size(232, 62);
            this.btn_CarregarFt.TabIndex = 90;
            this.btn_CarregarFt.Text = "Carregar Foto";
            this.btn_CarregarFt.UseVisualStyleBackColor = false;
            this.btn_CarregarFt.Click += new System.EventHandler(this.btn_CarregarFt_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_previsualização);
            this.panel1.Controls.Add(this.PixBx_Qrcode);
            this.panel1.Controls.Add(this.PixBx_FotoAluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(786, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 610);
            this.panel1.TabIndex = 102;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_previsualização
            // 
            this.lbl_previsualização.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_previsualização.AutoSize = true;
            this.lbl_previsualização.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previsualização.ForeColor = System.Drawing.Color.White;
            this.lbl_previsualização.Location = new System.Drawing.Point(29, 26);
            this.lbl_previsualização.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_previsualização.Name = "lbl_previsualização";
            this.lbl_previsualização.Size = new System.Drawing.Size(239, 36);
            this.lbl_previsualização.TabIndex = 61;
            this.lbl_previsualização.Text = "Prévisualização";
            // 
            // PixBx_Qrcode
            // 
            this.PixBx_Qrcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PixBx_Qrcode.Location = new System.Drawing.Point(73, 325);
            this.PixBx_Qrcode.Margin = new System.Windows.Forms.Padding(4);
            this.PixBx_Qrcode.Name = "PixBx_Qrcode";
            this.PixBx_Qrcode.Size = new System.Drawing.Size(160, 160);
            this.PixBx_Qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixBx_Qrcode.TabIndex = 1;
            this.PixBx_Qrcode.TabStop = false;
            // 
            // PixBx_FotoAluno
            // 
            this.PixBx_FotoAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PixBx_FotoAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PixBx_FotoAluno.Image = global::app.Properties.Resources.pessoa;
            this.PixBx_FotoAluno.Location = new System.Drawing.Point(80, 118);
            this.PixBx_FotoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.PixBx_FotoAluno.Name = "PixBx_FotoAluno";
            this.PixBx_FotoAluno.Size = new System.Drawing.Size(147, 159);
            this.PixBx_FotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PixBx_FotoAluno.TabIndex = 0;
            this.PixBx_FotoAluno.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 618);
            this.tableLayoutPanel1.TabIndex = 104;
            // 
            // CriarCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1113, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CriarCartao";
            this.Text = "Form2";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_Qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_FotoAluno)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_GerarQr;
        private System.Windows.Forms.Button btn_CarregarFt;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_criar;
    }
}