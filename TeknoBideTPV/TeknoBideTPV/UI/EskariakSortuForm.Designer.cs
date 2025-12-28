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
            lbl_EskariaSortu = new Label();
            flp_Produktuak = new FlowLayoutPanel();
            dgv_EskariaProduktua = new DataGridView();
            lbl_PrezioTotala = new Label();
            txt_PrezioTotala = new TextBox();
            cbo_Erreserba = new ComboBox();
            label1 = new Label();
            btn_SortuEskaria = new Button();
            pnl_ProduktuMotak = new Panel();
            flp_ProduktuMotak = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv_EskariaProduktua).BeginInit();
            SuspendLayout();
            // 
            // lbl_EskariaSortu
            // 
            lbl_EskariaSortu.AutoSize = true;
            lbl_EskariaSortu.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_EskariaSortu.Location = new Point(830, 25);
            lbl_EskariaSortu.Name = "lbl_EskariaSortu";
            lbl_EskariaSortu.Size = new Size(376, 81);
            lbl_EskariaSortu.TabIndex = 0;
            lbl_EskariaSortu.Text = "Eskaria Sortu";
            // 
            // flp_Produktuak
            // 
            flp_Produktuak.Location = new Point(34, 270);
            flp_Produktuak.Name = "flp_Produktuak";
            flp_Produktuak.Size = new Size(1005, 751);
            flp_Produktuak.TabIndex = 1;
            // 
            // dgv_EskariaProduktua
            // 
            dgv_EskariaProduktua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_EskariaProduktua.Location = new Point(1138, 270);
            dgv_EskariaProduktua.Name = "dgv_EskariaProduktua";
            dgv_EskariaProduktua.RowHeadersWidth = 51;
            dgv_EskariaProduktua.Size = new Size(651, 568);
            dgv_EskariaProduktua.TabIndex = 2;
            // 
            // lbl_PrezioTotala
            // 
            lbl_PrezioTotala.AutoSize = true;
            lbl_PrezioTotala.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PrezioTotala.Location = new Point(1293, 857);
            lbl_PrezioTotala.Name = "lbl_PrezioTotala";
            lbl_PrezioTotala.Size = new Size(148, 31);
            lbl_PrezioTotala.TabIndex = 3;
            lbl_PrezioTotala.Text = "Prezio Totala:";
            // 
            // txt_PrezioTotala
            // 
            txt_PrezioTotala.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_PrezioTotala.Location = new Point(1447, 854);
            txt_PrezioTotala.Name = "txt_PrezioTotala";
            txt_PrezioTotala.Size = new Size(125, 38);
            txt_PrezioTotala.TabIndex = 4;
            // 
            // cbo_Erreserba
            // 
            cbo_Erreserba.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_Erreserba.FormattingEnabled = true;
            cbo_Erreserba.Location = new Point(1447, 164);
            cbo_Erreserba.Name = "cbo_Erreserba";
            cbo_Erreserba.Size = new Size(219, 39);
            cbo_Erreserba.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1184, 167);
            label1.Name = "label1";
            label1.Size = new Size(257, 31);
            label1.TabIndex = 6;
            label1.Text = "Aukeratutako Erreserba:";
            // 
            // btn_SortuEskaria
            // 
            btn_SortuEskaria.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SortuEskaria.Location = new Point(1351, 916);
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
            flp_ProduktuMotak.Location = new Point(34, 131);
            flp_ProduktuMotak.Name = "flp_ProduktuMotak";
            flp_ProduktuMotak.Size = new Size(1005, 125);
            flp_ProduktuMotak.TabIndex = 10;
            // 
            // EskariakSortuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(flp_ProduktuMotak);
            Controls.Add(pnl_ProduktuMotak);
            Controls.Add(btn_SortuEskaria);
            Controls.Add(label1);
            Controls.Add(cbo_Erreserba);
            Controls.Add(txt_PrezioTotala);
            Controls.Add(lbl_PrezioTotala);
            Controls.Add(dgv_EskariaProduktua);
            Controls.Add(flp_Produktuak);
            Controls.Add(lbl_EskariaSortu);
            Name = "EskariakSortuForm";
            Text = "EskariakSortuForm";
            WindowState = FormWindowState.Maximized;
            Load += EskariakSortuForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_EskariaProduktua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_EskariaSortu;
        private FlowLayoutPanel flp_Produktuak;
        private DataGridView dgv_EskariaProduktua;
        private Label lbl_PrezioTotala;
        private TextBox txt_PrezioTotala;
        private ComboBox cbo_Erreserba;
        private Label label1;
        private Button btn_SortuEskaria;
        private Panel pnl_ProduktuMotak;
        private FlowLayoutPanel flp_ProduktuMotak;
    }
}