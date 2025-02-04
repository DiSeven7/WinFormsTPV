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
            btnNombrePrecio = new Button();
            tlpContenido = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            tlpContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.Cursor = Cursors.Hand;
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
            // btnNombrePrecio
            // 
            btnNombrePrecio.BackColor = Color.Teal;
            btnNombrePrecio.Cursor = Cursors.Hand;
            btnNombrePrecio.Dock = DockStyle.Fill;
            btnNombrePrecio.FlatAppearance.BorderSize = 0;
            btnNombrePrecio.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnNombrePrecio.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnNombrePrecio.FlatStyle = FlatStyle.Flat;
            btnNombrePrecio.Font = new Font("Verdana", 7F);
            btnNombrePrecio.ForeColor = Color.White;
            btnNombrePrecio.Location = new Point(0, 140);
            btnNombrePrecio.Margin = new Padding(0);
            btnNombrePrecio.Name = "btnNombrePrecio";
            btnNombrePrecio.Size = new Size(200, 60);
            btnNombrePrecio.TabIndex = 2;
            btnNombrePrecio.Text = "Coca-Cola\r\n0.00€";
            btnNombrePrecio.UseVisualStyleBackColor = false;
            btnNombrePrecio.Click += Producto_Click;
            btnNombrePrecio.MouseEnter += Producto_MouseEnter;
            btnNombrePrecio.MouseLeave += Producto_MouseLeave;
            // 
            // tlpContenido
            // 
            tlpContenido.ColumnCount = 1;
            tlpContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContenido.Controls.Add(pbImagen, 0, 0);
            tlpContenido.Controls.Add(btnNombrePrecio, 0, 1);
            tlpContenido.Dock = DockStyle.Fill;
            tlpContenido.Location = new Point(0, 0);
            tlpContenido.Margin = new Padding(1);
            tlpContenido.Name = "tlpContenido";
            tlpContenido.RowCount = 2;
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpContenido.Size = new Size(200, 200);
            tlpContenido.TabIndex = 3;
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
        public Button btnNombrePrecio;
    }
}
