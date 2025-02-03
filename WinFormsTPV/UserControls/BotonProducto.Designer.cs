namespace WinFormsTPV.UserControls
{
    partial class BotonProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbImagen = new PictureBox();
            btnNombre = new Button();
            tlpContenido = new TableLayoutPanel();
            btnPrecio = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            tlpContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.Dock = DockStyle.Fill;
            pbImagen.Location = new Point(0, 0);
            pbImagen.Margin = new Padding(0);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(200, 140);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 0;
            pbImagen.TabStop = false;
            pbImagen.Click += Producto_Click;
            pbImagen.MouseEnter += Producto_MouseEnter;
            pbImagen.MouseLeave += Producto_MouseLeave;
            // 
            // btnNombre
            // 
            btnNombre.BackColor = Color.Teal;
            btnNombre.Dock = DockStyle.Fill;
            btnNombre.FlatAppearance.BorderSize = 0;
            btnNombre.FlatStyle = FlatStyle.Flat;
            btnNombre.Font = new Font("Verdana", 8F);
            btnNombre.ForeColor = Color.White;
            btnNombre.Location = new Point(0, 140);
            btnNombre.Margin = new Padding(0);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(200, 30);
            btnNombre.TabIndex = 2;
            btnNombre.Text = "Coca-Cola";
            btnNombre.UseVisualStyleBackColor = false;
            btnNombre.Click += Producto_Click;
            // 
            // tlpContenido
            // 
            tlpContenido.ColumnCount = 1;
            tlpContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContenido.Controls.Add(pbImagen, 0, 0);
            tlpContenido.Controls.Add(btnNombre, 0, 1);
            tlpContenido.Controls.Add(btnPrecio, 0, 2);
            tlpContenido.Dock = DockStyle.Fill;
            tlpContenido.Location = new Point(0, 0);
            tlpContenido.Margin = new Padding(1);
            tlpContenido.Name = "tlpContenido";
            tlpContenido.RowCount = 3;
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpContenido.Size = new Size(200, 200);
            tlpContenido.TabIndex = 3;
            // 
            // btnPrecio
            // 
            btnPrecio.BackColor = Color.DimGray;
            btnPrecio.Dock = DockStyle.Fill;
            btnPrecio.FlatAppearance.BorderSize = 0;
            btnPrecio.FlatStyle = FlatStyle.Flat;
            btnPrecio.Font = new Font("Verdana", 8F);
            btnPrecio.ForeColor = Color.White;
            btnPrecio.Location = new Point(0, 170);
            btnPrecio.Margin = new Padding(0);
            btnPrecio.Name = "btnPrecio";
            btnPrecio.Size = new Size(200, 30);
            btnPrecio.TabIndex = 2;
            btnPrecio.Text = "0,00";
            btnPrecio.UseVisualStyleBackColor = false;
            btnPrecio.Click += Producto_Click;
            // 
            // BotonProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpContenido);
            Margin = new Padding(0);
            Name = "BotonProducto";
            Size = new Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            tlpContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpContenido;
        private Button btnAñadir;
        public PictureBox pbImagen;
        public Button btnPrecio;
        public Button btnNombre;
    }
}
