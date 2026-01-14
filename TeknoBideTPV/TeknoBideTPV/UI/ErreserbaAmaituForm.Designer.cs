namespace TeknoBideTPV.UI
{
    partial class ErreserbaAmaituForm
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
            footerControl_ErreserbaAmaitu = new TeknoBideTPV.UI.Controls.FooterControl();
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
            headerControl1.TabIndex = 0;
            headerControl1.Titulo = "IZENBURUA";
            // 
            // footerControl_ErreserbaAmaitu
            // 
            footerControl_ErreserbaAmaitu.AtzeraTestua = "Atzera";
            footerControl_ErreserbaAmaitu.BackColor = Color.Silver;
            footerControl_ErreserbaAmaitu.Dock = DockStyle.Bottom;
            footerControl_ErreserbaAmaitu.Location = new Point(0, 933);
            footerControl_ErreserbaAmaitu.Name = "footerControl_ErreserbaAmaitu";
            footerControl_ErreserbaAmaitu.Size = new Size(1902, 100);
            footerControl_ErreserbaAmaitu.TabIndex = 1;
            footerControl_ErreserbaAmaitu.Testua = "";
            // 
            // ErreserbaAmaituForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(footerControl_ErreserbaAmaitu);
            Controls.Add(headerControl1);
            Name = "ErreserbaAmaituForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErreserbaAmaituForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Controls.HeaderControl headerControl1;
        private Controls.FooterControl footerControl_ErreserbaAmaitu;
    }
}