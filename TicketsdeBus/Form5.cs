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

        TicketsBL _ticketBL;
        AsientosBL _asientoBL;
        public Form5()
        {
            
            InitializeComponent();
        }

        public void CargarDatos(TicketsBL ticketsBL, ClientesBL clientesBL, ViajesBL viajesBL, AsientosBL asientosBL )
        {
            _ticketBL = ticketsBL;
            _asientoBL = asientosBL;

            listaDeTicketsBindingSource.DataSource = ticketsBL.ListaDeTickets;
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
            listadeViajesBindingSource.DataSource = viajesBL.ListadeViajes;
            listadeAsientosBindingSource.DataSource = asientosBL.ListadeAsientos;




     

 
                 


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ticketsDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var ticket = (Ticket)listaDeTicketsBindingSource.Current;
            ticket.CalcularTotalTicket();

            listaDeTicketsBindingSource.ResetBindings(false);


        }
    }
}
