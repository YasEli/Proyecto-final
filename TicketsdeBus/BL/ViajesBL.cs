using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
            var fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\buller.jpg");
            var fileStream = fileInfo.OpenRead();
            viaje1.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var viaje2 = new Viaje(2, fecha1, "San Pedro Sula", "Villanueva", 50);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\paradiso.jpg");
            fileStream = fileInfo.OpenRead();

            viaje2.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var viaje3 = new Viaje(3, fecha1, "San Pedro Sula", "Tegucigalpa", 120);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\elf.jpeg");
            fileStream = fileInfo.OpenRead();

            viaje3.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var viaje4 = new Viaje(4, fecha1, "San Pedro Sula", "Tocoa", 110);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\Torino.jpg");
            fileStream = fileInfo.OpenRead();

            viaje4.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            ListadeViajes.Add(viaje1);
            ListadeViajes.Add(viaje2);
            ListadeViajes.Add(viaje3);
            ListadeViajes.Add(viaje4);
        }
    }
}
