using System;
using System.Windows.Forms;
using TeknoBideTPV.UI;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class MenuNagusia : Form
    {
        public MenuNagusia()
        {
            InitializeComponent();

            //minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Load += MenuNagusia_Load;
        }

        private async void MenuNagusia_Load(object sender, EventArgs e)
        {
            lbl_Erabiltzailea.Text = SesioZerbitzua.Izena;
            lbl_DataOrdua.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm");
        }

        private void btn_ErreserbakIkusi_Click(object sender, EventArgs e)
        {
            var ErreserbakForm = new ErreserbakForm(this);
            this.Hide();
            ErreserbakForm.Show();
        }

        private void btn_EskariakSortu_Click(object sender, EventArgs e)
        {
            var EskariakSortuForm = new EskariakSortuForm(this);
            this.Hide();
            EskariakSortuForm.Show();
        }

        private void btn_EskariakIkusi_Click(object sender, EventArgs e)
        {
            var EskariakForm = new EskariakForm(this);
            this.Hide();
            EskariakForm.Show();
        }
        private void btn_ErreserbaSortu_Click(object sender, EventArgs e)
        {
            var ErreserbakSortuForm = new ErreserbakSortuForm(this);
            this.Hide();
            ErreserbakSortuForm.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            SesioZerbitzua.Logout();

            var login = new LoginForm();
            login.Show();

            this.Close();
        }
    }
}
