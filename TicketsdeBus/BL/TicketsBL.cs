using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsdeBus.Modelos;

namespace TicketsdeBus.BL
{
    public class TicketsBL
    {
        public BindingList<Ticket> ListaDeTickets { get; set; }

        public TicketsBL()
        {
            ListaDeTickets = new BindingList<Ticket>();
        }



    }
}
