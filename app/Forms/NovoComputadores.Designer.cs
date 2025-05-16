namespace app.Forms
{
    partial class NovoComputadores
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
            this.Tbl_ListaComputadores = new Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Outros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox_Softwares = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descrição = new System.Windows.Forms.TextBox();
            this.btn_EditarPc = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaComputadores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Tbl_ListaComputadores);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(13, 14);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(621, 590);
            this.panel6.TabIndex = 93;
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
            this.Tbl_ListaComputadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Tbl_ListaComputadores.Location = new System.Drawing.Point(31, 79);
            this.Tbl_ListaComputadores.Margin = new System.Windows.Forms.Padding(4);
            this.Tbl_ListaComputadores.MultiSelect = false;
            this.Tbl_ListaComputadores.Name = "Tbl_ListaComputadores";
            this.Tbl_ListaComputadores.ReadOnly = true;
            this.Tbl_ListaComputadores.RowHeadersVisible = false;
            this.Tbl_ListaComputadores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaComputadores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Tbl_ListaComputadores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.Tbl_ListaComputadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbl_ListaComputadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_ListaComputadores.ShowEditingIcon = false;
            this.Tbl_ListaComputadores.Size = new System.Drawing.Size(557, 487);
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
            this.Tbl_ListaComputadores.TabIndex = 124;
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
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Computadores";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Outros);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkedListBox_Softwares);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_descrição);
            this.panel1.Controls.Add(this.btn_EditarPc);
            this.panel1.Controls.Add(this.btn_limpar);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Location = new System.Drawing.Point(641, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 592);
            this.panel1.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 126;
            this.label1.Text = "outros:";
            // 
            // txt_Outros
            // 
            this.txt_Outros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Outros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Outros.Location = new System.Drawing.Point(131, 241);
            this.txt_Outros.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Outros.Name = "txt_Outros";
            this.txt_Outros.Size = new System.Drawing.Size(235, 24);
            this.txt_Outros.TabIndex = 125;
            this.txt_Outros.TextChanged += new System.EventHandler(this.txt_Outros_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 124;
            this.label4.Text = "Softwares:";
            // 
            // checkedListBox_Softwares
            // 
            this.checkedListBox_Softwares.BackColor = System.Drawing.Color.LightGray;
            this.checkedListBox_Softwares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Softwares.CheckOnClick = true;
            this.checkedListBox_Softwares.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Softwares.FormattingEnabled = true;
            this.checkedListBox_Softwares.Items.AddRange(new object[] {
            "Visual Studio",
            "Visual Code",
            "Office",
            "Adobe",
            "Cisco Packet Tracer",
            "Gantt Project",
            "Gimp"});
            this.checkedListBox_Softwares.Location = new System.Drawing.Point(51, 110);
            this.checkedListBox_Softwares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox_Softwares.Name = "checkedListBox_Softwares";
            this.checkedListBox_Softwares.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox_Softwares.Size = new System.Drawing.Size(216, 102);
            this.checkedListBox_Softwares.TabIndex = 123;
            this.checkedListBox_Softwares.TabStop = false;
            this.checkedListBox_Softwares.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Softwares_ItemCheck);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 121;
            this.label3.Text = "Descrição:";
            // 
            // txt_descrição
            // 
            this.txt_descrição.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_descrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrição.Location = new System.Drawing.Point(63, 361);
            this.txt_descrição.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descrição.Multiline = true;
            this.txt_descrição.Name = "txt_descrição";
            this.txt_descrição.Size = new System.Drawing.Size(303, 144);
            this.txt_descrição.TabIndex = 122;
            // 
            // btn_EditarPc
            // 
            this.btn_EditarPc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_EditarPc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_EditarPc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarPc.FlatAppearance.BorderSize = 0;
            this.btn_EditarPc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_EditarPc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_EditarPc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_EditarPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarPc.ForeColor = System.Drawing.Color.Black;
            this.btn_EditarPc.Location = new System.Drawing.Point(275, 521);
            this.btn_EditarPc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EditarPc.Name = "btn_EditarPc";
            this.btn_EditarPc.Size = new System.Drawing.Size(104, 46);
            this.btn_EditarPc.TabIndex = 114;
            this.btn_EditarPc.Text = "Editar PC";
            this.btn_EditarPc.UseVisualStyleBackColor = false;
            this.btn_EditarPc.Click += new System.EventHandler(this.btn_EditarPc_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.FlatAppearance.BorderSize = 0;
            this.btn_limpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_limpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.Black;
            this.btn_limpar.Location = new System.Drawing.Point(163, 521);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(104, 46);
            this.btn_limpar.TabIndex = 113;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_Salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_Salvar.Location = new System.Drawing.Point(48, 521);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(107, 46);
            this.btn_Salvar.TabIndex = 112;
            this.btn_Salvar.Text = "Adicionar";
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // NovoComputadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1087, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NovoComputadores";
            this.Text = "EditarComputadores";
            this.Load += new System.EventHandler(this.EditarComputadores_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaComputadores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_EditarPc;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Outros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox_Softwares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descrição;
        private Krypton.Toolkit.KryptonDataGridView Tbl_ListaComputadores;
    }
}