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
    public class BusBL
    {
        public BindingList<Bus> ListadeBuses { get; set; }

        public BusBL()
        {
            ListadeBuses = new BindingList<Bus>();
            CargarDatos();
        }
        
        private void CargarDatos()
        {
            DateTime fecha1 = new DateTime(2019, 08, 20, 10, 00, 00);
            
            var viaje1 = new Viaje(1, fecha1, "San Pedro Sula", "El Progreso", 100);
            var viaje2 = new Viaje(2, fecha1, "San Pedro Sula", "Villanueva", 50);
            var viaje3 = new Viaje(3, fecha1, "San Pedro Sula", "Tegucigalpa", 120);
            var viaje4 = new Viaje(4, fecha1, "San Pedro Sula", "Toca", 110);

            var bus1 = new Bus(1, 48, 5, "Buller", "DINA", viaje1);

            var fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\buller.jpg");
            var fileStream = fileInfo.OpenRead();

            bus1.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var bus2 = new Bus(2, 52, 4, "9800 2017", "Volvo", viaje1);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\volvo.jpg");
            fileStream = fileInfo.OpenRead();

            bus2.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var bus3 = new Bus(3, 46, 2, "Paradiso 1200", "Mercedes Benz", viaje2);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\paradiso.jpg");
            fileStream = fileInfo.OpenRead();

            bus3.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var bus4 = new Bus(4, 56, 1, "SCD 12 200", "King", viaje2);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\scd.jpeg");
            fileStream = fileInfo.OpenRead();

            bus4.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var bus5 = new Bus(5, 40, 3, "ELF 600 Bus", "Isuzu", viaje3);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\elf.jpeg");
            fileStream = fileInfo.OpenRead();

            bus5.Foto = Program.imageToByteArray(Image.FromStream(fileStream));

            var bus6 = new Bus(6, 42, 6, "Torino", "Mercedes Benz", viaje4);
            fileInfo = new FileInfo(@"C:\Users\Yasmin Coto\Desktop\Yasmin\Proyecto L2\Proyecto-final\Imagenes\Torino.jpg");
            fileStream = fileInfo.OpenRead();

            bus6.Foto = Program.imageToByteArray(Image.FromStream(fileStream));


            ListadeBuses.Add(bus1);
            ListadeBuses.Add(bus2);
            ListadeBuses.Add(bus3);
            ListadeBuses.Add(bus4);
            ListadeBuses.Add(bus5);
            ListadeBuses.Add(bus6);
        }
    }
}
