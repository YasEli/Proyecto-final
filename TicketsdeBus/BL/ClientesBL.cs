using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsdeBus.Modelos;

namespace TicketsdeBus.BL
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CargarDatos();        
        }
        private void CargarDatos()
        {
            
            var cliente1 = new Cliente(1, "Ana", "Ordoñez", "98678656");
            var cliente2 = new Cliente(2, "Sara", "Guifarro", "96374859");
            var cliente3 = new Cliente(3, "Greysi", "Toro", "94567634");
            var cliente4 = new Cliente(4, "Paola", "Peraza", "92345676");

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
            ListadeClientes.Add(cliente4);
        }
    }
}
