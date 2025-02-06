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
                btnSubtotal.Text = $"{Math.Round(_Producto.Precio, 2)}€";
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
            if (cantidad < _Producto.Stock || _Producto.Stock == -1)
            {
                cantidad++;
                btnCantidad.Text = Convert.ToString(cantidad);
                Subtotal = Convert.ToDouble(cantidad * _Producto.Precio);
                btnSubtotal.Text = $"{Math.Round(Subtotal, 2)}€";
            }
            OnClick(e);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(btnCantidad.Text);
            if (cantidad > 1)
            {
                cantidad--;
            }
            else if (cantidad == 1)
            {
                cantidad -= 2;
            }
            else
            {
                cantidad--;
            }
            btnCantidad.Text = Convert.ToString(cantidad);
            Subtotal = Convert.ToDouble(cantidad * _Producto.Precio);
            btnSubtotal.Text = $"{Math.Round(Subtotal, 2)}€";

            OnClick(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Dispose();
            OnClick(e);
        }
    }
}
