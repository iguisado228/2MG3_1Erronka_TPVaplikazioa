using System;
using System.Drawing;
using System.Windows.Forms;
using TeknoBideTPV.Zerbitzuak;
using TeknoBideTPV.UI.Controls;

namespace TeknoBideTPV.UI
{
    public partial class ErreserbaAmaituForm : Form
    {
        private Form _AurrekoPantaila;
        private readonly ApiZerbitzua _api = new ApiZerbitzua();
        private int _langileaId;

        public ErreserbaAmaituForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            // minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;
            _langileaId = SesioZerbitzua.LangileaId;

            // Footer prestatu
            PrestatuFooter();
        }

        private void PrestatuFooter()
        {
            footerControl_ErreserbaAmaitu.Testua = "Erreserba amaitzen";
            footerControl_ErreserbaAmaitu.AtzeraTestua = "Atzera";

            footerControl_ErreserbaAmaitu.AtzeraClick += (s, e) =>
            {
                _AurrekoPantaila.Show();
                this.Close();
            };
        }
    }
}
