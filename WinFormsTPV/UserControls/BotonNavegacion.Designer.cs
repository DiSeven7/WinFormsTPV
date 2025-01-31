namespace WinFormsTPV.UserControls
{
    partial class BotonNavegacion
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
            tlpContenido = new TableLayoutPanel();
            btnTexto = new Button();
            pbImagen = new PictureBox();
            tlpContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // tlpContenido
            // 
            tlpContenido.ColumnCount = 1;
            tlpContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContenido.Controls.Add(btnTexto, 0, 1);
            tlpContenido.Controls.Add(pbImagen, 0, 0);
            tlpContenido.Dock = DockStyle.Fill;
            tlpContenido.Location = new Point(0, 0);
            tlpContenido.Margin = new Padding(1);
            tlpContenido.Name = "tlpContenido";
            tlpContenido.RowCount = 2;
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpContenido.Size = new Size(200, 200);
            tlpContenido.TabIndex = 0;
            // 
            // btnTexto
            // 
            btnTexto.BackColor = Color.LightSeaGreen;
            btnTexto.Dock = DockStyle.Fill;
            btnTexto.FlatAppearance.BorderSize = 0;
            btnTexto.FlatAppearance.MouseDownBackColor = Color.MediumTurquoise;
            btnTexto.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            btnTexto.FlatStyle = FlatStyle.Flat;
            btnTexto.Font = new Font("Verdana", 10F);
            btnTexto.ForeColor = Color.White;
            btnTexto.Location = new Point(0, 140);
            btnTexto.Margin = new Padding(0);
            btnTexto.Name = "btnTexto";
            btnTexto.Size = new Size(200, 60);
            btnTexto.TabIndex = 4;
            btnTexto.Text = "Categoría";
            btnTexto.UseVisualStyleBackColor = false;
            btnTexto.Click += Boton_Click;
            // 
            // pbImagen
            // 
            pbImagen.Dock = DockStyle.Fill;
            pbImagen.Location = new Point(0, 0);
            pbImagen.Margin = new Padding(0);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(200, 140);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 5;
            pbImagen.TabStop = false;
            pbImagen.Click += Boton_Click;
            pbImagen.MouseEnter += pbImagen_MouseEnter;
            pbImagen.MouseLeave += pbImagen_MouseLeave;
            // 
            // BotonNavegacion
            // 
            Controls.Add(tlpContenido);
            Margin = new Padding(0);
            Name = "BotonNavegacion";
            Size = new Size(200, 200);
            tlpContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpContenido;
        public Button btnTexto;
        private PictureBox pbImagen;
    }
}
