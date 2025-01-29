using System.Drawing.Imaging;
using System.Text;
using Microsoft.Data.Sqlite;
using WinFormsTPV.Models;

namespace WinFormsTPV.Controllers
{
    public class DbController : IDbController
    {
        string path = Path.Combine(Environment.CurrentDirectory, "tpvdb.db");

        #region Creacion db y datos iniciales

        public void CrearDb()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            using (SqliteConnection db =
               new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT EXISTS Usuarios (Id INTEGER PRIMARY KEY AUTOINCREMENT, Alias VARCHAR(100), Contraseña VARCHAR(250), Verificado INT(1), Admin INT(1), Activo INT(1));" +
                    "CREATE TABLE IF NOT EXISTS Tickets(Id INTEGER PRIMARY KEY AUTOINCREMENT, Fecha DATETIME);" +
                    "CREATE TABLE IF NOT EXISTS Productos(Id INTEGER PRIMARY KEY AUTOINCREMENT, Nombre TEXT(500), Precio DECIMAL(4,2), Stock INT(7), Imagen BLOB, Categoria INT(2), Activo INT(1));" +
                    "CREATE TABLE IF NOT EXISTS Ventas(Id INTEGER PRIMARY KEY AUTOINCREMENT, IdTicket INT(10), IdProducto INT(10), Cantidad INT(5), Subtotal DECIMAL(4,2));";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }

            if (ObtenerUsuarios().Count == 0)
            {
                InsertarUsuario(new Usuario("admin", "admin", true, true, true));
                InsertarUsuario(new Usuario("turno1", "admin", true, false, true));
                InsertarVenta(new Venta(1, 2, 5, 22.22));
                InsertarTicket(new Ticket(DateTime.Now));
                InsertarProducto(new Producto("Coca-Cola", 1.25, 400, @"..\..\..\Resources\cocacola.png", Categoria.Refrescos, true));
            }
            var co = ObtenerProductos();
        }

        #endregion

        #region Operaciones usuarios

        public void InsertarUsuario(Usuario usuario)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Usuarios (Alias,Contraseña,Verificado,Admin,Activo) VALUES (@alias,@contraseña,@verificado,@admin,@activo);";
                insertCommand.Parameters.AddWithValue("@alias", usuario.Alias);
                insertCommand.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                insertCommand.Parameters.AddWithValue("@verificado", usuario.Verificado);
                insertCommand.Parameters.AddWithValue("@admin", usuario.EsAdmin);
                insertCommand.Parameters.AddWithValue("@activo", usuario.Activo);

