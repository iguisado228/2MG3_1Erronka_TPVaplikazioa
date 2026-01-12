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
    public partial class ErreserbakEditatuForm : Form
    {

        private Form _AurrekoPantaila;
        private readonly ApiZerbitzua _api = new ApiZerbitzua();
        private int _langileaId;
        public ErreserbakEditatuForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            //minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;

            _langileaId = SesioZerbitzua.LangileaId;
            lbl_Erabiltzailea.Text = SesioZerbitzua.Izena;
        }

        private void ErreserbakEditatuForm_Load(object sender, EventArgs e)
        {
            lbl_Erabiltzailea.Text = SesioZerbitzua.Izena;


        }
    }
}
