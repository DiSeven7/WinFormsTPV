using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    btnTexto.FlatAppearance.MouseOverBackColor = Color.Silver;
                    btnTexto.FlatAppearance.MouseDownBackColor = Color.Silver;
                    pbImagen.Image = Image.FromFile(@"..\..\..\Resources\Atras.png");                    
                }
                else
                {
                    btnTexto.BackColor = Color.LightSeaGreen;
                    btnTexto.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
                    btnTexto.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
                }
            }
        }

        public BotonNavegacion()
        {
            InitializeComponent();
        }

        private void pbImagen_MouseEnter(object sender, EventArgs e)
        {
            btnTexto.BackColor = !EsBotonAtras ? Color.MediumTurquoise : Color.Silver;
        }

        private void pbImagen_MouseLeave(object sender, EventArgs e)
        {
            btnTexto.BackColor = !EsBotonAtras ? Color.LightSeaGreen : Color.DimGray;
        }

        private void Boton_Click(object? sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
