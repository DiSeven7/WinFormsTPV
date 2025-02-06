namespace WinFormsTPV.UserControls
{
    partial class FormularioCategorias
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
            tlpProductos = new TableLayoutPanel();
            SuspendLayout();
            // 
            // tlpProductos
            // 
            tlpProductos.ColumnCount = 2;
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpProductos.Dock = DockStyle.Fill;
            tlpProductos.Location = new Point(0, 0);
            tlpProductos.Margin = new Padding(0);
            tlpProductos.Name = "tlpProductos";
            tlpProductos.RowCount = 7;
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpProductos.Size = new Size(450, 600);
            tlpProductos.TabIndex = 1;
            // 
            // FormularioCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(tlpProductos);
            Name = "FormularioCategorias";
            Size = new Size(450, 600);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpProductos;
    }
}
