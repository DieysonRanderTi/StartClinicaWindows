using StartClinica.Controller;
using StartClinica.Mensagem;
using StartClinica.Model;
using System;
using System.Windows.Forms;

namespace StartClinica.View
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            GerarDataGrid();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            InserirCliente();
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
                BuscarClientes();
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
            BuscarClientes();
        }
        private void BuscarClientes()
        {
            var clientes = ClienteController.GetClientes();

            foreach (var cliente in clientes)
            {
                dataGridViewLista.Rows.Add
                    (
                        cliente.Nome,
                        cliente.TelefoneContato,
                        cliente.Rua + " Nº " + cliente.Numero,
                        cliente.Bairro,
                        cliente.Cidade
                    );
            }
        }
        private void GerarDataGrid()
        {
            dataGridViewLista.ColumnCount = 5;
            dataGridViewLista.Columns[0].Name = "NOME";
            dataGridViewLista.Columns[0].Width = 200;
            dataGridViewLista.Columns[1].Name = "TELEFONE";
            dataGridViewLista.Columns[1].Width = 100;
            dataGridViewLista.Columns[2].Name = "RUA";
            dataGridViewLista.Columns[2].Width = 150;
            dataGridViewLista.Columns[3].Name = "BAIRRO";
            dataGridViewLista.Columns[3].Width = 100;
            dataGridViewLista.Columns[4].Name = "CIDADE";
            dataGridViewLista.Columns[4].Width = 100;
        }
    }
}
