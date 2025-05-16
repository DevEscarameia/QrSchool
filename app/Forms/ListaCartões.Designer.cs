namespace app
{
    partial class ListaCartões
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_todas = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.ComBox_turma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.PictureBox();
            this.btn_apagar = new System.Windows.Forms.PictureBox();
            this.Tbl_ListaCartões = new Krypton.Toolkit.KryptonDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_apagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaCartões)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de Cartões";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_limpar);
            this.panel6.Controls.Add(this.btn_todas);
            this.panel6.Controls.Add(this.txt_Nome);
            this.panel6.Controls.Add(this.ComBox_turma);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btn_print);
            this.panel6.Controls.Add(this.btn_apagar);
            this.panel6.Controls.Add(this.Tbl_ListaCartões);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(13, 14);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(886, 503);
            this.panel6.TabIndex = 94;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Black;
            this.btn_limpar.Location = new System.Drawing.Point(705, 89);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(104, 30);
            this.btn_limpar.TabIndex = 129;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_todas
            // 
            this.btn_todas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_todas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_todas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_todas.FlatAppearance.BorderSize = 0;
            this.btn_todas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_todas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_todas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_todas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todas.ForeColor = System.Drawing.Color.Black;
            this.btn_todas.Location = new System.Drawing.Point(700, 384);
            this.btn_todas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_todas.Name = "btn_todas";
            this.btn_todas.Size = new System.Drawing.Size(107, 30);
            this.btn_todas.TabIndex = 128;
            this.btn_todas.Text = "Todos";
            this.btn_todas.UseVisualStyleBackColor = false;
            this.btn_todas.Click += new System.EventHandler(this.btn_todas_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(68, 91);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(303, 24);
            this.txt_Nome.TabIndex = 124;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // ComBox_turma
            // 
            this.ComBox_turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_turma.FormattingEnabled = true;
            this.ComBox_turma.Items.AddRange(new object[] {
            ""});
            this.ComBox_turma.Location = new System.Drawing.Point(441, 89);
            this.ComBox_turma.Margin = new System.Windows.Forms.Padding(4);
            this.ComBox_turma.Name = "ComBox_turma";
            this.ComBox_turma.Size = new System.Drawing.Size(255, 26);
            this.ComBox_turma.TabIndex = 123;
            this.ComBox_turma.TextChanged += new System.EventHandler(this.txt_turma_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(379, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 121;
            this.label2.Text = "Turma:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 120;
            this.label3.Text = "Aluno:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Image = global::app.Properties.Resources.imprimindo_contorno_do_botao;
            this.btn_print.Location = new System.Drawing.Point(700, 420);
            this.btn_print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(51, 50);
            this.btn_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_print.TabIndex = 97;
            this.btn_print.TabStop = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apagar.Image = global::app.Properties.Resources.trash;
            this.btn_apagar.Location = new System.Drawing.Point(756, 420);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(51, 50);
            this.btn_apagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_apagar.TabIndex = 96;
            this.btn_apagar.TabStop = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // Tbl_ListaCartões
            // 
            this.Tbl_ListaCartões.AllowUserToAddRows = false;
            this.Tbl_ListaCartões.AllowUserToDeleteRows = false;
            this.Tbl_ListaCartões.AllowUserToResizeColumns = false;
            this.Tbl_ListaCartões.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaCartões.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tbl_ListaCartões.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbl_ListaCartões.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tbl_ListaCartões.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbl_ListaCartões.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_ListaCartões.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Tbl_ListaCartões.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Tbl_ListaCartões.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.Tbl_ListaCartões.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_ListaCartões.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaCartões.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaCartões.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_ListaCartões.HideOuterBorders = true;
            this.Tbl_ListaCartões.Location = new System.Drawing.Point(20, 143);
            this.Tbl_ListaCartões.Margin = new System.Windows.Forms.Padding(4);
            this.Tbl_ListaCartões.MultiSelect = false;
            this.Tbl_ListaCartões.Name = "Tbl_ListaCartões";
            this.Tbl_ListaCartões.RowHeadersVisible = false;
            this.Tbl_ListaCartões.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaCartões.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Tbl_ListaCartões.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.Tbl_ListaCartões.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbl_ListaCartões.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_ListaCartões.ShowEditingIcon = false;
            this.Tbl_ListaCartões.Size = new System.Drawing.Size(613, 327);
            this.Tbl_ListaCartões.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaCartões.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaCartões.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_ListaCartões.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaCartões.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaCartões.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.Tbl_ListaCartões.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tbl_ListaCartões.StateCommon.DataCell.Border.Rounding = 0F;
            this.Tbl_ListaCartões.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_ListaCartões.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_ListaCartões.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaCartões.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaCartões.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_ListaCartões.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_ListaCartões.TabIndex = 95;
            this.Tbl_ListaCartões.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_ListaCartões_CellDoubleClick);
            this.Tbl_ListaCartões.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_ListaCartões_CellValueChanged);
            this.Tbl_ListaCartões.CurrentCellDirtyStateChanged += new System.EventHandler(this.Tbl_ListaCartões_CurrentCellDirtyStateChanged);
            this.Tbl_ListaCartões.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Tbl_ListaCartões_DataError);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ListaCartões
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(912, 530);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListaCartões";
            this.Text = "ListaCartões";
            this.Load += new System.EventHandler(this.ListaCartões_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_apagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaCartões)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private Krypton.Toolkit.KryptonDataGridView Tbl_ListaCartões;
        private System.Windows.Forms.PictureBox btn_apagar;
        private System.Windows.Forms.PictureBox btn_print;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComBox_turma;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_todas;
        private System.Windows.Forms.Button btn_limpar;
    }
}