namespace app.Forms
{
    partial class Historico
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
            this.btn_todas = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apagarhistorico = new System.Windows.Forms.Button();
            this.txt_FiltroProfessor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_historico = new Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_historico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_todas);
            this.panel6.Controls.Add(this.dateTimePicker3);
            this.panel6.Controls.Add(this.dateTimePicker2);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.apagarhistorico);
            this.panel6.Controls.Add(this.txt_FiltroProfessor);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.tbl_historico);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(13, 14);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1090, 616);
            this.panel6.TabIndex = 91;
            // 
            // btn_todas
            // 
            this.btn_todas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_todas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_todas.FlatAppearance.BorderSize = 0;
            this.btn_todas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_todas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_todas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_todas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todas.ForeColor = System.Drawing.Color.Black;
            this.btn_todas.Location = new System.Drawing.Point(179, 87);
            this.btn_todas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_todas.Name = "btn_todas";
            this.btn_todas.Size = new System.Drawing.Size(104, 30);
            this.btn_todas.TabIndex = 127;
            this.btn_todas.Text = "Totas";
            this.btn_todas.UseVisualStyleBackColor = false;
            this.btn_todas.Click += new System.EventHandler(this.btn_todas_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(65, 90);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(104, 22);
            this.dateTimePicker3.TabIndex = 126;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(508, 571);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 22);
            this.dateTimePicker2.TabIndex = 125;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 571);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 124;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(293, 571);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 123;
            this.label4.Text = "Apagar de";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(487, 571);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 122;
            this.label3.Text = "a";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apagarhistorico
            // 
            this.apagarhistorico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.apagarhistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.apagarhistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagarhistorico.FlatAppearance.BorderSize = 0;
            this.apagarhistorico.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.apagarhistorico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.apagarhistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.apagarhistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagarhistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagarhistorico.ForeColor = System.Drawing.Color.Black;
            this.apagarhistorico.Location = new System.Drawing.Point(631, 559);
            this.apagarhistorico.Margin = new System.Windows.Forms.Padding(4);
            this.apagarhistorico.Name = "apagarhistorico";
            this.apagarhistorico.Size = new System.Drawing.Size(165, 46);
            this.apagarhistorico.TabIndex = 119;
            this.apagarhistorico.Text = "Apagar";
            this.apagarhistorico.UseVisualStyleBackColor = false;
            this.apagarhistorico.Click += new System.EventHandler(this.apagarhistorico_Click);
            // 
            // txt_FiltroProfessor
            // 
            this.txt_FiltroProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FiltroProfessor.Location = new System.Drawing.Point(379, 89);
            this.txt_FiltroProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FiltroProfessor.Name = "txt_FiltroProfessor";
            this.txt_FiltroProfessor.Size = new System.Drawing.Size(196, 27);
            this.txt_FiltroProfessor.TabIndex = 118;
            this.txt_FiltroProfessor.TextChanged += new System.EventHandler(this.txt_FiltroProfessor_TextChanged);
            this.txt_FiltroProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FiltroProfessor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(293, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 117;
            this.label1.Text = "Professor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 116;
            this.label2.Text = "Data:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tbl_historico.Location = new System.Drawing.Point(20, 122);
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
            this.tbl_historico.Size = new System.Drawing.Size(1048, 423);
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
            this.tbl_historico.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tbl_historico_CellFormatting);
            this.tbl_historico.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbl_historico_CellMouseDoubleClick);
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
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Históricos";
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1116, 642);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Historico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_historico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private Krypton.Toolkit.KryptonDataGridView tbl_historico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_FiltroProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apagarhistorico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btn_todas;
    }
}