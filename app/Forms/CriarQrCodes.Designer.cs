namespace app.Forms
{
    partial class CriarQrCodes
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
            this.btn_CriarQrcodes = new System.Windows.Forms.Button();
            this.Tbl_ListaComputadores = new Krypton.Toolkit.KryptonDataGridView();
            this.pdfViewer1 = new PdfiumViewer.PdfViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaComputadores)).BeginInit();
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
            this.panel6.Controls.Add(this.btn_CriarQrcodes);
            this.panel6.Controls.Add(this.Tbl_ListaComputadores);
            this.panel6.Controls.Add(this.pdfViewer1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(13, 12);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1061, 590);
            this.panel6.TabIndex = 94;
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
            this.btn_todas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_todas.Location = new System.Drawing.Point(409, 46);
            this.btn_todas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_todas.Name = "btn_todas";
            this.btn_todas.Size = new System.Drawing.Size(107, 30);
            this.btn_todas.TabIndex = 129;
            this.btn_todas.Text = "Totas";
            this.btn_todas.UseVisualStyleBackColor = false;
            this.btn_todas.Click += new System.EventHandler(this.btn_todas_Click);
            // 
            // btn_CriarQrcodes
            // 
            this.btn_CriarQrcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CriarQrcodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_CriarQrcodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CriarQrcodes.FlatAppearance.BorderSize = 0;
            this.btn_CriarQrcodes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_CriarQrcodes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CriarQrcodes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CriarQrcodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CriarQrcodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CriarQrcodes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CriarQrcodes.Location = new System.Drawing.Point(359, 523);
            this.btn_CriarQrcodes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CriarQrcodes.Name = "btn_CriarQrcodes";
            this.btn_CriarQrcodes.Size = new System.Drawing.Size(157, 46);
            this.btn_CriarQrcodes.TabIndex = 128;
            this.btn_CriarQrcodes.Text = "Criar QrCodes";
            this.btn_CriarQrcodes.UseVisualStyleBackColor = false;
            this.btn_CriarQrcodes.Click += new System.EventHandler(this.btn_CriarQrcodes_Click);
            // 
            // Tbl_ListaComputadores
            // 
            this.Tbl_ListaComputadores.AllowUserToAddRows = false;
            this.Tbl_ListaComputadores.AllowUserToDeleteRows = false;
            this.Tbl_ListaComputadores.AllowUserToResizeColumns = false;
            this.Tbl_ListaComputadores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaComputadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tbl_ListaComputadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Tbl_ListaComputadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tbl_ListaComputadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbl_ListaComputadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_ListaComputadores.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Tbl_ListaComputadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Tbl_ListaComputadores.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.Tbl_ListaComputadores.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_ListaComputadores.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaComputadores.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaComputadores.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaComputadores.HideOuterBorders = true;
            this.Tbl_ListaComputadores.Location = new System.Drawing.Point(29, 82);
            this.Tbl_ListaComputadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tbl_ListaComputadores.MultiSelect = false;
            this.Tbl_ListaComputadores.Name = "Tbl_ListaComputadores";
            this.Tbl_ListaComputadores.RowHeadersVisible = false;
            this.Tbl_ListaComputadores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaComputadores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Tbl_ListaComputadores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.Tbl_ListaComputadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbl_ListaComputadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_ListaComputadores.ShowEditingIcon = false;
            this.Tbl_ListaComputadores.Size = new System.Drawing.Size(487, 431);
            this.Tbl_ListaComputadores.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaComputadores.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaComputadores.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_ListaComputadores.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaComputadores.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaComputadores.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.Tbl_ListaComputadores.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tbl_ListaComputadores.StateCommon.DataCell.Border.Rounding = 0F;
            this.Tbl_ListaComputadores.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_ListaComputadores.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_ListaComputadores.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaComputadores.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaComputadores.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaComputadores.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaComputadores.TabIndex = 127;
            this.Tbl_ListaComputadores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_ListaComputadores_CellValueChanged);
            this.Tbl_ListaComputadores.CurrentCellDirtyStateChanged += new System.EventHandler(this.Tbl_ListaComputadores_CurrentCellDirtyStateChanged);
            this.Tbl_ListaComputadores.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Tbl_ListaComputadores_DataError);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfViewer1.Location = new System.Drawing.Point(544, 82);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(487, 432);
            this.pdfViewer1.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "QrCodes";
            // 
            // CriarQrCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1087, 615);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CriarQrCodes";
            this.Text = "CriarQrCodes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriarQrCodes_FormClosing);
            this.Load += new System.EventHandler(this.CriarQrCodes_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaComputadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonDataGridView Tbl_ListaComputadores;
        private System.Windows.Forms.Button btn_CriarQrcodes;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private System.Windows.Forms.Button btn_todas;
    }
}