using WinFormsTPV.Models;

namespace WinFormsTPV.UserControls
{
    public partial class BotonNavegacion : UserControl
    {
        private Categoria CategoriaProducto { get; set; }
        public Categoria Categoria
        {
            get { return CategoriaProducto; }
            set
            {
                CategoriaProducto = value;
                btnTexto.Text = CategoriaProducto.Nombre;

                byte[] imgBytes = Convert.FromBase64String(CategoriaProducto.Imagen);
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    pbImagen.Image = Image.FromStream(ms);
                }
            }
        }

        private bool Atras { get; set; }
        public bool EsBotonAtras
        {
            get { return Atras; }
            set
            {
                Atras = value;
                if (Atras)
                {
                    btnTexto.Text = "Atrás";
                    btnTexto.BackColor = Color.DimGray;
                    btnTexto.FlatAppearance.MouseOverBackColor = Color.Gray;
                    btnTexto.FlatAppearance.MouseDownBackColor = Color.Gray;
                    pbImagen.Image = Image.FromFile(@"..\..\..\Resources\Atras.png");                    
                }
                else
                {
                    btnTexto.BackColor = Color.Teal;
                    btnTexto.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
                    btnTexto.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
                }
            }
        }

        public BotonNavegacion()
        {
            InitializeComponent();
        }

        private void pbImagen_MouseEnter(object sender, EventArgs e)
        {
            btnTexto.BackColor = !EsBotonAtras ? Color.LightSeaGreen : Color.Gray;
        }

        private void pbImagen_MouseLeave(object sender, EventArgs e)
        {
            btnTexto.BackColor = !EsBotonAtras ? Color.Teal : Color.DimGray;
        }

        private void Boton_Click(object? sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
