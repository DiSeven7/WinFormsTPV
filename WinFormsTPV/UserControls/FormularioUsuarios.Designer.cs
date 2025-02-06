namespace WinFormsTPV.UserControls
{
    partial class FormularioUsuarios
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tlpProductos.SuspendLayout();
            SuspendLayout();
            // 
            // tlpProductos
            // 
            tlpProductos.BackColor = Color.Transparent;
            tlpProductos.ColumnCount = 2;
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpProductos.Controls.Add(textBox2, 1, 2);
            tlpProductos.Controls.Add(textBox1, 1, 1);
            tlpProductos.Dock = DockStyle.Fill;
            tlpProductos.Location = new Point(0, 0);
            tlpProductos.Margin = new Padding(0);
            tlpProductos.Name = "tlpProductos";
            tlpProductos.RowCount = 9;
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpProductos.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpProductos.Size = new Size(450, 600);
            tlpProductos.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(138, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.Silver;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(138, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 27);
            textBox2.TabIndex = 1;
            // 
            // FormularioUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(tlpProductos);
            Name = "FormularioUsuarios";
            Size = new Size(450, 600);
            tlpProductos.ResumeLayout(false);
            tlpProductos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpProductos;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
