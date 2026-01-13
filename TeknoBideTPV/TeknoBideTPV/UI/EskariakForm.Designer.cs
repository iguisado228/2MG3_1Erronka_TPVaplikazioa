namespace TeknoBideTPV.UI
{
    partial class EskariakForm
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
            btn_Atzera = new Button();
            pnl_FooterEskariak = new Panel();
            pnl_EdukiaEskariak = new Panel();
            flp_Eskariak = new FlowLayoutPanel();
            flp_Filtroak = new FlowLayoutPanel();
            btn_Guztiak = new Button();
            bnt_Bidaliak = new Button();
            btn_Prest = new Button();
            btn_Zerbitzatuak = new Button();
            lbl_Izena = new Label();
            lbl_Erabiltzailea = new Label();
            lbl_Eskariak = new Label();
            headerControl_Eskariak = new TeknoBideTPV.UI.Controls.HeaderControl();
            pnl_HeaderEskariak = new Panel();
            pnl_FooterEskariak.SuspendLayout();
            pnl_EdukiaEskariak.SuspendLayout();
            flp_Filtroak.SuspendLayout();
            pnl_HeaderEskariak.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Atzera
            // 
            btn_Atzera.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Atzera.Location = new Point(1741, 8);
            btn_Atzera.Name = "btn_Atzera";
            btn_Atzera.Size = new Size(149, 60);
            btn_Atzera.TabIndex = 7;
            btn_Atzera.Text = "⬅ Atzera";
            btn_Atzera.UseVisualStyleBackColor = true;
            btn_Atzera.Click += btn_Atzera_Click;
            // 
            // pnl_FooterEskariak
            // 
            pnl_FooterEskariak.BackColor = Color.Silver;
            pnl_FooterEskariak.Controls.Add(btn_Atzera);
            pnl_FooterEskariak.Dock = DockStyle.Bottom;
            pnl_FooterEskariak.Location = new Point(0, 953);
            pnl_FooterEskariak.Name = "pnl_FooterEskariak";
            pnl_FooterEskariak.Size = new Size(1902, 80);
            pnl_FooterEskariak.TabIndex = 1;
            // 
            // pnl_EdukiaEskariak
            // 
            pnl_EdukiaEskariak.Controls.Add(flp_Eskariak);
            pnl_EdukiaEskariak.Controls.Add(flp_Filtroak);
            pnl_EdukiaEskariak.Dock = DockStyle.Fill;
            pnl_EdukiaEskariak.Location = new Point(0, 100);
            pnl_EdukiaEskariak.Name = "pnl_EdukiaEskariak";
            pnl_EdukiaEskariak.Size = new Size(1902, 853);
            pnl_EdukiaEskariak.TabIndex = 2;
            // 
            // flp_Eskariak
            // 
            flp_Eskariak.AutoScroll = true;
            flp_Eskariak.Dock = DockStyle.Fill;
            flp_Eskariak.Location = new Point(250, 0);
            flp_Eskariak.Name = "flp_Eskariak";
            flp_Eskariak.Padding = new Padding(20);
            flp_Eskariak.Size = new Size(1652, 853);
            flp_Eskariak.TabIndex = 1;
            // 
            // flp_Filtroak
            // 
            flp_Filtroak.AutoScroll = true;
            flp_Filtroak.BackColor = Color.FromArgb(224, 224, 224);
            flp_Filtroak.Controls.Add(btn_Guztiak);
            flp_Filtroak.Controls.Add(bnt_Bidaliak);
            flp_Filtroak.Controls.Add(btn_Prest);
            flp_Filtroak.Controls.Add(btn_Zerbitzatuak);
            flp_Filtroak.Dock = DockStyle.Left;
            flp_Filtroak.FlowDirection = FlowDirection.TopDown;
            flp_Filtroak.Location = new Point(0, 0);
            flp_Filtroak.Name = "flp_Filtroak";
            flp_Filtroak.Padding = new Padding(10);
            flp_Filtroak.Size = new Size(250, 853);
            flp_Filtroak.TabIndex = 0;
            // 
            // btn_Guztiak
            // 
            btn_Guztiak.BackColor = Color.FromArgb(192, 255, 192);
            btn_Guztiak.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Guztiak.Location = new Point(20, 20);
            btn_Guztiak.Margin = new Padding(10);
            btn_Guztiak.Name = "btn_Guztiak";
            btn_Guztiak.Size = new Size(220, 80);
            btn_Guztiak.TabIndex = 0;
            btn_Guztiak.Text = "Guztiak";
            btn_Guztiak.UseVisualStyleBackColor = false;
            // 
            // bnt_Bidaliak
            // 
            bnt_Bidaliak.BackColor = Color.FromArgb(255, 192, 128);
            bnt_Bidaliak.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_Bidaliak.Location = new Point(20, 120);
            bnt_Bidaliak.Margin = new Padding(10);
            bnt_Bidaliak.Name = "bnt_Bidaliak";
            bnt_Bidaliak.Size = new Size(220, 80);
            bnt_Bidaliak.TabIndex = 1;
            bnt_Bidaliak.Text = "Bidaliak";
            bnt_Bidaliak.UseVisualStyleBackColor = false;
            // 
            // btn_Prest
            // 
            btn_Prest.BackColor = Color.FromArgb(255, 192, 128);
            btn_Prest.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Prest.Location = new Point(20, 220);
            btn_Prest.Margin = new Padding(10);
            btn_Prest.Name = "btn_Prest";
            btn_Prest.Size = new Size(220, 80);
            btn_Prest.TabIndex = 2;
            btn_Prest.Text = "Prest";
            btn_Prest.UseVisualStyleBackColor = false;
            // 
            // btn_Zerbitzatuak
            // 
            btn_Zerbitzatuak.BackColor = Color.FromArgb(255, 192, 128);
            btn_Zerbitzatuak.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Zerbitzatuak.Location = new Point(20, 320);
            btn_Zerbitzatuak.Margin = new Padding(10);
            btn_Zerbitzatuak.Name = "btn_Zerbitzatuak";
            btn_Zerbitzatuak.Size = new Size(220, 80);
            btn_Zerbitzatuak.TabIndex = 3;
            btn_Zerbitzatuak.Text = "Zerbitzatuak";
            btn_Zerbitzatuak.UseVisualStyleBackColor = false;
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
            // lbl_Eskariak
            // 
            lbl_Eskariak.AutoSize = true;
            lbl_Eskariak.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Eskariak.Location = new Point(860, 27);
            lbl_Eskariak.Name = "lbl_Eskariak";
            lbl_Eskariak.Size = new Size(182, 46);
            lbl_Eskariak.TabIndex = 4;
            lbl_Eskariak.Text = "ESKARIAK";
            // 
            // headerControl_Eskariak
            // 
            headerControl_Eskariak.BackColor = Color.FromArgb(210, 210, 210);
            headerControl_Eskariak.DataOrdua = "Data - Ordua";
            headerControl_Eskariak.Dock = DockStyle.Top;
            headerControl_Eskariak.Erabiltzailea = "Erabiltzailea";
            headerControl_Eskariak.Izena = "TXAPELA";
            headerControl_Eskariak.Location = new Point(0, 0);
            headerControl_Eskariak.Name = "headerControl_Eskariak";
            headerControl_Eskariak.Size = new Size(1902, 100);
            headerControl_Eskariak.TabIndex = 5;
            headerControl_Eskariak.Titulo = "IZENBURUA";
            // 
            // pnl_HeaderEskariak
            // 
            pnl_HeaderEskariak.BackColor = Color.Silver;
            pnl_HeaderEskariak.Controls.Add(lbl_Eskariak);
            pnl_HeaderEskariak.Controls.Add(lbl_Erabiltzailea);
            pnl_HeaderEskariak.Controls.Add(lbl_Izena);
            pnl_HeaderEskariak.Dock = DockStyle.Top;
            pnl_HeaderEskariak.Location = new Point(0, 0);
            pnl_HeaderEskariak.Name = "pnl_HeaderEskariak";
            pnl_HeaderEskariak.Size = new Size(1902, 100);
            pnl_HeaderEskariak.TabIndex = 0;
            // 
            // EskariakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnl_EdukiaEskariak);
            Controls.Add(pnl_FooterEskariak);
            Controls.Add(headerControl_Eskariak);
            Name = "EskariakForm";
            Text = "EskariakForm";
            WindowState = FormWindowState.Maximized;
            pnl_FooterEskariak.ResumeLayout(false);
            pnl_EdukiaEskariak.ResumeLayout(false);
            flp_Filtroak.ResumeLayout(false);
            pnl_HeaderEskariak.ResumeLayout(false);
            pnl_HeaderEskariak.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_FooterEskariak;
        private Panel pnl_EdukiaEskariak;
        private FlowLayoutPanel flp_Filtroak;
        private Button btn_Guztiak;
        private Button bnt_Bidaliak;
        private FlowLayoutPanel flp_Eskariak;
        private Button btn_Prest;
        private Button btn_Zerbitzatuak;
        private Button btn_Atzera;
        private Label lbl_Izena;
        private Label lbl_Erabiltzailea;
        private Label lbl_Eskariak;
        private Controls.HeaderControl headerControl_Eskariak;
        private Panel pnl_HeaderEskariak;
    }
}