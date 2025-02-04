namespace WinFormsTPV.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Imagen { get; set; }

        public bool Activa { get; set; }

        public Categoria() { }

        public Categoria(string nombre, string imagen, bool activa, int id = -1)
        {
            if (id != -1) { Id = id; };
            Nombre = nombre;
            Imagen = imagen;
            Activa = activa;
        }
    }
}
