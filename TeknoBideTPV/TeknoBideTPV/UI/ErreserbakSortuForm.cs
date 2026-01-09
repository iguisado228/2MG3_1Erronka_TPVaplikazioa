using System;
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
            _AurrekoPantaila = AurrekoPantaila;

            _langileaId = SesioZerbitzua.LangileaId;
            lbl_Erabiltzailea.Text = SesioZerbitzua.Izena;

            this.Load += ErreserbakSortuForm_Load;
        }

        private async void ErreserbakSortuForm_Load(object sender, EventArgs e)
        {
            lbl_Erabiltzailea.Text = SesioZerbitzua.Izena;

            var mahaiak = await _api.MahaiakLortuAsync();
            comboBox1.DataSource = mahaiak;
            comboBox1.DisplayMember = "Zenbakia";
            comboBox1.ValueMember = "Id";
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

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Aukeratu mahaia.");
                return;
            }

            var mahaia = (MahaiaDto)comboBox1.SelectedItem;

            var dto = new ErreserbaSortuDto
            {
                BezeroIzena = txt_BezeroIzena.Text.Trim(),
                Telefonoa = txt_Telefonoa.Text.Trim(),
                PertsonaKopurua = (int)nud_PertsonaKopurua.Value,
                EgunaOrdua = dtp_Eguna.Value.Date + dtp_Ordua.Value.TimeOfDay,
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
