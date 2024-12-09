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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_FiltroProfessor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_filtroData = new System.Windows.Forms.MaskedTextBox();
            this.tbl_historico = new Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
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
            this.panel6.Controls.Add(this.kryptonDateTimePicker1);
            this.panel6.Controls.Add(this.txt_FiltroProfessor);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txt_filtroData);
            this.panel6.Controls.Add(this.tbl_historico);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(13, 13);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1090, 616);
            this.panel6.TabIndex = 91;
            // 
            // txt_FiltroProfessor
            // 
            this.txt_FiltroProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FiltroProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FiltroProfessor.Location = new System.Drawing.Point(258, 88);
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
            this.label1.Location = new System.Drawing.Point(173, 91);
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
            // txt_filtroData
            // 
            this.txt_filtroData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtroData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtroData.Location = new System.Drawing.Point(67, 88);
            this.txt_filtroData.Mask = "0000-00-00";
            this.txt_filtroData.Name = "txt_filtroData";
            this.txt_filtroData.Size = new System.Drawing.Size(99, 27);
            this.txt_filtroData.TabIndex = 96;
            this.txt_filtroData.Click += new System.EventHandler(this.txt_filtroData_Click);
            this.txt_filtroData.TextChanged += new System.EventHandler(this.txt_filtroData_TextChanged);
            // 
            // tbl_historico
            // 
            this.tbl_historico.AllowUserToAddRows = false;
            this.tbl_historico.AllowUserToDeleteRows = false;
            this.tbl_historico.AllowUserToResizeColumns = false;
            this.tbl_historico.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.tbl_historico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tbl_historico.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tbl_historico.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.tbl_historico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbl_historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_historico.ShowEditingIcon = false;
            this.tbl_historico.Size = new System.Drawing.Size(1015, 465);
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
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(490, 91);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(168, 25);
            this.kryptonDateTimePicker1.TabIndex = 119;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1116, 642);
            this.Controls.Add(this.panel6);
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
        private System.Windows.Forms.MaskedTextBox txt_filtroData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_FiltroProfessor;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
    }
}