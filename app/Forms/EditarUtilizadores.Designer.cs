namespace app
{
    partial class EditarUtilizadores
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tbl_Utilizadores = new Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComBox_nivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nomeUtilizador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_CarregarFt = new System.Windows.Forms.Button();
            this.PixBox_Ftutilizador = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Utilizadores)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBox_Ftutilizador)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Tbl_Utilizadores);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 360);
            this.panel2.TabIndex = 83;
            // 
            // Tbl_Utilizadores
            // 
            this.Tbl_Utilizadores.AllowUserToAddRows = false;
            this.Tbl_Utilizadores.AllowUserToDeleteRows = false;
            this.Tbl_Utilizadores.AllowUserToResizeColumns = false;
            this.Tbl_Utilizadores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_Utilizadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tbl_Utilizadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbl_Utilizadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tbl_Utilizadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbl_Utilizadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tbl_Utilizadores.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Tbl_Utilizadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.Tbl_Utilizadores.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.Tbl_Utilizadores.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_Utilizadores.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_Utilizadores.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_Utilizadores.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.Tbl_Utilizadores.HideOuterBorders = true;
            this.Tbl_Utilizadores.Location = new System.Drawing.Point(29, 79);
            this.Tbl_Utilizadores.Margin = new System.Windows.Forms.Padding(4);
            this.Tbl_Utilizadores.MultiSelect = false;
            this.Tbl_Utilizadores.Name = "Tbl_Utilizadores";
            this.Tbl_Utilizadores.ReadOnly = true;
            this.Tbl_Utilizadores.RowHeadersVisible = false;
            this.Tbl_Utilizadores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_Utilizadores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Tbl_Utilizadores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.Tbl_Utilizadores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbl_Utilizadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_Utilizadores.ShowEditingIcon = false;
            this.Tbl_Utilizadores.Size = new System.Drawing.Size(1070, 255);
            this.Tbl_Utilizadores.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_Utilizadores.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_Utilizadores.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_Utilizadores.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_Utilizadores.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_Utilizadores.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.DimGray;
            this.Tbl_Utilizadores.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tbl_Utilizadores.StateCommon.DataCell.Border.Rounding = 0F;
            this.Tbl_Utilizadores.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_Utilizadores.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.Tbl_Utilizadores.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_Utilizadores.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_Utilizadores.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Transparent;
            this.Tbl_Utilizadores.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.Tbl_Utilizadores.TabIndex = 122;
            this.Tbl_Utilizadores.SelectionChanged += new System.EventHandler(this.Tbl_Utilizadores_SelectionChanged);
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
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Editar Utilizador";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_Id);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ComBox_nivel);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_nomeUtilizador);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txt_Senha);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btn_apagar);
            this.panel4.Controls.Add(this.btn_salvar);
            this.panel4.Controls.Add(this.btn_CarregarFt);
            this.panel4.Controls.Add(this.PixBox_Ftutilizador);
            this.panel4.Location = new System.Drawing.Point(13, 386);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 296);
            this.panel4.TabIndex = 84;
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(261, 74);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(42, 24);
            this.txt_Id.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(198, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComBox_nivel
            // 
            this.ComBox_nivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBox_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_nivel.FormattingEnabled = true;
            this.ComBox_nivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComBox_nivel.Location = new System.Drawing.Point(261, 194);
            this.ComBox_nivel.Margin = new System.Windows.Forms.Padding(4);
            this.ComBox_nivel.Name = "ComBox_nivel";
            this.ComBox_nivel.Size = new System.Drawing.Size(304, 26);
            this.ComBox_nivel.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(198, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nível:";
            // 
            // txt_nomeUtilizador
            // 
            this.txt_nomeUtilizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nomeUtilizador.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nomeUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nomeUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeUtilizador.Location = new System.Drawing.Point(261, 112);
            this.txt_nomeUtilizador.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeUtilizador.Name = "txt_nomeUtilizador";
            this.txt_nomeUtilizador.Size = new System.Drawing.Size(304, 24);
            this.txt_nomeUtilizador.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(198, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(261, 153);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(256, 24);
            this.txt_Senha.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(198, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nome:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_apagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_apagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.White;
            this.btn_apagar.Location = new System.Drawing.Point(570, 233);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(165, 46);
            this.btn_apagar.TabIndex = 17;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(397, 233);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(165, 46);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_CarregarFt
            // 
            this.btn_CarregarFt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CarregarFt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_CarregarFt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CarregarFt.FlatAppearance.BorderSize = 0;
            this.btn_CarregarFt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CarregarFt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CarregarFt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CarregarFt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CarregarFt.ForeColor = System.Drawing.Color.White;
            this.btn_CarregarFt.Location = new System.Drawing.Point(825, 190);
            this.btn_CarregarFt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CarregarFt.Name = "btn_CarregarFt";
            this.btn_CarregarFt.Size = new System.Drawing.Size(109, 28);
            this.btn_CarregarFt.TabIndex = 13;
            this.btn_CarregarFt.Text = "Import";
            this.btn_CarregarFt.UseVisualStyleBackColor = false;
            this.btn_CarregarFt.Click += new System.EventHandler(this.btn_CarregarFt_Click);
            // 
            // PixBox_Ftutilizador
            // 
            this.PixBox_Ftutilizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PixBox_Ftutilizador.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PixBox_Ftutilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PixBox_Ftutilizador.Location = new System.Drawing.Point(825, 77);
            this.PixBox_Ftutilizador.Margin = new System.Windows.Forms.Padding(4);
            this.PixBox_Ftutilizador.Name = "PixBox_Ftutilizador";
            this.PixBox_Ftutilizador.Size = new System.Drawing.Size(109, 113);
            this.PixBox_Ftutilizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixBox_Ftutilizador.TabIndex = 12;
            this.PixBox_Ftutilizador.TabStop = false;
            // 
            // EditarUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1161, 695);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarUtilizadores";
            this.Load += new System.EventHandler(this.EditarUtilizadores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_Utilizadores)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBox_Ftutilizador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_CarregarFt;
        private System.Windows.Forms.PictureBox PixBox_Ftutilizador;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComBox_nivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nomeUtilizador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label8;
        private Krypton.Toolkit.KryptonDataGridView Tbl_Utilizadores;
    }
}
