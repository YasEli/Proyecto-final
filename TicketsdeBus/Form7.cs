using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketsdeBus.BL;

namespace TicketsdeBus
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public void CargarDatos(ViajesBL viajesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from p in viajesBL.ListadeViajes
                select new
                {
                    Foto = p.Foto,
                    Id = p.Id,
                    Fecha = p.Fecha,
                    Origen = p.Origen,
                    Destino = p.Destino,
                    Precio = p.Precio
                };

            var reporteViajes = new ReportedeViajes();
            reporteViajes.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporteViajes;
            crystalReportViewer1.RefreshReport();
        }
    }
}
