using System;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class ErreserbakEditatuForm : Form
    {
        private Form _AurrekoPantaila;
        private readonly ApiZerbitzua _api = new ApiZerbitzua();
        private int _langileaId;
        private ErreserbaDto _erreserba;

        public ErreserbakEditatuForm(Form AurrekoPantaila, ErreserbaDto erreserba)
        {
            InitializeComponent();

            //minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;
            _erreserba = erreserba;
            _langileaId = SesioZerbitzua.LangileaId;

            this.Load += ErreserbakEditatuForm_Load;
            PrestatuFooter();
        }

        private async void ErreserbakEditatuForm_Load(object sender, EventArgs e)
        {
            OrduakEzarri();
            await KargatuMahaiak();

            BindeatuDatuak();

            headerControl_EskariakEditatu.Izena = "TXAPELA";
            headerControl_EskariakEditatu.Titulo = "ERRESERBA EDITATU";
            headerControl_EskariakEditatu.Erabiltzailea = SesioZerbitzua.Izena;
            headerControl_EskariakEditatu.DataOrdua = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm");
        }

        private async Task KargatuMahaiak()
        {
            var mahaiak = await _api.MahaiakLortuAsync();
            cmb_Mahaiak.DataSource = mahaiak;
            cmb_Mahaiak.DisplayMember = "Zenbakia";
            cmb_Mahaiak.ValueMember = "Id";
        }

        private void PrestatuFooter()
        {
            footerControl_EskariakEditatu.AtzeraTestua = "Atzera";

            footerControl_EskariakEditatu.AtzeraClick += (s, e) =>
            {
                _AurrekoPantaila.Show();
                this.Close();
            };
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
        }

        private void BindeatuDatuak()
        {
            txt_BezeroIzena.Text = _erreserba.BezeroIzena;
            txt_Telefonoa.Text = _erreserba.Telefonoa;
            nud_PertsonaKopurua.Value = _erreserba.PertsonaKopurua;
            dtp_Eguna.Value = _erreserba.EgunaOrdua.Date;

            string timeStr = _erreserba.EgunaOrdua.ToString("HH:mm");
            if (cmb_Ordua.Items.Contains(timeStr))
            {
                cmb_Ordua.SelectedItem = timeStr;
            }
            else
            {
                cmb_Ordua.Text = timeStr;
            }

            cmb_Mahaiak.SelectedValue = _erreserba.MahaiakId;
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

            TimeSpan AukeratutakoOrdua;
            if (cmb_Ordua.SelectedItem != null)
                AukeratutakoOrdua = TimeSpan.Parse(cmb_Ordua.SelectedItem.ToString());
            else
            {
                if (!TimeSpan.TryParse(cmb_Ordua.Text, out AukeratutakoOrdua))
                {
                    MessageBox.Show("Ordu formatua ez da zuzena.");
                    return;
                }
            }

            var dto = new ErreserbaSortuDto
            {
                BezeroIzena = txt_BezeroIzena.Text.Trim(),
                Telefonoa = txt_Telefonoa.Text.Trim(),
                PertsonaKopurua = (int)nud_PertsonaKopurua.Value,
                EgunaOrdua = dtp_Eguna.Value.Date + AukeratutakoOrdua,
                PrezioTotala = _erreserba.PrezioTotala,
                FakturaRuta = _erreserba.FakturaRuta,
                LangileaId = _langileaId,
                MahaiakId = mahaia.Id
            };

            bool ondo = await _api.UpdateErreserbaAsync(_erreserba.Id, dto);

            if (ondo)
            {
                MessageBox.Show("Erreserba eguneratuta!");
                _AurrekoPantaila.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Errorea erreserba eguneratzean.");
            }
        }
    }
}