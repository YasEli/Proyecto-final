using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsdeBus.Modelos
{
    public class Viaje
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double Precio { get; set; }
      
        public Viaje()
        {

        }
   
        public Viaje(int id, DateTime fecha, string origen, string destino, double precio)
        {
            Id = id;
            Fecha = fecha;
            Origen = origen;
            Destino = destino;
            Precio = precio;
           
        }
    }
}
