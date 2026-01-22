using System;
using System.Drawing;
using System.Windows.Forms;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class LoginForm : Form
    {
        private bool _hasierakoaGordeta = false;

        public LoginForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.Shown += LoginForm_Shown;
            this.Resize += LoginForm_Resize;

            this.MaximizeBox = false;
            img_Logoa.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (!_hasierakoaGordeta)
            {
                TPVEstiloa.PantailarenEskalatuaHasi(this);
                _hasierakoaGordeta = true;
            }

            TPVEstiloa.EskalatuaAplikatu(this);
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            if (!_hasierakoaGordeta)
                return;

            TPVEstiloa.EskalatuaAplikatu(this);
        }

        private async void btn_Sartu_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_Erabiltzailea.Text, out int langileKodea))
            {
                MessageBox.Show("Langile kodea zenbaki bat izan behar da", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pasahitza = txt_Pasahitza.Text;

            var api = new ApiZerbitzua();
            var erantzuna = await api.LoginAsync(langileKodea, pasahitza);

            if (erantzuna == null)
            {
                MessageBox.Show("Errorea APIarekin konektatzean", "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (erantzuna.Ok)
            {
                SesioZerbitzua.LangileaId = erantzuna.Data.Id;
                SesioZerbitzua.Izena = erantzuna.Data.Izena;
                SesioZerbitzua.Gerentea = erantzuna.Data.Gerentea;

                MessageBox.Show(erantzuna.Message, "Sarrera",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var menuNagusia = new MenuNagusia();
                menuNagusia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(erantzuna.Message, "Errorea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
