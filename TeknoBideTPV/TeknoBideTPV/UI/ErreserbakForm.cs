using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.UI.Styles;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class ErreserbakForm : Form
    {
        private readonly ApiZerbitzua _api = new ApiZerbitzua();

        private List<ErreserbaDto> _erreserbakOriginalak = new();
        private List<MahaiaDto> mahaiak = new();

        private bool _editatuKolumnaGehituta = false;

        private Form _AurrekoPantaila;

        public ErreserbakForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            //minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;
            this.Load += ErreserbakForm_Load;
            this.Shown += ErreserbakForm_Shown;
        }
        private void ErreserbakForm_Shown(object sender, EventArgs e)
        {
            TPVEstiloaFinkoa.Prestatu(this);
            TPVEstiloaFinkoa.Aplikatu(this);
        }

        private async void ErreserbakForm_Load(object sender, EventArgs e)
        {
            await KargatuMahaiak();
            await KargatuErreserbak();
            EstilatuDataGridView();

            headerControl_Erreserbak.Izena = "TXAPELA";
            headerControl_Erreserbak.Titulo = "ERRESERBAK";
            headerControl_Erreserbak.Erabiltzailea = SesioZerbitzua.Izena;
            headerControl_Erreserbak.DataOrdua = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm");
        }

        private async Task KargatuMahaiak()
        {
            mahaiak = await _api.MahaiakLortuAsync();
        }

        private async Task KargatuErreserbak()
        {
            try
            {
                _erreserbakOriginalak = await _api.ErreserbakLortuAsync();

                foreach (var r in _erreserbakOriginalak)
                {
                    r.MahaiaZenbakia =
                        mahaiak.FirstOrDefault(m => m.Id == r.MahaiakId)?.Zenbakia ?? 0;
                }

                dgv_ErreserbakIkusi.DataSource = _erreserbakOriginalak;

                EzarriKolumnak();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errorea erreserbak kargatzen: {ex.Message}");
            }
        }

        private void EzarriKolumnak()
        {
            if (dgv_ErreserbakIkusi.Columns.Count == 0)
                return;

            dgv_ErreserbakIkusi.RowHeadersVisible = false;
            dgv_ErreserbakIkusi.Columns["Id"].Visible = false;
            dgv_ErreserbakIkusi.Columns["EgunaOrdua"].Visible = false;
            dgv_ErreserbakIkusi.Columns["FakturaRuta"].Visible = false;
            dgv_ErreserbakIkusi.Columns["MahaiakId"].Visible = false;

            dgv_ErreserbakIkusi.Columns["BezeroIzena"].HeaderText = "Bezeroa";
            dgv_ErreserbakIkusi.Columns["Telefonoa"].HeaderText = "Telefonoa";
            dgv_ErreserbakIkusi.Columns["PertsonaKopurua"].HeaderText = "Kopurua";
            dgv_ErreserbakIkusi.Columns["Eguna"].HeaderText = "Eguna";
            dgv_ErreserbakIkusi.Columns["Ordua"].HeaderText = "Ordua";
            dgv_ErreserbakIkusi.Columns["PrezioTotala"].HeaderText = "Prezioa";
            dgv_ErreserbakIkusi.Columns["LangileaId"].HeaderText = "Langilea";

            dgv_ErreserbakIkusi.Columns["MahaiaZenbakia"].HeaderText = "Mahaia";

            if (!_editatuKolumnaGehituta)
            {
                var editatuCol = new DataGridViewButtonColumn
                {
                    HeaderText = "Editatu",
                    Text = "Editatu",
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                    Name = "Editatu"
                };
                dgv_ErreserbakIkusi.Columns.Add(editatuCol);
                _editatuKolumnaGehituta = true;
            }
        }

        private void dgv_ErreserbakIkusi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_ErreserbakIkusi.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var dto = dgv_ErreserbakIkusi.Rows[e.RowIndex].DataBoundItem as ErreserbaDto;
                if (dto != null)
                {
                    //var editForm = new ErreserbaEditatuForm(dto);
                    //editForm.ShowDialog();
                    //await KargatuErreserbak(); // refrescar después de editar
                }
            }
        }


        private void EstilatuDataGridView()
        {
            dgv_ErreserbakIkusi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ErreserbakIkusi.BackgroundColor = Color.White;
            dgv_ErreserbakIkusi.BorderStyle = BorderStyle.None;

            dgv_ErreserbakIkusi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230);
            dgv_ErreserbakIkusi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv_ErreserbakIkusi.EnableHeadersVisualStyles = false;

            dgv_ErreserbakIkusi.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgv_ErreserbakIkusi.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv_ErreserbakIkusi.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv_ErreserbakIkusi.RowTemplate.Height = 40;
        }

        private void btn_Bilatu_Click(object sender, EventArgs e)
        {
            FiltratuErreserbak();
        }

        private void FiltratuErreserbak()
        {
            if (_erreserbakOriginalak == null || _erreserbakOriginalak.Count == 0)
                return;

            string testua = txt_Bilatu.Text.Trim().ToLower();
            bool egunaAktibatuta = dtp_Eguna.Checked;
            DateTime eguna = dtp_Eguna.Value.Date;

            IEnumerable<ErreserbaDto> filtratuta = _erreserbakOriginalak;

            if (!string.IsNullOrEmpty(testua))
            {
                filtratuta = filtratuta.Where(r =>
                    r.BezeroIzena != null &&
                    r.BezeroIzena.ToLower().Contains(testua));
            }

            if (egunaAktibatuta)
            {
                filtratuta = filtratuta.Where(r => r.EgunaOrdua.Date == eguna);
            }

            dgv_ErreserbakIkusi.DataSource = filtratuta.ToList();
            EzarriKolumnak();
        }

        private void btn_Garbitu_Click(object sender, EventArgs e)
        {
            txt_Bilatu.Text = string.Empty;
            dtp_Eguna.Checked = false;

            dgv_ErreserbakIkusi.DataSource = _erreserbakOriginalak.ToList();
            EzarriKolumnak();
        }

        private void btn_Atzera_Click(object sender, EventArgs e)
        {
            _AurrekoPantaila.Show();
            this.Close();
        }
    }
}
