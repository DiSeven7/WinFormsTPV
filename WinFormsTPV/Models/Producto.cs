using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTPV.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int Stock { get; set; }

        public string Imagen { get; set; }

        public Categoria Categoria { get; set; }

        public bool Activo { get; set; }

        public Producto()
        {

        }

        public Producto(string nombre, double precio, int stock, string imagen, Categoria categoria, bool activo, int id = -1)
        {
            if (id != -1) { Id = id; };
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Imagen = imagen;
            Categoria = categoria;
            Activo = activo;
        }
    }
}
