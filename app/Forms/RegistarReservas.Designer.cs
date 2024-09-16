namespace app
{
    partial class RegistarReservas
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
            this.txt_NPortateis = new Krypton.Toolkit.KryptonTextBox();
            this.ComBox_Professor = new Krypton.Toolkit.KryptonComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComBox_Horario = new Krypton.Toolkit.KryptonComboBox();
            this.Tp_Data = new Krypton.Toolkit.KryptonDateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_requisitar = new Krypton.Toolkit.KryptonButton();
            this.btn_cancelar = new Krypton.Toolkit.KryptonButton();
            this.txt_turma = new Krypton.Toolkit.KryptonTextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Professor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Horario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NPortateis
            // 
            this.txt_NPortateis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_NPortateis.AutoCompleteCustomSource.AddRange(new string[] {
            "dsd"});
            this.txt_NPortateis.Location = new System.Drawing.Point(528, 421);
            this.txt_NPortateis.Name = "txt_NPortateis";
            this.txt_NPortateis.Size = new System.Drawing.Size(321, 48);
            this.txt_NPortateis.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_NPortateis.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_NPortateis.StateCommon.Border.Rounding = 15F;
            this.txt_NPortateis.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_NPortateis.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NPortateis.TabIndex = 4;
            this.txt_NPortateis.Text = "Nº Portateis";
            this.txt_NPortateis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NPortateis.WordWrap = false;
            this.txt_NPortateis.Enter += new System.EventHandler(this.txt_NPortateis_Enter);
            this.txt_NPortateis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NPortateis_KeyDown);
            this.txt_NPortateis.Leave += new System.EventHandler(this.txt_NPortateis_Leave);
            // 
            // ComBox_Professor
            // 
            this.ComBox_Professor.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.ComBox_Professor.Location = new System.Drawing.Point(528, 185);
            this.ComBox_Professor.Name = "ComBox_Professor";
            this.ComBox_Professor.Size = new System.Drawing.Size(321, 46);
            this.ComBox_Professor.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Professor.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Professor.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Professor.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Professor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Professor.TabIndex = 1;
            this.ComBox_Professor.Text = "Professor";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 54);
            this.label1.TabIndex = 60;
            this.label1.Text = "Requisições dos Portateis";
            // 
            // ComBox_Horario
            // 
            this.ComBox_Horario.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.ComBox_Horario.Location = new System.Drawing.Point(528, 265);
            this.ComBox_Horario.Name = "ComBox_Horario";
            this.ComBox_Horario.Size = new System.Drawing.Size(321, 46);
            this.ComBox_Horario.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComBox_Horario.StateCommon.ComboBox.Border.Rounding = 15F;
            this.ComBox_Horario.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.ComBox_Horario.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox_Horario.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ComBox_Horario.TabIndex = 2;
            this.ComBox_Horario.Text = "Horário";
            // 
            // Tp_Data
            // 
            this.Tp_Data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tp_Data.CalendarTodayDate = new System.DateTime(2024, 6, 5, 0, 0, 0, 0);
            this.Tp_Data.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tp_Data.Location = new System.Drawing.Point(610, 487);
            this.Tp_Data.Name = "Tp_Data";
            this.Tp_Data.Size = new System.Drawing.Size(153, 36);
            this.Tp_Data.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.Tp_Data.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tp_Data.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_requisitar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 100);
            this.panel1.TabIndex = 75;
            // 
            // btn_requisitar
            // 
            this.btn_requisitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_requisitar.CornerRoundingRadius = 20F;
            this.btn_requisitar.Location = new System.Drawing.Point(493, 24);
            this.btn_requisitar.Name = "btn_requisitar";
            this.btn_requisitar.Size = new System.Drawing.Size(185, 50);
            this.btn_requisitar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_requisitar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_requisitar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_requisitar.StateCommon.Border.Rounding = 20F;
            this.btn_requisitar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_requisitar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btn_requisitar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_requisitar.TabIndex = 72;
            this.btn_requisitar.TabStop = false;
            this.btn_requisitar.Values.Text = "Requisitar";
            this.btn_requisitar.Click += new System.EventHandler(this.btn_requisitar_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.CornerRoundingRadius = 20F;
            this.btn_cancelar.Location = new System.Drawing.Point(684, 24);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(185, 50);
            this.btn_cancelar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_cancelar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_cancelar.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cancelar.StateCommon.Border.Rounding = 20F;
            this.btn_cancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.btn_cancelar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btn_cancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.TabIndex = 71;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Values.Text = "Cancelar";
            // 
            // txt_turma
            // 
            this.txt_turma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_turma.AutoCompleteCustomSource.AddRange(new string[] {
            "dsd"});
            this.txt_turma.Location = new System.Drawing.Point(528, 346);
            this.txt_turma.Name = "txt_turma";
            this.txt_turma.Size = new System.Drawing.Size(321, 48);
            this.txt_turma.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_turma.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_turma.StateCommon.Border.Rounding = 15F;
            this.txt_turma.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_turma.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_turma.TabIndex = 3;
            this.txt_turma.Text = "Turma";
            this.txt_turma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_turma.WordWrap = false;
            this.txt_turma.Enter += new System.EventHandler(this.txt_turma_Enter);
            this.txt_turma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_turma_KeyDown);
            this.txt_turma.Leave += new System.EventHandler(this.txt_turma_Leave);
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
            this.btn_sair.TabIndex = 77;
            this.btn_sair.Text = "X";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // RegistarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 673);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_turma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tp_Data);
            this.Controls.Add(this.ComBox_Horario);
            this.Controls.Add(this.txt_NPortateis);
            this.Controls.Add(this.ComBox_Professor);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "RegistarReservas";
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Professor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBox_Horario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txt_NPortateis;
        private Krypton.Toolkit.KryptonComboBox ComBox_Professor;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonComboBox ComBox_Horario;
        private Krypton.Toolkit.KryptonDateTimePicker Tp_Data;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btn_cancelar;
        private Krypton.Toolkit.KryptonTextBox txt_turma;
        private Krypton.Toolkit.KryptonButton btn_requisitar;
        private System.Windows.Forms.Button btn_sair;
    }
}
