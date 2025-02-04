using WinFormsTPV.Models;

namespace WinFormsTPV.UserControls
{
    public partial class BotonProducto : UserControl
    {
        private Producto _Producto;
        public Producto Producto
        {
            get { return _Producto; }
            set
            {
                _Producto = value;

                btnNombrePrecio.Text = _Producto.Nombre;

                if ((_Producto.Stock < 1 && _Producto.Stock != -1) || !_Producto.Activo)
                {
                    btnNombrePrecio.BackColor = Color.Maroon;
                    btnNombrePrecio.FlatAppearance.MouseDownBackColor = Color.Crimson;
                    btnNombrePrecio.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    btnNombrePrecio.Text = $"{_Producto.Nombre}\r\nAgotado";
                }
                else
                {
                    btnNombrePrecio.Text = $"{_Producto.Nombre}\r\n{_Producto.Precio}€";
                }

                byte[] imgBytes = Convert.FromBase64String(_Producto.Imagen);
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    pbImagen.Image = Image.FromStream(ms);
                }
            }
        }

        public BotonProducto()
        {
            InitializeComponent();
        }

        private void Producto_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void Producto_MouseEnter(object sender, EventArgs e)
        {
            btnNombrePrecio.BackColor = Color.LightSeaGreen;
            if ((_Producto.Stock < 1 && Producto.Stock != -1) || !_Producto.Activo)
            {
                btnNombrePrecio.BackColor = Color.Crimson;
            }
            else
            {
                btnNombrePrecio.BackColor = Color.LightSeaGreen;
            }
        }

        private void Producto_MouseLeave(object sender, EventArgs e)
        {
            if ((_Producto.Stock < 1 && Producto.Stock != -1) || !_Producto.Activo)
            {
                btnNombrePrecio.BackColor = Color.Maroon;
            }
            else
            {
                btnNombrePrecio.BackColor = Color.Teal;
            }
        }
    }
}
