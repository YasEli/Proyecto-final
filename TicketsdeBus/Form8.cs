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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public void CargarDatos(TicketsBL ticketsBL, ClientesBL clientesBL)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource =
                from p in ticketsBL.ListaDeTickets
                select new
                {
                    Id = p.Id,
                    Fecha = p.Fecha,
                    Cliente = clientesBL.ListadeClientes.FirstOrDefault(r => r.Id == p.ClienteId).Nombre,
                    Subtotal = p.Subtotal,
                    Impuesto = p.Impuesto,
                    Total = p.Total

                };

            var reporteVentas = new ReporteDeVentas();
            reporteVentas.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporteVentas;
            crystalReportViewer1.RefreshReport();
        }
    }
}
