using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.Zerbitzuak;
using TeknoBideTPV.UI.Controls;

namespace TeknoBideTPV.UI
{
    public partial class ErreserbaAmaituForm : Form
    {
        private Form _AurrekoPantaila;
        private readonly ApiZerbitzua _api = new ApiZerbitzua();
        private int _langileaId;

        private ErreserbaDto? _hautatutakoErreserba;
        private double _guztira;
        private bool _eskudiruaAukeratuta;

        public ErreserbaAmaituForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            dgv_Eskariak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Eskariak.RowTemplate.Height = 50;
            dgv_Eskariak.Font = new Font("Segoe UI", 14);
            dgv_Eskariak.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            dgv_Eskariak.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Eskariak.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Eskariak.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Eskariak.MultiSelect = false;
            dgv_Eskariak.ReadOnly = true;


            lbl_Guztira.AutoSize = false;
            lbl_Guztira.Size = new Size(650, 80);
            lbl_Guztira.TextAlign = ContentAlignment.MiddleRight;

            lbl_Itzulia.AutoSize = false;
            lbl_Itzulia.Size = new Size(300, 60);
            lbl_Itzulia.TextAlign = ContentAlignment.MiddleRight;

            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;
            _langileaId = SesioZerbitzua.LangileaId;

            this.Load += ErreserbaAmaituForm_Load;

            cmb_Erreserbak.SelectedIndexChanged += cmb_Erreserbak_SelectedIndexChanged;
            btn_Eskudirua.Click += btn_Eskudirua_Click;
            btn_Txartela.Click += btn_Txartela_Click;
            txt_JasoDenDirua.TextChanged += txt_JasoDenDirua_TextChanged;
            btn_Ordaindu.Click += btn_Ordaindu_Click;

            txt_JasoDenDirua.Enabled = false;
            lbl_Itzulia.Text = "0,00 €";
            lbl_Guztira.Text = "0,00 €";

            PrestatuFooter();
        }

