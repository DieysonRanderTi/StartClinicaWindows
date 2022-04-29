using StartClinica.Controller;
using StartClinica.Mensagem;
using StartClinica.Model;
using System;
using System.Windows.Forms;

namespace StartClinica.View
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
            GerarDataGrid();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            lblDataHoje.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbClientes.Focus();

            var clientes = ClienteController.GetClientesAtivos();
            foreach (var cliente in clientes)
            {
                cmbClientes.Items.Add(cliente.Nome);
            }
            BuscarEventos();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarEventoAgenda();
        }
        private void CadastrarEventoAgenda()
        {
            try
            {
                Agenda agenda = new Agenda()
                {
                    Cliente = ClienteController.GetClienteByName(cmbClientes.Text),
                    Usuario = UsuarioController.GetUsuario(1),
                    Data = dtpData.Value,
                    DataAgendamento = DateTime.Now,
                    Horario = cmbHorario.Text,
                    Motivo = txtDescricao.Text,
                };
                AgendaController.InsertAgenda(agenda);
                BuscarEventos();
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
            txtDescricao.Text = string.Empty;
            cmbClientes.Text = string.Empty;
            cmbHorario.Text = string.Empty;
            dtpData.Value = DateTime.Now;
            
        }
        private void BuscarEventos()
        {
            var eventos = AgendaController.GetAgendas();

            foreach (var evento in eventos)
            {
                dataGridViewAgenda.Rows.Add(evento.Cliente.Nome, evento.Data.ToString("dd/MM/yyyy"), evento.Horario, evento.Motivo);
            }
               
        }
        private void GerarDataGrid()
        {
            dataGridViewAgenda.ColumnCount = 4;
            dataGridViewAgenda.Columns[0].Name = "CLIENTE";
            dataGridViewAgenda.Columns[0].Width = 200;
            dataGridViewAgenda.Columns[1].Name = "DATA";
            dataGridViewAgenda.Columns[1].Width = 100;
            dataGridViewAgenda.Columns[2].Name = "HORÁRIO";
            dataGridViewAgenda.Columns[2].Width = 100;
            dataGridViewAgenda.Columns[3].Name = "DESCRIÇÃO";
            dataGridViewAgenda.Columns[3].Width = 500;
        }
    }
}
