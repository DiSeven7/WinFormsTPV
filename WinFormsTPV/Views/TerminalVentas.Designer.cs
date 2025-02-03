namespace WinFormsTPV.Views
{
    partial class TerminalVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalVentas));
            layoutPrincipal = new TableLayoutPanel();
            btnCabecera = new Button();
            tlpProductos = new TableLayoutPanel();
            tlpAdmin = new TableLayoutPanel();
            btnFinalizarTicket = new Button();
            btnTotal = new Button();
            tlpUsuario = new TableLayoutPanel();
            btnFecha = new Button();
            btnAdministrar = new Button();
            btnFinalizar = new Button();
            panelTicket = new Panel();
            layoutPrincipal.SuspendLayout();
            tlpAdmin.SuspendLayout();
            tlpUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPrincipal
            // 
            layoutPrincipal.BackColor = Color.Silver;
            layoutPrincipal.ColumnCount = 2;
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            layoutPrincipal.Controls.Add(btnCabecera, 0, 0);
            layoutPrincipal.Controls.Add(tlpProductos, 0, 1);
            layoutPrincipal.Controls.Add(tlpAdmin, 1, 2);
            layoutPrincipal.Controls.Add(tlpUsuario, 0, 2);
            layoutPrincipal.Controls.Add(panelTicket, 1, 1);
            layoutPrincipal.Dock = DockStyle.Fill;
            layoutPrincipal.Location = new Point(0, 0);
            layoutPrincipal.Name = "layoutPrincipal";
            layoutPrincipal.RowCount = 3;
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            layoutPrincipal.Size = new Size(1080, 720);
            layoutPrincipal.TabIndex = 0;
            // 
            // btnCabecera
            // 
            btnCabecera.BackColor = Color.Teal;
            layoutPrincipal.SetColumnSpan(btnCabecera, 2);
            btnCabecera.Dock = DockStyle.Fill;
            btnCabecera.FlatAppearance.BorderColor = Color.White;
            btnCabecera.FlatAppearance.BorderSize = 0;
            btnCabecera.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnCabecera.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCabecera.FlatStyle = FlatStyle.Flat;
            btnCabecera.Font = new Font("Verdana", 7.5F);
            btnCabecera.ForeColor = Color.Silver;
            btnCabecera.Location = new Point(0, 0);
            btnCabecera.Margin = new Padding(0);
            btnCabecera.Name = "btnCabecera";
            btnCabecera.Size = new Size(1080, 21);
            btnCabecera.TabIndex = 3;
            btnCabecera.Text = "WinForms TPV";
            btnCabecera.UseVisualStyleBackColor = false;
            // 
            // tlpProductos
            // 
            tlpProductos.BackColor = Color.Silver;
            tlpProductos.ColumnCount = 8;
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tlpProductos.Dock = DockStyle.Fill;
            tlpProductos.Location = new Point(0, 23);
            tlpProductos.Margin = new Padding(0, 2, 0, 2);
            tlpProductos.Name = "tlpProductos";
            tlpProductos.RowCount = 6;
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6750011F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6649971F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6649971F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6649971F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6649971F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6649971F));
            tlpProductos.Size = new Size(648, 644);
            tlpProductos.TabIndex = 11;
            // 
            // tlpAdmin
            // 
            tlpAdmin.ColumnCount = 2;
            tlpAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpAdmin.Controls.Add(btnFinalizarTicket, 1, 0);
            tlpAdmin.Controls.Add(btnTotal, 0, 0);
            tlpAdmin.Dock = DockStyle.Fill;
            tlpAdmin.Location = new Point(648, 669);
            tlpAdmin.Margin = new Padding(0);
            tlpAdmin.Name = "tlpAdmin";
            tlpAdmin.RowCount = 1;
            tlpAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAdmin.Size = new Size(432, 51);
            tlpAdmin.TabIndex = 13;
            // 
            // btnFinalizarTicket
            // 
            btnFinalizarTicket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinalizarTicket.BackColor = Color.Maroon;
            btnFinalizarTicket.Dock = DockStyle.Fill;
            btnFinalizarTicket.FlatAppearance.BorderColor = Color.White;
            btnFinalizarTicket.FlatAppearance.BorderSize = 0;
            btnFinalizarTicket.FlatAppearance.MouseDownBackColor = Color.Crimson;
            btnFinalizarTicket.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btnFinalizarTicket.FlatStyle = FlatStyle.Flat;
            btnFinalizarTicket.Font = new Font("Verdana", 12F);
            btnFinalizarTicket.ForeColor = Color.Silver;
            btnFinalizarTicket.Location = new Point(280, 0);
            btnFinalizarTicket.Margin = new Padding(0);
            btnFinalizarTicket.Name = "btnFinalizarTicket";
            btnFinalizarTicket.Size = new Size(152, 51);
            btnFinalizarTicket.TabIndex = 17;
            btnFinalizarTicket.Text = "Finalizar";
            btnFinalizarTicket.UseVisualStyleBackColor = false;
            // 
            // btnTotal
            // 
            btnTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTotal.BackColor = Color.FromArgb(70, 70, 70);
            btnTotal.Dock = DockStyle.Fill;
            btnTotal.FlatAppearance.BorderColor = Color.White;
            btnTotal.FlatAppearance.BorderSize = 0;
            btnTotal.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            btnTotal.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnTotal.FlatStyle = FlatStyle.Flat;
            btnTotal.Font = new Font("Verdana", 12F);
            btnTotal.ForeColor = Color.Silver;
            btnTotal.Location = new Point(0, 0);
            btnTotal.Margin = new Padding(0);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(280, 51);
            btnTotal.TabIndex = 16;
            btnTotal.Text = "Total: 0.00€";
            btnTotal.UseVisualStyleBackColor = false;
            // 
            // tlpUsuario
            // 
            tlpUsuario.ColumnCount = 3;
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpUsuario.Controls.Add(btnFecha, 0, 0);
            tlpUsuario.Controls.Add(btnAdministrar, 2, 0);
            tlpUsuario.Controls.Add(btnFinalizar, 1, 0);
            tlpUsuario.Dock = DockStyle.Fill;
            tlpUsuario.Location = new Point(0, 669);
            tlpUsuario.Margin = new Padding(0);
            tlpUsuario.Name = "tlpUsuario";
            tlpUsuario.RowCount = 1;
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUsuario.Size = new Size(648, 51);
            tlpUsuario.TabIndex = 12;
            // 
            // btnFecha
            // 
            btnFecha.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFecha.BackColor = Color.FromArgb(70, 70, 70);
            btnFecha.Dock = DockStyle.Fill;
            btnFecha.FlatAppearance.BorderColor = Color.White;
            btnFecha.FlatAppearance.BorderSize = 0;
            btnFecha.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            btnFecha.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            btnFecha.FlatStyle = FlatStyle.Flat;
            btnFecha.Font = new Font("Verdana", 12F);
            btnFecha.ForeColor = Color.Silver;
            btnFecha.Location = new Point(0, 0);
            btnFecha.Margin = new Padding(0);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(453, 51);
            btnFecha.TabIndex = 15;
            btnFecha.Text = "Admin 01/01/2025 12:00:00";
            btnFecha.UseVisualStyleBackColor = false;
            // 
            // btnAdministrar
            // 
            btnAdministrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdministrar.BackColor = Color.Teal;
            btnAdministrar.Dock = DockStyle.Fill;
            btnAdministrar.FlatAppearance.BorderColor = Color.White;
            btnAdministrar.FlatAppearance.BorderSize = 0;
            btnAdministrar.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnAdministrar.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnAdministrar.FlatStyle = FlatStyle.Flat;
            btnAdministrar.Font = new Font("Verdana", 12F);
            btnAdministrar.ForeColor = Color.White;
            btnAdministrar.Image = (Image)resources.GetObject("btnAdministrar.Image");
            btnAdministrar.Location = new Point(550, 0);
            btnAdministrar.Margin = new Padding(0);
            btnAdministrar.Name = "btnAdministrar";
            btnAdministrar.Size = new Size(98, 51);
            btnAdministrar.TabIndex = 14;
            btnAdministrar.UseVisualStyleBackColor = false;
            btnAdministrar.Visible = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinalizar.BackColor = Color.Maroon;
            btnFinalizar.Dock = DockStyle.Fill;
            btnFinalizar.FlatAppearance.BorderColor = Color.White;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatAppearance.MouseDownBackColor = Color.Crimson;
            btnFinalizar.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Verdana", 12F);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Image = (Image)resources.GetObject("btnFinalizar.Image");
            btnFinalizar.Location = new Point(453, 0);
            btnFinalizar.Margin = new Padding(0);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(97, 51);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // panelTicket
            // 
            panelTicket.AutoScroll = true;
            panelTicket.BackColor = Color.Silver;
            panelTicket.Dock = DockStyle.Fill;
            panelTicket.Location = new Point(648, 21);
            panelTicket.Margin = new Padding(0, 0, 0, 2);
            panelTicket.Name = "panelTicket";
            panelTicket.Size = new Size(432, 646);
            panelTicket.TabIndex = 14;
            // 
            // TerminalVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 720);
            Controls.Add(layoutPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TerminalVentas";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TerminalVentas";
            WindowState = FormWindowState.Maximized;
            layoutPrincipal.ResumeLayout(false);
            tlpAdmin.ResumeLayout(false);
            tlpUsuario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutPrincipal;
        private Button btnCabecera;
        private TableLayoutPanel tlpProductos;
        private TableLayoutPanel tlpAdmin;
        private TableLayoutPanel tlpUsuario;
        private Button btnFecha;
        private Button btnAdministrar;
        private Button btnFinalizar;
        private Button btnFinalizarTicket;
        private Button btnTotal;
        private Panel panelTicket;
    }
}