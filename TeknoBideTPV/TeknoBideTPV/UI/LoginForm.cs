using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoBideTPV.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnSartu_Click(object sender, EventArgs e)
        {
            string erabiltzaile_izena = txtErabiltzailea.Text;
            string pasahitza = txtPasahitza.Text;

            var loginController = new TeknoBideTPV.Services.LoginController();
            bool loginZuzena = loginController.loginEgin(erabiltzaile_izena, pasahitza);

            if (loginZuzena)
            {
                MessageBox.Show("Login zuzena", "Sarrera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var MenuNagusia = new MenuNagusia();
                MenuNagusia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erabiltzaile edo Pasahitza okerra", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
