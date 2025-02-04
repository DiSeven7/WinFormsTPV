using System.Data;
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
                var item = new BotonProducto()
                {
                    Producto = producto
                };
                item.Click += Producto_Click;
                tlpProductos.Controls.Add(item, col, row);
                col++;
                if (col == 8)
                {
                    row++;
                    col = 0;
                }
            }
        }

        private void Producto_Click(object? sender, EventArgs e)
        {
            var productoAñadir = (sender as BotonProducto).Producto;
            if (!panelTicket.Controls.Cast<BotonTicket>().Any(x => x.Producto.Nombre.Equals(productoAñadir.Nombre)))
            {
                if (productoAñadir.Stock != 0)
                {
                    var btnTicket = new BotonTicket()
                    {
                        Dock = DockStyle.Top,
                        Height = 100,
                        Producto = productoAñadir
                    };
                    btnTicket.Click += BtnTicket_Click;
                    panelTicket.Controls.Add(btnTicket);
                    btnTotal.Text = $"Total: {Math.Round(panelTicket.Controls.Cast<BotonTicket>().Select(x => x.Subtotal).Sum(), 2)}€";
                }
            }
            else
            {
                if (panelTicket.Controls.Count > 0)
                {
                    var objetivo = panelTicket.Controls.Cast<BotonTicket>().First(x => x.Producto.Nombre.Equals(productoAñadir.Nombre));
                    if (objetivo.Producto.Stock != 0)
                    {
                        objetivo.Cantidad = objetivo.Cantidad++;
                    }
                }
            }
        }

        private void BtnTicket_Click(object? sender, EventArgs e)
        {
            btnTotal.Text = $"Total: {Math.Round(panelTicket.Controls.Cast<BotonTicket>().Select(x => x.Subtotal).Sum(), 2)}€";
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

        private void btnFinalizarTicket_Click(object sender, EventArgs e)
        {
            var fechaVenta = DateTime.Now;
            dbController.InsertarTicket(new Ticket(fechaVenta));
            var ticket = dbController.ObtenerTicket(fechaVenta);
            foreach (var item in panelTicket.Controls.Cast<BotonTicket>())
            {
                var producto = item.Producto;
                dbController.InsertarVenta(new Venta(ticket.Id, producto.Id, Usuario.Id, item.Cantidad, item.Subtotal));
                if (producto.Stock != -1 && producto.Stock > 0)
                {
                    producto.Stock = producto.Stock - item.Cantidad;
                }
                dbController.ActualizarStock(producto);   
            }
            panelTicket.Controls.Clear();
            btnTotal.Text = $"Total: 0.00€";
        }
    }
}
