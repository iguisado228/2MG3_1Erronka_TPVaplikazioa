namespace TeknoBideTPV.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnSartu = new Button();
            lblErabiltzailea = new Label();
            lblPasahitza = new Label();
            txtErabiltzailea = new TextBox();
            txtPasahitza = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSartu
            // 
            btnSartu.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSartu.Location = new Point(690, 541);
            btnSartu.Name = "btnSartu";
            btnSartu.Size = new Size(345, 96);
            btnSartu.TabIndex = 0;
            btnSartu.Text = "Sartu";
            btnSartu.UseVisualStyleBackColor = true;
            btnSartu.Click += btnSartu_Click;
            // 
            // lblErabiltzailea
            // 
            lblErabiltzailea.AutoSize = true;
            lblErabiltzailea.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErabiltzailea.Location = new Point(396, 374);
            lblErabiltzailea.Name = "lblErabiltzailea";
            lblErabiltzailea.Size = new Size(283, 62);
            lblErabiltzailea.TabIndex = 1;
            lblErabiltzailea.Text = "Erabiltzailea:";
            // 
            // lblPasahitza
            // 
            lblPasahitza.AutoSize = true;
            lblPasahitza.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasahitza.Location = new Point(396, 450);
            lblPasahitza.Name = "lblPasahitza";
            lblPasahitza.Size = new Size(228, 62);
            lblPasahitza.TabIndex = 2;
            lblPasahitza.Text = "Pasahitza:";
            // 
            // txtErabiltzailea
            // 
            txtErabiltzailea.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtErabiltzailea.Location = new Point(672, 366);
            txtErabiltzailea.Name = "txtErabiltzailea";
            txtErabiltzailea.Size = new Size(381, 70);
            txtErabiltzailea.TabIndex = 3;
            txtErabiltzailea.TextChanged += txtErabiltzailea_TextChanged;
            // 
            // txtPasahitza
            // 
            txtPasahitza.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPasahitza.Location = new Point(672, 442);
            txtPasahitza.Name = "txtPasahitza";
            txtPasahitza.PasswordChar = '*';
            txtPasahitza.Size = new Size(381, 70);
            txtPasahitza.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1211, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 481);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pictureBox1);
            Controls.Add(txtPasahitza);
            Controls.Add(txtErabiltzailea);
            Controls.Add(lblPasahitza);
            Controls.Add(lblErabiltzailea);
            Controls.Add(btnSartu);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSartu;
        private Label lblErabiltzailea;
        private Label lblPasahitza;
        private TextBox txtErabiltzailea;
        private TextBox txtPasahitza;
        private PictureBox pictureBox1;
    }
}