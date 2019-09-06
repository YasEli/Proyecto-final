using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsdeBus.Modelos;

namespace TicketsdeBus.BL
{
    public class AsientosBL
    {

        public BindingList<Asiento> ListadeAsientos { get; set; }

        public AsientosBL()
        {
            ListadeAsientos  = new BindingList<Asiento>();
            CargarDatos();
        }
        private void CargarDatos()
        {

            DateTime fecha1 = new DateTime(2019, 08, 20);

            var silla1 = new Asiento(1, "A1");
            var silla2 = new Asiento(2, "A2");
            var silla3 = new Asiento(3, "A3");
            var silla4 = new Asiento(4, "A4");

            ListadeAsientos.Add(silla1);
            ListadeAsientos.Add(silla2);
            ListadeAsientos.Add(silla3);
            ListadeAsientos.Add(silla4);
        }
     }
}


 