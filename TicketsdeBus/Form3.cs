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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void CargarDatos(ViajesBL viajesBL)
        {
            listadeViajesBindingSource.DataSource = viajesBL.ListadeViajes;
        }
    }
}
