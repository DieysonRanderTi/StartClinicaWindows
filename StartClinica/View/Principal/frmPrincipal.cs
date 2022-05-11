using MaterialSkin.Controls;
using StartClinica.Controller;
using StartClinica.Mensagem;
using StartClinica.Model;
using StartClinica.View;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace StartClinica
{
    public partial class frmPrincipal : MaterialForm
    {
        int month, year;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmPrincipal()
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

        #region Calendário
        public void MostrarDiasMes()
        {
            painelCalendario.Controls.Clear();
            DateTime hoje = DateTime.Now;
            month = hoje.Month;
            year = hoje.Year;

            string nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month).ToUpper();
            lblMesAno.Text = nomeMes +" "+ year;

            DateTime primeiroDiaMes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(hoje.Year, hoje.Month);
            int diaDaSemana = Convert.ToInt32(primeiroDiaMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaDaSemana; i++)
            {
                UserControlCalendario calendario = new UserControlCalendario();
                painelCalendario.Controls.Add(calendario);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias numdias = new UserControlDias();
                numdias.Dias(i);
                painelCalendario.Controls.Add(numdias);
            }
        }
        private void btnAvancarMes_Click(object sender, EventArgs e)
        {
            painelCalendario.Controls.Clear();
            month++;

            string nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month).ToUpper();
            lblMesAno.Text = nomeMes + " " + year;

            DateTime hoje = DateTime.Now;

            DateTime primeiroDiaMes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diaDaSemana = Convert.ToInt32(primeiroDiaMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaDaSemana; i++)
            {
                UserControlCalendario calendario = new UserControlCalendario();
                painelCalendario.Controls.Add(calendario);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias numdias = new UserControlDias();
                numdias.Dias(i);
                painelCalendario.Controls.Add(numdias);
            }
        }

        private void btnVoltarMes_Click(object sender, EventArgs e)
        {
            painelCalendario.Controls.Clear();
            month--;

            string nomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month).ToUpper();
            lblMesAno.Text = nomeMes + " " + year;

            DateTime hoje = DateTime.Now;

            DateTime primeiroDiaMes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diaDaSemana = Convert.ToInt32(primeiroDiaMes.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < diaDaSemana; i++)
            {
                UserControlCalendario calendario = new UserControlCalendario();
                painelCalendario.Controls.Add(calendario);
            }
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias numdias = new UserControlDias();
                numdias.Dias(i);
                painelCalendario.Controls.Add(numdias);
            }
        }
        #endregion

        #region Metodos de Eventos
        private void BuscarEventosDoDia()
        {
            var eventos = EventoController.GetAllEventos().Where(x => x.DataEvento.Date == DateTime.Now.Date).ToList();
            PreencherGridEventos(eventos);
        }
        private void BuscarTodosEventos()
        {
            var eventos = EventoController.GetAllEventos();
            PreencherGridEventos(eventos);
        }
        private void PreencherGridEventos(IEnumerable<Evento> eventos)
        {
            dataGridViewEventosHome.Rows.Clear();
            foreach (var evento in eventos)
            {
                dataGridViewEventosHome.Rows.Add(evento.Cliente.Nome, evento.Data.ToString("dd/MM/yyyy"), evento.Horario, evento.Motivo);
            }
        }
        private void GerarDataGridEventos()
        {
            dataGridViewEventosHome.ColumnCount = 4;
            dataGridViewEventosHome.Columns[0].Name = "CLIENTE";
            dataGridViewEventosHome.Columns[0].Width = 200;
            dataGridViewEventosHome.Columns[1].Name = "DATA";
            dataGridViewEventosHome.Columns[1].Width = 100;
            dataGridViewEventosHome.Columns[2].Name = "HORÁRIO";
            dataGridViewEventosHome.Columns[2].Width = 100;
            dataGridViewEventosHome.Columns[3].Name = "DESCRIÇÃO";
            dataGridViewEventosHome.Columns[3].Width = 500;
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarEventoEvento();
        }
        private void CadastrarEventoEvento()
        {
            try
            {
                Evento Evento = new Evento()
                {
                    ClienteId = ClienteController.GetClienteByName(cmbClientes.Text).Id,
                    UsuarioId = UsuarioController.GetUsuario(1).Id,
                    Data = dtpData.Value,
                    DataEvento = DateTime.Now,
                    Horario = cmbHorario.Text,
                    Motivo = txtDescricao.Text,
                };
                EventoController.InsertEvento(Evento);
                Mensagens.CadastroSucesso();
                LimparDadosEventos();
            }
            catch (Exception ex)
            {
                Mensagens.ErroParametros(ex.Message, "Erro");
            }
        }
        private void LimparDadosEventos()
        {
            txtDescricao.Text = string.Empty;
            cmbClientes.Text = string.Empty;
            cmbHorario.Text = string.Empty;
            dtpData.Value = DateTime.Now;
        }

        #endregion

        #region Metodos de Cliente
        private void BuscarTodosClientes()
        {
            var clientes = ClienteController.GetClientes();
            PreencherGridClientes(clientes);
        }
        private void PreencherGridClientes(IEnumerable<Cliente> clientes)
        {
            dataGridViewListaClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dataGridViewListaClientes.Rows.Add
                    (
                        cliente.Nome,
                        cliente.TelefoneContato,
                        cliente.Rua + " Nº " + cliente.Numero,
                        cliente.Bairro,
                        cliente.Cidade
                    );
            }
        }
        private void GerarDataGridClientes()
        {
            dataGridViewListaClientes.ColumnCount = 5;
            dataGridViewListaClientes.Columns[0].Name = "NOME";
            dataGridViewListaClientes.Columns[0].Width = 200;
            dataGridViewListaClientes.Columns[1].Name = "TELEFONE";
            dataGridViewListaClientes.Columns[1].Width = 100;
            dataGridViewListaClientes.Columns[2].Name = "RUA";
            dataGridViewListaClientes.Columns[2].Width = 150;
            dataGridViewListaClientes.Columns[3].Name = "BAIRRO";
            dataGridViewListaClientes.Columns[3].Width = 100;
            dataGridViewListaClientes.Columns[4].Name = "CIDADE";
            dataGridViewListaClientes.Columns[4].Width = 100;
        }
        #endregion

        #region Eventos do Form
        //Inicio Form Principal
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvento frm = new frmEvento();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarDiasMes();
            GerarDataGridEventos();
            //BuscarEventosDoDia();
            BuscarTodosEventos();
        }
        private void rbTodoEventos_CheckedChanged(object sender, EventArgs e)
        {
            BuscarTodosEventos();
        }

        private void rbEventosDeHoje_CheckedChanged(object sender, EventArgs e)
        {
            BuscarEventosDoDia();
        }
        //Fim Form Principal

        //Inicio Form Clientes
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }


        //Fim Form Clientes
        #endregion

        // Inicio Tab Menu Principal
        private void tabMenuPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage tabSelecionada = (sender as TabControl).SelectedTab;

            if (tabSelecionada == tabClientes)
            {
                GerarDataGridClientes();
                BuscarTodosClientes();
            }
            else if (tabSelecionada == tabHome)
            {
                MostrarDiasMes();
                GerarDataGridEventos();
                BuscarTodosEventos();
            }
            else if (tabSelecionada == tabEventos)
            {
                PreencherComboBoxClientes();
            }
        }
        // Fim Tab Menu Principal
    }
}
