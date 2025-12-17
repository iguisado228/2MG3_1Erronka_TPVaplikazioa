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
            var ErreserbakForm = new ErreserbakForm();
            ErreserbakForm.ShowDialog();
        }

        private void btn_EskariakSortu_Click(object sender, EventArgs e)
        {
            var EskariakSortuForm = new EskariakSortuForm();
            EskariakSortuForm.ShowDialog();
        }
    }
}
