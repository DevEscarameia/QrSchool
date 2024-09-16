namespace app
{
    partial class FrmPrevisualizarCartão
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_guardarPDF = new Krypton.Toolkit.KryptonButton();
            this.btn_cancelar = new Krypton.Toolkit.KryptonButton();
            this.pnl_cartao = new System.Windows.Forms.Panel();
            this.PicBox_ftAluno = new System.Windows.Forms.PictureBox();
            this.lbl_trienio = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnl_Qrcode = new System.Windows.Forms.Panel();
            this.PixBox_qrcode = new System.Windows.Forms.PictureBox();
            this.ComBox_Dimensao = new Krypton.Toolkit.KryptonComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pnl_cartao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ftAluno)).BeginInit();
            this.pnl_Qrcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBox_qrcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Dimensao)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardarPDF
            // 
            this.btn_guardarPDF.Location = new System.Drawing.Point(771, 726);
            this.btn_guardarPDF.Name = "btn_guardarPDF";
            this.btn_guardarPDF.Size = new System.Drawing.Size(147, 46);
            this.btn_guardarPDF.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_guardarPDF.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_guardarPDF.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_guardarPDF.StateCommon.Border.Rounding = 15F;
            this.btn_guardarPDF.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_guardarPDF.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_guardarPDF.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarPDF.TabIndex = 2;
            this.btn_guardarPDF.TabStop = false;
            this.btn_guardarPDF.Values.Text = "Guardar PDF";
            this.btn_guardarPDF.Click += new System.EventHandler(this.btn_guardarPDF_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(924, 726);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(147, 46);
            this.btn_cancelar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_cancelar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_cancelar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cancelar.StateCommon.Border.Rounding = 15F;
            this.btn_cancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_cancelar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_cancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Values.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // pnl_cartao
            // 
            this.pnl_cartao.BackgroundImage = global::app.Properties.Resources.CartaoEscola__1_1;
            this.pnl_cartao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_cartao.Controls.Add(this.PicBox_ftAluno);
            this.pnl_cartao.Controls.Add(this.lbl_trienio);
            this.pnl_cartao.Controls.Add(this.lbl_Curso);
            this.pnl_cartao.Controls.Add(this.lbl_nome);
            this.pnl_cartao.Controls.Add(this.lbl_numero);
            this.pnl_cartao.Location = new System.Drawing.Point(33, 26);
            this.pnl_cartao.Name = "pnl_cartao";
            this.pnl_cartao.Size = new System.Drawing.Size(650, 370);
            this.pnl_cartao.TabIndex = 5;
            this.pnl_cartao.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cartao_Paint);
            // 
            // PicBox_ftAluno
            // 
            this.PicBox_ftAluno.BackColor = System.Drawing.Color.Transparent;
            this.PicBox_ftAluno.Location = new System.Drawing.Point(529, 18);
            this.PicBox_ftAluno.Name = "PicBox_ftAluno";
            this.PicBox_ftAluno.Size = new System.Drawing.Size(94, 121);
            this.PicBox_ftAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_ftAluno.TabIndex = 4;
            this.PicBox_ftAluno.TabStop = false;
            // 
            // lbl_trienio
            // 
            this.lbl_trienio.AutoSize = true;
            this.lbl_trienio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_trienio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trienio.ForeColor = System.Drawing.Color.Black;
            this.lbl_trienio.Location = new System.Drawing.Point(327, 196);
            this.lbl_trienio.Name = "lbl_trienio";
            this.lbl_trienio.Size = new System.Drawing.Size(65, 24);
            this.lbl_trienio.TabIndex = 3;
            this.lbl_trienio.Text = "fffffffffff";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.BackColor = System.Drawing.Color.White;
            this.lbl_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Curso.ForeColor = System.Drawing.Color.Black;
            this.lbl_Curso.Location = new System.Drawing.Point(90, 230);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(65, 24);
            this.lbl_Curso.TabIndex = 2;
            this.lbl_Curso.Text = "fffffffffff";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(91, 156);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(65, 24);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "fffffffffff";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.ForeColor = System.Drawing.Color.Black;
            this.lbl_numero.Location = new System.Drawing.Point(115, 195);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(65, 24);
            this.lbl_numero.TabIndex = 1;
            this.lbl_numero.Text = "fffffffffff";
            // 
            // pnl_Qrcode
            // 
            this.pnl_Qrcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.pnl_Qrcode.Controls.Add(this.PixBox_qrcode);
            this.pnl_Qrcode.Location = new System.Drawing.Point(33, 402);
            this.pnl_Qrcode.Name = "pnl_Qrcode";
            this.pnl_Qrcode.Size = new System.Drawing.Size(650, 370);
            this.pnl_Qrcode.TabIndex = 7;
            // 
            // PixBox_qrcode
            // 
            this.PixBox_qrcode.Location = new System.Drawing.Point(200, 51);
            this.PixBox_qrcode.Name = "PixBox_qrcode";
            this.PixBox_qrcode.Size = new System.Drawing.Size(260, 260);
            this.PixBox_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixBox_qrcode.TabIndex = 0;
            this.PixBox_qrcode.TabStop = false;
            // 
            // ComBox_Dimensao
            // 
            this.ComBox_Dimensao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBox_Dimensao.CornerRoundingRadius = 15F;
            this.ComBox_Dimensao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Dimensao.DropDownWidth = 311;
            this.ComBox_Dimensao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComBox_Dimensao.IntegralHeight = false;
            this.ComBox_Dimensao.Items.AddRange(new object[] {
            "Normal",
            "Zoom",
            "StretchImage",
            "CenterImage",
            "AutoSize"});
            this.ComBox_Dimensao.Location = new System.Drawing.Point(771, 658);
            this.ComBox_Dimensao.Name = "ComBox_Dimensao";
            this.ComBox_Dimensao.Size = new System.Drawing.Size(300, 46);
            this.ComBox_Dimensao.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Dimensao.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Dimensao.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Dimensao.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Dimensao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Dimensao.TabIndex = 1;
            this.ComBox_Dimensao.SelectedIndexChanged += new System.EventHandler(this.ComBox_Curso_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1094, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 32);
            this.button5.TabIndex = 71;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmPrevisualizarCartão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 800);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ComBox_Dimensao);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardarPDF);
            this.Controls.Add(this.pnl_Qrcode);
            this.Controls.Add(this.pnl_cartao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrevisualizarCartão";
            this.Text = "FrmPrevisualizarCartão";
            this.pnl_cartao.ResumeLayout(false);
            this.pnl_cartao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ftAluno)).EndInit();
            this.pnl_Qrcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PixBox_qrcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Dimensao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.Label lbl_trienio;
        private System.Windows.Forms.PictureBox PicBox_ftAluno;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnl_cartao;
        private Krypton.Toolkit.KryptonButton btn_cancelar;
        private Krypton.Toolkit.KryptonButton btn_guardarPDF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel pnl_Qrcode;
        private System.Windows.Forms.PictureBox PixBox_qrcode;
        private Krypton.Toolkit.KryptonComboBox ComBox_Dimensao;
        private System.Windows.Forms.Button button5;
    }
}