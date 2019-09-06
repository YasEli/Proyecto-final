using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsdeBus.Modelos;

namespace TicketsdeBus.BL
{
    public class UsuariosBL
    {
        public BindingList<Usuario> ListadeUsuarios { get; set; }

        public UsuariosBL()
        {
            ListadeUsuarios = new BindingList<Usuario>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            var usuarioAdmin = new Usuario(1, "admin", "1234");
            usuarioAdmin.PuedeVerBuses = true;
            usuarioAdmin.PuedeVerViajes = true;
            usuarioAdmin.PuedeVerClientes = true;
            usuarioAdmin.PuedeVerTickets = true;
            usuarioAdmin.ReporteVentas = true;

            var usuario1 = new Usuario(2, "ana", "1997");
            usuario1.PuedeVerBuses = true;
            usuario1.PuedeVerClientes = true;
            usuario1.PuedeVerTickets = true;

            var usuario2 = new Usuario(3, "yasmin", "1998");
            usuario2.PuedeVerBuses = true;
            usuario2.PuedeVerViajes = true;
            usuario2.PuedeVerClientes = true;
  
            ListadeUsuarios.Add(usuarioAdmin);
            ListadeUsuarios.Add(usuario1);
            ListadeUsuarios.Add(usuario2);
        }

        public Usuario Autenticar(string nombre, string contrasena)
        {
            foreach (var usuario in ListadeUsuarios)
            {
                if(usuario.Nombre == nombre && usuario.Contrasena == contrasena)
                {
                    return usuario;
                }
            }

            return null;
        }
    }
}
