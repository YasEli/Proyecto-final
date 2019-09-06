using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsdeBus.Modelos;

namespace TicketsdeBus.BL
{
    public class ViajesBL
    {
        
        public BindingList<Viaje> ListadeViajes { get; set; }

        public ViajesBL()
        {
            ListadeViajes = new BindingList<Viaje>();
            CargarDatos();
        }


        public double ObtenerPrecio(int id)
        {
            double precio = 0;

            foreach (var viaje in ListadeViajes)
            {
                if (viaje.Id == id)
                {
                    precio = viaje.Precio;
                }
            }
            return precio;

        }

        private void CargarDatos()
        {
            DateTime fecha1 = new DateTime(2019, 08, 20);
            
            var viaje1 = new Viaje(1, fecha1, "San Pedro Sula", "El Progreso", 100);
            var viaje2 = new Viaje(2, fecha1, "Puerto Cortes", "Villanueva", 50);
            var viaje3 = new Viaje(3, fecha1, "Santa Barbara", "San Pedro Sula", 120);
            var viaje4 = new Viaje(4, fecha1, "Copan", "San Pedro Sula", 110);

            ListadeViajes.Add(viaje1);
            ListadeViajes.Add(viaje2);
            ListadeViajes.Add(viaje3);
            ListadeViajes.Add(viaje4);
        }
    }
}
