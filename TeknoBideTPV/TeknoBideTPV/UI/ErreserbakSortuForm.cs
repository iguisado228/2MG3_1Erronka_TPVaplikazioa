using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class ErreserbakSortuForm : Form
    {
        private Form _AurrekoPantaila;
        private readonly ApiZerbitzua _api = new ApiZerbitzua();
        private int _langileaId;

        public ErreserbakSortuForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            //minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;

            _langileaId = SesioZerbitzua.LangileaId;

            this.Load += ErreserbakSortuForm_Load;
        }

        private async void ErreserbakSortuForm_Load(object sender, EventArgs e)
        {
            OrduakEzarri();

            var mahaiak = await _api.MahaiakLortuAsync();

            cmb_Mahaiak.DataSource = mahaiak;
            cmb_Mahaiak.DisplayMember = "Zenbakia";
            cmb_Mahaiak.ValueMember = "Id";

            headerControl_ErreserbakSortu.Izena = "TXAPELA";
            headerControl_ErreserbakSortu.Titulo = "ERRESERBA SORTU";
            headerControl_ErreserbakSortu.Erabiltzailea = SesioZerbitzua.Izena;
            headerControl_ErreserbakSortu.DataOrdua = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm");
        }

        private void OrduakEzarri()
        {
            cmb_Ordua.Items.Clear();

            TimeSpan bazkariHasiera = new TimeSpan(12, 30, 0);
            TimeSpan bazkariAmaiera = new TimeSpan(15, 30, 0);

            TimeSpan afariHasiera = new TimeSpan(20, 0, 0);
            TimeSpan afariAmaiera = new TimeSpan(23, 0, 0);

            TimeSpan denboraTartea = new TimeSpan(0, 30, 0);

            for (TimeSpan ordua = bazkariHasiera; ordua <= bazkariAmaiera; ordua += denboraTartea)
            {
                cmb_Ordua.Items.Add(ordua.ToString(@"hh\:mm"));
            }

            for (TimeSpan ordua = afariHasiera; ordua <= afariAmaiera; ordua += denboraTartea)
            {
                cmb_Ordua.Items.Add(ordua.ToString(@"hh\:mm"));
            }

            cmb_Ordua.SelectedIndex = 0;
        }

        private void btn_Atzera_Click(object sender, EventArgs e)
        {
            _AurrekoPantaila.Show();
            this.Close();
        }

        private async void btn_Gorde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_BezeroIzena.Text))
            {
                MessageBox.Show("Bezero izena bete behar da.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Telefonoa.Text))
            {
                MessageBox.Show("Telefonoa bete behar da.");
                return;
            }

            if (cmb_Mahaiak.SelectedItem == null)
            {
                MessageBox.Show("Aukeratu mahaia.");
                return;
            }

            var mahaia = (MahaiaDto)cmb_Mahaiak.SelectedItem;

            if (!Regex.IsMatch(txt_Telefonoa.Text, @"^\d{9}$"))
            {
                MessageBox.Show("Telefonoak 9 zenbaki izan behar ditu.");
                return;
            }

            var AukeratutakoOrdua = TimeSpan.Parse(cmb_Ordua.SelectedItem.ToString());

            var dto = new ErreserbaSortuDto
            {
                BezeroIzena = txt_BezeroIzena.Text.Trim(),
                Telefonoa = txt_Telefonoa.Text.Trim(),
                PertsonaKopurua = (int)nud_PertsonaKopurua.Value,
                EgunaOrdua = dtp_Eguna.Value.Date + AukeratutakoOrdua,
                PrezioTotala = 0,
                FakturaRuta = "",
                LangileaId = _langileaId,
                MahaiakId = mahaia.Id
            };

            bool ondo = await _api.SortuErreserbaAsync(dto);

            if (ondo)
            {
                MessageBox.Show("Erreserba sortuta!");
                _AurrekoPantaila.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Errorea erreserba sortzean.");
            }
        }
    }
}
