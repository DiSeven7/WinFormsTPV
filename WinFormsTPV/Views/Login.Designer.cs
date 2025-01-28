namespace WinFormsTPV.Views
{
    partial class Login
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
            btnAcceder = new Button();
            btnSalir = new Button();
            btnCabecera = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            tbUsuario = new TextBox();
            tbContraseña = new TextBox();
            lblErrorLogin = new Label();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.LightSeaGreen;
            btnAcceder.FlatAppearance.BorderColor = Color.White;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Verdana", 9F);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(388, 150);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(100, 50);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.LightCoral;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Verdana", 9F);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(282, 150);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 50);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCabecera
            // 
            btnCabecera.BackColor = Color.LightSeaGreen;
            btnCabecera.Dock = DockStyle.Top;
            btnCabecera.FlatAppearance.BorderColor = Color.White;
            btnCabecera.FlatAppearance.BorderSize = 0;
            btnCabecera.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            btnCabecera.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            btnCabecera.FlatStyle = FlatStyle.Flat;
            btnCabecera.Font = new Font("Verdana", 7.5F);
            btnCabecera.ForeColor = Color.White;
            btnCabecera.Location = new Point(0, 0);
            btnCabecera.Name = "btnCabecera";
            btnCabecera.Size = new Size(500, 25);
            btnCabecera.TabIndex = 2;
            btnCabecera.TabStop = false;
            btnCabecera.Text = "Iniciar sesión";
            btnCabecera.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Verdana", 9F);
            lblUsuario.Location = new Point(12, 53);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 18);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Verdana", 9F);
            lblContraseña.Location = new Point(12, 103);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(94, 18);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // tbUsuario
            // 
            tbUsuario.BackColor = SystemColors.Control;
            tbUsuario.BorderStyle = BorderStyle.FixedSingle;
            tbUsuario.CharacterCasing = CharacterCasing.Lower;
            tbUsuario.Location = new Point(126, 50);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.PlaceholderText = " Nombre de usuario";
            tbUsuario.Size = new Size(362, 27);
            tbUsuario.TabIndex = 1;
            tbUsuario.KeyUp += inputsFormulario_KeyUp;
            // 
            // tbContraseña
            // 
            tbContraseña.BackColor = SystemColors.Control;
            tbContraseña.BorderStyle = BorderStyle.FixedSingle;
            tbContraseña.Location = new Point(126, 100);
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PasswordChar = '*';
            tbContraseña.Size = new Size(362, 27);
            tbContraseña.TabIndex = 2;
            tbContraseña.UseSystemPasswordChar = true;
            tbContraseña.KeyUp += inputsFormulario_KeyUp;
            // 
            // lblErrorLogin
            // 
            lblErrorLogin.AutoSize = true;
            lblErrorLogin.Font = new Font("Verdana", 8F);
            lblErrorLogin.ForeColor = Color.Crimson;
            lblErrorLogin.Location = new Point(14, 168);
            lblErrorLogin.Name = "lblErrorLogin";
            lblErrorLogin.Size = new Size(241, 17);
            lblErrorLogin.TabIndex = 7;
            lblErrorLogin.Text = "Usuario o contraseña incorrectos";
            lblErrorLogin.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(500, 225);
            Controls.Add(lblErrorLogin);
            Controls.Add(tbContraseña);
            Controls.Add(tbUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnCabecera);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(500, 225);
            MinimizeBox = false;
            MinimumSize = new Size(500, 225);
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcceder;
        private Button btnSalir;
        private Button btnCabecera;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox tbUsuario;
        private TextBox tbContraseña;
        private Label lblErrorLogin;
    }
}