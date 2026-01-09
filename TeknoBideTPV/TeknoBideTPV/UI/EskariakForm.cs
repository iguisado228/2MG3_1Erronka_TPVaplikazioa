using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class EskariakForm : Form
    {
        private readonly ApiZerbitzua _api = new ApiZerbitzua();


        private Form _AurrekoPantaila;

        public EskariakForm(Form AurrekoPantaila)
        {
            InitializeComponent();

            //minimizatu maximizatu eta itxi botoiak ezkutatu
            this.ControlBox = false;
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            _AurrekoPantaila = AurrekoPantaila;
            EskariakForm_Load(this, EventArgs.Empty);
            this.Load += EskariakForm_Load;
        }



        private async void EskariakForm_Load(object sender, EventArgs e)
        {
            var eskariak = await _api.LortuEskariakAsync();
            KargatuEskariak(eskariak);

            EzarriEskariakLayout();

            lbl_Erabiltzailea.Text = SesioZerbitzua.Izena;
        }

        private void EzarriEskariakLayout()
        {
            int panel_Zabalera = 520;
            int margina = 10;
            int zutabeak = 3;

            int beharrezkoZabalera = (panel_Zabalera + margina) * zutabeak;

            flp_Eskariak.Width = beharrezkoZabalera;
            flp_Eskariak.FlowDirection = FlowDirection.LeftToRight;
            flp_Eskariak.WrapContents = true;
            flp_Eskariak.AutoScroll = true;
            flp_Eskariak.Padding = new Padding(10);

            flp_Eskariak.ResumeLayout();
        }

        private void KargatuEskariak(List<EskariaDto> eskariak)
        {
            flp_Eskariak.Controls.Clear();

            foreach (var eskaria in eskariak)
            {
                Panel panel = SortuEskariaPanel(eskaria);
                flp_Eskariak.Controls.Add(panel);
            }
        }

        private Panel SortuEskariaPanel(EskariaDto eskaria)
        {
            Panel pnl_Eskaria = new Panel
            {
                Width = 520,
                Height = 280,
                BackColor = Color.FromArgb(245, 245, 235),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(8),
                Padding = new Padding(10)
            };

            Label lbl_Mahaia = new Label
            {
                Text = $"Mahai: {eskaria.MahaiaZenbakia}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                Size = new Size(300, 25)
            };

            Label lbl_Egoera = new Label
            {
                Text = $"Egoera: {eskaria.Egoera}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 40),
                Size = new Size(200, 25)
            };

            FlowLayoutPanel flp_Produktuak = new FlowLayoutPanel
            {
                Location = new Point(10, 80),
                Size = new Size(480, 110),
                MaximumSize = new Size(480, 9999),
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                WrapContents = false
            };

            flp_Produktuak.HorizontalScroll.Visible = false;
            flp_Produktuak.HorizontalScroll.Maximum = 0;
            flp_Produktuak.AutoScrollMargin = new Size(0, 0);


            foreach (var p in eskaria.Produktuak)
            {
                Label lblProd = new Label
                {
                    Text = $"{p.ProduktuaIzena}   x{p.Kantitatea}   {p.Prezioa:0.00} €",
                    Font = new Font("Segoe UI", 10),
                    Size = new Size(460, 25)
                };

                flp_Produktuak.Controls.Add(lblProd);
            }


            Label lbl_Prezioa = new Label
            {
                Text = $"Prezioa: {eskaria.Prezioa:0.00} €",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(300, 190),
                Size = new Size(200, 25),
                TextAlign = ContentAlignment.TopRight
            };

            int botoiZabalera = 110;
            int botoiAltuera = 30;
            int espazioa = 20;
            int totalZabalera = (botoiZabalera * 3) + (espazioa * 2);
            int xHasiera = (pnl_Eskaria.Width - totalZabalera) / 2;
            int yPos = 225;

            Button btn_Zerbitzatu = new Button
            {
                Text = "ZERBITZATU",
                Size = new Size(botoiZabalera, botoiAltuera),
                Location = new Point(xHasiera, yPos),
                BackColor = Color.LightGreen,
                FlatStyle = FlatStyle.Flat
            };

            Button btn_Ezabatu = new Button
            {
                Text = "EZABATU",
                Size = new Size(botoiZabalera, botoiAltuera),
                Location = new Point(xHasiera + botoiZabalera + espazioa, yPos),
                BackColor = Color.LightCoral,
                FlatStyle = FlatStyle.Flat
            };

            Button btn_Editatu = new Button
            {
                Text = "EDITATU",
                Size = new Size(botoiZabalera, botoiAltuera),
                Location = new Point(xHasiera + (botoiZabalera + espazioa) * 2, yPos),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };

            pnl_Eskaria.Controls.Add(lbl_Mahaia);
            pnl_Eskaria.Controls.Add(lbl_Egoera);
            pnl_Eskaria.Controls.Add(flp_Produktuak);
            pnl_Eskaria.Controls.Add(lbl_Prezioa);
            pnl_Eskaria.Controls.Add(btn_Zerbitzatu);
            pnl_Eskaria.Controls.Add(btn_Ezabatu);
            pnl_Eskaria.Controls.Add(btn_Editatu);

            return pnl_Eskaria;
        }

        private void btn_Atzera_Click(object sender, EventArgs e)
        {
            _AurrekoPantaila.Show();
            this.Close();
        }

        private void btn_Guztiak_Click(object sender, EventArgs e)
        {

        }
    }
}
