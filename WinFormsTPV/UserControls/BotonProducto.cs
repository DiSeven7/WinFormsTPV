using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                btnNombre.Text = _Producto.Nombre;

                if (_Producto.Stock < 1 || !_Producto.Activo)
                {
                    btnPrecio.BackColor = Color.DarkOrange;
                    btnPrecio.Enabled = false;
                    btnPrecio.Text = "Agotado";
                }
                else
                {
                    btnPrecio.Text = _Producto.Precio + "€";
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
            btnNombre.BackColor = Color.LightSeaGreen;
            if (_Producto.Stock < 1 || !_Producto.Activo)
            {
                btnPrecio.FlatAppearance.MouseOverBackColor = Color.Orange;
            }
            else
            {
                btnPrecio.BackColor = Color.Silver;
            }
        }

        private void Producto_MouseLeave(object sender, EventArgs e)
        {
            btnNombre.BackColor = Color.Teal;
            if (_Producto.Stock < 1 || !_Producto.Activo)
            {
                btnPrecio.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            }
            else
            {
                btnPrecio.BackColor = Color.DimGray;
            }
        }
    }
}
