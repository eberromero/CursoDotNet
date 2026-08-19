namespace ERSistemas.WinForms
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            lblStatusTitulo = new Label();
            picLogo = new PictureBox();
            pnlFundo = new Panel();
            pnlRodape = new Panel();
            lblCopyRight = new Label();
            lblVersao = new Label();
            label2 = new Label();
            prgInicializacao = new ProgressBar();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlFundo.SuspendLayout();
            pnlRodape.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatusTitulo
            // 
            lblStatusTitulo.BackColor = Color.Transparent;
            lblStatusTitulo.Font = new Font("Comfortaa", 12F, FontStyle.Bold);
            lblStatusTitulo.ForeColor = SystemColors.Window;
            lblStatusTitulo.Location = new Point(0, -2);
            lblStatusTitulo.Name = "lblStatusTitulo";
            lblStatusTitulo.Size = new Size(225, 22);
            lblStatusTitulo.TabIndex = 1;
            lblStatusTitulo.Text = "Inicializando Sistema...";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(133, 41);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(329, 133);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // pnlFundo
            // 
            pnlFundo.BackgroundImage = Properties.Resources.fundo;
            pnlFundo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlFundo.Controls.Add(pnlRodape);
            pnlFundo.Controls.Add(picLogo);
            pnlFundo.Dock = DockStyle.Fill;
            pnlFundo.Location = new Point(0, 0);
            pnlFundo.Name = "pnlFundo";
            pnlFundo.Size = new Size(600, 380);
            pnlFundo.TabIndex = 7;
            // 
            // pnlRodape
            // 
            pnlRodape.BackColor = Color.Transparent;
            pnlRodape.BackgroundImage = (Image)resources.GetObject("pnlRodape.BackgroundImage");
            pnlRodape.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRodape.Controls.Add(lblCopyRight);
            pnlRodape.Controls.Add(lblVersao);
            pnlRodape.Controls.Add(label2);
            pnlRodape.Controls.Add(prgInicializacao);
            pnlRodape.Controls.Add(lblStatus);
            pnlRodape.Controls.Add(lblStatusTitulo);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(0, 300);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(600, 80);
            pnlRodape.TabIndex = 8;
            // 
            // lblCopyRight
            // 
            lblCopyRight.BackColor = Color.Transparent;
            lblCopyRight.Font = new Font("Comfortaa", 8F, FontStyle.Bold);
            lblCopyRight.ForeColor = Color.White;
            lblCopyRight.Location = new Point(101, 59);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(468, 18);
            lblCopyRight.TabIndex = 9;
            lblCopyRight.Text = "|         ©Date ERSistemas. Todos os direitos reservados.\r\n";
            // 
            // lblVersao
            // 
            lblVersao.BackColor = Color.Transparent;
            lblVersao.Font = new Font("Comfortaa", 8F, FontStyle.Bold);
            lblVersao.ForeColor = Color.White;
            lblVersao.Location = new Point(50, 59);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(54, 18);
            lblVersao.TabIndex = 8;
            lblVersao.Text = "1.0.0.0";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comfortaa", 8F, FontStyle.Bold);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 7;
            label2.Text = "Versão";
            // 
            // prgInicializacao
            // 
            prgInicializacao.Location = new Point(6, 45);
            prgInicializacao.Name = "prgInicializacao";
            prgInicializacao.Size = new Size(244, 11);
            prgInicializacao.TabIndex = 2;
            prgInicializacao.Value = 50;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Comfortaa", 8F, FontStyle.Bold);
            lblStatus.ForeColor = Color.DodgerBlue;
            lblStatus.Location = new Point(3, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(436, 18);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Conectando ao banco de dados...";
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(600, 380);
            ControlBox = false;
            Controls.Add(pnlFundo);
            ForeColor = Color.FromArgb(0, 0, 64);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSplash";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ERSistemas";
            TopMost = true;
            Activated += FrmSplash_Activated;
            Load += FrmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlFundo.ResumeLayout(false);
            pnlRodape.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblStatusTitulo;
        private ProgressBar prgInicializacao;
        private Label lblStatus;
        private PictureBox picLogo;
        private Panel pnlFundo;
        private Panel pnlRodape;
        private Label lblCopyRight;
        private Label lblVersao;
        private Label label2;
    }
}