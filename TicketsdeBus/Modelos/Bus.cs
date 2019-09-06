using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsdeBus.Modelos
{
    public class Bus
    {
        public int Id { get; set; }
        public int Capacidad { get; set; }
        public int Ruta { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int ViajeId { get; set; }
        public Viaje Viaje { get; set; }
        public string Aciento { get; set; }
        public Bus()
        {
            DateTime fecha1 = new DateTime(2019, 08, 20, 10, 00, 00);
            Viaje = new Viaje(1, fecha1, "San Pedro Sula", "El Progreso", 100);
            ViajeId = Viaje.Id;
        }

        public Bus(int id, int capacidad, int ruta, string modelo, string marca, Viaje viaje)
        {
            Id = id;
            Capacidad = capacidad;
            Ruta = ruta;
            Modelo = modelo;
            Marca = marca;
            ViajeId = viaje.Id;
            Viaje = viaje;
        }
    }
}
