using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsdeBus.Modelos
{
   public  class Asiento
    {

        public int Id { get; set; }

        public string Descripcion { get; set; }
        public int AsientosId { get; set; }
        public bool Activo { get; set; }

        public BindingList<AsientoDetalle> AsientosDetalle { get; set; }

        public Asiento()
        {
            Activo = true;
            AsientosDetalle = new BindingList<AsientoDetalle>();
        }
        public Asiento(int id, string descipcion)
        {
            Id = id;
            Descripcion = descipcion;
        }

        public class AsientoDetalle
        {

            public int Id { get; set; }
            public int AsientoId { get; set; }
            public Viaje Viaje { get; set; }
            public int Cantidad { get; set; }
            public double Precio { get; set; }
            public double Total { get; set; }
            public string Asiento { get; set; }


            public AsientoDetalle()
            {
                Cantidad = 1;
                AsientoId = 1;
            }
        }

    }



}
