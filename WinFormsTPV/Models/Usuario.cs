using System.Text;

namespace WinFormsTPV.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Alias { get; set; }

        public string Contraseña { get; set; }

        public bool Verificado { get; set; }

        public bool EsAdmin { get; set; }

        public bool Activo { get; set; }

        public Usuario()
        {

        }

        public Usuario(string alias, string contraseña, bool verificado, bool esAdmin, bool activo, int id = -1)
        {
            if (id != -1) { Id = id; };
            Alias = alias;
            Contraseña = Convert.ToBase64String(Encoding.UTF8.GetBytes(contraseña));
            Verificado = verificado;
            EsAdmin = esAdmin;
            Activo = activo;
        }
    }
}
