using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class MahaiakKudeatuForm : Form
    {
        private readonly ApiZerbitzua _api = new ApiZerbitzua();
        private Form _AurrekoPantaila;

        private int? _mahaiaIdAktiboa = null;

        private Panel? _panelAukeratua = null;

        public MahaiakKudeatuForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;
            this.Load += MahaiakKudeatuForm_Load;

            PrestatuFooter();
            PrestatuKokapenak();
            PrestatuHasierakoEgoera();
        }

        private async void MahaiakKudeatuForm_Load(object sender, EventArgs e)
        {
            headerControl_MahaiakKudeatu.Izena = "TXAPELA";
            headerControl_MahaiakKudeatu.Titulo = "MAHAIAK KUDEATU";
            headerControl_MahaiakKudeatu.Erabiltzailea = SesioZerbitzua.Izena;
            headerControl_MahaiakKudeatu.DataOrdua = DateTime.Now.ToString("dddd, dd MMMM yyyy - HH:mm");

            if (!SesioZerbitzua.Gerentea)
            {
                btn_Gorde.Enabled = false;
                btn_Ezabatu.Enabled = false;
                btn_MahaiBerria.Enabled = false;
            }

            await KargatuMahaiakAsync();
        }

        private void PrestatuFooter()
        {
            footerControl_MahaiakKudeatu.AtzeraTestua = "Atzera";

            footerControl_MahaiakKudeatu.AtzeraClick += (s, e) =>
            {
                _AurrekoPantaila.Show();
                this.Close();
            };
        }

        private void PrestatuKokapenak()
        {
            cmb_Kokapena.Items.AddRange(new[]
            {
                "Barneko gunea",
                "Kanpoko terraza",
                "Leiho ondoan",
                "Areto nagusia"
            });
        }

        private void PrestatuHasierakoEgoera()
        {
            txt_Zenbakia.ReadOnly = true;
            cmb_Kokapena.Enabled = false;
            nud_PertsonaKopurua.Enabled = false;
        }

        private async Task KargatuMahaiakAsync()
        {
            flp_Mahaiak.Controls.Clear();

            var mahaiak = await _api.MahaiakLortuAsync();

            foreach (var mahaia in mahaiak)
            {
                var kontrola = SortuMahaiaBanaka(mahaia);
                flp_Mahaiak.Controls.Add(kontrola);
            }
        }

        private void PanelariEsatiloaEman(Panel p)
        {
            p.BackColor = Color.LightGray;
            p.BorderStyle = BorderStyle.None;
        }

        private void EstilatuPanelAukeratua(Panel p)
        {
            p.BackColor = Color.FromArgb(180, 220, 255);
            p.BorderStyle = BorderStyle.FixedSingle;
        }

        private Control SortuMahaiaBanaka(MahaiaDto mahaia)
        {
            var panel = new Panel
            {
                Width = 180,
                Height = 140,
                Margin = new Padding(10),
                Cursor = Cursors.Hand,
                Tag = mahaia,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            panel.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.FillRectangle(new SolidBrush(Color.White), panel.ClientRectangle);
            };

            var lblZenbakia = new Label
            {
                Text = $"🪑 Mahai {mahaia.Zenbakia}",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 40
            };

            var lblPertsonak = new Label
            {
                Text = $"👥 {mahaia.PertsonaKopurua} pertsona",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30
            };

            var lblKokapena = new Label
            {
                Text = $"📍 {mahaia.Kokapena}",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 11, FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel.Controls.Add(lblKokapena);
            panel.Controls.Add(lblPertsonak);
            panel.Controls.Add(lblZenbakia);

            panel.Click += MahaiaAukeratu;
            lblZenbakia.Click += MahaiaAukeratu;
            lblPertsonak.Click += MahaiaAukeratu;
            lblKokapena.Click += MahaiaAukeratu;

            return panel;
        }


        private void MahaiaAukeratu(object sender, EventArgs e)
        {
            Control kontrola = sender as Control;

            if (kontrola is Label)
                kontrola = kontrola.Parent;

            var mahaia = kontrola.Tag as MahaiaDto;
            if (mahaia == null) return;

            if (_panelAukeratua != null)
                PanelariEsatiloaEman(_panelAukeratua);

            Panel panel = (Panel)kontrola;
            EstilatuPanelAukeratua(panel);
            _panelAukeratua = panel;

            _mahaiaIdAktiboa = mahaia.Id;

            txt_Zenbakia.Text = mahaia.Zenbakia.ToString();
            nud_PertsonaKopurua.Value = mahaia.PertsonaKopurua;
            for (int i = 0; i < cmb_Kokapena.Items.Count; i++)
            {
                if (string.Equals(cmb_Kokapena.Items[i].ToString(), mahaia.Kokapena, StringComparison.OrdinalIgnoreCase))
                {
                    cmb_Kokapena.SelectedIndex = i;
                    break;
                }
            }

            txt_Zenbakia.ReadOnly = false;
            cmb_Kokapena.Enabled = true;
            nud_PertsonaKopurua.Enabled = true;

        }

        private async void btn_Gorde_Click(object sender, EventArgs e)
        {
            if (_mahaiaIdAktiboa == null)
            {
                MessageBox.Show("Ez dago mahaia aukeratuta.");
                return;
            }

            if (!int.TryParse(txt_Zenbakia.Text, out int zenbakia))
            {
                MessageBox.Show("Zenbakia ez da baliozko zenbaki bat.");
                return;
            }

            var dto = new MahaiaDto
            {
                Id = _mahaiaIdAktiboa.Value,
                Zenbakia = zenbakia,
                PertsonaKopurua = (int)nud_PertsonaKopurua.Value,
                Kokapena = cmb_Kokapena.SelectedItem?.ToString() ?? ""
            };

            var ok = await _api.AktualizatuMahaiaAsync(dto);

            if (ok)
            {
                MessageBox.Show("Mahaia eguneratuta!");
                await KargatuMahaiakAsync();
            }
            else
            {
                MessageBox.Show("Errorea mahaia eguneratzean.");
            }
        }

        private async void btn_Ezabatu_Click(object sender, EventArgs e)
        {
            if (_mahaiaIdAktiboa == null)
            {
                MessageBox.Show("Ez dago mahaia aukeratuta.");
                return;
            }

            var ok = await _api.EzabatuMahaiaAsync(_mahaiaIdAktiboa.Value);

            if (ok)
            {
                MessageBox.Show("Mahaia ezabatuta!");

                _mahaiaIdAktiboa = null;
                txt_Zenbakia.Text = "";
                nud_PertsonaKopurua.Value = 0;
                cmb_Kokapena.SelectedIndex = -1;

                PrestatuHasierakoEgoera();
                await KargatuMahaiakAsync();
            }
            else
            {
                MessageBox.Show("Errorea mahaia ezabatzean.");
            }
        }

        private async void btn_MahaiBerria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Zenbakia.Text))
            {
                MessageBox.Show("Zenbakia ezin da hutsik egon.");
                return;
            }

            var dto = new MahaiaSortuDto
            {
                Zenbakia = txt_Zenbakia.Text,
                PertsonaKopurua = (int)nud_PertsonaKopurua.Value,
                Kokapena = cmb_Kokapena.SelectedItem?.ToString() ?? ""
            };

            var ok = await _api.SortuMahaiaAsync(dto);

            if (ok)
            {
                MessageBox.Show("Mahaia sortuta!");
                await KargatuMahaiakAsync();
            }
            else
            {
                MessageBox.Show("Errorea mahaia sortzean.");
            }
        }

        private void btn_Garbitu_Click(object sender, EventArgs e)
        {
            _mahaiaIdAktiboa = null;

            txt_Zenbakia.Text = "";
            nud_PertsonaKopurua.Value = 0;
            cmb_Kokapena.SelectedIndex = -1;

            txt_Zenbakia.ReadOnly = false;
            cmb_Kokapena.Enabled = true;
            nud_PertsonaKopurua.Enabled = true;

            if (_panelAukeratua != null)
            {
                PanelariEsatiloaEman(_panelAukeratua);
                _panelAukeratua = null;
            }
        }

    }
}
