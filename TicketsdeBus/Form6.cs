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
using TicketsdeBus.Modelos;

namespace TicketsdeBus
{
    public partial class Form6 : Form
    {
        UsuariosBL _usuariosBL;

        public Usuario UsuarioAutenticado { get; set; }

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = textBox1.Text;
            var contrasena = textBox2.Text;

            var usuarioAutenticar = _usuariosBL.Autenticar(nombre, contrasena);

            if(usuarioAutenticar != null)
            {
                UsuarioAutenticado = usuarioAutenticar;
                this.Close();

            } else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CargarDatos(UsuariosBL usuariosBL)
        {
            _usuariosBL = usuariosBL;
        }
    }
}
