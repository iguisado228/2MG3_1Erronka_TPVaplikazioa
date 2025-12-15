using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeknoBideTPV.DTOak;
using TeknoBideTPV.Zerbitzuak;

namespace TeknoBideTPV.UI
{
    public partial class ErreserbakForm : Form
    {
        private readonly ApiZerbitzua _api = new ApiZerbitzua();

        public ErreserbakForm()
        {
            InitializeComponent();
        }

        private async void btn_ErreserbakErakutsi_Click(object sender, EventArgs e)
        {
            try
            {
                var api = new ApiZerbitzua();
                var erreserbak = await api.ErreserbakLortuAsync();

                dgv_ErreserbakIkusi.DataSource = erreserbak;

                // Opcional: configurar columnas
                dgv_ErreserbakIkusi.Columns["Id"].HeaderText = "ID";
                dgv_ErreserbakIkusi.Columns["BezeroIzena"].HeaderText = "Bezeroa";
                dgv_ErreserbakIkusi.Columns["Telefonoa"].HeaderText = "Telefonoa";
                dgv_ErreserbakIkusi.Columns["PertsonaKopurua"].HeaderText = "Kopurua";
                dgv_ErreserbakIkusi.Columns["Eguna"].HeaderText = "Eguna";
                dgv_ErreserbakIkusi.Columns["Ordua"].HeaderText = "Ordua";
                dgv_ErreserbakIkusi.Columns["PrezioTotala"].HeaderText = "Prezioa";
                dgv_ErreserbakIkusi.Columns["FakturaRuta"].HeaderText = "Faktura";
                dgv_ErreserbakIkusi.Columns["LangileaId"].HeaderText = "Langilea";
                dgv_ErreserbakIkusi.Columns["MahaiakId"].HeaderText = "Mahaia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errorea erreserbak kargatzen: {ex.Message}");
            }
        }


    }
}
