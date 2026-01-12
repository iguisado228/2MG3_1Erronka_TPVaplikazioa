namespace TeknoBideTPV.UI
{
    partial class ErreserbakForm
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
            dgv_ErreserbakIkusi = new DataGridView();
            pnl_HeaderErreserbak = new Panel();
            lbl_Erreserbak = new Label();
            lbl_Erabiltzailea = new Label();
            lbl_Izena = new Label();
            btn_Atzera = new Button();
            lbl_Bilatu = new Label();
            txt_Bilatu = new TextBox();
            lbl_Eguna = new Label();
            dtp_Eguna = new DateTimePicker();
            btn_Bilatu = new Button();
            btn_Garbitu = new Button();
            pnl_FooterEskariak = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_ErreserbakIkusi).BeginInit();
            pnl_HeaderErreserbak.SuspendLayout();
            pnl_FooterEskariak.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_ErreserbakIkusi
            // 
            dgv_ErreserbakIkusi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ErreserbakIkusi.Location = new Point(40, 240);
            dgv_ErreserbakIkusi.Name = "dgv_ErreserbakIkusi";
            dgv_ErreserbakIkusi.RowHeadersWidth = 51;
            dgv_ErreserbakIkusi.Size = new Size(1840, 623);
            dgv_ErreserbakIkusi.TabIndex = 0;
            // 
            // pnl_HeaderErreserbak
            // 
            pnl_HeaderErreserbak.BackColor = Color.Silver;
            pnl_HeaderErreserbak.Controls.Add(lbl_Erreserbak);
            pnl_HeaderErreserbak.Controls.Add(lbl_Erabiltzailea);
            pnl_HeaderErreserbak.Controls.Add(lbl_Izena);
            pnl_HeaderErreserbak.Dock = DockStyle.Top;
            pnl_HeaderErreserbak.Location = new Point(0, 0);
            pnl_HeaderErreserbak.Name = "pnl_HeaderErreserbak";
            pnl_HeaderErreserbak.Size = new Size(1902, 100);
            pnl_HeaderErreserbak.TabIndex = 2;
            // 
            // lbl_Erreserbak
            // 
            lbl_Erreserbak.AutoSize = true;
            lbl_Erreserbak.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Erreserbak.Location = new Point(854, 20);
            lbl_Erreserbak.Name = "lbl_Erreserbak";
            lbl_Erreserbak.Size = new Size(266, 54);
            lbl_Erreserbak.TabIndex = 3;
            lbl_Erreserbak.Text = "ERRESERBAK";
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
            // btn_Atzera
            // 
            btn_Atzera.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Atzera.Location = new Point(1741, 8);
            btn_Atzera.Name = "btn_Atzera";
            btn_Atzera.Size = new Size(149, 60);
            btn_Atzera.TabIndex = 6;
            btn_Atzera.Text = "⬅ Atzera";
            btn_Atzera.UseVisualStyleBackColor = true;
            btn_Atzera.Click += btn_Atzera_Click;
            // 
            // lbl_Bilatu
            // 
            lbl_Bilatu.AutoSize = true;
            lbl_Bilatu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Bilatu.Location = new Point(49, 147);
            lbl_Bilatu.Name = "lbl_Bilatu";
            lbl_Bilatu.Size = new Size(92, 38);
            lbl_Bilatu.TabIndex = 3;
            lbl_Bilatu.Text = "Bilatu:";
            // 
            // txt_Bilatu
            // 
            txt_Bilatu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Bilatu.Location = new Point(147, 147);
            txt_Bilatu.Name = "txt_Bilatu";
            txt_Bilatu.Size = new Size(300, 43);
            txt_Bilatu.TabIndex = 4;
            // 
            // lbl_Eguna
            // 
            lbl_Eguna.AutoSize = true;
            lbl_Eguna.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Eguna.Location = new Point(458, 147);
            lbl_Eguna.Name = "lbl_Eguna";
            lbl_Eguna.Size = new Size(99, 38);
            lbl_Eguna.TabIndex = 5;
            lbl_Eguna.Text = "Eguna:";
            // 
            // dtp_Eguna
            // 
            dtp_Eguna.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_Eguna.Format = DateTimePickerFormat.Short;
            dtp_Eguna.Location = new Point(563, 147);
            dtp_Eguna.Name = "dtp_Eguna";
            dtp_Eguna.ShowCheckBox = true;
            dtp_Eguna.Size = new Size(220, 43);
            dtp_Eguna.TabIndex = 6;
            // 
            // btn_Bilatu
            // 
            btn_Bilatu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Bilatu.Location = new Point(806, 145);
            btn_Bilatu.Name = "btn_Bilatu";
            btn_Bilatu.Size = new Size(156, 46);
            btn_Bilatu.TabIndex = 7;
            btn_Bilatu.Text = "Bilatu";
            btn_Bilatu.UseVisualStyleBackColor = true;
            btn_Bilatu.Click += btn_Bilatu_Click;
            // 
            // btn_Garbitu
            // 
            btn_Garbitu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Garbitu.Location = new Point(1628, 147);
            btn_Garbitu.Name = "btn_Garbitu";
            btn_Garbitu.Size = new Size(226, 50);
            btn_Garbitu.TabIndex = 8;
            btn_Garbitu.Text = "Filtroak Garbitu";
            btn_Garbitu.UseVisualStyleBackColor = true;
            btn_Garbitu.Click += btn_Garbitu_Click;
            // 
            // pnl_FooterEskariak
            // 
            pnl_FooterEskariak.BackColor = Color.Silver;
            pnl_FooterEskariak.Controls.Add(btn_Atzera);
            pnl_FooterEskariak.Dock = DockStyle.Bottom;
            pnl_FooterEskariak.Location = new Point(0, 953);
            pnl_FooterEskariak.Name = "pnl_FooterEskariak";
            pnl_FooterEskariak.Size = new Size(1902, 80);
            pnl_FooterEskariak.TabIndex = 9;
            // 
            // ErreserbakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnl_FooterEskariak);
            Controls.Add(btn_Garbitu);
            Controls.Add(btn_Bilatu);
            Controls.Add(dtp_Eguna);
            Controls.Add(lbl_Eguna);
            Controls.Add(txt_Bilatu);
            Controls.Add(lbl_Bilatu);
            Controls.Add(pnl_HeaderErreserbak);
            Controls.Add(dgv_ErreserbakIkusi);
            Name = "ErreserbakForm";
            Text = "Erreserbak";
            WindowState = FormWindowState.Maximized;
            Load += ErreserbakForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_ErreserbakIkusi).EndInit();
            pnl_HeaderErreserbak.ResumeLayout(false);
            pnl_HeaderErreserbak.PerformLayout();
            pnl_FooterEskariak.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_ErreserbakIkusi;
        private Panel pnl_HeaderErreserbak;
        private Label lbl_Erabiltzailea;
        private Label lbl_Izena;
        private Label lbl_Erreserbak;
        private Label lbl_Bilatu;
        private TextBox txt_Bilatu;
        private Label lbl_Eguna;
        private DateTimePicker dtp_Eguna;
        private Button btn_Bilatu;
        private Button btn_Garbitu;
        private Panel pnl_FooterEskariak;
        private Button btn_Atzera;
    }
}