namespace TeknoBideTPV.UI
{
    partial class EskariakSortuForm
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
            flp_Produktuak = new FlowLayoutPanel();
            dgv_EskariaProduktua = new DataGridView();
            lbl_PrezioTotala = new Label();
            txt_PrezioTotala = new TextBox();
            cbo_Erreserba = new ComboBox();
            label1 = new Label();
            btn_SortuEskaria = new Button();
            pnl_ProduktuMotak = new Panel();
            flp_ProduktuMotak = new FlowLayoutPanel();
            pnl_HeaderEskariak = new Panel();
            lbl_EskariaSortu = new Label();
            lbl_Erabiltzailea = new Label();
            lbl_Izena = new Label();
            btn_Atzera = new Button();
            pnl_FooterEskariak = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_EskariaProduktua).BeginInit();
            pnl_HeaderEskariak.SuspendLayout();
            pnl_FooterEskariak.SuspendLayout();
            SuspendLayout();
            // 
            // flp_Produktuak
            // 
            flp_Produktuak.Location = new Point(34, 246);
            flp_Produktuak.Name = "flp_Produktuak";
            flp_Produktuak.Size = new Size(1005, 679);
            flp_Produktuak.TabIndex = 1;
            // 
            // dgv_EskariaProduktua
            // 
            dgv_EskariaProduktua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_EskariaProduktua.Location = new Point(1132, 214);
            dgv_EskariaProduktua.Name = "dgv_EskariaProduktua";
            dgv_EskariaProduktua.RowHeadersWidth = 51;
            dgv_EskariaProduktua.Size = new Size(651, 568);
            dgv_EskariaProduktua.TabIndex = 2;
            // 
            // lbl_PrezioTotala
            // 
            lbl_PrezioTotala.AutoSize = true;
            lbl_PrezioTotala.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PrezioTotala.Location = new Point(1288, 794);
            lbl_PrezioTotala.Name = "lbl_PrezioTotala";
            lbl_PrezioTotala.Size = new Size(148, 31);
            lbl_PrezioTotala.TabIndex = 3;
            lbl_PrezioTotala.Text = "Prezio Totala:";
            // 
            // txt_PrezioTotala
            // 
            txt_PrezioTotala.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_PrezioTotala.Location = new Point(1442, 791);
            txt_PrezioTotala.Name = "txt_PrezioTotala";
            txt_PrezioTotala.Size = new Size(125, 38);
            txt_PrezioTotala.TabIndex = 4;
            // 
            // cbo_Erreserba
            // 
            cbo_Erreserba.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_Erreserba.FormattingEnabled = true;
            cbo_Erreserba.Location = new Point(1447, 144);
            cbo_Erreserba.Name = "cbo_Erreserba";
            cbo_Erreserba.Size = new Size(219, 39);
            cbo_Erreserba.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1184, 144);
            label1.Name = "label1";
            label1.Size = new Size(257, 31);
            label1.TabIndex = 6;
            label1.Text = "Aukeratutako Erreserba:";
            // 
            // btn_SortuEskaria
            // 
            btn_SortuEskaria.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SortuEskaria.Location = new Point(1334, 835);
            btn_SortuEskaria.Name = "btn_SortuEskaria";
            btn_SortuEskaria.Size = new Size(216, 68);
            btn_SortuEskaria.TabIndex = 8;
            btn_SortuEskaria.Text = "Eskaria Sortu";
            btn_SortuEskaria.UseVisualStyleBackColor = true;
            btn_SortuEskaria.Click += btn_SortuEskaria_Click;
            // 
            // pnl_ProduktuMotak
            // 
            pnl_ProduktuMotak.AutoSize = true;
            pnl_ProduktuMotak.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_ProduktuMotak.Location = new Point(34, 144);
            pnl_ProduktuMotak.Name = "pnl_ProduktuMotak";
            pnl_ProduktuMotak.Size = new Size(0, 0);
            pnl_ProduktuMotak.TabIndex = 9;
            // 
            // flp_ProduktuMotak
            // 
            flp_ProduktuMotak.Location = new Point(34, 115);
            flp_ProduktuMotak.Name = "flp_ProduktuMotak";
            flp_ProduktuMotak.Size = new Size(1005, 125);
            flp_ProduktuMotak.TabIndex = 10;
            // 
            // pnl_HeaderEskariak
            // 
            pnl_HeaderEskariak.BackColor = Color.Silver;
            pnl_HeaderEskariak.Controls.Add(lbl_EskariaSortu);
            pnl_HeaderEskariak.Controls.Add(lbl_Erabiltzailea);
            pnl_HeaderEskariak.Controls.Add(lbl_Izena);
            pnl_HeaderEskariak.Dock = DockStyle.Top;
            pnl_HeaderEskariak.Location = new Point(0, 0);
            pnl_HeaderEskariak.Name = "pnl_HeaderEskariak";
            pnl_HeaderEskariak.Size = new Size(1902, 100);
            pnl_HeaderEskariak.TabIndex = 11;
            // 
            // lbl_EskariaSortu
            // 
            lbl_EskariaSortu.AutoSize = true;
            lbl_EskariaSortu.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_EskariaSortu.Location = new Point(820, 27);
            lbl_EskariaSortu.Name = "lbl_EskariaSortu";
            lbl_EskariaSortu.Size = new Size(280, 46);
            lbl_EskariaSortu.TabIndex = 4;
            lbl_EskariaSortu.Text = "ESKARIA SORTU";
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
            btn_Atzera.TabIndex = 5;
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
            pnl_FooterEskariak.TabIndex = 12;
            // 
            // EskariakSortuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnl_FooterEskariak);
            Controls.Add(pnl_HeaderEskariak);
            Controls.Add(flp_ProduktuMotak);
            Controls.Add(pnl_ProduktuMotak);
            Controls.Add(btn_SortuEskaria);
            Controls.Add(label1);
            Controls.Add(cbo_Erreserba);
            Controls.Add(txt_PrezioTotala);
            Controls.Add(lbl_PrezioTotala);
            Controls.Add(dgv_EskariaProduktua);
            Controls.Add(flp_Produktuak);
            Name = "EskariakSortuForm";
            Text = "EskariakSortuForm";
            WindowState = FormWindowState.Maximized;
            Load += EskariakSortuForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_EskariaProduktua).EndInit();
            pnl_HeaderEskariak.ResumeLayout(false);
            pnl_HeaderEskariak.PerformLayout();
            pnl_FooterEskariak.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flp_Produktuak;
        private DataGridView dgv_EskariaProduktua;
        private Label lbl_PrezioTotala;
        private TextBox txt_PrezioTotala;
        private ComboBox cbo_Erreserba;
        private Label label1;
        private Button btn_SortuEskaria;
        private Panel pnl_ProduktuMotak;
        private FlowLayoutPanel flp_ProduktuMotak;
        private Panel pnl_HeaderEskariak;
        private Label lbl_Erabiltzailea;
        private Label lbl_Izena;
        private Panel pnl_FooterEskariak;
        private Label lbl_EskariaSortu;
        private Button btn_Atzera;
    }
}