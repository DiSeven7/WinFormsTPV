using System.Data;
using System.Drawing.Printing;
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
            btnCabecera.Text = Properties.Settings.Default.NombreTienda;
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
                var btnTicket = new BotonTicket()
                {
                    Dock = DockStyle.Top,
                    Height = 100,
                    Producto = productoAñadir,
                    Cantidad = productoAñadir.Stock == 0 ? -2 : 0
                };
                btnTicket.Click += BtnTicket_Click;
                panelTicket.Controls.Add(btnTicket);
                btnTotal.Text = $"Total: {Math.Round(panelTicket.Controls.Cast<BotonTicket>().Select(x => x.Subtotal).Sum(), 2)}€";
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
                    producto.Stock = item.Cantidad > 0 ? producto.Stock - item.Cantidad : producto.Stock + (-item.Cantidad);
                }
                else if (producto.Stock == 0 && item.Cantidad < 0)
                {
                    producto.Stock = producto.Stock + (-item.Cantidad);
                }
                dbController.ActualizarStock(producto);
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += ImprimirTicket;
            PaperSize ps = new PaperSize("", 420, offsetX);
            pd.PrintController = new StandardPrintController();
            pd.DefaultPageSettings.Margins.Left = 0;
            pd.DefaultPageSettings.Margins.Right = 0;
            pd.DefaultPageSettings.Margins.Top = 0;
            pd.DefaultPageSettings.Margins.Bottom = 0;
            pd.DefaultPageSettings.PaperSize = ps;
            pd.Print();
            offsetX = 5;

            panelTicket.Controls.Clear();
            MuestraMenuPrincipal();
            btnTotal.Text = $"Total: 0.00€";
        }

        int offsetX = 5;
        private void ImprimirTicket(object sender, PrintPageEventArgs e)
        {
            double total = 0;
            int width = Properties.Settings.Default.AnchoTicket;

            Font fontTitulo = new Font("Verdana", 15, FontStyle.Bold);
            Font fontNormal = new Font("Verdana", 12);
            Font fontBold = new Font("Verdana", 12, FontStyle.Bold);
            SolidBrush b = new SolidBrush(Color.Black);

            Graphics g = e.Graphics;
            var tamañoTitulo = g.MeasureString(Properties.Settings.Default.NombreTienda, fontTitulo).Width;
            g.DrawString(Properties.Settings.Default.NombreTienda, fontTitulo, b, (width - tamañoTitulo) / 2, 5);
            offsetX += 25;
            var tamañoFecha = g.MeasureString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), fontNormal).Width;
            g.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), fontNormal, b, (width - tamañoFecha) / 2, offsetX);
            offsetX += 25;
            var tamañoEspaciador = g.MeasureString("--------------------------------------------------------", fontNormal).Width;
            g.DrawString("--------------------------------------------------------", fontNormal, b, 1, offsetX);
            offsetX += 20;
            var tamañoProducto = g.MeasureString("Producto", fontNormal).Width;
            g.DrawString("Producto", fontBold, b, ((width / 4 * 2) - tamañoProducto) / 2, offsetX);
            var tamañoCantidad = g.MeasureString("Cantidad", fontNormal).Width;
            g.DrawString("Cantidad", fontBold, b, (width / 4 * 3) - tamañoCantidad, offsetX);
            var tamañoSubtotal = g.MeasureString("Subtotal", fontNormal).Width;
            g.DrawString("Subtotal", fontBold, b, width - tamañoSubtotal, offsetX);
            offsetX += 25;

            foreach (var item in panelTicket.Controls.Cast<BotonTicket>())
            {
                var producto = item.Producto;
                var tamañoItemNombre = g.MeasureString(item.Producto.Nombre, fontNormal).Width;
                g.DrawString(item.Producto.Nombre, fontNormal, b, ((width / 4 * 2) - tamañoItemNombre) / 2, offsetX);
                var tamañoItemCantidad = g.MeasureString(item.Cantidad.ToString(), fontNormal).Width;
                g.DrawString(item.Cantidad.ToString(), fontNormal, b, (width / 4 * 3) - (tamañoCantidad / 2) - (tamañoItemCantidad / 2), offsetX);
                var tamañoItemSubtotal = g.MeasureString($"{Math.Round(item.Subtotal, 2)}€", fontNormal).Width;
                g.DrawString($"{Math.Round(item.Subtotal, 2)}€", fontNormal, b, width - (tamañoSubtotal / 2) - (tamañoItemSubtotal / 2), offsetX);
                total += item.Subtotal;
                offsetX += 25;
            }
            g.DrawString("--------------------------------------------------------", fontNormal, b, 1, offsetX);
            offsetX += 25;
            var tamañoTotal = g.MeasureString($"TOTAL:{Math.Round(total, 2)}€", fontBold).Width;
            g.DrawString($"TOTAL:{Math.Round(total, 2)}€", fontBold, b, (width - tamañoTotal) / 2, offsetX);
            offsetX += 25;
            var tamañoIva = g.MeasureString("IVA Incluido", fontNormal).Width;
            g.DrawString("IVA Incluido", fontNormal, b, (width - tamañoIva) / 2, offsetX);
            offsetX += 25;
            var tamañoGracias = g.MeasureString("Gracias por su visita", fontNormal).Width;
            g.DrawString("Gracias por su visita", fontNormal, b, (width - tamañoGracias) / 2, offsetX);
            offsetX += 25;
            g.Dispose();
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            Administracion admin = new Administracion();
            admin.ShowDialog();
        }
    }
}
