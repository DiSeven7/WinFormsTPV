namespace WinFormsTPV.Views
{
    partial class Administracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpAdmin = new TableLayoutPanel();
            tlpOpciones = new TableLayoutPanel();
            btnCerrar = new Button();
            btnConfiguracion = new Button();
            btnSistema = new Button();
            btnRendimientos = new Button();
            btnBuscarVenta = new Button();
            btnInformes = new Button();
            btnVentas = new Button();
            btnEditarCategorias = new Button();
            btnAñadirCategorias = new Button();
            btnCategorias = new Button();
            btnEditarUsuarios = new Button();
            btnAñadirUsuarios = new Button();
            btnUsuarios = new Button();
            btnEditarProductos = new Button();
            btnAñadirProductos = new Button();
            btnProductos = new Button();
            tlpAdmin.SuspendLayout();
            tlpOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpAdmin
            // 
            tlpAdmin.BackColor = Color.Silver;
            tlpAdmin.ColumnCount = 3;
            tlpAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tlpAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41F));
            tlpAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41F));
            tlpAdmin.Controls.Add(tlpOpciones, 0, 0);
            tlpAdmin.Dock = DockStyle.Fill;
            tlpAdmin.Location = new Point(0, 0);
            tlpAdmin.Margin = new Padding(0);
            tlpAdmin.Name = "tlpAdmin";
            tlpAdmin.RowCount = 1;
            tlpAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAdmin.Size = new Size(1080, 720);
            tlpAdmin.TabIndex = 0;
            // 
            // tlpOpciones
            // 
            tlpOpciones.ColumnCount = 1;
            tlpOpciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOpciones.Controls.Add(btnCerrar, 0, 15);
            tlpOpciones.Controls.Add(btnConfiguracion, 0, 14);
            tlpOpciones.Controls.Add(btnSistema, 0, 13);
            tlpOpciones.Controls.Add(btnRendimientos, 0, 12);
            tlpOpciones.Controls.Add(btnBuscarVenta, 0, 11);
            tlpOpciones.Controls.Add(btnInformes, 0, 10);
            tlpOpciones.Controls.Add(btnVentas, 0, 9);
            tlpOpciones.Controls.Add(btnEditarCategorias, 0, 8);
            tlpOpciones.Controls.Add(btnAñadirCategorias, 0, 7);
            tlpOpciones.Controls.Add(btnCategorias, 0, 6);
            tlpOpciones.Controls.Add(btnEditarUsuarios, 0, 5);
            tlpOpciones.Controls.Add(btnAñadirUsuarios, 0, 4);
            tlpOpciones.Controls.Add(btnUsuarios, 0, 3);
            tlpOpciones.Controls.Add(btnEditarProductos, 0, 2);
            tlpOpciones.Controls.Add(btnAñadirProductos, 0, 1);
            tlpOpciones.Controls.Add(btnProductos, 0, 0);
            tlpOpciones.Dock = DockStyle.Fill;
            tlpOpciones.Location = new Point(0, 0);
            tlpOpciones.Margin = new Padding(0);
            tlpOpciones.Name = "tlpOpciones";
            tlpOpciones.RowCount = 16;
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6.7F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6.7F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6.7F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6.7F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6.7F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tlpOpciones.RowStyles.Add(new RowStyle(SizeType.Percent, 6.5F));
            tlpOpciones.Size = new Size(194, 720);
            tlpOpciones.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Maroon;
            btnCerrar.Dock = DockStyle.Fill;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.Crimson;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Verdana", 9F);
            btnCerrar.ForeColor = Color.Silver;
            btnCerrar.Location = new Point(0, 670);
            btnCerrar.Margin = new Padding(0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(194, 50);
            btnCerrar.TabIndex = 23;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.Teal;
            btnConfiguracion.Dock = DockStyle.Fill;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Verdana", 9F);
            btnConfiguracion.ForeColor = Color.Silver;
            btnConfiguracion.Location = new Point(0, 627);
            btnConfiguracion.Margin = new Padding(0, 0, 0, 1);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(194, 42);
            btnConfiguracion.TabIndex = 22;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // btnSistema
            // 
            btnSistema.BackColor = Color.DimGray;
            btnSistema.Dock = DockStyle.Fill;
            btnSistema.FlatAppearance.BorderSize = 0;
            btnSistema.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnSistema.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSistema.FlatStyle = FlatStyle.Flat;
            btnSistema.Font = new Font("Verdana", 9F);
            btnSistema.ForeColor = Color.Silver;
            btnSistema.Location = new Point(0, 579);
            btnSistema.Margin = new Padding(0, 0, 0, 1);
            btnSistema.Name = "btnSistema";
            btnSistema.Size = new Size(194, 47);
            btnSistema.TabIndex = 21;
            btnSistema.Text = "Sistema";
            btnSistema.UseVisualStyleBackColor = false;
            // 
            // btnRendimientos
            // 
            btnRendimientos.BackColor = Color.Teal;
            btnRendimientos.Dock = DockStyle.Fill;
            btnRendimientos.FlatAppearance.BorderSize = 0;
            btnRendimientos.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnRendimientos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnRendimientos.FlatStyle = FlatStyle.Flat;
            btnRendimientos.Font = new Font("Verdana", 9F);
            btnRendimientos.ForeColor = Color.Silver;
            btnRendimientos.Location = new Point(0, 536);
            btnRendimientos.Margin = new Padding(0, 0, 0, 1);
            btnRendimientos.Name = "btnRendimientos";
            btnRendimientos.Size = new Size(194, 42);
            btnRendimientos.TabIndex = 20;
            btnRendimientos.Text = "Rendimiento usuarios";
            btnRendimientos.UseVisualStyleBackColor = false;
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.BackColor = Color.Teal;
            btnBuscarVenta.Dock = DockStyle.Fill;
            btnBuscarVenta.FlatAppearance.BorderSize = 0;
            btnBuscarVenta.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnBuscarVenta.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnBuscarVenta.FlatStyle = FlatStyle.Flat;
            btnBuscarVenta.Font = new Font("Verdana", 9F);
            btnBuscarVenta.ForeColor = Color.Silver;
            btnBuscarVenta.Location = new Point(0, 493);
            btnBuscarVenta.Margin = new Padding(0, 0, 0, 1);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(194, 42);
            btnBuscarVenta.TabIndex = 19;
            btnBuscarVenta.Text = "Buscar venta";
            btnBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // btnInformes
            // 
            btnInformes.BackColor = Color.Teal;
            btnInformes.Dock = DockStyle.Fill;
            btnInformes.FlatAppearance.BorderSize = 0;
            btnInformes.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnInformes.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnInformes.FlatStyle = FlatStyle.Flat;
            btnInformes.Font = new Font("Verdana", 9F);
            btnInformes.ForeColor = Color.Silver;
            btnInformes.Location = new Point(0, 450);
            btnInformes.Margin = new Padding(0, 0, 0, 1);
            btnInformes.Name = "btnInformes";
            btnInformes.Size = new Size(194, 42);
            btnInformes.TabIndex = 18;
            btnInformes.Text = "Informes";
            btnInformes.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.DimGray;
            btnVentas.Dock = DockStyle.Fill;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Verdana", 9F);
            btnVentas.ForeColor = Color.Silver;
            btnVentas.Location = new Point(0, 402);
            btnVentas.Margin = new Padding(0, 0, 0, 1);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(194, 47);
            btnVentas.TabIndex = 17;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnEditarCategorias
            // 
            btnEditarCategorias.BackColor = Color.Teal;
            btnEditarCategorias.Dock = DockStyle.Fill;
            btnEditarCategorias.FlatAppearance.BorderSize = 0;
            btnEditarCategorias.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnEditarCategorias.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnEditarCategorias.FlatStyle = FlatStyle.Flat;
            btnEditarCategorias.Font = new Font("Verdana", 9F);
            btnEditarCategorias.ForeColor = Color.Silver;
            btnEditarCategorias.Location = new Point(0, 359);
            btnEditarCategorias.Margin = new Padding(0, 0, 0, 1);
            btnEditarCategorias.Name = "btnEditarCategorias";
            btnEditarCategorias.Size = new Size(194, 42);
            btnEditarCategorias.TabIndex = 16;
            btnEditarCategorias.Text = "Editar categorías";
            btnEditarCategorias.UseVisualStyleBackColor = false;
            // 
            // btnAñadirCategorias
            // 
            btnAñadirCategorias.BackColor = Color.Teal;
            btnAñadirCategorias.Dock = DockStyle.Fill;
            btnAñadirCategorias.FlatAppearance.BorderSize = 0;
            btnAñadirCategorias.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnAñadirCategorias.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnAñadirCategorias.FlatStyle = FlatStyle.Flat;
            btnAñadirCategorias.Font = new Font("Verdana", 9F);
            btnAñadirCategorias.ForeColor = Color.Silver;
            btnAñadirCategorias.Location = new Point(0, 316);
            btnAñadirCategorias.Margin = new Padding(0, 0, 0, 1);
            btnAñadirCategorias.Name = "btnAñadirCategorias";
            btnAñadirCategorias.Size = new Size(194, 42);
            btnAñadirCategorias.TabIndex = 15;
            btnAñadirCategorias.Text = "Añadir categorías";
            btnAñadirCategorias.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.DimGray;
            btnCategorias.Dock = DockStyle.Fill;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Verdana", 9F);
            btnCategorias.ForeColor = Color.Silver;
            btnCategorias.Location = new Point(0, 268);
            btnCategorias.Margin = new Padding(0, 0, 0, 1);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(194, 47);
            btnCategorias.TabIndex = 14;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuarios
            // 
            btnEditarUsuarios.BackColor = Color.Teal;
            btnEditarUsuarios.Dock = DockStyle.Fill;
            btnEditarUsuarios.FlatAppearance.BorderSize = 0;
            btnEditarUsuarios.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnEditarUsuarios.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnEditarUsuarios.FlatStyle = FlatStyle.Flat;
            btnEditarUsuarios.Font = new Font("Verdana", 9F);
            btnEditarUsuarios.ForeColor = Color.Silver;
            btnEditarUsuarios.Location = new Point(0, 225);
            btnEditarUsuarios.Margin = new Padding(0);
            btnEditarUsuarios.Name = "btnEditarUsuarios";
            btnEditarUsuarios.Size = new Size(194, 43);
            btnEditarUsuarios.TabIndex = 7;
            btnEditarUsuarios.Text = "Editar usuarios";
            btnEditarUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnAñadirUsuarios
            // 
            btnAñadirUsuarios.BackColor = Color.Teal;
            btnAñadirUsuarios.Dock = DockStyle.Fill;
            btnAñadirUsuarios.FlatAppearance.BorderSize = 0;
            btnAñadirUsuarios.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnAñadirUsuarios.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnAñadirUsuarios.FlatStyle = FlatStyle.Flat;
            btnAñadirUsuarios.Font = new Font("Verdana", 9F);
            btnAñadirUsuarios.ForeColor = Color.Silver;
            btnAñadirUsuarios.Location = new Point(0, 182);
            btnAñadirUsuarios.Margin = new Padding(0, 0, 0, 1);
            btnAñadirUsuarios.Name = "btnAñadirUsuarios";
            btnAñadirUsuarios.Size = new Size(194, 42);
            btnAñadirUsuarios.TabIndex = 6;
            btnAñadirUsuarios.Text = "Añadir usuarios";
            btnAñadirUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.DimGray;
            btnUsuarios.Dock = DockStyle.Fill;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Verdana", 9F);
            btnUsuarios.ForeColor = Color.Silver;
            btnUsuarios.Location = new Point(0, 134);
            btnUsuarios.Margin = new Padding(0, 0, 0, 1);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(194, 47);
            btnUsuarios.TabIndex = 5;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnEditarProductos
            // 
            btnEditarProductos.BackColor = Color.Teal;
            btnEditarProductos.Dock = DockStyle.Fill;
            btnEditarProductos.FlatAppearance.BorderSize = 0;
            btnEditarProductos.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnEditarProductos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnEditarProductos.FlatStyle = FlatStyle.Flat;
            btnEditarProductos.Font = new Font("Verdana", 9F);
            btnEditarProductos.ForeColor = Color.Silver;
            btnEditarProductos.Location = new Point(0, 91);
            btnEditarProductos.Margin = new Padding(0, 0, 0, 1);
            btnEditarProductos.Name = "btnEditarProductos";
            btnEditarProductos.Size = new Size(194, 42);
            btnEditarProductos.TabIndex = 4;
            btnEditarProductos.Text = "Editar productos";
            btnEditarProductos.UseVisualStyleBackColor = false;
            // 
            // btnAñadirProductos
            // 
            btnAñadirProductos.BackColor = Color.Teal;
            btnAñadirProductos.Dock = DockStyle.Fill;
            btnAñadirProductos.FlatAppearance.BorderSize = 0;
            btnAñadirProductos.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnAñadirProductos.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnAñadirProductos.FlatStyle = FlatStyle.Flat;
            btnAñadirProductos.Font = new Font("Verdana", 9F);
            btnAñadirProductos.ForeColor = Color.Silver;
            btnAñadirProductos.Location = new Point(0, 48);
            btnAñadirProductos.Margin = new Padding(0, 0, 0, 1);
            btnAñadirProductos.Name = "btnAñadirProductos";
            btnAñadirProductos.Size = new Size(194, 42);
            btnAñadirProductos.TabIndex = 3;
            btnAñadirProductos.Text = "Añadir productos";
            btnAñadirProductos.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.DimGray;
            btnProductos.Dock = DockStyle.Fill;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Verdana", 9F);
            btnProductos.ForeColor = Color.Silver;
            btnProductos.Location = new Point(0, 0);
            btnProductos.Margin = new Padding(0, 0, 0, 1);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(194, 47);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // Administracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 720);
            Controls.Add(tlpAdmin);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Administracion";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion";
            WindowState = FormWindowState.Maximized;
            tlpAdmin.ResumeLayout(false);
            tlpOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAdmin;
        private TableLayoutPanel tlpOpciones;
        private Button btnCerrar;
        private Button btnConfiguracion;
        private Button btnSistema;
        private Button btnRendimientos;
        private Button btnBuscarVenta;
        private Button btnInformes;
        private Button btnVentas;
        private Button btnEditarCategorias;
        private Button btnAñadirCategorias;
        private Button btnCategorias;
        private Button btnEditarUsuarios;
        private Button btnAñadirUsuarios;
        private Button btnUsuarios;
        private Button btnEditarProductos;
        private Button btnAñadirProductos;
        private Button btnProductos;
    }
}