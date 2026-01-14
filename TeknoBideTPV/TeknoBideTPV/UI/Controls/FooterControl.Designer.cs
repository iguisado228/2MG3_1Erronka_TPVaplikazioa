namespace TeknoBideTPV.UI.Controls
{
    partial class FooterControl
    {
        private System.ComponentModel.IContainer components = null;
        private Label lbl_Testua;
        private Button btn_Atzera;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbl_Testua = new Label();
            btn_Atzera = new Button();
            SuspendLayout();
            // 
            // lbl_Testua
            // 
            lbl_Testua.Dock = DockStyle.Left;
            lbl_Testua.Font = new Font("Segoe UI", 14F);
            lbl_Testua.Location = new Point(0, 0);
            lbl_Testua.Name = "lbl_Testua";
            lbl_Testua.Padding = new Padding(20, 0, 0, 0);
            lbl_Testua.Size = new Size(600, 80);
            lbl_Testua.TabIndex = 0;
            lbl_Testua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_Atzera
            //
            btn_Atzera.Size = new Size(200, 60); 
            btn_Atzera.Location = new Point(this.Width - 220, 20); 
            btn_Atzera.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btn_Atzera.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn_Atzera.Text = "Atzera";
            btn_Atzera.BackColor = Color.White;
            btn_Atzera.FlatStyle = FlatStyle.Flat;
            btn_Atzera.FlatAppearance.BorderSize = 0;
            btn_Atzera.Image = Properties.Resources.ico_atzera;
            btn_Atzera.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Atzera.TextAlign = ContentAlignment.MiddleRight;
            btn_Atzera.Padding = new Padding(10, 0, 10, 0);
            btn_Atzera.Click += btn_Atzera_Click;

            // 
            // FooterControl
            // 
            BackColor = Color.Silver;
            Controls.Add(lbl_Testua);
            Controls.Add(btn_Atzera);
            Name = "FooterControl";
            Size = new Size(1245, 80);
            ResumeLayout(false);
        }
    }
}
