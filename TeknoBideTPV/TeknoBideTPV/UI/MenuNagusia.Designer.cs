namespace TeknoBideTPV.UI
{
    partial class MenuNagusia
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
            tlp_Menua = new TableLayoutPanel();
            btn_ErreserbakIkusi = new Button();
            btn_EskariakSortu = new Button();
            btn_EskariakIkusi = new Button();
            btn_ErreserbaAmaitu = new Button();
            btn_Txostenak = new Button();
            btn_ErreserbaSortu = new Button();
            btn_MahaiakKudeatu = new Button();
            btn_Ezarpenak = new Button();
            pnl_FooterEskariak = new Panel();
            btn_Logout = new Button();
            headerControl_Menua = new TeknoBideTPV.UI.Controls.HeaderControl();
            tlp_Menua.SuspendLayout();
            pnl_FooterEskariak.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_Menua
            // 
            tlp_Menua.ColumnCount = 4;
            tlp_Menua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Menua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Menua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Menua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Menua.Controls.Add(btn_EskariakSortu, 1, 0);
            tlp_Menua.Controls.Add(btn_ErreserbaAmaitu, 0, 1);
            tlp_Menua.Controls.Add(btn_Txostenak, 2, 1);
            tlp_Menua.Controls.Add(btn_ErreserbaSortu, 3, 0);
            tlp_Menua.Controls.Add(btn_MahaiakKudeatu, 1, 1);
            tlp_Menua.Controls.Add(btn_Ezarpenak, 3, 1);
            tlp_Menua.Controls.Add(btn_EskariakIkusi, 0, 0);
            tlp_Menua.Controls.Add(btn_ErreserbakIkusi, 2, 0);
            tlp_Menua.Dock = DockStyle.Fill;
            tlp_Menua.Location = new Point(0, 100);
            tlp_Menua.Name = "tlp_Menua";
            tlp_Menua.RowCount = 2;
            tlp_Menua.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Menua.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Menua.Size = new Size(1541, 665);
            tlp_Menua.TabIndex = 0;
            // 
            // btn_ErreserbakIkusi
            // 
            btn_ErreserbakIkusi.BackColor = Color.White;
            btn_ErreserbakIkusi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ErreserbakIkusi.Location = new Point(800, 29);
            btn_ErreserbakIkusi.Margin = new Padding(30, 29, 30, 29);
            btn_ErreserbakIkusi.Name = "btn_ErreserbakIkusi";
            btn_ErreserbakIkusi.Size = new Size(325, 273);
            btn_ErreserbakIkusi.TabIndex = 0;
            btn_ErreserbakIkusi.Text = "Erreserbak Ikusi";
            btn_ErreserbakIkusi.UseVisualStyleBackColor = false;
            btn_ErreserbakIkusi.Click += btn_ErreserbakIkusi_Click;
            // 
            // btn_EskariakSortu
            // 
            btn_EskariakSortu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EskariakSortu.Location = new Point(415, 29);
            btn_EskariakSortu.Margin = new Padding(30, 29, 30, 29);
            btn_EskariakSortu.Name = "btn_EskariakSortu";
            btn_EskariakSortu.Size = new Size(325, 273);
            btn_EskariakSortu.TabIndex = 1;
            btn_EskariakSortu.Text = "Eskaria Sortu";
            btn_EskariakSortu.UseVisualStyleBackColor = true;
            btn_EskariakSortu.Click += btn_EskariakSortu_Click;
            // 
            // btn_EskariakIkusi
            // 
            btn_EskariakIkusi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EskariakIkusi.Location = new Point(30, 29);
            btn_EskariakIkusi.Margin = new Padding(30, 29, 30, 29);
            btn_EskariakIkusi.Name = "btn_EskariakIkusi";
            btn_EskariakIkusi.Size = new Size(325, 273);
            btn_EskariakIkusi.TabIndex = 2;
            btn_EskariakIkusi.Text = "Eskariak Ikusi";
            btn_EskariakIkusi.UseVisualStyleBackColor = true;
            btn_EskariakIkusi.Click += btn_EskariakIkusi_Click;
            // 
            // btn_ErreserbaAmaitu
            // 
            btn_ErreserbaAmaitu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ErreserbaAmaitu.Location = new Point(30, 361);
            btn_ErreserbaAmaitu.Margin = new Padding(30, 29, 30, 29);
            btn_ErreserbaAmaitu.Name = "btn_ErreserbaAmaitu";
            btn_ErreserbaAmaitu.Size = new Size(325, 275);
            btn_ErreserbaAmaitu.TabIndex = 4;
            btn_ErreserbaAmaitu.Text = "Erreserba Amaitu";
            btn_ErreserbaAmaitu.UseVisualStyleBackColor = true;
            btn_ErreserbaAmaitu.Click += btn_ErreserbaAmaitu_Click;
            // 
            // btn_Txostenak
            // 
            btn_Txostenak.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Txostenak.Location = new Point(800, 361);
            btn_Txostenak.Margin = new Padding(30, 29, 30, 29);
            btn_Txostenak.Name = "btn_Txostenak";
            btn_Txostenak.Size = new Size(325, 275);
            btn_Txostenak.TabIndex = 6;
            btn_Txostenak.Text = "Txostenak";
            btn_Txostenak.UseVisualStyleBackColor = true;
            btn_Txostenak.Click += btn_Txostenak_Click;
            // 
            // btn_ErreserbaSortu
            // 
            btn_ErreserbaSortu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ErreserbaSortu.Location = new Point(1185, 29);
            btn_ErreserbaSortu.Margin = new Padding(30, 29, 30, 29);
            btn_ErreserbaSortu.Name = "btn_ErreserbaSortu";
            btn_ErreserbaSortu.Size = new Size(326, 273);
            btn_ErreserbaSortu.TabIndex = 3;
            btn_ErreserbaSortu.Text = "Erreserba Sortu";
            btn_ErreserbaSortu.UseVisualStyleBackColor = true;
            btn_ErreserbaSortu.Click += btn_ErreserbaSortu_Click;
            // 
            // btn_MahaiakKudeatu
            // 
            btn_MahaiakKudeatu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_MahaiakKudeatu.Location = new Point(415, 361);
            btn_MahaiakKudeatu.Margin = new Padding(30, 29, 30, 29);
            btn_MahaiakKudeatu.Name = "btn_MahaiakKudeatu";
            btn_MahaiakKudeatu.Size = new Size(325, 275);
            btn_MahaiakKudeatu.TabIndex = 5;
            btn_MahaiakKudeatu.Text = "Mahaiak Kudeatu";
            btn_MahaiakKudeatu.UseVisualStyleBackColor = true;
            btn_MahaiakKudeatu.Click += btn_MahaiakKudeatu_Click;
            // 
            // btn_Ezarpenak
            // 
            btn_Ezarpenak.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Ezarpenak.Location = new Point(1185, 361);
            btn_Ezarpenak.Margin = new Padding(30, 29, 30, 29);
            btn_Ezarpenak.Name = "btn_Ezarpenak";
            btn_Ezarpenak.Size = new Size(326, 275);
            btn_Ezarpenak.TabIndex = 7;
            btn_Ezarpenak.Text = "Ezarpenak";
            btn_Ezarpenak.UseVisualStyleBackColor = true;
            btn_Ezarpenak.Click += btn_Ezarpenak_Click;
            // 
            // pnl_FooterEskariak
            // 
            pnl_FooterEskariak.BackColor = Color.Silver;
            pnl_FooterEskariak.Controls.Add(btn_Logout);
            pnl_FooterEskariak.Dock = DockStyle.Bottom;
            pnl_FooterEskariak.Location = new Point(0, 765);
            pnl_FooterEskariak.Name = "pnl_FooterEskariak";
            pnl_FooterEskariak.Size = new Size(1541, 80);
            pnl_FooterEskariak.TabIndex = 13;
            // 
            // btn_Logout
            // 
            btn_Logout.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Logout.Location = new Point(1730, 8);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(160, 60);
            btn_Logout.TabIndex = 0;
            btn_Logout.Text = "Atera";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // headerControl_Menua
            // 
            headerControl_Menua.BackColor = Color.FromArgb(210, 210, 210);
            headerControl_Menua.DataOrdua = "Data - Ordua";
            headerControl_Menua.Dock = DockStyle.Top;
            headerControl_Menua.Erabiltzailea = "Erabiltzailea";
            headerControl_Menua.Izena = "TXAPELA";
            headerControl_Menua.Location = new Point(0, 0);
            headerControl_Menua.Name = "headerControl_Menua";
            headerControl_Menua.Size = new Size(1541, 100);
            headerControl_Menua.TabIndex = 5;
            headerControl_Menua.Titulo = "TITULO";
            // 
            // MenuNagusia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1541, 845);
            Controls.Add(tlp_Menua);
            Controls.Add(headerControl_Menua);
            Controls.Add(pnl_FooterEskariak);
            Name = "MenuNagusia";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "MenuNagusia";
            WindowState = FormWindowState.Maximized;
            tlp_Menua.ResumeLayout(false);
            pnl_FooterEskariak.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_Menua;
        private Button btn_ErreserbakIkusi;
        private Button btn_EskariakSortu;
        private Button btn_EskariakIkusi;
        private Button btn_ErreserbaSortu;
        private Button btn_ErreserbaAmaitu;
        private Button btn_MahaiakKudeatu;
        private Button btn_Txostenak;
        private Button btn_Ezarpenak;
        private Panel pnl_FooterEskariak;
        private Button btn_Logout;
        private Controls.HeaderControl headerControl_Menua;
    }
}