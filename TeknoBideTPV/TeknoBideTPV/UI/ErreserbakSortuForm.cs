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
    public partial class ErreserbakSortuForm : Form
    {

        private Form _AurrekoPantaila;

        public ErreserbakSortuForm(Form AurrekoPantaila)
        {
            InitializeComponent();
            _AurrekoPantaila = AurrekoPantaila;
        }

        private void btn_Atzera_Click(object sender, EventArgs e)
        {
            _AurrekoPantaila.Show();
            this.Close();
        }
    }
}
