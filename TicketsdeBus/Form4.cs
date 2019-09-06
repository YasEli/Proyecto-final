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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       public void CargarDatos(ClientesBL clientesBL)
        {
            listadeClientesBindingSource.DataSource = clientesBL.ListadeClientes;
        }
    }
}
