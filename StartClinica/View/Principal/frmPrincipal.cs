using StartClinica.Controller;
using StartClinica.Model;
using StartClinica.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartClinica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }
        #region Metodos
        private void BuscarEventosDoDia()
        {
            var eventos = EventoController.GetAllEventos().Where( x => x.DataEvento.Date == DateTime.Now.Date).ToList();
            PreencherGrid(eventos);
        }
        private void BuscarTodosEventos()
        {
            var eventos = EventoController.GetAllEventos();
            PreencherGrid(eventos);
        }
        private void PreencherGrid(IEnumerable<Evento> eventos)
        {
            dataGridViewAgenda.Rows.Clear();
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
        #endregion
        #region Eventos do Form
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda frm = new frmAgenda();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GerarDataGrid();
            BuscarEventosDoDia();
        }
        private void rdbEventosDia_CheckedChanged(object sender, EventArgs e)
        {
            BuscarEventosDoDia();
        }
        private void rdbTodosEventos_CheckedChanged(object sender, EventArgs e)
        {
            BuscarTodosEventos();
        }
        #endregion
    }
}
