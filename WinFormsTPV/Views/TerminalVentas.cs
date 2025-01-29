using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTPV.Controllers;
using WinFormsTPV.Models;

namespace WinFormsTPV.Views
{
    public partial class TerminalVentas : Form
    {
        System.Windows.Forms.Timer timerFechaHora;

        private DbController dbController = new DbController();

        private NavigationController NavigationController = new NavigationController();

        private Usuario Usuario;

        public TerminalVentas(Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            var producto = dbController.ObtenerProducto(1);
            byte[] imgBytes = Convert.FromBase64String(producto.Imagen);
            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                var img = Image.FromStream(ms);
                productoPrueba.pbImagen.Image = img;               
                img.Save("C:\\Users\\DiSeven\\Desktop\\caquita.png");
            }
            productoPrueba.btnNombre.Text = producto.Nombre;
            if (producto.Stock < 1)
            {
                productoPrueba.btnPrecio.BackColor = Color.DarkOrange;
                productoPrueba.btnPrecio.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
                productoPrueba.btnPrecio.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
                productoPrueba.btnPrecio.Enabled = false;
                productoPrueba.btnPrecio.Text = "Agotado";
            }
            else
            {
                productoPrueba.btnPrecio.Text = producto.Precio.ToString() + "€";
            }
            timerFechaHora = new System.Windows.Forms.Timer();
            timerFechaHora.Interval = 1000;
            timerFechaHora.Tick += TimerFechaHora_Tick;
            timerFechaHora.Start();
            if (usuario.EsAdmin)
            {
                btnAdministrar.Visible = true;
            }
            else
            {
                tlpAdmin.SetColumnSpan(btnFecha, 2);
            }
        }

        private void TimerFechaHora_Tick(object? sender, EventArgs e)
        {
            btnFecha.Text = $"{Usuario.Alias} {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Dispose();
            NavigationController.LoginTerminal();
        }
    }
}
