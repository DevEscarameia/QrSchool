namespace app.Forms
{
    partial class VisualizarReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarReservas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_numeropcs = new System.Windows.Forms.Label();
            this.lbl_NPortateis = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Label();
            this.Tbl_ListaReservas = new Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_numeropcs);
            this.panel2.Controls.Add(this.lbl_NPortateis);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.Tbl_ListaReservas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 669);
            this.panel2.TabIndex = 96;
            // 
            // txt_numeropcs
            // 
            this.txt_numeropcs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numeropcs.AutoSize = true;
            this.txt_numeropcs.BackColor = System.Drawing.Color.Transparent;
            this.txt_numeropcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeropcs.ForeColor = System.Drawing.Color.Black;
            this.txt_numeropcs.Location = new System.Drawing.Point(401, 37);
            this.txt_numeropcs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_numeropcs.Name = "txt_numeropcs";
            this.txt_numeropcs.Size = new System.Drawing.Size(16, 18);
            this.txt_numeropcs.TabIndex = 124;
            this.txt_numeropcs.Text = "0";
            this.txt_numeropcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NPortateis
            // 
            this.lbl_NPortateis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NPortateis.AutoSize = true;
            this.lbl_NPortateis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NPortateis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NPortateis.ForeColor = System.Drawing.Color.Black;
            this.lbl_NPortateis.Location = new System.Drawing.Point(311, 37);
            this.lbl_NPortateis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NPortateis.Name = "lbl_NPortateis";
            this.lbl_NPortateis.Size = new System.Drawing.Size(91, 18);
            this.lbl_NPortateis.TabIndex = 123;
            this.lbl_NPortateis.Text = "Nº Portateis:";
            this.lbl_NPortateis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(1108, 4);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(21, 23);
            this.btn_cancelar.TabIndex = 122;
            this.btn_cancelar.Text = "X";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Tbl_ListaReservas
            // 
            this.Tbl_ListaReservas.AllowUserToAddRows = false;
            this.Tbl_ListaReservas.AllowUserToDeleteRows = false;
            this.Tbl_ListaReservas.AllowUserToResizeColumns = false;
            this.Tbl_ListaReservas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tbl_ListaReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbl_ListaReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tbl_ListaReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbl_ListaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_ListaReservas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Tbl_ListaReservas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Tbl_ListaReservas.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.Tbl_ListaReservas.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_ListaReservas.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaReservas.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaReservas.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaReservas.HideOuterBorders = true;
            this.Tbl_ListaReservas.Location = new System.Drawing.Point(29, 78);
            this.Tbl_ListaReservas.Margin = new System.Windows.Forms.Padding(4);
            this.Tbl_ListaReservas.MultiSelect = false;
            this.Tbl_ListaReservas.Name = "Tbl_ListaReservas";
            this.Tbl_ListaReservas.ReadOnly = true;
            this.Tbl_ListaReservas.RowHeadersVisible = false;
            this.Tbl_ListaReservas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaReservas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Tbl_ListaReservas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.Tbl_ListaReservas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbl_ListaReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_ListaReservas.ShowEditingIcon = false;
            this.Tbl_ListaReservas.Size = new System.Drawing.Size(1070, 564);
            this.Tbl_ListaReservas.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaReservas.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaReservas.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_ListaReservas.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaReservas.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaReservas.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.Tbl_ListaReservas.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tbl_ListaReservas.StateCommon.DataCell.Border.Rounding = 0F;
            this.Tbl_ListaReservas.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_ListaReservas.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_ListaReservas.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaReservas.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaReservas.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaReservas.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaReservas.TabIndex = 121;
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
            this.label5.Size = new System.Drawing.Size(217, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Visualizar Reservas";
            // 
            // VisualizarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1161, 695);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarReservas";
            this.Load += new System.EventHandler(this.VisualizarReservas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonDataGridView Tbl_ListaReservas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label btn_cancelar;
        private System.Windows.Forms.Label txt_numeropcs;
        private System.Windows.Forms.Label lbl_NPortateis;
    }
}