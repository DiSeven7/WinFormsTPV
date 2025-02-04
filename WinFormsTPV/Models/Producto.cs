namespace WinFormsTPV.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public int Stock { get; set; }

        public string Imagen { get; set; }

        public int Categoria { get; set; }

        public bool Activo { get; set; }

        public Producto()
        {

        }

        public Producto(string nombre, double precio, int stock, string imagen, int categoria, bool activo, int id = -1)
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
