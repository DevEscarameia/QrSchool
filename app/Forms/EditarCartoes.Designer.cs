namespace app.Forms
{
    partial class EditarCartoes
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnl_cartao = new System.Windows.Forms.Panel();
            this.PicBox_ftAluno = new System.Windows.Forms.PictureBox();
            this.lbl_trienio = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.pnl_Qrcode = new System.Windows.Forms.Panel();
            this.PixBox_qrcode = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ComBox_Curso = new System.Windows.Forms.ComboBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_CarregarFt = new System.Windows.Forms.Button();
            this.txt_trienio = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_NPortateis = new System.Windows.Forms.Label();
            this.lbl_turma = new System.Windows.Forms.Label();
            this.lbl_Horario = new System.Windows.Forms.Label();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            this.pnl_cartao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ftAluno)).BeginInit();
            this.pnl_Qrcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixBox_qrcode)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pnl_cartao);
            this.panel6.Controls.Add(this.pnl_Qrcode);
            this.panel6.Location = new System.Drawing.Point(13, 14);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1135, 419);
            this.panel6.TabIndex = 95;
            // 
            // pnl_cartao
            // 
            this.pnl_cartao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_cartao.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cartao.BackgroundImage = global::app.Properties.Resources.CartaoEscola__1_1;
            this.pnl_cartao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_cartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cartao.Controls.Add(this.PicBox_ftAluno);
            this.pnl_cartao.Controls.Add(this.lbl_trienio);
            this.pnl_cartao.Controls.Add(this.lbl_Curso);
            this.pnl_cartao.Controls.Add(this.lbl_nome);
            this.pnl_cartao.Controls.Add(this.lbl_numero);
            this.pnl_cartao.Location = new System.Drawing.Point(171, 25);
            this.pnl_cartao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_cartao.Name = "pnl_cartao";
            this.pnl_cartao.Size = new System.Drawing.Size(778, 369);
            this.pnl_cartao.TabIndex = 9;
            this.pnl_cartao.DoubleClick += new System.EventHandler(this.pnl_cartao_DoubleClick);
            // 
            // PicBox_ftAluno
            // 
            this.PicBox_ftAluno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBox_ftAluno.BackColor = System.Drawing.Color.Transparent;
            this.PicBox_ftAluno.Image = global::app.Properties.Resources.pessoa_desconhecida;
            this.PicBox_ftAluno.Location = new System.Drawing.Point(631, 16);
            this.PicBox_ftAluno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PicBox_ftAluno.Name = "PicBox_ftAluno";
            this.PicBox_ftAluno.Size = new System.Drawing.Size(111, 123);
            this.PicBox_ftAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_ftAluno.TabIndex = 4;
            this.PicBox_ftAluno.TabStop = false;
            // 
            // lbl_trienio
            // 
            this.lbl_trienio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_trienio.AutoSize = true;
            this.lbl_trienio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_trienio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trienio.ForeColor = System.Drawing.Color.Black;
            this.lbl_trienio.Location = new System.Drawing.Point(389, 192);
            this.lbl_trienio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trienio.Name = "lbl_trienio";
            this.lbl_trienio.Size = new System.Drawing.Size(90, 29);
            this.lbl_trienio.TabIndex = 3;
            this.lbl_trienio.Text = "fffffffffff";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Curso.ForeColor = System.Drawing.Color.Black;
            this.lbl_Curso.Location = new System.Drawing.Point(105, 225);
            this.lbl_Curso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(90, 29);
            this.lbl_Curso.TabIndex = 2;
            this.lbl_Curso.Text = "fffffffffff";
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(107, 153);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(90, 29);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "fffffffffff";
            // 
            // lbl_numero
            // 
            this.lbl_numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero.ForeColor = System.Drawing.Color.Black;
            this.lbl_numero.Location = new System.Drawing.Point(136, 192);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(90, 29);
            this.lbl_numero.TabIndex = 1;
            this.lbl_numero.Text = "fffffffffff";
            // 
            // pnl_Qrcode
            // 
            this.pnl_Qrcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Qrcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(116)))), ((int)(((byte)(0)))));
            this.pnl_Qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Qrcode.Controls.Add(this.PixBox_qrcode);
            this.pnl_Qrcode.Location = new System.Drawing.Point(171, 25);
            this.pnl_Qrcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Qrcode.Name = "pnl_Qrcode";
            this.pnl_Qrcode.Size = new System.Drawing.Size(778, 369);
            this.pnl_Qrcode.TabIndex = 10;
            this.pnl_Qrcode.DoubleClick += new System.EventHandler(this.pnl_Qrcode_DoubleClick);
            // 
            // PixBox_qrcode
            // 
            this.PixBox_qrcode.Location = new System.Drawing.Point(-1, -1);
            this.PixBox_qrcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PixBox_qrcode.Name = "PixBox_qrcode";
            this.PixBox_qrcode.Size = new System.Drawing.Size(779, 369);
            this.PixBox_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PixBox_qrcode.TabIndex = 0;
            this.PixBox_qrcode.TabStop = false;
            this.PixBox_qrcode.DoubleClick += new System.EventHandler(this.PixBox_qrcode_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ComBox_Curso);
            this.panel4.Controls.Add(this.btn_Voltar);
            this.panel4.Controls.Add(this.btn_CarregarFt);
            this.panel4.Controls.Add(this.txt_trienio);
            this.panel4.Controls.Add(this.txt_numero);
            this.panel4.Controls.Add(this.txt_Nome);
            this.panel4.Controls.Add(this.lbl_NPortateis);
            this.panel4.Controls.Add(this.lbl_turma);
            this.panel4.Controls.Add(this.lbl_Horario);
            this.panel4.Controls.Add(this.lbl_Professor);
            this.panel4.Controls.Add(this.btn_salvar);
            this.panel4.Location = new System.Drawing.Point(13, 441);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1135, 241);
            this.panel4.TabIndex = 98;
            // 
            // ComBox_Curso
            // 
            this.ComBox_Curso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComBox_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Curso.FormattingEnabled = true;
            this.ComBox_Curso.Items.AddRange(new object[] {
            "Técnico de Logística",
            "Técnico de Gestão e Prog. de Sistemas Informáticos",
            "Técnico de Turismo",
            "Técnico de Gestão",
            "Técnico de Informática de Gestão",
            "Técnico de Comunicação, Marketing, Relações Públicas e Publicidade",
            "Técnico de Comércio",
            "Animador Sociocultural"});
            this.ComBox_Curso.Location = new System.Drawing.Point(317, 132);
            this.ComBox_Curso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComBox_Curso.Name = "ComBox_Curso";
            this.ComBox_Curso.Size = new System.Drawing.Size(505, 26);
            this.ComBox_Curso.TabIndex = 133;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Voltar.FlatAppearance.BorderSize = 0;
            this.btn_Voltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Voltar.Location = new System.Drawing.Point(571, 174);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(165, 46);
            this.btn_Voltar.TabIndex = 132;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
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
            this.btn_CarregarFt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CarregarFt.Location = new System.Drawing.Point(701, 34);
            this.btn_CarregarFt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CarregarFt.Name = "btn_CarregarFt";
            this.btn_CarregarFt.Size = new System.Drawing.Size(109, 28);
            this.btn_CarregarFt.TabIndex = 131;
            this.btn_CarregarFt.Text = "Import";
            this.btn_CarregarFt.UseVisualStyleBackColor = false;
            this.btn_CarregarFt.Click += new System.EventHandler(this.btn_CarregarFt_Click);
            // 
            // txt_trienio
            // 
            this.txt_trienio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_trienio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trienio.Location = new System.Drawing.Point(317, 98);
            this.txt_trienio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_trienio.Name = "txt_trienio";
            this.txt_trienio.Size = new System.Drawing.Size(304, 24);
            this.txt_trienio.TabIndex = 130;
            this.txt_trienio.TextChanged += new System.EventHandler(this.txt_trienio_TextChanged);
            this.txt_trienio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trienio_KeyPress);
            // 
            // txt_numero
            // 
            this.txt_numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_numero.BackColor = System.Drawing.SystemColors.Window;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(317, 66);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(135, 24);
            this.txt_numero.TabIndex = 128;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(317, 34);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(255, 24);
            this.txt_Nome.TabIndex = 127;
            // 
            // lbl_NPortateis
            // 
            this.lbl_NPortateis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NPortateis.AutoSize = true;
            this.lbl_NPortateis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NPortateis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NPortateis.ForeColor = System.Drawing.Color.Black;
            this.lbl_NPortateis.Location = new System.Drawing.Point(259, 134);
            this.lbl_NPortateis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NPortateis.Name = "lbl_NPortateis";
            this.lbl_NPortateis.Size = new System.Drawing.Size(53, 18);
            this.lbl_NPortateis.TabIndex = 117;
            this.lbl_NPortateis.Text = "Curso:";
            this.lbl_NPortateis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_turma
            // 
            this.lbl_turma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_turma.AutoSize = true;
            this.lbl_turma.BackColor = System.Drawing.Color.Transparent;
            this.lbl_turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turma.ForeColor = System.Drawing.Color.Black;
            this.lbl_turma.Location = new System.Drawing.Point(255, 101);
            this.lbl_turma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_turma.Name = "lbl_turma";
            this.lbl_turma.Size = new System.Drawing.Size(57, 18);
            this.lbl_turma.TabIndex = 116;
            this.lbl_turma.Text = "Triénio:";
            this.lbl_turma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Horario
            // 
            this.lbl_Horario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Horario.AutoSize = true;
            this.lbl_Horario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Horario.ForeColor = System.Drawing.Color.Black;
            this.lbl_Horario.Location = new System.Drawing.Point(245, 69);
            this.lbl_Horario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Horario.Name = "lbl_Horario";
            this.lbl_Horario.Size = new System.Drawing.Size(66, 18);
            this.lbl_Horario.TabIndex = 115;
            this.lbl_Horario.Text = "Numero:";
            this.lbl_Horario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Professor
            // 
            this.lbl_Professor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Professor.AutoSize = true;
            this.lbl_Professor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Professor.ForeColor = System.Drawing.Color.Black;
            this.lbl_Professor.Location = new System.Drawing.Point(261, 36);
            this.lbl_Professor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Size = new System.Drawing.Size(49, 18);
            this.lbl_Professor.TabIndex = 114;
            this.lbl_Professor.Text = "Aluno:";
            this.lbl_Professor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_salvar.Location = new System.Drawing.Point(397, 174);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(165, 46);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // EditarCartoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1161, 695);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditarCartoes";
            this.Text = "EditarCartoes";
            this.panel6.ResumeLayout(false);
            this.pnl_cartao.ResumeLayout(false);
            this.pnl_cartao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ftAluno)).EndInit();
            this.pnl_Qrcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PixBox_qrcode)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_NPortateis;
        private System.Windows.Forms.Label lbl_turma;
        private System.Windows.Forms.Label lbl_Horario;
        private System.Windows.Forms.Label lbl_Professor;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_trienio;
        private System.Windows.Forms.Panel pnl_cartao;
        private System.Windows.Forms.PictureBox PicBox_ftAluno;
        private System.Windows.Forms.Label lbl_trienio;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Panel pnl_Qrcode;
        private System.Windows.Forms.Button btn_CarregarFt;
        private System.Windows.Forms.PictureBox PixBox_qrcode;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.ComboBox ComBox_Curso;
    }
}