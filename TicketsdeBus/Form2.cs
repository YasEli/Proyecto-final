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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public void CargarDatos(BusBL busBL, ViajesBL viajesBL)
        {
            listadeBusesBindingSource.DataSource = busBL.ListadeBuses;
            listadeViajesBindingSource.DataSource = viajesBL.ListadeViajes;
        }
    }
}