                insertCommand.ExecuteReader();
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            using (SqliteConnection db =
             new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var selectCommand = new SqliteCommand();
                selectCommand.Connection = db;

                selectCommand.CommandText = "SELECT * FROM usuarios";
                var resultados = selectCommand.ExecuteReader();
                List<Usuario> usuarios = new List<Usuario>();
                while (resultados.Read())
                {
                    Usuario usuario = new Usuario((string)resultados["Alias"], (string)resultados["Contraseña"], Convert.ToInt32(resultados["Verificado"]) == 1 ? true : false, Convert.ToInt32(resultados["Admin"]) == 1 ? true : false, Convert.ToInt32(resultados["Activo"]) == 1 ? true : false, Convert.ToInt32(resultados["Id"]));
                    usuarios.Add(usuario);
                }
                return usuarios;
            }
        }

        public Usuario ObtenerUsuario(int id)
        {
            using (SqliteConnection db =
             new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var selectCommand = new SqliteCommand();
                selectCommand.Connection = db;

                selectCommand.CommandText = "SELECT * FROM usuarios WHERE id=@id";
                selectCommand.Parameters.AddWithValue("@id", id);
                var resultado = selectCommand.ExecuteReader();
                Usuario usuario = null;
                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        usuario = new Usuario((string)resultado["Alias"], (string)resultado["Contraseña"], Convert.ToInt32(resultado["Verificado"]) == 1 ? true : false, Convert.ToInt32(resultado["Admin"]) == 1 ? true : false, Convert.ToInt32(resultado["Activo"]) == 1 ? true : false, Convert.ToInt32(resultado["Id"]));
                    }
                }
                return usuario;
            }
        }

        public bool ActualizarUsuario(Usuario usuario)
        {
            using (SqliteConnection db =
             new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var selectCommand = new SqliteCommand();
                selectCommand.Connection = db;

                selectCommand.CommandText = "UPDATE usuarios SET Alias=@alias,Contraseña=@contraseña,Verificado=@verificado,Admin=@admin,Activo=@activo WHERE id=@id";
                selectCommand.Parameters.AddWithValue("@alias", usuario.Alias);
                selectCommand.Parameters.AddWithValue("@contraseña", Convert.ToBase64String(Encoding.UTF8.GetBytes(usuario.Contraseña)));
                selectCommand.Parameters.AddWithValue("@verificado", usuario.Verificado);
                selectCommand.Parameters.AddWithValue("@admin", usuario.EsAdmin);
                selectCommand.Parameters.AddWithValue("@activo", usuario.Activo);
                selectCommand.Parameters.AddWithValue("@id", usuario.Id);
                var resultado = selectCommand.ExecuteNonQuery();
                return resultado > 0;
            }
        }

        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            using (SqliteConnection db =
           new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var selectCommand = new SqliteCommand();
                selectCommand.Connection = db;

                selectCommand.CommandText = "SELECT * FROM usuarios WHERE Alias=@alias AND Contraseña=@contraseña";
                selectCommand.Parameters.AddWithValue("@alias", nombreUsuario);
                selectCommand.Parameters.AddWithValue("@contraseña", Convert.ToBase64String(Encoding.UTF8.GetBytes(contraseña)));
                var resultado = selectCommand.ExecuteReader();
                Usuario usuario = null;
                if (resultado.HasRows)
                {
                    while (resultado.Read())
                    {
                        usuario = new Usuario((string)resultado["Alias"], (string)resultado["Contraseña"], Convert.ToInt32(resultado["Verificado"]) == 1 ? true : false, Convert.ToInt32(resultado["Admin"]) == 1 ? true : false, Convert.ToInt32(resultado["Activo"]) == 1 ? true : false, Convert.ToInt32(resultado["Id"]));
                    }
                }
                return usuario;
            }
        }

        #endregion

        #region Operaciones productos

        public void InsertarProducto(Producto producto)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Productos (Nombre,Precio,Stock,Imagen,Categoria,Activo) VALUES (@nombre,@precio,@stock,@imagen,@categoria,@activo);";
                insertCommand.Parameters.AddWithValue("@nombre", producto.Nombre);
                insertCommand.Parameters.AddWithValue("@precio", producto.Precio);
                insertCommand.Parameters.AddWithValue("@stock", producto.Stock);
                using (MemoryStream ms = new MemoryStream())
                {
                    Image img = Image.FromFile(producto.Imagen);
                    img.Save(ms, ImageFormat.Png);
                    insertCommand.Parameters.AddWithValue("@imagen", ms.ToArray());
                }
                insertCommand.Parameters.AddWithValue("@categoria", producto.Categoria);
                insertCommand.Parameters.AddWithValue("@activo", producto.Activo);
                insertCommand.ExecuteReader();
            }
        }

        public List<Producto> ObtenerProductos()
        {
            using (SqliteConnection db =
         new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "SELECT * FROM Productos;";
                List<Producto> productos = new List<Producto>();
                var resultados = insertCommand.ExecuteReader();
                while (resultados.Read())
                {
                    Producto producto = new Producto((string)resultados["Nombre"], Convert.ToDouble(resultados["Precio"]), Convert.ToInt32(resultados["Stock"]), Convert.ToBase64String((byte[])resultados["Imagen"]), (Categoria)Convert.ToInt32(resultados["Categoria"]), Convert.ToInt32(resultados["Activo"]) == 1 ? true : false, Convert.ToInt32(resultados["Id"]));
                    productos.Add(producto);
                }
                return productos;
            }
        }

        public Producto ObtenerProducto(int id)
        {
            using (SqliteConnection db =
    new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "SELECT * FROM Productos WHERE id=@id;";
                insertCommand.Parameters.AddWithValue("@id", id);
                Producto producto = null;
                var resultados = insertCommand.ExecuteReader();
                while (resultados.Read())
                {
                    producto = new Producto((string)resultados["Nombre"], Convert.ToDouble(resultados["Precio"]), Convert.ToInt32(resultados["Stock"]), Convert.ToBase64String((byte[])resultados["Imagen"]), (Categoria)Convert.ToInt32(resultados["Categoria"]), Convert.ToInt32(resultados["Activo"]) == 1 ? true : false, Convert.ToInt32(resultados["Id"]));
                }
                return producto;
            }
        }

        public bool ActualizarProducto(Producto producto)
        {
            using (SqliteConnection db =
             new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "UPDATE Productos SET Nombre=@nombre,Precio=@precio,Stock=@stock,Imagen=@imagen,Categoria=@categoria,Activo=@activo WHERE Id=@id);";
                insertCommand.Parameters.AddWithValue("@nombre", producto.Nombre);
                insertCommand.Parameters.AddWithValue("@precio", producto.Precio);
                insertCommand.Parameters.AddWithValue("@stock", producto.Stock);
                insertCommand.Parameters.AddWithValue("@activo", producto.Activo);
                using (MemoryStream ms = new MemoryStream())
                {
                    Image img = Image.FromFile(producto.Imagen);
                    img.Save(ms, ImageFormat.Png);
                    insertCommand.Parameters.AddWithValue("@imagen", ms.ToArray());
                }
                insertCommand.Parameters.AddWithValue("@categoria", producto.Categoria);
                insertCommand.Parameters.AddWithValue("@id", producto.Id);
                var resultado = insertCommand.ExecuteNonQuery();
                return resultado > 0;
            }
        }

        #endregion

        #region Operaciones tickets

        public void InsertarTicket(Ticket ticket)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Tickets (Fecha) VALUES (@fecha);";
                insertCommand.Parameters.AddWithValue("@fecha", ticket.Fecha);
                insertCommand.ExecuteReader();
            }
        }

        public List<Ticket> ObtenerTickets()
        {
            using (SqliteConnection db =
     new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "SELECT * FROM Tickets;";
                List<Ticket> tickets = new List<Ticket>();
                var resultados = insertCommand.ExecuteReader();
                while (resultados.Read())
                {
                    Ticket ticket = new Ticket(Convert.ToDateTime(resultados["Fecha"]), Convert.ToInt32(resultados["Id"]));
                    tickets.Add(ticket);
                }
                return tickets;
            }
        }

        public Ticket ObtenerTicket(int id)
        {
            using (SqliteConnection db =
     new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "SELECT * FROM Tickets WHERE Id=@id;";
                insertCommand.Parameters.AddWithValue("@id", id);
                Ticket ticket = null;
                var resultados = insertCommand.ExecuteReader();
                while (resultados.Read())
                {
                    ticket = new Ticket(Convert.ToDateTime(resultados["Fecha"]), Convert.ToInt32(resultados["Id"]));
                }
                return ticket;
            }
        }

        public bool ActualizarTicket(Ticket ticket)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "UPDATE Tickets SET Fecha=@fecha WHERE Id=@id;";
                insertCommand.Parameters.AddWithValue("@fecha", ticket.Fecha);
                insertCommand.Parameters.AddWithValue("@id", ticket.Id);
                var resultado = insertCommand.ExecuteNonQuery();
                return resultado > 0;
            }
        }

        #endregion

        #region Operaciones ventas

        public void InsertarVenta(Venta venta)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "INSERT INTO Ventas (IdTicket,IdProducto,Cantidad,Subtotal) VALUES (@idTicket,@idProducto,@cantidad,@subtotal);";
                insertCommand.Parameters.AddWithValue("@idTicket", venta.IdTicket);
                insertCommand.Parameters.AddWithValue("@idProducto", venta.IdProducto);
                insertCommand.Parameters.AddWithValue("@cantidad", venta.Cantidad);
                insertCommand.Parameters.AddWithValue("@subtotal", venta.Subtotal);
                insertCommand.ExecuteReader();
            }
        }

        public List<Venta> ObtenerVentas()
        {
            using (SqliteConnection db =
            new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "SELECT * FROM Ventas";
                List<Venta> ventas = new List<Venta>();
                var resultados = insertCommand.ExecuteReader();
                while (resultados.Read())
                {
                    Venta venta = new Venta(Convert.ToInt32(resultados["IdTicket"]), Convert.ToInt32(resultados["IdProducto"]), Convert.ToInt32(resultados["Cantidad"]), Convert.ToDouble(resultados["Subtotal"]), Convert.ToInt32(resultados["Id"]));
                    ventas.Add(venta);
                }
                return ventas;
            }
        }

        public Venta ObtenerVenta(int id)
        {
            using (SqliteConnection db =
            new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "SELECT * FROM Ventas WHERE Id=@id";
                insertCommand.Parameters.AddWithValue("@id", id);
                Venta venta = null;
                var resultados = insertCommand.ExecuteReader();
                while (resultados.Read())
                {
                    venta = new Venta(Convert.ToInt32(resultados["IdTicket"]), Convert.ToInt32(resultados["IdProducto"]), Convert.ToInt32(resultados["Cantidad"]), Convert.ToDouble(resultados["Subtotal"]), Convert.ToInt32(resultados["Id"]));
                }
                return venta;
            }
        }

        public bool ActualizarVenta(Venta venta)
        {
            using (SqliteConnection db =
              new SqliteConnection($"Filename={path}"))
            {
                db.Open();

                var insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                insertCommand.CommandText = "UPDATE Ventas SET IdTicket=@idTicket,IdProducto=@idProducto,Cantidad=@cantidad,Subtotal=@subtotal WHERE Id=@id;";
                insertCommand.Parameters.AddWithValue("@idTicket", venta.IdTicket);
                insertCommand.Parameters.AddWithValue("@idProducto", venta.IdProducto);
                insertCommand.Parameters.AddWithValue("@cantidad", venta.Cantidad);
                insertCommand.Parameters.AddWithValue("@subtotal", venta.Subtotal);
                insertCommand.Parameters.AddWithValue("@id", venta.Id);
                var resultado = insertCommand.ExecuteNonQuery();
                return resultado > 0;
            }
        }

        #endregion
    }
}
