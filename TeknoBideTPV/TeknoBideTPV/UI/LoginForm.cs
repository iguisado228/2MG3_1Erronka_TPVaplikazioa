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
            if (!int.TryParse(txtErabiltzailea.Text, out int langileKodea))
            {
                MessageBox.Show("Langile kodea zenbaki bat izan behar da", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pasahitza = txtPasahitza.Text;

            var api = new ApiZerbitzua();
            var erantzuna = await api.LoginAsync(langileKodea, pasahitza);

            if (erantzuna == null)
            {
                MessageBox.Show("Errorea APIarekin konektatzean", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (erantzuna.Ok)
            {
                MessageBox.Show(erantzuna.Message, "Sarrera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var menuNagusia = new MenuNagusia();
                menuNagusia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(erantzuna.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

