using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsdeBus.BL;
using TicketsdeBus.Modelos;

namespace TicketsdeBus
{
    public partial class Form5 : Form
    {
        TicketsBL _ticketsBL;

        public Form5()
        {
            InitializeComponent();
        }

        public void CargarDatos(TicketsBL ticketsBL, ClientesBL clientesBL, ViajesBL viajesBL)
        {
            _ticketsBL = ticketsBL;
            listaDeTicketsBindingSource.DataSource = ticketsBL.ListaDeTickets;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeViajesBindingSource.DataSource = viajesBL.ListadeViajes;
        }

        private void ticketsDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var ticket = (Ticket)listaDeTicketsBindingSource.Current;
            ticket.CalcularTotalTicket();

            listaDeTicketsBindingSource.ResetBindings(false);
        }
    }
}
