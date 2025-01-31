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
using WinFormsTPV.UserControls;

namespace WinFormsTPV.Views
{
    public partial class TerminalVentas : Form
    {
        System.Windows.Forms.Timer timerFechaHora;

        private DbController dbController = new DbController();

        private NavigationController NavigationController = new NavigationController();

        private List<BotonNavegacion> BotonesNavegacion = new List<BotonNavegacion>();

        private BotonNavegacion BotonAtras;

        private Usuario Usuario;

        public TerminalVentas(Usuario usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            timerFechaHora = new System.Windows.Forms.Timer();
            timerFechaHora.Interval = 1000;
            timerFechaHora.Tick += TimerFechaHora_Tick;
            timerFechaHora.Start();
            BotonAtras = new BotonNavegacion()
            {
                EsBotonAtras = true,
                Margin = new Padding(1, 1, 1, 1)
            };
            BotonAtras.Click += BotonAtras_Click;
            foreach (Categoria categoria in dbController.ObtenerCategorias().Where(x => x.Activa))
            {
                BotonNavegacion botonNavegacion = new BotonNavegacion()
                {
                    Categoria = categoria,
                    EsBotonAtras = false,
                    Margin = new Padding(1, 1, 1, 1)
                };
                botonNavegacion.Click += BotonNavegacion_Click;
                BotonesNavegacion.Add(botonNavegacion);
            }
            MuestraMenuPrincipal();
            if (usuario.EsAdmin)
            {
                btnAdministrar.Visible = true;
            }
            else
            {
                tlpAdmin.SetColumnSpan(btnFecha, 2);
            }
        }

        private void BotonNavegacion_Click(object sender, EventArgs e)
        {
            tlpProductos.Controls.Clear();
            var productos = dbController.ObtenerProductosCategoria(((BotonNavegacion)sender).Categoria);

            int col = 0;
            int row = 0;
            tlpProductos.Controls.Add(BotonAtras, 0, 0);
            col++;
            foreach (var producto in productos)
            {
                tlpProductos.Controls.Add(
                    new BotonProducto()
                    {
                        Producto = producto
                    }, col, row);
                col++;
                if (col == 8)
                {
                    row++;
                    col = 0;
                }
            }
        }

        private void BotonAtras_Click(object? sender, EventArgs e)
        {
            MuestraMenuPrincipal();
        }

        private void TimerFechaHora_Tick(object? sender, EventArgs e)
        {
            btnFecha.Text = $"{Usuario.Alias} - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Dispose();
            NavigationController.LoginTerminal();
        }

        public void MuestraMenuPrincipal()
        {
            tlpProductos.Controls.Clear();
            int col = 0;
            int row = 0;
            foreach (var boton in BotonesNavegacion)
            {
                tlpProductos.Controls.Add(boton, col, row);
                col++;
                if (col == 8)
                {
                    row++;
                    col = 0;
                }
            }
            tlpProductos.Invalidate();
        }
    }
}
