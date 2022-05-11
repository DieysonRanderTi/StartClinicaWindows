using MaterialSkin.Controls;
using StartClinica.Controller;
using StartClinica.Mensagem;
using StartClinica.Model;
using System;

namespace StartClinica.View
{
    public partial class frmCliente : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmCliente()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Orange200, MaterialSkin.TextShade.WHITE);
        }

        private void InserirCliente()
        {
            try
            {
                var cliente = new Cliente()
                {
                    Nome = txtNome.Text,
                    TelefoneContato = mskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim(),
                    CPF = mskCPF.Text.Replace(",", "").Replace("-", "").Trim(),
                    DataCadastro = DateTime.Now,
                    DataNascimento = dtpDataNascimento.Value,
                    Ativo = chkAtivo.Checked ? true : false,
                    Rua = txtRua.Text,
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    CEP = mskCEP.Text.Replace(",", "").Replace("-", "").Trim(),
                    EstadoUF = txtEstado.Text,
                    Numero = txtNumero.Text,
                    Complemento = txtComplemento.Text

                };

                ClienteController.InsertCliente(cliente);
                Mensagens.CadastroSucesso();
                LimparDados();
            }
            catch (Exception ex)
            {
                Mensagens.ErroParametros(ex.Message, "Erro");
            }
        }
        private void LimparDados()
        {
            txtNome.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            mskCPF.Text = string.Empty;
            dtpDataNascimento.Value = DateTime.Now;
            txtRua.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            mskCEP.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;

            txtNome.Focus();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }
        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            InserirCliente();
        }
    }
}
