namespace WinFormsTPV.UserControls
{
    partial class BotonTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonTicket));
            tlpTicket = new TableLayoutPanel();
            btnCantidad = new Button();
            btnSubtotal = new Button();
            btnNombre = new Button();
            btnEliminar = new Button();
            btnMas = new Button();
            btnMenos = new Button();
            tlpTicket.SuspendLayout();
            SuspendLayout();
            // 
            // tlpTicket
            // 
            tlpTicket.BackColor = Color.Silver;
            tlpTicket.ColumnCount = 3;
            tlpTicket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpTicket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpTicket.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpTicket.Controls.Add(btnCantidad, 0, 0);
            tlpTicket.Controls.Add(btnSubtotal, 1, 1);
            tlpTicket.Controls.Add(btnNombre, 1, 0);
            tlpTicket.Controls.Add(btnEliminar, 0, 1);
            tlpTicket.Controls.Add(btnMas, 2, 0);
            tlpTicket.Controls.Add(btnMenos, 2, 1);
            tlpTicket.Dock = DockStyle.Fill;
            tlpTicket.Location = new Point(0, 0);
            tlpTicket.Margin = new Padding(0);
            tlpTicket.Name = "tlpTicket";
            tlpTicket.RowCount = 2;
            tlpTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTicket.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTicket.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTicket.Size = new Size(300, 100);
            tlpTicket.TabIndex = 0;
            // 
            // btnCantidad
            // 
            btnCantidad.BackColor = Color.DimGray;
            btnCantidad.Dock = DockStyle.Fill;
            btnCantidad.FlatAppearance.BorderSize = 0;
            btnCantidad.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnCantidad.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCantidad.FlatStyle = FlatStyle.Flat;
            btnCantidad.Font = new Font("Segoe UI", 12F);
            btnCantidad.ForeColor = Color.Silver;
            btnCantidad.Location = new Point(2, 2);
            btnCantidad.Margin = new Padding(2, 2, 0, 2);
            btnCantidad.Name = "btnCantidad";
            btnCantidad.Size = new Size(43, 46);
            btnCantidad.TabIndex = 14;
            btnCantidad.Text = "1";
            btnCantidad.UseVisualStyleBackColor = false;
            // 
            // btnSubtotal
            // 
            btnSubtotal.BackColor = Color.Teal;
            btnSubtotal.Dock = DockStyle.Fill;
            btnSubtotal.FlatAppearance.BorderSize = 0;
            btnSubtotal.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnSubtotal.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnSubtotal.FlatStyle = FlatStyle.Flat;
            btnSubtotal.Font = new Font("Segoe UI", 12F);
            btnSubtotal.ForeColor = Color.Silver;
            btnSubtotal.Location = new Point(47, 50);
            btnSubtotal.Margin = new Padding(2, 0, 2, 0);
            btnSubtotal.Name = "btnSubtotal";
            btnSubtotal.Size = new Size(206, 50);
            btnSubtotal.TabIndex = 13;
            btnSubtotal.Text = "0.00€";
            btnSubtotal.UseVisualStyleBackColor = false;
            // 
            // btnNombre
            // 
            btnNombre.BackColor = Color.DimGray;
            btnNombre.Dock = DockStyle.Fill;
            btnNombre.FlatAppearance.BorderSize = 0;
            btnNombre.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnNombre.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnNombre.FlatStyle = FlatStyle.Flat;
            btnNombre.Font = new Font("Segoe UI", 12F);
            btnNombre.ForeColor = Color.Silver;
            btnNombre.Location = new Point(47, 2);
            btnNombre.Margin = new Padding(2);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(206, 46);
            btnNombre.TabIndex = 12;
            btnNombre.Text = "Coca-Cola";
            btnNombre.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Crimson;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 28F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(2, 50);
            btnEliminar.Margin = new Padding(2, 0, 0, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(43, 50);
            btnEliminar.TabIndex = 11;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMas
            // 
            btnMas.BackColor = Color.DimGray;
            btnMas.Cursor = Cursors.Hand;
            btnMas.Dock = DockStyle.Fill;
            btnMas.FlatAppearance.BorderSize = 0;
            btnMas.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMas.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMas.FlatStyle = FlatStyle.Flat;
            btnMas.Font = new Font("Segoe UI", 12F);
            btnMas.ForeColor = Color.Silver;
            btnMas.Location = new Point(255, 2);
            btnMas.Margin = new Padding(0, 2, 2, 2);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(43, 46);
            btnMas.TabIndex = 10;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = false;
            btnMas.Click += btnMas_Click;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = Color.Teal;
            btnMenos.Cursor = Cursors.Hand;
            btnMenos.Dock = DockStyle.Fill;
            btnMenos.FlatAppearance.BorderSize = 0;
            btnMenos.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnMenos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnMenos.FlatStyle = FlatStyle.Flat;
            btnMenos.Font = new Font("Segoe UI", 12F);
            btnMenos.ForeColor = Color.Silver;
            btnMenos.Location = new Point(255, 50);
            btnMenos.Margin = new Padding(0, 0, 2, 0);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(43, 50);
            btnMenos.TabIndex = 9;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // BotonTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(tlpTicket);
            Margin = new Padding(0);
            Name = "BotonTicket";
            Size = new Size(300, 100);
            tlpTicket.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpTicket;
        private Button btnSubtotal;
        private Button btnNombre;
        private Button btnEliminar;
        private Button btnMas;
        private Button btnMenos;
        private Button btnCantidad;
    }
}
