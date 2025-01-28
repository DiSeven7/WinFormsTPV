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
            layoutPrincipal = new TableLayoutPanel();
            btnCabecera = new Button();
            tlpUsuario = new TableLayoutPanel();
            btnUsuario = new Button();
            btnFinalizar = new Button();
            tlpAdmin = new TableLayoutPanel();
            btnFecha = new Button();
            btnAdministrar = new Button();
            layoutPrincipal.SuspendLayout();
            tlpUsuario.SuspendLayout();
            tlpAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // layoutPrincipal
            // 
            layoutPrincipal.ColumnCount = 2;
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutPrincipal.Controls.Add(btnCabecera, 0, 0);
            layoutPrincipal.Controls.Add(tlpUsuario, 1, 2);
            layoutPrincipal.Controls.Add(tlpAdmin, 0, 2);
            layoutPrincipal.Dock = DockStyle.Fill;
            layoutPrincipal.Location = new Point(0, 0);
            layoutPrincipal.Name = "layoutPrincipal";
            layoutPrincipal.RowCount = 3;
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 3F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            layoutPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            layoutPrincipal.Size = new Size(1080, 720);
            layoutPrincipal.TabIndex = 0;
            // 
            // btnCabecera
            // 
            btnCabecera.BackColor = Color.LightSeaGreen;
            layoutPrincipal.SetColumnSpan(btnCabecera, 2);
            btnCabecera.Dock = DockStyle.Fill;
            btnCabecera.FlatAppearance.BorderColor = Color.White;
            btnCabecera.FlatAppearance.BorderSize = 0;
            btnCabecera.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnCabecera.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnCabecera.FlatStyle = FlatStyle.Flat;
            btnCabecera.Font = new Font("Verdana", 7.5F);
            btnCabecera.ForeColor = Color.White;
            btnCabecera.Location = new Point(0, 0);
            btnCabecera.Margin = new Padding(0);
            btnCabecera.Name = "btnCabecera";
            btnCabecera.Size = new Size(1080, 21);
            btnCabecera.TabIndex = 3;
            btnCabecera.Text = "WinForms TPV";
            btnCabecera.UseVisualStyleBackColor = false;
            // 
            // tlpUsuario
            // 
            tlpUsuario.ColumnCount = 2;
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpUsuario.Controls.Add(btnUsuario, 0, 0);
            tlpUsuario.Controls.Add(btnFinalizar, 1, 0);
            tlpUsuario.Dock = DockStyle.Fill;
            tlpUsuario.Location = new Point(540, 669);
            tlpUsuario.Margin = new Padding(0);
            tlpUsuario.Name = "tlpUsuario";
            tlpUsuario.RowCount = 1;
            tlpUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpUsuario.Size = new Size(540, 51);
            tlpUsuario.TabIndex = 0;
            // 
            // btnUsuario
            // 
            btnUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUsuario.BackColor = SystemColors.WindowFrame;
            btnUsuario.Dock = DockStyle.Fill;
            btnUsuario.FlatAppearance.BorderColor = Color.White;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            btnUsuario.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Verdana", 12F);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Location = new Point(0, 0);
            btnUsuario.Margin = new Padding(0, 0, 2, 0);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(187, 51);
            btnUsuario.TabIndex = 11;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFinalizar.BackColor = Color.Crimson;
            btnFinalizar.Dock = DockStyle.Fill;
            btnFinalizar.FlatAppearance.BorderColor = Color.White;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btnFinalizar.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Verdana", 12F);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Location = new Point(189, 0);
            btnFinalizar.Margin = new Padding(0);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(351, 51);
            btnFinalizar.TabIndex = 10;
            btnFinalizar.Text = "Finalizar jornada";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // tlpAdmin
            // 
            tlpAdmin.ColumnCount = 2;
            tlpAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpAdmin.Controls.Add(btnFecha, 0, 0);
            tlpAdmin.Controls.Add(btnAdministrar, 1, 0);
            tlpAdmin.Dock = DockStyle.Fill;
            tlpAdmin.Location = new Point(0, 669);
            tlpAdmin.Margin = new Padding(0);
            tlpAdmin.Name = "tlpAdmin";
            tlpAdmin.RowCount = 1;
            tlpAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAdmin.Size = new Size(540, 51);
            tlpAdmin.TabIndex = 8;
            // 
            // btnFecha
            // 
            btnFecha.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFecha.BackColor = SystemColors.WindowFrame;
            btnFecha.Dock = DockStyle.Fill;
            btnFecha.FlatAppearance.BorderColor = Color.White;
            btnFecha.FlatAppearance.BorderSize = 0;
            btnFecha.FlatAppearance.MouseDownBackColor = SystemColors.WindowFrame;
            btnFecha.FlatAppearance.MouseOverBackColor = SystemColors.WindowFrame;
            btnFecha.FlatStyle = FlatStyle.Flat;
            btnFecha.Font = new Font("Verdana", 12F);
            btnFecha.ForeColor = Color.White;
            btnFecha.Location = new Point(0, 0);
            btnFecha.Margin = new Padding(0, 0, 2, 0);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(349, 51);
            btnFecha.TabIndex = 11;
            btnFecha.Text = "01/01/2025 12:00:00";
            btnFecha.UseVisualStyleBackColor = false;
            // 
            // btnAdministrar
            // 
            btnAdministrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdministrar.BackColor = Color.LightSeaGreen;
            btnAdministrar.Dock = DockStyle.Fill;
            btnAdministrar.FlatAppearance.BorderColor = Color.White;
            btnAdministrar.FlatAppearance.BorderSize = 0;
            btnAdministrar.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
            btnAdministrar.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            btnAdministrar.FlatStyle = FlatStyle.Flat;
            btnAdministrar.Font = new Font("Verdana", 12F);
            btnAdministrar.ForeColor = Color.White;
            btnAdministrar.Location = new Point(351, 0);
            btnAdministrar.Margin = new Padding(0, 0, 2, 0);
            btnAdministrar.Name = "btnAdministrar";
            btnAdministrar.Size = new Size(187, 51);
            btnAdministrar.TabIndex = 13;
            btnAdministrar.Text = "Administración";
            btnAdministrar.UseVisualStyleBackColor = false;
            btnAdministrar.Visible = false;
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
            tlpUsuario.ResumeLayout(false);
            tlpAdmin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutPrincipal;
        private Button btnCabecera;
        private TableLayoutPanel tlpAdmin;
        private Button btnFecha;
        private Button btnAdministrar;
        private TableLayoutPanel tlpUsuario;
        private Button btnUsuario;
        private Button btnFinalizar;
    }
}