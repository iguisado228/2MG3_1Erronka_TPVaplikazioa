using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using TeknoBideTPV.Zerbitzuak;


namespace TeknoBideTPV.UI
{
    public partial class LoginForm : Form
    {
            public LoginForm()
            {
                InitializeComponent();

                this.Load += LoginForm_Load;
                this.Resize += LoginForm_Resize;

                this.MaximizeBox = false;
                img_Logoa.SizeMode = PictureBoxSizeMode.Zoom;
            }

            private void LoginForm_Load(object sender, EventArgs e)
            {
                TPVEstiloa.PantailarenEskalatuaHasi(this);
                TPVEstiloa.EskalatuaAplikatu(this);
            }

            private void LoginForm_Resize(object sender, EventArgs e)
            {
                TPVEstiloa.EskalatuaAplikatu(this);
            }

            private async void btn_Sartu_Click(object sender, EventArgs e)
            {
                if (!int.TryParse(txt_Erabiltzailea.Text, out int langileKodea))
                {
                    MessageBox.Show("Langile kodea zenbaki bat izan behar da", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string pasahitza = txt_Pasahitza.Text;

                var api = new ApiZerbitzua();
                var erantzuna = await api.LoginAsync(langileKodea, pasahitza);

                if (erantzuna == null)
                {
                    MessageBox.Show("Errorea APIarekin konektatzean", "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (erantzuna.Ok)
                {

                    SesioZerbitzua.LangileaId = erantzuna.Data.Id;

                    SesioZerbitzua.Izena = erantzuna.Data.Izena;

                    MessageBox.Show(erantzuna.Message, "Sarrera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var menuNagusia = new MenuNagusia();
                    menuNagusia.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(erantzuna.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}


