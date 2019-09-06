using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsdeBus.BL;

namespace TicketsdeBus.Modelos
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Asiento { get; set; }

        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
         
        public bool Activo { get; set; }

        public BindingList<TicketDetalle> TicketsDetalle { get; set; }


        public Ticket()
        {

            Fecha = DateTime.Now;
            Activo = true;
            TicketsDetalle = new BindingList<TicketDetalle>();

        }

        public void CalcularTotalTicket()
        {

            var viajesBL = new ViajesBL();


            double subtotal = 0;
            foreach (var detalle in TicketsDetalle)
            {
                var precio = viajesBL.ObtenerPrecio(detalle.ViajeId);
             subtotal = subtotal +  detalle.CalcualrTotalDetalle(precio);
            }

            Subtotal = subtotal;
            Impuesto = Subtotal * 0.15;
            Total = Subtotal + Impuesto;

        }
    }


        public class TicketDetalle
        {
            
            public int ViajeId { get; set; }
            public Viaje Viaje { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Total { get; set; }
            public string Asiento { get; set; }


        public TicketDetalle()
            {
                Cantidad = 1;
                ViajeId = 1;
            }

            public double CalcualrTotalDetalle(double precio)
            {
                Precio = precio;
                Total = Cantidad * Precio;

                return Total;

            }

        } 
}
