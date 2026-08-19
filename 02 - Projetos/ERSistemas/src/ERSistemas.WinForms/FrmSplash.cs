using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERSistemas.Infrastructure;

namespace ERSistemas.WinForms
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Activated(object sender, EventArgs e)
        {

        }

        private void AtualizarProgresso(
        ProgressoInicializacao progresso)
        {
            prgInicializacao.Value = progresso.Percentual;

            lblStatus.Text = progresso.Mensagem;
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "1.0.0.0";
            lblCopyRight.Text = $"Copyright © {DateTime.Now.Year} ERSistemas. Todos os direitos reservados.";
        }
    }
}
