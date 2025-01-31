using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTPV.Models
{
    public class Venta
    {
        public int Id { get; set; }

        public int IdTicket { get; set; }

        public int IdProducto { get; set; }

        public int IdUsuario { get; set; }

        public int Cantidad { get; set; }

        public double Subtotal { get; set; }

        public Venta() { }

        public Venta(int idTicket, int idProducto, int idUsuario, int cantidad, double subtotal, int id = -1)
        {
            if (id != -1) { Id = id; };
            IdTicket = idTicket;
            IdProducto = idProducto;
            IdUsuario = idUsuario;
            Cantidad = cantidad;
            Subtotal = subtotal;
        }
    }
}
