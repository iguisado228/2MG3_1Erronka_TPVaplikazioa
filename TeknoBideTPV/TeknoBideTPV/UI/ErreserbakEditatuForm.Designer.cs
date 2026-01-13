namespace TeknoBideTPV.UI
{
    partial class ErreserbakEditatuForm
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
            pnl_FooterEskariak = new Panel();
            btn_Atzera = new Button();
            headerControl1 = new TeknoBideTPV.UI.Controls.HeaderControl();
            pnl_FooterEskariak.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_FooterEskariak
            // 
            pnl_FooterEskariak.BackColor = Color.Silver;
            pnl_FooterEskariak.Controls.Add(btn_Atzera);
            pnl_FooterEskariak.Dock = DockStyle.Bottom;
            pnl_FooterEskariak.Location = new Point(0, 953);
            pnl_FooterEskariak.Name = "pnl_FooterEskariak";
            pnl_FooterEskariak.Size = new Size(1902, 80);
            pnl_FooterEskariak.TabIndex = 11;
            // 
            // btn_Atzera
            // 
            btn_Atzera.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Atzera.Location = new Point(1741, 8);
            btn_Atzera.Name = "btn_Atzera";
            btn_Atzera.Size = new Size(149, 60);
            btn_Atzera.TabIndex = 6;
            btn_Atzera.Text = "⬅ Atzera";
            btn_Atzera.UseVisualStyleBackColor = true;
            // 
            // headerControl1
            // 
            headerControl1.DataOrdua = "Data - Ordua";
            headerControl1.Dock = DockStyle.Top;
            headerControl1.Erabiltzailea = "Erabiltzailea";
            headerControl1.Izena = "TXAPELA";
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(1902, 100);
            headerControl1.TabIndex = 12;
            headerControl1.Titulo = "IZENBURUA";
            // 
            // ErreserbakEditatuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(headerControl1);
            Controls.Add(pnl_FooterEskariak);
            Name = "ErreserbakEditatuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErreserbakEditatuForm";
            WindowState = FormWindowState.Maximized;
            pnl_FooterEskariak.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_FooterEskariak;
        private Button btn_Atzera;
        private Controls.HeaderControl headerControl1;
    }
}