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
            btn_ErreserbakErakutsi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ErreserbakIkusi).BeginInit();
            SuspendLayout();
            // 
            // dgv_ErreserbakIkusi
            // 
            dgv_ErreserbakIkusi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ErreserbakIkusi.Location = new Point(59, 41);
            dgv_ErreserbakIkusi.Name = "dgv_ErreserbakIkusi";
            dgv_ErreserbakIkusi.RowHeadersWidth = 51;
            dgv_ErreserbakIkusi.Size = new Size(992, 676);
            dgv_ErreserbakIkusi.TabIndex = 0;
            // 
            // btn_ErreserbakErakutsi
            // 
            btn_ErreserbakErakutsi.Location = new Point(1125, 97);
            btn_ErreserbakErakutsi.Name = "btn_ErreserbakErakutsi";
            btn_ErreserbakErakutsi.Size = new Size(190, 115);
            btn_ErreserbakErakutsi.TabIndex = 1;
            btn_ErreserbakErakutsi.Text = "Erreserbak erakutsi";
            btn_ErreserbakErakutsi.UseVisualStyleBackColor = true;
            btn_ErreserbakErakutsi.Click += btn_ErreserbakErakutsi_Click;
            // 
            // ErreserbakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btn_ErreserbakErakutsi);
            Controls.Add(dgv_ErreserbakIkusi);
            Name = "ErreserbakForm";
            Text = "Erreserbak";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgv_ErreserbakIkusi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ErreserbakIkusi;
        private Button btn_ErreserbakErakutsi;
    }
}