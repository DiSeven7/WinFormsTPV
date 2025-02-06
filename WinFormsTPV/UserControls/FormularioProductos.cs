using WinFormsTPV.Models;

namespace WinFormsTPV.UserControls
{
    public partial class FormularioProductos : UserControl
    {
        private Producto _Producto;

        public Producto Producto
        {
            get { return _Producto; }
            set
            {
                if (value != null)
                {
                    _Producto = value;
                }
            }
        }


        public FormularioProductos()
        {
            InitializeComponent();
        }
    }
}
