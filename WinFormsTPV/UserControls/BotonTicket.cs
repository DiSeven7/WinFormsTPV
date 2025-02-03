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
    public partial class BotonTicket : UserControl
    {
        private Producto _Producto;

        public double Subtotal { get; set; }

        public Producto Producto
        {
            get { return _Producto; }
            set
            {
                _Producto = value;
                btnNombre.Text = _Producto.Nombre;
                btnSubtotal.Text = $"{_Producto.Precio}€";
                Subtotal = _Producto.Precio;
            }
        }

        public int Cantidad
        {
            get
            {
                return Convert.ToInt32(btnCantidad.Text);
            }
            set
            {
                btnCantidad.Text = value.ToString();
                btnMas.PerformClick();
            }
        }

        public BotonTicket()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(btnCantidad.Text);
            if (cantidad < _Producto.Stock)
            {
                cantidad++;
                btnCantidad.Text = Convert.ToString(cantidad);
                Subtotal = Convert.ToDouble(cantidad * _Producto.Precio);
                btnSubtotal.Text = $"{Subtotal}€";
            }
            OnClick(e);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(btnCantidad.Text);
            if (cantidad > 1)
            {
                cantidad--;
                btnCantidad.Text = Convert.ToString(cantidad);
                Subtotal = Convert.ToDouble(cantidad * _Producto.Precio);
                btnSubtotal.Text = $"{Subtotal}€";
            }
            OnClick(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Dispose();
            OnClick(e);
        }
    }
}
