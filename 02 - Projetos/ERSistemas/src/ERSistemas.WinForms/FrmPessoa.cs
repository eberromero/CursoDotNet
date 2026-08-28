using ERSistemas.Application.Services;
using ERSistemas.Domain.Enums;
using ERSistemas.Domain.Models;

namespace ERSistemas.WinForms
{
    public partial class frmPessoa : Form
    {
        private readonly PessoaService _pessoaService;

        public frmPessoa()
        {
            InitializeComponent();

            _pessoaService = new PessoaService();

            cboTipoDocumento.DataSource = Enum.GetValues<TipoDocumento>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeRazaoSocial = txtNomeRazaoSocial.Text;
                string documento = txtDocumento.Text;

                TipoDocumento tipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;

                Pessoa pessoa = _pessoaService.Cadastrar(nomeRazaoSocial, documento, tipoDocumento);

                MessageBox.Show(
                    $"Pessoa cadastrada!\n\n" +
                    $"Nome: {pessoa.NomeRazaoSocial}\n" +
                    $"Tipo: {pessoa.TipoDocumento}\n" +
                    $"Documento: {pessoa.Documento}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Atenção", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }
    }
}
