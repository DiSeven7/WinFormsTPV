using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsTPV.Models;

namespace WinFormsTPV.Services
{
    public interface IDbController
    {
        void CrearDb();

        void InsertarUsuario(Usuario usuario);

        List<Usuario> ObtenerUsuarios();

        Usuario ObtenerUsuario(int id);

        bool ActualizarUsuario(Usuario usuario);

        Usuario IniciarSesion(string nombreUsuario, string contraseña);

        void InsertarProducto(Producto producto);

        List<Producto> ObtenerProductos();

        Producto ObtenerProducto(int id);

        bool ActualizarProducto(Producto producto);

        void InsertarTicket(Ticket ticket);

        List<Ticket> ObtenerTickets();

        Ticket ObtenerTicket(int id);

        bool ActualizarTicket(Ticket ticket);

        void InsertarVenta(Venta venta);

        List<Venta> ObtenerVentas();

        Venta ObtenerVenta(int id);

        bool ActualizarVenta(Venta venta);
    }
}
