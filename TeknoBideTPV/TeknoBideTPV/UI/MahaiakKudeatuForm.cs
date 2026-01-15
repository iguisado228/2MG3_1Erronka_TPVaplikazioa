using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class MahaiakKudeatuForm : Form
    {

        private Form _AurrekoPantaila;
        public MahaiakKudeatuForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            //minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;
            this.Load += MahaiakKudeatuForm_Load;

            pnl_Edukia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            PrestatuFooter();
        }

        private async void MahaiakKudeatuForm_Load(object sender, EventArgs e)
        {
            headerControl_MahaiakKudeatu.Izena = "TXAPELA";
            headerControl_MahaiakKudeatu.Titulo = "MAHAIAK KUDEATU";
            headerControl_MahaiakKudeatu.Erabiltzailea = SesioZerbitzua.Izena;
            headerControl_MahaiakKudeatu.DataOrdua = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm");
        }


        private void PrestatuFooter()
        {
            footerControl_MahaiakKudeatu.Testua = "Mahaiak kudeatzen";
            footerControl_MahaiakKudeatu.AtzeraTestua = "Atzera";

            footerControl_MahaiakKudeatu.AtzeraClick += (s, e) =>
            {
                _AurrekoPantaila.Show();
                this.Close();
            };
        }
    }
}
