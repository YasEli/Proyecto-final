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
            bindingSource.DataSource = viajesBL.ListadeViajes;

            var reporteViajes = new ReportedeViajes();
            reporteViajes.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporteViajes;
            crystalReportViewer1.RefreshReport();
        }
    }
}
