using System;
using System.Windows.Forms;
using TeknoBideTPV.UI;

namespace TeknoBideTPV.UI
{
    public partial class MenuNagusia : Form
    {
        public MenuNagusia()
        {
            InitializeComponent();
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
    }
}
