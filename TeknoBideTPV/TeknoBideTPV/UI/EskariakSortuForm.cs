using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class EskariakSortuForm : Form
    {
        private readonly ApiZerbitzua api = new ApiZerbitzua();
        private List<EskariaProduktuaSortuDto> produktuakEskarian = new();
        private List<ProduktuaDto> produktuak = new();
        private List<ErreserbaDto> erreserbak = new();

        public EskariakSortuForm()
        {
            InitializeComponent();
            dgv_EskariaProduktua.CellClick += dgv_EskariaProduktua_CellClick;
        }

        private async void EskariakSortuForm_Load(object sender, EventArgs e)
        {
            erreserbak = await api.ErreserbakLortuAsync();
            cbo_Erreserba.DataSource = erreserbak;
            cbo_Erreserba.DisplayMember = "BezeroIzena";
            cbo_Erreserba.ValueMember = "Id";

            produktuak = await api.LortuProduktuakAsync();

            if (produktuak.Count == 0)
            {
                MessageBox.Show("Ez da produkturik aurkitu.");
                return;
            }

            flp_Produktuak.Controls.Clear();

            foreach (var p in produktuak)
            {
                var btn = new Button
                {
                    Text = $"{p.Izena}\n{p.Prezioa:0.00}€",
                    Tag = p,
                    Width = 150,
                    Height = 80,
                    BackColor = System.Drawing.Color.LightSteelBlue,
                    Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold),
                    Margin = new Padding(5)
                };
                btn.Click += ProduktuaGehitu_Click;
                flp_Produktuak.Controls.Add(btn);
            }
        }

        private void ProduktuaGehitu_Click(object sender, EventArgs e)
        {
            var produktua = (ProduktuaDto)((Button)sender).Tag;
            var lehendik = produktuakEskarian.FirstOrDefault(x => x.ProduktuaId == produktua.Id);

            if (lehendik != null)
            {
                lehendik.Kantitatea++;
                lehendik.Prezioa = lehendik.Kantitatea * produktua.Prezioa;
            }
            else
            {
                produktuakEskarian.Add(new EskariaProduktuaSortuDto
                {
                    ProduktuaId = produktua.Id,
                    Kantitatea = 1,
                    Prezioa = produktua.Prezioa
                });
            }

            EskariakGridEguneratu();
        }

       private void EskariakGridEguneratu()
{
    dgv_EskariaProduktua.Columns.Clear();

    var data = produktuakEskarian.Select(p => new
    {
        ProduktuaIzena = produktuak.FirstOrDefault(x => x.Id == p.ProduktuaId)?.Izena ?? "Desconocido",
        Kantitatea = p.Kantitatea,
        ProduktuakPrezioaBakarka = p.Prezioa / p.Kantitatea,
        ProduktuakPrezioaGuztira = p.Prezioa
    }).ToList();

    dgv_EskariaProduktua.AutoGenerateColumns = false;
    dgv_EskariaProduktua.DataSource = data;
    dgv_EskariaProduktua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

    dgv_EskariaProduktua.Columns.Add(new DataGridViewTextBoxColumn
    {
        DataPropertyName = "ProduktuaIzena",
        HeaderText = "Produktua",
        Name = "ProduktuaIzena"
    });

    dgv_EskariaProduktua.Columns.Add(new DataGridViewTextBoxColumn
    {
        DataPropertyName = "Kantitatea",
        HeaderText = "Kantitatea",
        Name = "Kantitatea"
    });

    dgv_EskariaProduktua.Columns.Add(new DataGridViewTextBoxColumn
    {
        DataPropertyName = "ProduktuakPrezioaBakarka",
        HeaderText = "Prezioa (€)",
        Name = "ProduktuakPrezioaBakarka"
    });

    dgv_EskariaProduktua.Columns.Add(new DataGridViewTextBoxColumn
    {
        DataPropertyName = "ProduktuakPrezioaGuztira",
        HeaderText = "Guztira (€)",
        Name = "ProduktuakPrezioaGuztira"
    });

    dgv_EskariaProduktua.Columns.Add(new DataGridViewButtonColumn
    {
        Name = "btn_ProduktuaKendu",
        HeaderText = "Produktua ezabatu",
        Text = "Ezabatu",
        UseColumnTextForButtonValue = true
    });

    txt_PrezioTotala.Text = produktuakEskarian.Sum(p => p.Prezioa).ToString("0.00");
}

        private void dgv_EskariaProduktua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_EskariaProduktua.Columns[e.ColumnIndex].Name == "btn_ProduktuaKendu")
            {
                var produktuaIzena = dgv_EskariaProduktua.Rows[e.RowIndex].Cells["ProduktuaIzena"].Value.ToString();
                var produktuaEskarian = produktuakEskarian.FirstOrDefault(p =>
                    produktuak.FirstOrDefault(x => x.Id == p.ProduktuaId)?.Izena == produktuaIzena);

                if (produktuaEskarian != null)
                {
                    if (produktuaEskarian.Kantitatea > 1)
                    {
                        produktuaEskarian.Kantitatea--;
                        produktuaEskarian.Prezioa = produktuaEskarian.Kantitatea *
                            produktuak.First(x => x.Id == produktuaEskarian.ProduktuaId).Prezioa;
                    }
                    else
                    {
                        produktuakEskarian.Remove(produktuaEskarian);
                    }
                }

                EskariakGridEguneratu();
            }
        }


        private async void btn_SortuEskaria_Click(object sender, EventArgs e)
        {
            if (cbo_Erreserba.SelectedItem == null || produktuakEskarian.Count == 0)
            {
                MessageBox.Show("Aukeratu erreserba eta produktuak lehenik.");
                return;
            }

            var eskaria = new EskariaSortuDto
            {
                ErreserbaId = ((ErreserbaDto)cbo_Erreserba.SelectedItem).Id,
                Prezioa = double.Parse(txt_PrezioTotala.Text),
                Egoera = "Bidalita",
                Produktuak = produktuakEskarian
            };

            var emaitza = await api.SortuEskariaAsync(eskaria);

            if (emaitza != null)
            {
                var sb = new System.Text.StringBuilder();
                sb.AppendLine($"Eskaria sortuta!");
                sb.AppendLine($"Prezio Totala: {emaitza.PrezioaTotala:0.00} €");
                sb.AppendLine("Produktuak:");

                foreach (var p in emaitza.Produktuak)
                {
                    sb.AppendLine($"{p.ProduktuaIzena} - {p.Kantitatea} x {p.ProduktuakPrezioaBakarka:0.00}€ = {p.ProduktuakPrezioaGuztira:0.00}€");
                }

                MessageBox.Show(sb.ToString(), "Eskaria sortuta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Errorea eskaria sortzean.");
            }

            produktuakEskarian.Clear();

            if (produktuakEskarian.Count > 0)
                EskariakGridEguneratu();
            else
                dgv_EskariaProduktua.DataSource = null;
        }

    }
}
