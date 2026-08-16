namespace ERSistemas.WinForms
{
    partial class frmPessoa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNomeRazaoSocial = new Label();
            txtNomeRazaoSocial = new TextBox();
            lblTipoDocumento = new Label();
            cboTipoDocumento = new ComboBox();
            txtDocumento = new TextBox();
            lblDocumento = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNomeRazaoSocial
            // 
            lblNomeRazaoSocial.AutoSize = true;
            lblNomeRazaoSocial.Location = new Point(12, 21);
            lblNomeRazaoSocial.Name = "lblNomeRazaoSocial";
            lblNomeRazaoSocial.Size = new Size(113, 15);
            lblNomeRazaoSocial.TabIndex = 0;
            lblNomeRazaoSocial.Text = "Nome/Razão Social:";
            // 
            // txtNomeRazaoSocial
            // 
            txtNomeRazaoSocial.Location = new Point(129, 17);
            txtNomeRazaoSocial.Name = "txtNomeRazaoSocial";
            txtNomeRazaoSocial.Size = new Size(179, 23);
            txtNomeRazaoSocial.TabIndex = 1;
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(25, 46);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(100, 15);
            lblTipoDocumento.TabIndex = 2;
            lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(129, 42);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(75, 23);
            cboTipoDocumento.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(129, 67);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(177, 23);
            txtDocumento.TabIndex = 5;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(52, 73);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(73, 15);
            lblDocumento.TabIndex = 4;
            lblDocumento.Text = "Documento:";
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Location = new Point(12, 200);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 236);
            Controls.Add(btnSalvar);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(cboTipoDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(txtNomeRazaoSocial);
            Controls.Add(lblNomeRazaoSocial);
            Name = "frmPessoa";
            Text = "Cadastro de Pessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeRazaoSocial;
        private TextBox txtNomeRazaoSocial;
        private Label lblTipoDocumento;
        private ComboBox cboTipoDocumento;
        private TextBox txtDocumento;
        private Label lblDocumento;
        private Button btnSalvar;
    }
}
