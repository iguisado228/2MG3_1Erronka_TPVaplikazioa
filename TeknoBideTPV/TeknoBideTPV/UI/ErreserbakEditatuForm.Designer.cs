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
            pnl_HeaderEskariak = new Panel();
            lbl_Erreserbak = new Label();
            lbl_Erabiltzailea = new Label();
            lbl_Izena = new Label();
            pnl_FooterEskariak = new Panel();
            btn_Atzera = new Button();
            pnl_HeaderEskariak.SuspendLayout();
            pnl_FooterEskariak.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_HeaderEskariak
            // 
            pnl_HeaderEskariak.BackColor = Color.Silver;
            pnl_HeaderEskariak.Controls.Add(lbl_Erreserbak);
            pnl_HeaderEskariak.Controls.Add(lbl_Erabiltzailea);
            pnl_HeaderEskariak.Controls.Add(lbl_Izena);
            pnl_HeaderEskariak.Dock = DockStyle.Top;
            pnl_HeaderEskariak.Location = new Point(0, 0);
            pnl_HeaderEskariak.Name = "pnl_HeaderEskariak";
            pnl_HeaderEskariak.Size = new Size(1902, 100);
            pnl_HeaderEskariak.TabIndex = 2;
            // 
            // lbl_Erreserbak
            // 
            lbl_Erreserbak.AutoSize = true;
            lbl_Erreserbak.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Erreserbak.Location = new Point(860, 27);
            lbl_Erreserbak.Name = "lbl_Erreserbak";
            lbl_Erreserbak.Size = new Size(325, 46);
            lbl_Erreserbak.TabIndex = 4;
            lbl_Erreserbak.Text = "ERRESERBA SORTU";
            // 
            // lbl_Erabiltzailea
            // 
            lbl_Erabiltzailea.AutoSize = true;
            lbl_Erabiltzailea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Erabiltzailea.Location = new Point(1700, 40);
            lbl_Erabiltzailea.Name = "lbl_Erabiltzailea";
            lbl_Erabiltzailea.Size = new Size(117, 28);
            lbl_Erabiltzailea.TabIndex = 1;
            lbl_Erabiltzailea.Text = "Erabiltzailea";
            // 
            // lbl_Izena
            // 
            lbl_Izena.AutoSize = true;
            lbl_Izena.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Izena.Location = new Point(40, 30);
            lbl_Izena.Name = "lbl_Izena";
            lbl_Izena.Size = new Size(195, 54);
            lbl_Izena.TabIndex = 0;
            lbl_Izena.Text = "TXAPELA";
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
            // ErreserbakEditatuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnl_FooterEskariak);
            Controls.Add(pnl_HeaderEskariak);
            Name = "ErreserbakEditatuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErreserbakEditatuForm";
            WindowState = FormWindowState.Maximized;
            Load += ErreserbakEditatuForm_Load;
            pnl_HeaderEskariak.ResumeLayout(false);
            pnl_HeaderEskariak.PerformLayout();
            pnl_FooterEskariak.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_HeaderEskariak;
        private Label lbl_Erreserbak;
        private Label lbl_Erabiltzailea;
        private Label lbl_Izena;
        private Panel pnl_FooterEskariak;
        private Button btn_Atzera;
    }
}