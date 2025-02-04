using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsTPV.Models;

namespace WinFormsTPV.Controllers
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

        List<Producto> ObtenerProductosCategoria(Categoria categoria);

        bool ActualizarProducto(Producto producto);

        bool ActualizarStock(Producto producto);

        void InsertarTicket(Ticket ticket);

        List<Ticket> ObtenerTickets();

        Ticket ObtenerTicket(int id);

        Ticket ObtenerTicket(DateTime fecha);

        bool ActualizarTicket(Ticket ticket);

        void InsertarVenta(Venta venta);

        List<Venta> ObtenerVentas();

        Venta ObtenerVenta(int id);

        bool ActualizarVenta(Venta venta);

        void InsertarCategoria(Categoria categoria);

        List<Categoria> ObtenerCategorias();

        Categoria ObtenerCategoria(int id);

        bool ActualizarCategoria(Categoria categoria);
    }
}
