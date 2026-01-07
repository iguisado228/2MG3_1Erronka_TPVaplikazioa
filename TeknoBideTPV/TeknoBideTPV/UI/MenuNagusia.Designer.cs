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
            tlpMenua = new TableLayoutPanel();
            btn_ErreserbakIkusi = new Button();
            btn_EskariakSortu = new Button();
            btn_EskariakIkusi = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            tlpMenua.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMenua
            // 
            tlpMenua.ColumnCount = 4;
            tlpMenua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenua.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenua.Controls.Add(btn_ErreserbakIkusi, 0, 0);
            tlpMenua.Controls.Add(btn_EskariakSortu, 1, 0);
            tlpMenua.Controls.Add(btn_EskariakIkusi, 2, 0);
            tlpMenua.Controls.Add(button4, 3, 0);
            tlpMenua.Controls.Add(button5, 0, 1);
            tlpMenua.Controls.Add(button6, 1, 1);
            tlpMenua.Controls.Add(button7, 2, 1);
            tlpMenua.Controls.Add(button8, 3, 1);
            tlpMenua.Location = new Point(4, 3);
            tlpMenua.Name = "tlpMenua";
            tlpMenua.RowCount = 2;
            tlpMenua.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMenua.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMenua.Size = new Size(1902, 838);
            tlpMenua.TabIndex = 0;
            // 
            // btn_ErreserbakIkusi
            // 
            btn_ErreserbakIkusi.Location = new Point(3, 3);
            btn_ErreserbakIkusi.Name = "btn_ErreserbakIkusi";
            btn_ErreserbakIkusi.Size = new Size(469, 413);
            btn_ErreserbakIkusi.TabIndex = 0;
            btn_ErreserbakIkusi.Text = "Erreserbak ikusi";
            btn_ErreserbakIkusi.UseVisualStyleBackColor = false;
            btn_ErreserbakIkusi.Click += btn_ErreserbakIkusi_Click;
            // 
            // btn_EskariakSortu
            // 
            btn_EskariakSortu.Location = new Point(478, 3);
            btn_EskariakSortu.Name = "btn_EskariakSortu";
            btn_EskariakSortu.Size = new Size(469, 413);
            btn_EskariakSortu.TabIndex = 1;
            btn_EskariakSortu.Text = "Eskaria Sortu";
            btn_EskariakSortu.UseVisualStyleBackColor = true;
            btn_EskariakSortu.Click += btn_EskariakSortu_Click;
            // 
            // btn_EskariakIkusi
            // 
            btn_EskariakIkusi.Location = new Point(953, 3);
            btn_EskariakIkusi.Name = "btn_EskariakIkusi";
            btn_EskariakIkusi.Size = new Size(469, 413);
            btn_EskariakIkusi.TabIndex = 2;
            btn_EskariakIkusi.Text = "EskariakIkusi";
            btn_EskariakIkusi.UseVisualStyleBackColor = true;
            btn_EskariakIkusi.Click += btn_EskariakIkusi_Click;

            // 
            // button4
            // 
            button4.Location = new Point(1428, 3);
            button4.Name = "button4";
            button4.Size = new Size(471, 413);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 422);
            button5.Name = "button5";
            button5.Size = new Size(469, 413);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(478, 422);
            button6.Name = "button6";
            button6.Size = new Size(469, 413);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(953, 422);
            button7.Name = "button7";
            button7.Size = new Size(469, 413);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(1428, 422);
            button8.Name = "button8";
            button8.Size = new Size(471, 413);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // MenuNagusia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tlpMenua);
            Name = "MenuNagusia";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "MenuNagusia";
            WindowState = FormWindowState.Maximized;
            tlpMenua.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMenua;
        private Button btn_ErreserbakIkusi;
        private Button btn_EskariakSortu;
        private Button btn_EskariakIkusi;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}