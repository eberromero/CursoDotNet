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
        private readonly InicializadorSistema _inicializadorSistema;
        private readonly Progress<ProgressoInicializacao> _progresso;
        public FrmSplash(InicializadorSistema inicializadorSistema)
        {
            InitializeComponent();
            _inicializadorSistema = inicializadorSistema;
            _progresso = new Progress<ProgressoInicializacao>(AtualizarProgresso);
        }

        private void AtualizarProgresso(ProgressoInicializacao progresso)
        {
            prgInicializacao.Value = progresso.Percentual;
            lblStatus.Text = progresso.Mensagem;
        }

        private async void FrmSplash_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "1.0.0.0";
            lblCopyRight.Text = $"Copyright © {DateTime.Now.Year} ERSistemas. Todos os direitos reservados.";
            await InicializarSistemaAsync();
        }

        private async Task InicializarSistemaAsync()
        {
            try
            {
                await Task.Run(() => 
                {
                    _inicializadorSistema.Inicializar(_progresso);
                });

                prgInicializacao.Value = 100; 
                lblStatus.Text = "Sistema pronto!";

                InicializacaoConcluida = true;

                await Task.Delay(1500);

                Close();
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Falha na inicialização.";
                MessageBox.Show($"Ocorreu um erro durante a inicialização do sistema: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
            }
        }

        public bool InicializacaoConcluida { get; private set; } = false;
    }
}
