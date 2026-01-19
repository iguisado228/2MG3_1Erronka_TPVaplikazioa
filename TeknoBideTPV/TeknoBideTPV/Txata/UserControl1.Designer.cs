namespace TeknoBideTPV.Txata
{
    partial class UserControl1
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
            Bidali = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // Bidali
            // 
            Bidali.Location = new Point(481, 539);
            Bidali.Name = "Bidali";
            Bidali.Size = new Size(111, 50);
            Bidali.TabIndex = 0;
            Bidali.Text = "button1";
            Bidali.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 539);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(455, 50);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 16);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(565, 505);
            textBox2.TabIndex = 2;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Bidali);
            Name = "UserControl1";
            Size = new Size(600, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bidali;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
