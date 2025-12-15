using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using TeknoBideTPV.Zerbitzuak;


namespace TeknoBideTPV.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private async void btnSartu_Click(object sender, EventArgs e)
        {
            string erabiltzaile_izena = txtErabiltzailea.Text;
            string pasahitza = txtPasahitza.Text;

            var api = new ApiZerbitzua();
            var langilea = await api.LoginAsync(erabiltzaile_izena, pasahitza);

            if (langilea != null)
            {
                MessageBox.Show("Login zuzena", "Sarrera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var menuNagusia = new MenuNagusia();
                menuNagusia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erabiltzaile edo Pasahitza okerra", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtErabiltzailea_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
