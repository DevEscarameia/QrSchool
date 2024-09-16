namespace app
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
            this.txt_trienio = new Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_previsualização = new System.Windows.Forms.Label();
            this.txt_nome = new Krypton.Toolkit.KryptonTextBox();
            this.ComBox_Curso = new Krypton.Toolkit.KryptonComboBox();
            this.btn_GeraQr = new Krypton.Toolkit.KryptonButton();
            this.btn_Guardar = new Krypton.Toolkit.KryptonButton();
            this.btn_CarregarFt = new Krypton.Toolkit.KryptonButton();
            this.txt_numero = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.PixBx_Qrcode = new Krypton.Toolkit.KryptonPictureBox();
            this.PixBx_FotoAluno = new Krypton.Toolkit.KryptonPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Curso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_Qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_FotoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_trienio
            // 
            this.txt_trienio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_trienio.AutoCompleteCustomSource.AddRange(new string[] {
            "dsd"});
            this.txt_trienio.Location = new System.Drawing.Point(239, 473);
            this.txt_trienio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_trienio.Name = "txt_trienio";
            this.txt_trienio.Size = new System.Drawing.Size(428, 56);
            this.txt_trienio.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_trienio.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_trienio.StateCommon.Border.Rounding = 15F;
            this.txt_trienio.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_trienio.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trienio.TabIndex = 64;
            this.txt_trienio.Text = "Triénio";
            this.txt_trienio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_trienio.WordWrap = false;
            this.txt_trienio.TextChanged += new System.EventHandler(this.txt_trienio_TextChanged);
            this.txt_trienio.Enter += new System.EventHandler(this.txt_trienio_Enter);
            this.txt_trienio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_trienio_KeyDown);
            this.txt_trienio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trienio_KeyPress_1);
            this.txt_trienio.Leave += new System.EventHandler(this.txt_trienio_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbl_previsualização);
            this.panel1.Controls.Add(this.PixBx_Qrcode);
            this.panel1.Controls.Add(this.PixBx_FotoAluno);
            this.panel1.Location = new System.Drawing.Point(1057, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 961);
            this.panel1.TabIndex = 69;
            // 
            // lbl_previsualização
            // 
            this.lbl_previsualização.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_previsualização.AutoSize = true;
            this.lbl_previsualização.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previsualização.ForeColor = System.Drawing.Color.White;
            this.lbl_previsualização.Location = new System.Drawing.Point(28, 14);
            this.lbl_previsualização.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_previsualização.Name = "lbl_previsualização";
            this.lbl_previsualização.Size = new System.Drawing.Size(460, 67);
            this.lbl_previsualização.TabIndex = 61;
            this.lbl_previsualização.Text = "Prévisualização";
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nome.AutoCompleteCustomSource.AddRange(new string[] {
            "dsd"});
            this.txt_nome.Location = new System.Drawing.Point(239, 290);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(428, 56);
            this.txt_nome.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_nome.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_nome.StateCommon.Border.Rounding = 15F;
            this.txt_nome.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_nome.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.TabIndex = 62;
            this.txt_nome.Text = "Nome";
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nome.WordWrap = false;
            this.txt_nome.Enter += new System.EventHandler(this.txt_nome_Enter);
            this.txt_nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nome_KeyDown);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_Leave);
            // 
            // ComBox_Curso
            // 
            this.ComBox_Curso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComBox_Curso.CornerRoundingRadius = 15F;
            this.ComBox_Curso.DropDownWidth = 311;
            this.ComBox_Curso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComBox_Curso.IntegralHeight = false;
            this.ComBox_Curso.Items.AddRange(new object[] {
            "Técnico de Logística",
            "Técnico de Gestão e Prog. de Sistemas Informáticos",
            "Técnico de Turismo",
            "Técnico de Comunicação, Marketing, Relações Públicas e Publicidade",
            "Técnico de Comércio",
            "Animador Sociocultural"});
            this.ComBox_Curso.Location = new System.Drawing.Point(239, 559);
            this.ComBox_Curso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComBox_Curso.Name = "ComBox_Curso";
            this.ComBox_Curso.Size = new System.Drawing.Size(428, 54);
            this.ComBox_Curso.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Curso.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Curso.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Curso.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Curso.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Curso.TabIndex = 65;
            this.ComBox_Curso.Text = "Curso";
            // 
            // btn_GeraQr
            // 
            this.btn_GeraQr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_GeraQr.CornerRoundingRadius = 20F;
            this.btn_GeraQr.Location = new System.Drawing.Point(295, 756);
            this.btn_GeraQr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GeraQr.Name = "btn_GeraQr";
            this.btn_GeraQr.Size = new System.Drawing.Size(309, 69);
            this.btn_GeraQr.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_GeraQr.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_GeraQr.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_GeraQr.StateCommon.Border.Rounding = 20F;
            this.btn_GeraQr.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_GeraQr.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btn_GeraQr.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GeraQr.TabIndex = 68;
            this.btn_GeraQr.TabStop = false;
            this.btn_GeraQr.Values.Text = "Gerar Código QR";
            this.btn_GeraQr.Click += new System.EventHandler(this.btn_GeraQr_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Guardar.CornerRoundingRadius = 20F;
            this.btn_Guardar.Location = new System.Drawing.Point(295, 847);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(309, 69);
            this.btn_Guardar.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_Guardar.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_Guardar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Guardar.StateCommon.Border.Rounding = 20F;
            this.btn_Guardar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_Guardar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_Guardar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.TabIndex = 67;
            this.btn_Guardar.TabStop = false;
            this.btn_Guardar.Values.Text = "Inserir Cartão";
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_CarregarFt
            // 
            this.btn_CarregarFt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_CarregarFt.CornerRoundingRadius = 20F;
            this.btn_CarregarFt.Location = new System.Drawing.Point(295, 666);
            this.btn_CarregarFt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CarregarFt.Name = "btn_CarregarFt";
            this.btn_CarregarFt.Size = new System.Drawing.Size(309, 69);
            this.btn_CarregarFt.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_CarregarFt.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_CarregarFt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_CarregarFt.StateCommon.Border.Rounding = 20F;
            this.btn_CarregarFt.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_CarregarFt.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btn_CarregarFt.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CarregarFt.TabIndex = 66;
            this.btn_CarregarFt.TabStop = false;
            this.btn_CarregarFt.Values.Text = "Carregar Foto";
            this.btn_CarregarFt.Click += new System.EventHandler(this.btn_CarregarFt_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_numero.AutoCompleteCustomSource.AddRange(new string[] {
            "dsd"});
            this.txt_numero.Location = new System.Drawing.Point(239, 380);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(428, 56);
            this.txt_numero.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_numero.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_numero.StateCommon.Border.Rounding = 15F;
            this.txt_numero.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_numero.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.TabIndex = 63;
            this.txt_numero.Text = "Número";
            this.txt_numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_numero.WordWrap = false;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            this.txt_numero.Enter += new System.EventHandler(this.txt_numero_Enter);
            this.txt_numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_numero_KeyDown);
            this.txt_numero.Leave += new System.EventHandler(this.txt_numero_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 67);
            this.label1.TabIndex = 61;
            this.label1.Text = "Criar Cartão";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 39);
            this.button5.TabIndex = 70;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PixBx_Qrcode
            // 
            this.PixBx_Qrcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PixBx_Qrcode.Location = new System.Drawing.Point(112, 585);
            this.PixBx_Qrcode.Margin = new System.Windows.Forms.Padding(4);
            this.PixBx_Qrcode.Name = "PixBx_Qrcode";
            this.PixBx_Qrcode.Size = new System.Drawing.Size(307, 283);
            this.PixBx_Qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixBx_Qrcode.TabIndex = 1;
            this.PixBx_Qrcode.TabStop = false;
            // 
            // PixBx_FotoAluno
            // 
            this.PixBx_FotoAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PixBx_FotoAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PixBx_FotoAluno.Image = global::app.Properties.Resources.pessoa;
            this.PixBx_FotoAluno.Location = new System.Drawing.Point(112, 209);
            this.PixBx_FotoAluno.Margin = new System.Windows.Forms.Padding(4);
            this.PixBx_FotoAluno.Name = "PixBx_FotoAluno";
            this.PixBx_FotoAluno.Size = new System.Drawing.Size(307, 283);
            this.PixBx_FotoAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PixBx_FotoAluno.TabIndex = 0;
            this.PixBx_FotoAluno.TabStop = false;
            // 
            // CriarCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1579, 961);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txt_trienio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.ComBox_Curso);
            this.Controls.Add(this.btn_GeraQr);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_CarregarFt);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CriarCartao";
            this.Text = "CriarCartao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Curso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_Qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixBx_FotoAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txt_trienio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_previsualização;
        private Krypton.Toolkit.KryptonPictureBox PixBx_Qrcode;
        private Krypton.Toolkit.KryptonPictureBox PixBx_FotoAluno;
        private Krypton.Toolkit.KryptonTextBox txt_nome;
        private Krypton.Toolkit.KryptonComboBox ComBox_Curso;
        private Krypton.Toolkit.KryptonButton btn_GeraQr;
        private Krypton.Toolkit.KryptonButton btn_Guardar;
        private Krypton.Toolkit.KryptonButton btn_CarregarFt;
        private Krypton.Toolkit.KryptonTextBox txt_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}