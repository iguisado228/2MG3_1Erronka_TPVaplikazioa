namespace TeknoBideTPV.Txata
{
    partial class TxatPantaila
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
            BidaliBotoia = new Button();
            MezuIdazlea = new TextBox();
            MezuPantaila = new TextBox();
            SuspendLayout();
            // 
            // BidaliBotoia
            // 
            BidaliBotoia.Location = new Point(470, 539);
            BidaliBotoia.Name = "BidaliBotoia";
            BidaliBotoia.Size = new Size(111, 50);
            BidaliBotoia.TabIndex = 0;
            BidaliBotoia.Text = "Bidali";
            BidaliBotoia.UseVisualStyleBackColor = true;
            // 
            // MezuIdazlea
            // 
            MezuIdazlea.Location = new Point(16, 539);
            MezuIdazlea.Multiline = true;
            MezuIdazlea.Name = "MezuIdazlea";
            MezuIdazlea.Size = new Size(445, 50);
            MezuIdazlea.TabIndex = 1;
            // 
            // MezuPantaila
            // 
            MezuPantaila.Location = new Point(16, 16);
            MezuPantaila.Multiline = true;
            MezuPantaila.Name = "MezuPantaila";
            MezuPantaila.Size = new Size(565, 505);
            MezuPantaila.TabIndex = 2;
            // 
            // TxatPantaila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(MezuPantaila);
            Controls.Add(MezuIdazlea);
            Controls.Add(BidaliBotoia);
            Name = "TxatPantaila";
            Size = new Size(600, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BidaliBotoia;
        private TextBox MezuIdazlea;
        private TextBox MezuPantaila;
    }
}
