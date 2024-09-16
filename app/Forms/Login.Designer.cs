namespace app.Forms
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Label();
            this.kryptonButton1 = new System.Windows.Forms.Button();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.txt_palavraPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_utilizador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 492);
            this.panel1.TabIndex = 58;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::app.Properties.Resources.Logo_200x75;
            this.pictureBox2.Location = new System.Drawing.Point(67, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(733, 9);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(21, 23);
            this.btn_cancelar.TabIndex = 71;
            this.btn_cancelar.Text = "X";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(134)))));
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.FlatAppearance.BorderSize = 0;
            this.kryptonButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kryptonButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.ForeColor = System.Drawing.Color.White;
            this.kryptonButton1.Location = new System.Drawing.Point(387, 359);
            this.kryptonButton1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(124, 42);
            this.kryptonButton1.TabIndex = 70;
            this.kryptonButton1.Text = "LOGIN";
            this.kryptonButton1.UseVisualStyleBackColor = false;
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass.Location = new System.Drawing.Point(585, 311);
            this.login_showPass.Margin = new System.Windows.Forms.Padding(4);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(130, 22);
            this.login_showPass.TabIndex = 69;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // txt_palavraPass
            // 
            this.txt_palavraPass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_palavraPass.Location = new System.Drawing.Point(387, 267);
            this.txt_palavraPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_palavraPass.Multiline = true;
            this.txt_palavraPass.Name = "txt_palavraPass";
            this.txt_palavraPass.PasswordChar = '*';
            this.txt_palavraPass.Size = new System.Drawing.Size(347, 36);
            this.txt_palavraPass.TabIndex = 68;
            this.txt_palavraPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_palavraPass_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 67;
            this.label4.Text = "Password:";
            // 
            // txt_utilizador
            // 
            this.txt_utilizador.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_utilizador.Location = new System.Drawing.Point(387, 188);
            this.txt_utilizador.Margin = new System.Windows.Forms.Padding(4);
            this.txt_utilizador.Multiline = true;
            this.txt_utilizador.Name = "txt_utilizador";
            this.txt_utilizador.Size = new System.Drawing.Size(347, 36);
            this.txt_utilizador.TabIndex = 66;
            this.txt_utilizador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_utilizador_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 65;
            this.label3.Text = "Username:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(767, 492);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.txt_palavraPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_utilizador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label btn_cancelar;
        private System.Windows.Forms.Button kryptonButton1;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.TextBox txt_palavraPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_utilizador;
        private System.Windows.Forms.Label label3;
    }
}