        private async void ErreserbaAmaituForm_Load(object sender, EventArgs e)
        {
            headerControl_ErreserbaAmaitu.Izena = "TXAPELA";
            headerControl_ErreserbaAmaitu.Titulo = "ERRESERBA AMAITU";
            headerControl_ErreserbaAmaitu.Erabiltzailea = SesioZerbitzua.Izena;
            headerControl_ErreserbaAmaitu.DataOrdua = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm");

            await KargatuErreserbakAsync();
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

        private async Task KargatuErreserbakAsync()
        {
            var erreserbak = await _api.ErreserbakLortuAsync();

            var aukeragarriak = erreserbak
                .Where(e => e.PrezioTotala > 0)
                .ToList();

            cmb_Erreserbak.DisplayMember = "BezeroIzena";
            cmb_Erreserbak.ValueMember = "Id";
            cmb_Erreserbak.DataSource = aukeragarriak;
        }

        private async void cmb_Erreserbak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Erreserbak.SelectedItem is ErreserbaDto erreserba)
            {
                _hautatutakoErreserba = erreserba;
                await KargatuEskariakEtaGuztiraAsync(erreserba.Id);
            }
        }

        private async Task KargatuEskariakEtaGuztiraAsync(int erreserbaId)
        {
            var eskariak = await _api.LortuEskariakAsync();
            var eskariakErreserba = eskariak
                .Where(e => e.ErreserbaId == erreserbaId)
                .ToList();

            var produktuak = eskariakErreserba
                .SelectMany(e => e.Produktuak)
                .ToList();

            dgv_Eskariak.DataSource = produktuak;

            if (dgv_Eskariak.Columns.Contains("Id"))
                dgv_Eskariak.Columns["Id"].Visible = false;

            if (dgv_Eskariak.Columns.Contains("EskariaId"))
                dgv_Eskariak.Columns["EskariaId"].Visible = false;

            if (dgv_Eskariak.Columns.Contains("ProduktuaId"))
                dgv_Eskariak.Columns["ProduktuaId"].Visible = false;

            if (dgv_Eskariak.Columns.Contains("ProduktuaIzena"))
                dgv_Eskariak.Columns["ProduktuaIzena"].HeaderText = "Produktua";

            if (dgv_Eskariak.Columns.Contains("Kantitatea"))
                dgv_Eskariak.Columns["Kantitatea"].HeaderText = "Kantitatea";

            if (dgv_Eskariak.Columns.Contains("Prezioa"))
                dgv_Eskariak.Columns["Prezioa"].HeaderText = "Prezioa (€)";

            dgv_Eskariak.RowHeadersVisible = false;

            double guztira = produktuak.Sum(p => p.Kantitatea * p.Prezioa);
            _guztira = guztira;
            lbl_Guztira.Text = _guztira.ToString("0.00 €");

            txt_JasoDenDirua.Text = "";
            lbl_Itzulia.Text = "0,00 €";
        }


        private void btn_Eskudirua_Click(object sender, EventArgs e)
        {
            _eskudiruaAukeratuta = true;
            txt_JasoDenDirua.Enabled = true;
            txt_JasoDenDirua.Focus();

            btn_Eskudirua.BackColor = Color.LightGreen;
            btn_Txartela.BackColor = SystemColors.Control;

            KalkulatuItzulia();
        }

        private void btn_Txartela_Click(object sender, EventArgs e)
        {
            _eskudiruaAukeratuta = false;
            txt_JasoDenDirua.Enabled = false;
            txt_JasoDenDirua.Text = "";
            lbl_Itzulia.Text = "0,00 €";

            btn_Txartela.BackColor = Color.LightGreen;
            btn_Eskudirua.BackColor = SystemColors.Control;
        }

        private void txt_JasoDenDirua_TextChanged(object sender, EventArgs e)
        {
            if (_eskudiruaAukeratuta)
                KalkulatuItzulia();
        }

        private void KalkulatuItzulia()
        {
            if (!double.TryParse(txt_JasoDenDirua.Text.Replace("€", "").Trim(),
                                 NumberStyles.Number,
                                 CultureInfo.CurrentCulture,
                                 out var jasotakoa))
            {
                lbl_Itzulia.Text = "0,00 €";
                return;
            }

            var itzulia = jasotakoa - _guztira;
            lbl_Itzulia.Text = itzulia < 0 ? "0,00 €" : itzulia.ToString("0.00 €");
        }

        private async void btn_Ordaindu_Click(object sender, EventArgs e)
        {
            if (_hautatutakoErreserba == null)
            {
                MessageBox.Show("Lehenengo erreserba bat aukeratu.", "Abisua",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ordainketaModua = _eskudiruaAukeratuta ? "Eskudirua" : "Txartela";

            double jasotakoa = 0;
            double itzulia = 0;

            if (_eskudiruaAukeratuta)
            {
                if (!double.TryParse(txt_JasoDenDirua.Text.Replace("€", "").Trim(),
                                     NumberStyles.Number,
                                     CultureInfo.CurrentCulture,
                                     out jasotakoa))
                {
                    MessageBox.Show("Sartu jasotako dirua zuzen.", "Errorea",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (jasotakoa < _guztira)
                {
                    MessageBox.Show("Jasotako dirua ez da nahikoa.", "Errorea",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                itzulia = jasotakoa - _guztira;
            }

            var dto = new ErreserbaOrdainduDto
            {
                ErreserbaId = _hautatutakoErreserba.Id,
                Guztira = _guztira,
                Jasotakoa = jasotakoa,
                Itzulia = itzulia,
                LangileaId = _langileaId,
                OrdainketaModua = ordainketaModua
            };

            bool ok = await _api.OrdainduErreserbaAsync(dto);

            if (!ok)
            {
                MessageBox.Show("Errorea erreserba ordaintzean.", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            MessageBox.Show("Erreserba ongi ordaindu da.", "Informazioa",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            _AurrekoPantaila.Show();
            this.Close();
        }
    }
}
