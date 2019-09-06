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
    public partial class Form1 : Form
    {
        BusBL _busBL;
        ViajesBL _viajesBL;
        ClientesBL _clientesBL;
        TicketsBL _ticketsBL;
        AsientosBL _asientoBL;
        UsuariosBL _usuariosBL;

        public Form1()
        {
            InitializeComponent();

            _busBL = new BusBL();
            _viajesBL = new ViajesBL();
            _clientesBL = new ClientesBL();
            _ticketsBL = new TicketsBL();
            _asientoBL = new AsientosBL();
            _usuariosBL = new UsuariosBL();


        }

        private void busToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formBus = new Form2();
            formBus.MdiParent = this;
            formBus.CargarDatos(_busBL, _viajesBL);
            formBus.Show();
        }

        private void programaciónDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formViajes = new Form3();
            formViajes.MdiParent = this;
            formViajes.CargarDatos(_viajesBL);
            formViajes.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCLientes = new Form4();
            formCLientes.MdiParent = this;
            formCLientes.CargarDatos(_clientesBL);
            formCLientes.Show();
        }

       
        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formTicket = new Form5();
            formTicket.MdiParent = this;
            formTicket.CargarDatos(_ticketsBL, _clientesBL, _viajesBL, _asientoBL);
            

            formTicket.Show();
        }

       
        private void transacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            var formLogin = new Form6();
            formLogin.CargarDatos(_usuariosBL);
            formLogin.ShowDialog();

            busToolStripMenuItem.Visible = formLogin.UsuarioAutenticado.PuedeVerBuses;
            programaciónDeViajesToolStripMenuItem.Visible = formLogin.UsuarioAutenticado.PuedeVerViajes;
            clientesToolStripMenuItem.Visible = formLogin.UsuarioAutenticado.PuedeVerClientes;
            ticketToolStripMenuItem1.Visible = formLogin.UsuarioAutenticado.PuedeVerTickets;
            reporteDeVentaToolStripMenuItem.Visible = formLogin.UsuarioAutenticado.ReporteVentas;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
