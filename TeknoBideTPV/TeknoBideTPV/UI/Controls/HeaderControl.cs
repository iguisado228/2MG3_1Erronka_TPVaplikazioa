using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknoBideTPV.UI.Controls
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        public string Titulo
        {
            get => lbl_Izenburua.Text;
            set => lbl_Izenburua.Text = value;
        }

        public string Izena
        {
            get => lbl_Izena.Text;
            set => lbl_Izena.Text = value;
        }

        public string Erabiltzailea
        {
            get => lbl_Erabiltzailea.Text;
            set => lbl_Erabiltzailea.Text = value;
        }

        public string DataOrdua
        {
            get => lbl_DataOrdua.Text;
            set => lbl_DataOrdua.Text = value;
        }

        private void lbl_DataOrdua_Click(object sender, EventArgs e)
        {

        }
    }
}
