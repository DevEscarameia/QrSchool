namespace app
{
    partial class ListaReservas
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
            this.Tbl_ListaReservas = new Krypton.Toolkit.KryptonDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.ComBox_Professor = new Krypton.Toolkit.KryptonComboBox();
            this.ComBox_Horario = new Krypton.Toolkit.KryptonComboBox();
            this.ComBox_Turmas = new Krypton.Toolkit.KryptonComboBox();
            this.ComBox_Data = new Krypton.Toolkit.KryptonComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_apagar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Professor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Horario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Tbl_ListaReservas.Location = new System.Drawing.Point(37, 123);
            this.Tbl_ListaReservas.MultiSelect = false;
            this.Tbl_ListaReservas.Name = "Tbl_ListaReservas";
            this.Tbl_ListaReservas.ReadOnly = true;
            this.Tbl_ListaReservas.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Tbl_ListaReservas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Tbl_ListaReservas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Tbl_ListaReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tbl_ListaReservas.ShowEditingIcon = false;
            this.Tbl_ListaReservas.Size = new System.Drawing.Size(515, 264);
            this.Tbl_ListaReservas.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaReservas.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.Tbl_ListaReservas.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.Tbl_ListaReservas.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.Tbl_ListaReservas.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.Tbl_ListaReservas.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.Tbl_ListaReservas.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Tbl_ListaReservas.StateCommon.DataCell.Border.Rounding = 0F;
            this.Tbl_ListaReservas.TabIndex = 81;
            this.Tbl_ListaReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_ListaReservas_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(584, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 56);
            this.button1.TabIndex = 76;
            this.button1.Text = "Limpar Filtros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Lista de Reservas";
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(31, 32);
            this.btn_sair.TabIndex = 82;
            this.btn_sair.Text = "X";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button6_Click);
            // 
            // ComBox_Professor
            // 
            this.ComBox_Professor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComBox_Professor.CornerRoundingRadius = 15F;
            this.ComBox_Professor.DropDownWidth = 311;
            this.ComBox_Professor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComBox_Professor.IntegralHeight = false;
            this.ComBox_Professor.Items.AddRange(new object[] {
            "Técnico de Logística",
            "Técnico de Gestão e Prog. de Sistemas Informáticos",
            "Técnico de Turismo",
            "Técnico de Comunicação, Marketing, Relações Públicas e Publicidade",
            "Técnico de Comércio",
            "Animador Sociocultural"});
            this.ComBox_Professor.Location = new System.Drawing.Point(584, 123);
            this.ComBox_Professor.Name = "ComBox_Professor";
            this.ComBox_Professor.Size = new System.Drawing.Size(150, 46);
            this.ComBox_Professor.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Professor.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Professor.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Professor.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Professor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Professor.TabIndex = 83;
            this.ComBox_Professor.Text = "Professor";
            this.ComBox_Professor.SelectedIndexChanged += new System.EventHandler(this.ComBox_Professor_SelectedIndexChanged);
            // 
            // ComBox_Horario
            // 
            this.ComBox_Horario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComBox_Horario.CornerRoundingRadius = 15F;
            this.ComBox_Horario.DropDownWidth = 311;
            this.ComBox_Horario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComBox_Horario.IntegralHeight = false;
            this.ComBox_Horario.Items.AddRange(new object[] {
            "8:30 as 9:30",
            "9:40 as 10:40",
            "11:00 as 12:00",
            "12:00 as 13:00",
            "14:00 as 15:00",
            "15:10 as 16:00",
            "16:15 as 17:15"});
            this.ComBox_Horario.Location = new System.Drawing.Point(584, 175);
            this.ComBox_Horario.Name = "ComBox_Horario";
            this.ComBox_Horario.Size = new System.Drawing.Size(150, 46);
            this.ComBox_Horario.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Horario.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Horario.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Horario.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Horario.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Horario.TabIndex = 84;
            this.ComBox_Horario.Text = "Horário";
            this.ComBox_Horario.SelectedIndexChanged += new System.EventHandler(this.ComBox_Horario_SelectedIndexChanged);
            // 
            // ComBox_Turmas
            // 
            this.ComBox_Turmas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComBox_Turmas.CornerRoundingRadius = 15F;
            this.ComBox_Turmas.DropDownWidth = 311;
            this.ComBox_Turmas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComBox_Turmas.IntegralHeight = false;
            this.ComBox_Turmas.Items.AddRange(new object[] {
            "8:30 as 9:30",
            "9:40 as 10:40",
            "11:00 as 12:00",
            "12:00 as 13:00",
            "14:00 as 15:00",
            "15:10 as 16:00",
            "16:15 as 17:15"});
            this.ComBox_Turmas.Location = new System.Drawing.Point(584, 227);
            this.ComBox_Turmas.Name = "ComBox_Turmas";
            this.ComBox_Turmas.Size = new System.Drawing.Size(150, 46);
            this.ComBox_Turmas.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Turmas.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Turmas.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Turmas.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Turmas.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Turmas.TabIndex = 85;
            this.ComBox_Turmas.Text = "Turma";
            this.ComBox_Turmas.SelectedIndexChanged += new System.EventHandler(this.ComBox_Turmas_SelectedIndexChanged);
            // 
            // ComBox_Data
            // 
            this.ComBox_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComBox_Data.CornerRoundingRadius = 15F;
            this.ComBox_Data.DropDownWidth = 311;
            this.ComBox_Data.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComBox_Data.IntegralHeight = false;
            this.ComBox_Data.Items.AddRange(new object[] {
            "8:30 as 9:30",
            "9:40 as 10:40",
            "11:00 as 12:00",
            "12:00 as 13:00",
            "14:00 as 15:00",
            "15:10 as 16:00",
            "16:15 as 17:15"});
            this.ComBox_Data.Location = new System.Drawing.Point(584, 279);
            this.ComBox_Data.Name = "ComBox_Data";
            this.ComBox_Data.Size = new System.Drawing.Size(150, 46);
            this.ComBox_Data.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Data.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Data.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Data.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Data.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Data.TabIndex = 86;
            this.ComBox_Data.Text = "Data";
            this.ComBox_Data.SelectedIndexChanged += new System.EventHandler(this.ComBox_Data_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_apagar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 73);
            this.panel1.TabIndex = 87;
            // 
            // btn_apagar
            // 
            this.btn_apagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_apagar.CornerRoundingRadius = 20F;
            this.btn_apagar.Location = new System.Drawing.Point(296, 11);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(185, 50);
            this.btn_apagar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_apagar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_apagar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_apagar.StateCommon.Border.Rounding = 20F;
            this.btn_apagar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_apagar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btn_apagar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.TabIndex = 70;
            this.btn_apagar.TabStop = false;
            this.btn_apagar.Values.Text = "Apagar";
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // ListaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(777, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ComBox_Data);
            this.Controls.Add(this.ComBox_Turmas);
            this.Controls.Add(this.ComBox_Horario);
            this.Controls.Add(this.ComBox_Professor);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.Tbl_ListaReservas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ListaReservas";
            this.Load += new System.EventHandler(this.ListaReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Professor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Horario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView Tbl_ListaReservas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
        private Krypton.Toolkit.KryptonComboBox ComBox_Professor;
        private Krypton.Toolkit.KryptonComboBox ComBox_Horario;
        private Krypton.Toolkit.KryptonComboBox ComBox_Turmas;
        private Krypton.Toolkit.KryptonComboBox ComBox_Data;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btn_apagar;
    }
}
