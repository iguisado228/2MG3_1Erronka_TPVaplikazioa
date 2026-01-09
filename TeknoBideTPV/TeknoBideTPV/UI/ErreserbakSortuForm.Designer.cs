namespace TeknoBideTPV.UI
{
    partial class ErreserbakSortuForm
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
            pnl_EzkerrekoPanela = new Panel();
            nud_PertsonaKopurua = new NumericUpDown();
            lbl_PertsonaKopurua = new Label();
            txt_Telefonoa = new TextBox();
            lbl_Telefonoa = new Label();
            txt_BezeroIzena = new TextBox();
            lbl_BezeroIzena = new Label();
            pnl_EskubikoPanela = new Panel();
            comboBox1 = new ComboBox();
            lbl_Mahaia = new Label();
            dtp_Ordua = new DateTimePicker();
            lbl_Ordua = new Label();
            dtp_Eguna = new DateTimePicker();
            lbl_Eguna = new Label();
            btn_Gorde = new Button();
            pnl_HeaderEskariak.SuspendLayout();
            pnl_FooterEskariak.SuspendLayout();
            pnl_EzkerrekoPanela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_PertsonaKopurua).BeginInit();
            pnl_EskubikoPanela.SuspendLayout();
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
            pnl_HeaderEskariak.TabIndex = 1;
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
            pnl_FooterEskariak.TabIndex = 10;
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
            // pnl_EzkerrekoPanela
            // 
            pnl_EzkerrekoPanela.BorderStyle = BorderStyle.FixedSingle;
            pnl_EzkerrekoPanela.Controls.Add(nud_PertsonaKopurua);
            pnl_EzkerrekoPanela.Controls.Add(lbl_PertsonaKopurua);
            pnl_EzkerrekoPanela.Controls.Add(txt_Telefonoa);
            pnl_EzkerrekoPanela.Controls.Add(lbl_Telefonoa);
            pnl_EzkerrekoPanela.Controls.Add(txt_BezeroIzena);
            pnl_EzkerrekoPanela.Controls.Add(lbl_BezeroIzena);
            pnl_EzkerrekoPanela.Location = new Point(80, 150);
            pnl_EzkerrekoPanela.Name = "pnl_EzkerrekoPanela";
            pnl_EzkerrekoPanela.Padding = new Padding(30);
            pnl_EzkerrekoPanela.Size = new Size(800, 700);
            pnl_EzkerrekoPanela.TabIndex = 11;
            // 
            // nud_PertsonaKopurua
            // 
            nud_PertsonaKopurua.Location = new Point(20, 280);
            nud_PertsonaKopurua.Name = "nud_PertsonaKopurua";
            nud_PertsonaKopurua.Size = new Size(150, 27);
            nud_PertsonaKopurua.TabIndex = 5;
            // 
            // lbl_PertsonaKopurua
            // 
            lbl_PertsonaKopurua.AutoSize = true;
            lbl_PertsonaKopurua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PertsonaKopurua.Location = new Point(20, 240);
            lbl_PertsonaKopurua.Name = "lbl_PertsonaKopurua";
            lbl_PertsonaKopurua.Size = new Size(167, 28);
            lbl_PertsonaKopurua.TabIndex = 4;
            lbl_PertsonaKopurua.Text = "Pertsona Kopurua";
            // 
            // txt_Telefonoa
            // 
            txt_Telefonoa.Location = new Point(20, 170);
            txt_Telefonoa.Name = "txt_Telefonoa";
            txt_Telefonoa.Size = new Size(300, 27);
            txt_Telefonoa.TabIndex = 3;
            // 
            // lbl_Telefonoa
            // 
            lbl_Telefonoa.AutoSize = true;
            lbl_Telefonoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Telefonoa.Location = new Point(20, 130);
            lbl_Telefonoa.Name = "lbl_Telefonoa";
            lbl_Telefonoa.Size = new Size(96, 28);
            lbl_Telefonoa.TabIndex = 2;
            lbl_Telefonoa.Text = "Telefonoa";
            // 
            // txt_BezeroIzena
            // 
            txt_BezeroIzena.Location = new Point(20, 60);
            txt_BezeroIzena.Name = "txt_BezeroIzena";
            txt_BezeroIzena.Size = new Size(500, 27);
            txt_BezeroIzena.TabIndex = 1;
            // 
            // lbl_BezeroIzena
            // 
            lbl_BezeroIzena.AutoSize = true;
            lbl_BezeroIzena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_BezeroIzena.Location = new Point(20, 20);
            lbl_BezeroIzena.Name = "lbl_BezeroIzena";
            lbl_BezeroIzena.Size = new Size(121, 28);
            lbl_BezeroIzena.TabIndex = 0;
            lbl_BezeroIzena.Text = "Bezero Izena";
            // 
            // pnl_EskubikoPanela
            // 
            pnl_EskubikoPanela.BorderStyle = BorderStyle.FixedSingle;
            pnl_EskubikoPanela.Controls.Add(comboBox1);
            pnl_EskubikoPanela.Controls.Add(lbl_Mahaia);
            pnl_EskubikoPanela.Controls.Add(dtp_Ordua);
            pnl_EskubikoPanela.Controls.Add(lbl_Ordua);
            pnl_EskubikoPanela.Controls.Add(dtp_Eguna);
            pnl_EskubikoPanela.Controls.Add(lbl_Eguna);
            pnl_EskubikoPanela.Location = new Point(1040, 150);
            pnl_EskubikoPanela.Name = "pnl_EskubikoPanela";
            pnl_EskubikoPanela.Padding = new Padding(30);
            pnl_EskubikoPanela.Size = new Size(800, 700);
            pnl_EskubikoPanela.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 280);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 36);
            comboBox1.TabIndex = 5;
            // 
            // lbl_Mahaia
            // 
            lbl_Mahaia.AutoSize = true;
            lbl_Mahaia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mahaia.Location = new Point(20, 240);
            lbl_Mahaia.Name = "lbl_Mahaia";
            lbl_Mahaia.Size = new Size(76, 28);
            lbl_Mahaia.TabIndex = 4;
            lbl_Mahaia.Text = "Mahaia";
            // 
            // dtp_Ordua
            // 
            dtp_Ordua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_Ordua.Format = DateTimePickerFormat.Time;
            dtp_Ordua.Location = new Point(20, 170);
            dtp_Ordua.Name = "dtp_Ordua";
            dtp_Ordua.Size = new Size(200, 34);
            dtp_Ordua.TabIndex = 3;
            // 
            // lbl_Ordua
            // 
            lbl_Ordua.AutoSize = true;
            lbl_Ordua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Ordua.Location = new Point(20, 130);
            lbl_Ordua.Name = "lbl_Ordua";
            lbl_Ordua.Size = new Size(67, 28);
            lbl_Ordua.TabIndex = 2;
            lbl_Ordua.Text = "Ordua";
            // 
            // dtp_Eguna
            // 
            dtp_Eguna.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_Eguna.Location = new Point(20, 60);
            dtp_Eguna.Name = "dtp_Eguna";
            dtp_Eguna.Size = new Size(365, 34);
            dtp_Eguna.TabIndex = 1;
            // 
            // lbl_Eguna
            // 
            lbl_Eguna.AutoSize = true;
            lbl_Eguna.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Eguna.Location = new Point(20, 20);
            lbl_Eguna.Name = "lbl_Eguna";
            lbl_Eguna.Size = new Size(66, 28);
            lbl_Eguna.TabIndex = 0;
            lbl_Eguna.Text = "Eguna";
            // 
            // btn_Gorde
            // 
            btn_Gorde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Gorde.Location = new Point(1676, 876);
            btn_Gorde.Name = "btn_Gorde";
            btn_Gorde.Size = new Size(141, 44);
            btn_Gorde.TabIndex = 13;
            btn_Gorde.Text = "Gorde";
            btn_Gorde.UseVisualStyleBackColor = true;
            btn_Gorde.Click += btn_Gorde_Click;
            // 
            // ErreserbakSortuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btn_Gorde);
            Controls.Add(pnl_EskubikoPanela);
            Controls.Add(pnl_EzkerrekoPanela);
            Controls.Add(pnl_FooterEskariak);
            Controls.Add(pnl_HeaderEskariak);
            Name = "ErreserbakSortuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErreserbakSortuForm";
            WindowState = FormWindowState.Maximized;
            pnl_HeaderEskariak.ResumeLayout(false);
            pnl_HeaderEskariak.PerformLayout();
            pnl_FooterEskariak.ResumeLayout(false);
            pnl_EzkerrekoPanela.ResumeLayout(false);
            pnl_EzkerrekoPanela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_PertsonaKopurua).EndInit();
            pnl_EskubikoPanela.ResumeLayout(false);
            pnl_EskubikoPanela.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_HeaderEskariak;
        private Label lbl_Erreserbak;
        private Label lbl_Erabiltzailea;
        private Label lbl_Izena;
        private Panel pnl_FooterEskariak;
        private Button btn_Atzera;
        private Panel pnl_EzkerrekoPanela;
        private TextBox txt_Telefonoa;
        private Label lbl_Telefonoa;
        private TextBox txt_BezeroIzena;
        private Label lbl_BezeroIzena;
        private NumericUpDown nud_PertsonaKopurua;
        private Label lbl_PertsonaKopurua;
        private Panel pnl_EskubikoPanela;
        private Label lbl_Eguna;
        private ComboBox comboBox1;
        private Label lbl_Mahaia;
        private DateTimePicker dtp_Ordua;
        private Label lbl_Ordua;
        private DateTimePicker dtp_Eguna;
        private Button btn_Gorde;
    }
}