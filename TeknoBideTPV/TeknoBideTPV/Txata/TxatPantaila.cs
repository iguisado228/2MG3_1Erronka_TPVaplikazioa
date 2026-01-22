using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.Txata
{
    public partial class TxatPantaila : UserControl
    {
        private string erabiltzaileIzena = SesioZerbitzua.Izena;
        private TcpClient erabiltzailea;
        private StreamReader irakurlea;
        private StreamWriter idazlea;
        private Thread entzunHari;

        public TxatPantaila(string erabiltzaileIzena)
        {
            InitializeComponent();
            this.erabiltzaileIzena = erabiltzaileIzena;
        }

        public TxatPantaila()
        {
            InitializeComponent();
            this.Load += TxatPantaila_Load;
        }

        private void TxatPantaila_Load(object sender, EventArgs e)
        {
            konexioaKargatu();
        }

        private void konexioaKargatu()
        {
            try
            {
                erabiltzailea = new TcpClient("192.168.1.112", 5555);

                irakurlea = new StreamReader(erabiltzailea.GetStream());
                idazlea = new StreamWriter(erabiltzailea.GetStream());
                idazlea.AutoFlush = true;

                idazlea.WriteLine(erabiltzaileIzena);

                entzunHari = new Thread(entzunBuklea);
                entzunHari.IsBackground = true;
                entzunHari.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea zerbitzarira konektatzean: " + ex.Message);
            }
        }

        private void entzunBuklea()
        {
            try
            {
                string lerroa;
                while ((lerroa = irakurlea.ReadLine()) != null)
                {
                    idatziMezua(lerroa);
                }
            }
            catch
            {

            }
        }

        private void idatziMezua(string msg)
        {
            if (MezuPantaila.InvokeRequired)
            {
                MezuPantaila.Invoke(new Action(() =>
                    MezuPantaila.AppendText(msg + Environment.NewLine)
                ));
            }
            else
            {
                MezuPantaila.AppendText(msg + Environment.NewLine);
            }
        }

        private void BidaliBotoia_Click(object sender, EventArgs e)
        {
            string mezua = MezuIdazlea.Text.Trim();
            if (mezua == "") return;

            idazlea.WriteLine(SesioZerbitzua.Izena + ":  " + mezua);
            MezuIdazlea.Text = "";
        }
    }
}
