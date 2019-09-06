using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsdeBus.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public bool PuedeVerBuses { get; set; }
        public bool PuedeVerViajes { get; set; }
        public bool PuedeVerClientes { get; set; }
        public bool PuedeVerTickets { get; set; }
        public bool ReporteVentas { get; set; }

        public Usuario(int id, string nombre, string contrasena)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
        }
    }
}
