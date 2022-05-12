using MaterialSkin.Controls;
using StartClinica.Controller;
using StartClinica.Mensagem;
using StartClinica.Model;
using System;

namespace StartClinica.View
{
    public partial class frmEvento : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmEvento()
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

        private void frmEvento_Load(object sender, EventArgs e)
        {
            var mes = "";
            if (UserControlDias.staticDia.Length == 1)
                UserControlDias.staticDia = "0" + UserControlDias.staticDia;
            if (frmPrincipal.staticMes.ToString().Length == 1)
                mes = "0" + frmPrincipal.staticMes.ToString();

            txtData.Text = UserControlDias.staticDia +"/"+ mes +"/"+ frmPrincipal.staticAno;
            PreencherComboBoxClientes();

        }
        private void PreencherComboBoxClientes()
        {
            cmbClientes.Items.Clear();
            cmbClientes.Focus();
            var clientes = ClienteController.GetClientesAtivos();
            foreach (var cliente in clientes)
            {
                cmbClientes.Items.Add(cliente.Nome);
            }
        }
        private void CadastrarEventoEvento()
        {
            try
            {
                Evento Evento = new Evento()
                {
                    ClienteId = ClienteController.GetClienteByName(cmbClientes.Text).Id,
                    UsuarioId = UsuarioController.GetUsuario(1).Id,
                    DataCadastro = DateTime.Now,
                    DataEvento = txtData.Text,
                    Horario = cmbHorario.Text,
                    Descricao = txtDescricao.Text,
                };
                EventoController.InsertEvento(Evento);
                Mensagens.CadastroSucesso();
                frmEvento frm = new frmEvento();
                frm.Close();
            }
            catch (Exception ex)
            {
                Mensagens.ErroParametros(ex.Message, "Erro");
            }
        }

        private void btnSalvarEvento_Click(object sender, EventArgs e)
        {
            CadastrarEventoEvento();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }
    }
}
