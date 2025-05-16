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
            this.panel4 = new System.Windows.Forms.Panel();
            this.Combox_Turma = new System.Windows.Forms.ComboBox();
            this.ComBox_HFim = new System.Windows.Forms.ComboBox();
            this.ComBox_HInicio = new System.Windows.Forms.ComboBox();
            this.Tp_Data = new Krypton.Toolkit.KryptonDateTimePicker();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComBox_Professor = new System.Windows.Forms.ComboBox();
            this.txt_NPortateis = new System.Windows.Forms.TextBox();
            this.lbl_NPortateis = new System.Windows.Forms.Label();
            this.lbl_turma = new System.Windows.Forms.Label();
            this.lbl_Horario = new System.Windows.Forms.Label();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_todas = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.txt_FiltroProfessor = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbl_ListaReservas = new Krypton.Toolkit.KryptonDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Combox_Turma);
            this.panel4.Controls.Add(this.ComBox_HFim);
            this.panel4.Controls.Add(this.ComBox_HInicio);
            this.panel4.Controls.Add(this.Tp_Data);
            this.panel4.Controls.Add(this.txt_Id);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.ComBox_Professor);
            this.panel4.Controls.Add(this.txt_NPortateis);
            this.panel4.Controls.Add(this.lbl_NPortateis);
            this.panel4.Controls.Add(this.lbl_turma);
            this.panel4.Controls.Add(this.lbl_Horario);
            this.panel4.Controls.Add(this.lbl_Professor);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_salvar);
            this.panel4.Location = new System.Drawing.Point(13, 441);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 242);
            this.panel4.TabIndex = 94;
            // 
            // Combox_Turma
            // 
            this.Combox_Turma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combox_Turma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combox_Turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combox_Turma.FormattingEnabled = true;
            this.Combox_Turma.Location = new System.Drawing.Point(277, 119);
            this.Combox_Turma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Combox_Turma.Name = "Combox_Turma";
            this.Combox_Turma.Size = new System.Drawing.Size(249, 26);
            this.Combox_Turma.TabIndex = 127;
            // 
            // ComBox_HFim
            // 
            this.ComBox_HFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBox_HFim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_HFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_HFim.FormattingEnabled = true;
            this.ComBox_HFim.Location = new System.Drawing.Point(405, 82);
            this.ComBox_HFim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComBox_HFim.Name = "ComBox_HFim";
            this.ComBox_HFim.Size = new System.Drawing.Size(121, 26);
            this.ComBox_HFim.TabIndex = 126;
            // 
            // ComBox_HInicio
            // 
            this.ComBox_HInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBox_HInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_HInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_HInicio.FormattingEnabled = true;
            this.ComBox_HInicio.Location = new System.Drawing.Point(277, 82);
            this.ComBox_HInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComBox_HInicio.Name = "ComBox_HInicio";
            this.ComBox_HInicio.Size = new System.Drawing.Size(121, 26);
            this.ComBox_HInicio.TabIndex = 125;
            // 
            // Tp_Data
            // 
            this.Tp_Data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tp_Data.CalendarTodayDate = new System.DateTime(2024, 6, 5, 0, 0, 0, 0);
            this.Tp_Data.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tp_Data.Enabled = false;
            this.Tp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tp_Data.Location = new System.Drawing.Point(723, 142);
            this.Tp_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tp_Data.Name = "Tp_Data";
            this.Tp_Data.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Tp_Data.Size = new System.Drawing.Size(164, 30);
            this.Tp_Data.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.Tp_Data.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_Data.TabIndex = 124;
            // 
            // txt_Id
            // 
            this.txt_Id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Id.Enabled = false;
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(277, 16);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(41, 24);
            this.txt_Id.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 122;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComBox_Professor
            // 
            this.ComBox_Professor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBox_Professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBox_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Professor.FormattingEnabled = true;
            this.ComBox_Professor.Location = new System.Drawing.Point(277, 48);
            this.ComBox_Professor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComBox_Professor.Name = "ComBox_Professor";
            this.ComBox_Professor.Size = new System.Drawing.Size(304, 26);
            this.ComBox_Professor.TabIndex = 118;
            // 
            // txt_NPortateis
            // 
            this.txt_NPortateis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NPortateis.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NPortateis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NPortateis.Location = new System.Drawing.Point(277, 154);
            this.txt_NPortateis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NPortateis.Name = "txt_NPortateis";
            this.txt_NPortateis.Size = new System.Drawing.Size(249, 24);
            this.txt_NPortateis.TabIndex = 121;
            // 
            // lbl_NPortateis
            // 
            this.lbl_NPortateis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NPortateis.AutoSize = true;
            this.lbl_NPortateis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NPortateis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NPortateis.ForeColor = System.Drawing.Color.Black;
            this.lbl_NPortateis.Location = new System.Drawing.Point(179, 154);
            this.lbl_NPortateis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NPortateis.Name = "lbl_NPortateis";
            this.lbl_NPortateis.Size = new System.Drawing.Size(91, 18);
            this.lbl_NPortateis.TabIndex = 117;
            this.lbl_NPortateis.Text = "Nº Portateis:";
            this.lbl_NPortateis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_turma
            // 
            this.lbl_turma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.BackColor = System.Drawing.Color.Transparent;
            this.lbl_turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turma.ForeColor = System.Drawing.Color.Black;
            this.lbl_turma.Location = new System.Drawing.Point(213, 122);
            this.lbl_turma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(55, 18);
            this.lbl_turma.TabIndex = 116;
            this.lbl_turma.Text = "Turma:";
            this.lbl_turma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Horario
            // 
            this.lbl_Horario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Horario.AutoSize = true;
            this.lbl_Horario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horario.ForeColor = System.Drawing.Color.Black;
            this.lbl_Horario.Location = new System.Drawing.Point(207, 90);
            this.lbl_Horario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Horario.Name = "lbl_Horario";
            this.lbl_Horario.Size = new System.Drawing.Size(62, 18);
            this.lbl_Horario.TabIndex = 115;
            this.lbl_Horario.Text = "Horario:";
            this.lbl_Horario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Professor
            // 
            this.lbl_Professor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Professor.AutoSize = true;
            this.lbl_Professor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Professor.ForeColor = System.Drawing.Color.Black;
            this.lbl_Professor.Location = new System.Drawing.Point(191, 50);
            this.lbl_Professor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Size = new System.Drawing.Size(78, 18);
            this.lbl_Professor.TabIndex = 114;
            this.lbl_Professor.Text = "Professor:";
            this.lbl_Professor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(589, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_apagar_Click);
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
            this.btn_salvar.ForeColor = System.Drawing.Color.Black;
            this.btn_salvar.Location = new System.Drawing.Point(416, 186);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(165, 46);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_todas);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.txt_FiltroProfessor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Tbl_ListaReservas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(13, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 416);
            this.panel2.TabIndex = 95;
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
            this.btn_todas.Location = new System.Drawing.Point(179, 84);
            this.btn_todas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_todas.Name = "btn_todas";
            this.btn_todas.Size = new System.Drawing.Size(104, 30);
            this.btn_todas.TabIndex = 128;
            this.btn_todas.Text = "Totas";
            this.btn_todas.UseVisualStyleBackColor = false;
            this.btn_todas.Click += new System.EventHandler(this.btn_todas_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(65, 86);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(104, 22);
            this.dateTimePicker3.TabIndex = 127;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // txt_FiltroProfessor
            // 
            this.txt_FiltroProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FiltroProfessor.Location = new System.Drawing.Point(379, 85);
            this.txt_FiltroProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FiltroProfessor.Name = "txt_FiltroProfessor";
            this.txt_FiltroProfessor.Size = new System.Drawing.Size(196, 27);
            this.txt_FiltroProfessor.TabIndex = 125;
            this.txt_FiltroProfessor.TextChanged += new System.EventHandler(this.txt_FiltroProfessor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(293, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 124;
            this.label2.Text = "Professor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 123;
            this.label3.Text = "Data:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Tbl_ListaReservas.Location = new System.Drawing.Point(29, 119);
            this.Tbl_ListaReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.Tbl_ListaReservas.Size = new System.Drawing.Size(1069, 270);
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
            this.Tbl_ListaReservas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tbl_ListaReservas_CellDoubleClick);
            this.Tbl_ListaReservas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Tbl_ListaReservas_CellFormatting);
            this.Tbl_ListaReservas.SelectionChanged += new System.EventHandler(this.Tbl_ListaReservas_SelectionChanged);
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
            this.label5.Size = new System.Drawing.Size(201, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lista de Reservas";
            // 
            // ListaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1161, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListaReservas";
            this.Load += new System.EventHandler(this.ListaReservas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_ListaReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComBox_Professor;
        private System.Windows.Forms.TextBox txt_NPortateis;
        private System.Windows.Forms.Label lbl_NPortateis;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.Label lbl_Horario;
        private System.Windows.Forms.Label lbl_Professor;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDateTimePicker Tp_Data;
        private System.Windows.Forms.ComboBox ComBox_HFim;
        private System.Windows.Forms.ComboBox ComBox_HInicio;
        private Krypton.Toolkit.KryptonDataGridView Tbl_ListaReservas;
        private System.Windows.Forms.ComboBox Combox_Turma;
        private System.Windows.Forms.MaskedTextBox txt_FiltroProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btn_todas;
    }
}
