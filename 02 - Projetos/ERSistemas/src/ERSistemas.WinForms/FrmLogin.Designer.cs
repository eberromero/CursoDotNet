namespace ERSistemas.WinForms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            picLogo = new PictureBox();
            panel1 = new Panel();
            pnlSenha = new ERSistemas.WinForms.Controls.RoundedPanel();
            txtSenha = new TextBox();
            pnlUsuario = new ERSistemas.WinForms.Controls.RoundedPanel();
            txtUsuario = new TextBox();
            btnFechar = new Button();
            btnEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            pnlSenha.SuspendLayout();
            pnlUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImageLayout = ImageLayout.None;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(184, 77);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pnlSenha);
            panel1.Controls.Add(pnlUsuario);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(picLogo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 259);
            panel1.TabIndex = 3;
            // 
            // pnlSenha
            // 
            pnlSenha.BackColor = Color.White;
            pnlSenha.Controls.Add(txtSenha);
            pnlSenha.Location = new Point(101, 124);
            pnlSenha.Name = "pnlSenha";
            pnlSenha.Padding = new Padding(10, 5, 10, 5);
            pnlSenha.Size = new Size(230, 27);
            pnlSenha.TabIndex = 9;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.CharacterCasing = CharacterCasing.Upper;
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Comfortaa", 9F);
            txtSenha.Location = new Point(10, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(210, 14);
            txtSenha.TabIndex = 8;
            txtSenha.Text = "EBER";
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = Color.White;
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(101, 89);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Padding = new Padding(10, 5, 10, 5);
            pnlUsuario.Size = new Size(230, 28);
            pnlUsuario.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.White;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Comfortaa", 9F);
            txtUsuario.Location = new Point(10, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 14);
            txtUsuario.TabIndex = 8;
            txtUsuario.Text = "EBER";
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFechar
            // 
            btnFechar.FlatStyle = FlatStyle.System;
            btnFechar.Location = new Point(250, 161);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(81, 29);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.System;
            btnEntrar.Location = new Point(101, 161);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(81, 29);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 259);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            pnlSenha.ResumeLayout(false);
            pnlSenha.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picLogo;
        private Panel panel1;
        private Button btnFechar;
        private Button btnEntrar;
        private Controls.RoundedPanel pnlUsuario;
        private Controls.RoundedPanel pnlSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
    }
}