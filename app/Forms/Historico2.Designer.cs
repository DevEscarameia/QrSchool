namespace app.Forms
{
    partial class Historico2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbl_historico = new Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txt_IdRequisiçao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txt_data = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_quantidade = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt_turma = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_horaFim = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_horaInicio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_professor = new System.Windows.Forms.Label();
            this.btn_voltar = new Krypton.Toolkit.KryptonButton();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_historico)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_voltar);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.tbl_historico);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(13, 13);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1090, 616);
            this.panel6.TabIndex = 92;
            // 
            // tbl_historico
            // 
            this.tbl_historico.AllowUserToAddRows = false;
            this.tbl_historico.AllowUserToDeleteRows = false;
            this.tbl_historico.AllowUserToResizeColumns = false;
            this.tbl_historico.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tbl_historico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_historico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_historico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_historico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_historico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbl_historico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tbl_historico.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.tbl_historico.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.tbl_historico.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.tbl_historico.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.tbl_historico.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.tbl_historico.HideOuterBorders = true;
            this.tbl_historico.Location = new System.Drawing.Point(4, 152);
            this.tbl_historico.Margin = new System.Windows.Forms.Padding(4);
            this.tbl_historico.MultiSelect = false;
            this.tbl_historico.Name = "tbl_historico";
            this.tbl_historico.ReadOnly = true;
            this.tbl_historico.RowHeadersVisible = false;
            this.tbl_historico.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.tbl_historico.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tbl_historico.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.tbl_historico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_historico.ShowEditingIcon = false;
            this.tbl_historico.Size = new System.Drawing.Size(1080, 383);
            this.tbl_historico.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.tbl_historico.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.tbl_historico.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.tbl_historico.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.tbl_historico.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.tbl_historico.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.tbl_historico.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbl_historico.StateCommon.DataCell.Border.Rounding = 0F;
            this.tbl_historico.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.tbl_historico.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.tbl_historico.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.tbl_historico.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.tbl_historico.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.tbl_historico.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.tbl_historico.TabIndex = 94;
            this.tbl_historico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_historico_CellContentClick);
            this.tbl_historico.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tbl_historico_CellFormatting);
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
            this.label5.Size = new System.Drawing.Size(104, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Histórico";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.txt_IdRequisiçao);
            this.panel7.Location = new System.Drawing.Point(462, 70);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(145, 57);
            this.panel7.TabIndex = 100;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::app.Properties.Resources._1eb182f7_317c_4961_b1f0_48fa5e72c438_removebg_preview1;
            this.pictureBox6.Location = new System.Drawing.Point(4, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 49);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 80;
            this.pictureBox6.TabStop = false;
            // 
            // txt_IdRequisiçao
            // 
            this.txt_IdRequisiçao.AutoSize = true;
            this.txt_IdRequisiçao.ForeColor = System.Drawing.Color.Black;
            this.txt_IdRequisiçao.Location = new System.Drawing.Point(67, 20);
            this.txt_IdRequisiçao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_IdRequisiçao.Name = "txt_IdRequisiçao";
            this.txt_IdRequisiçao.Size = new System.Drawing.Size(0, 16);
            this.txt_IdRequisiçao.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.txt_data);
            this.panel1.Location = new System.Drawing.Point(274, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 57);
            this.panel1.TabIndex = 99;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::app.Properties.Resources.calendar;
            this.pictureBox5.Location = new System.Drawing.Point(4, 4);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 80;
            this.pictureBox5.TabStop = false;
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.ForeColor = System.Drawing.Color.Black;
            this.txt_data.Location = new System.Drawing.Point(67, 20);
            this.txt_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(0, 16);
            this.txt_data.TabIndex = 81;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txt_quantidade);
            this.panel3.Location = new System.Drawing.Point(951, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 57);
            this.panel3.TabIndex = 96;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::app.Properties.Resources.icons8_amount_50;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_quantidade.AutoSize = true;
            this.txt_quantidade.ForeColor = System.Drawing.Color.Black;
            this.txt_quantidade.Location = new System.Drawing.Point(67, 12);
            this.txt_quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(21, 16);
            this.txt_quantidade.TabIndex = 81;
            this.txt_quantidade.Text = "00";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.txt_turma);
            this.panel4.Location = new System.Drawing.Point(792, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 57);
            this.panel4.TabIndex = 97;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::app.Properties.Resources.icons8_class_50;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 80;
            this.pictureBox3.TabStop = false;
            // 
            // txt_turma
            // 
            this.txt_turma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_turma.AutoSize = true;
            this.txt_turma.ForeColor = System.Drawing.Color.Black;
            this.txt_turma.Location = new System.Drawing.Point(80, 12);
            this.txt_turma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_turma.Name = "txt_turma";
            this.txt_turma.Size = new System.Drawing.Size(21, 16);
            this.txt_turma.TabIndex = 80;
            this.txt_turma.Text = "00";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.txt_horaFim);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.txt_horaInicio);
            this.panel5.Location = new System.Drawing.Point(611, 70);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 57);
            this.panel5.TabIndex = 98;
            // 
            // txt_horaFim
            // 
            this.txt_horaFim.AutoSize = true;
            this.txt_horaFim.ForeColor = System.Drawing.Color.Black;
            this.txt_horaFim.Location = new System.Drawing.Point(67, 37);
            this.txt_horaFim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_horaFim.Name = "txt_horaFim";
            this.txt_horaFim.Size = new System.Drawing.Size(37, 16);
            this.txt_horaFim.TabIndex = 82;
            this.txt_horaFim.Text = "Hora";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::app.Properties.Resources.icons8_clock_50;
            this.pictureBox4.Location = new System.Drawing.Point(4, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            // 
            // txt_horaInicio
            // 
            this.txt_horaInicio.AutoSize = true;
            this.txt_horaInicio.ForeColor = System.Drawing.Color.Black;
            this.txt_horaInicio.Location = new System.Drawing.Point(67, 4);
            this.txt_horaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_horaInicio.Name = "txt_horaInicio";
            this.txt_horaInicio.Size = new System.Drawing.Size(37, 16);
            this.txt_horaInicio.TabIndex = 81;
            this.txt_horaInicio.Text = "Hora";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txt_professor);
            this.panel2.Location = new System.Drawing.Point(4, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 57);
            this.panel2.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::app.Properties.Resources.icons8_professor_50;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // txt_professor
            // 
            this.txt_professor.AutoSize = true;
            this.txt_professor.BackColor = System.Drawing.Color.White;
            this.txt_professor.ForeColor = System.Drawing.Color.Black;
            this.txt_professor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_professor.Location = new System.Drawing.Point(67, 12);
            this.txt_professor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_professor.Name = "txt_professor";
            this.txt_professor.Size = new System.Drawing.Size(65, 16);
            this.txt_professor.TabIndex = 79;
            this.txt_professor.Text = "Professor";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_voltar.CornerRoundingRadius = 20F;
            this.btn_voltar.Location = new System.Drawing.Point(22, 543);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(165, 46);
            this.btn_voltar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_voltar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_voltar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_voltar.StateCommon.Border.Rounding = 20F;
            this.btn_voltar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_voltar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btn_voltar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.TabIndex = 101;
            this.btn_voltar.TabStop = false;
            this.btn_voltar.Values.Text = "Voltar";
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Historico2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1116, 642);
            this.Controls.Add(this.panel6);
            this.Name = "Historico2";
            this.Text = "Historico2";
            this.Load += new System.EventHandler(this.Historico2_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_historico)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private Krypton.Toolkit.KryptonDataGridView tbl_historico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label txt_IdRequisiçao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txt_quantidade;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label txt_turma;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txt_horaFim;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txt_horaInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_professor;
        private Krypton.Toolkit.KryptonButton btn_voltar;
    }
}