namespace WinFormsTPV.UserControls
{
    partial class BotonesProductos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPrecio = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            // 
            // btnNombre
            // 
            btnNombre.BackColor = Color.DimGray;
            btnNombre.Dock = DockStyle.Fill;
            btnNombre.FlatAppearance.BorderSize = 0;
            btnNombre.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNombre.FlatAppearance.MouseOverBackColor = Color.DimGray;
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pbImagen, 0, 0);
            tableLayoutPanel1.Controls.Add(btnNombre, 0, 1);
            tableLayoutPanel1.Controls.Add(btnPrecio, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(200, 200);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // btnPrecio
            // 
            btnPrecio.BackColor = Color.LightSeaGreen;
            btnPrecio.Dock = DockStyle.Fill;
            btnPrecio.FlatAppearance.BorderSize = 0;
            btnPrecio.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnPrecio.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnPrecio.FlatStyle = FlatStyle.Flat;
            btnPrecio.Font = new Font("Verdana", 8F);
            btnPrecio.ForeColor = Color.White;
            btnPrecio.Location = new Point(0, 170);
            btnPrecio.Margin = new Padding(0);
            btnPrecio.Name = "btnPrecio";
            btnPrecio.Size = new Size(200, 30);
            btnPrecio.TabIndex = 2;
            btnPrecio.Text = "+";
            btnPrecio.UseVisualStyleBackColor = false;
            // 
            // BotonesProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "BotonesProductos";
            Size = new Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAñadir;
        public PictureBox pbImagen;
        public Button btnPrecio;
        public Button btnNombre;
    }
}
