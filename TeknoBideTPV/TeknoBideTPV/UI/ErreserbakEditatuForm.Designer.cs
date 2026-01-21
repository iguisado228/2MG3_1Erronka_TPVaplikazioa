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
            headerControl1 = new TeknoBideTPV.UI.Controls.HeaderControl();
            footerControl1 = new TeknoBideTPV.UI.Controls.FooterControl();
            SuspendLayout();
            // 
            // headerControl1
            // 
            headerControl1.BackColor = Color.FromArgb(210, 210, 210);
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
            // footerControl1
            // 
            footerControl1.AtzeraTestua = "Atzera";
            footerControl1.BackColor = Color.Silver;
            footerControl1.Dock = DockStyle.Bottom;
            footerControl1.Location = new Point(0, 933);
            footerControl1.Name = "footerControl1";
            footerControl1.Size = new Size(1902, 100);
            footerControl1.TabIndex = 13;
            // 
            // ErreserbakEditatuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(footerControl1);
            Controls.Add(headerControl1);
            Name = "ErreserbakEditatuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErreserbakEditatuForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private Controls.HeaderControl headerControl1;
        private Controls.FooterControl footerControl1;
    }
}