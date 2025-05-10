using Projekat.Models;
using Projekat.Repositories;
using System;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmOboje : Form
    {
        private int selectedBiljkaHerbarijumID;
        public event Action DataUpdated;

        public FrmOboje(int selectedBiljkaHerbarijumID)
        {
            InitializeComponent();
            this.selectedBiljkaHerbarijumID = selectedBiljkaHerbarijumID;
            this.saveBtn.Click += BtnSave_Click;

            InitData();
        }

        private void InitData()
        {
            var biljke = BiljkaRepository.GetPlantsDataTable();
            this.cbPlant.DataSource = biljke;
            this.cbPlant.DisplayMember = "Naziv";
            this.cbPlant.ValueMember = "BiljkaID";

            var herbarijumi = HerbarijumRepository.GetHerbariumsDataTable();
            this.cbHerbarium.DataSource = herbarijumi;
            this.cbHerbarium.DisplayMember = "Naziv";
            this.cbHerbarium.ValueMember = "HerbarijumID";

            if (selectedBiljkaHerbarijumID != -1)
            {
                this.lblTitle.Text = "Izmijeni biljku u herbarijumu";
                this.saveBtn.Text = "Izmijeni";

                BiljkaHerbarijum biljkaHerbarijum = BiljkaHerbRepository.GetBiljkaHerbarijumByID(selectedBiljkaHerbarijumID);
                if (biljkaHerbarijum != null)
                {
                    this.cbPlant.SelectedValue = biljkaHerbarijum.BiljkaID;
                    this.cbHerbarium.SelectedValue = biljkaHerbarijum.HerbarijumID;
                    this.dtpDatumSmjestanja.Value = biljkaHerbarijum.DatumSmještanja;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // VALIDACIJA
            if (this.cbPlant.SelectedValue == null || this.cbHerbarium.SelectedValue == null)
            {
                MessageBox.Show("Molimo odaberite važeće biljke i herbarijume.");
                return;
            }

            BiljkaHerbarijum biljkaHerbarijum = new BiljkaHerbarijum
            {
                BiljkaID = (int)this.cbPlant.SelectedValue,
                HerbarijumID = (int)this.cbHerbarium.SelectedValue,
                DatumSmještanja = this.dtpDatumSmjestanja.Value
            };

            bool result = false;
            if (this.selectedBiljkaHerbarijumID != -1)
            {
                // UPDATE
                biljkaHerbarijum.BiljkaHerbarijumID = this.selectedBiljkaHerbarijumID;
                result = BiljkaHerbRepository.UpdatePlantInHerbarium(biljkaHerbarijum.BiljkaHerbarijumID, biljkaHerbarijum.BiljkaID, biljkaHerbarijum.HerbarijumID, biljkaHerbarijum.DatumSmještanja);
            }
            else
            {
                // INSERT
                result = BiljkaHerbRepository.AddPlantToHerbarium(biljkaHerbarijum.BiljkaID, biljkaHerbarijum.HerbarijumID, biljkaHerbarijum.DatumSmještanja);
            }

            if (result)
            {
                MessageBox.Show("Uspješno sačuvani podaci!");
                DataUpdated?.Invoke(); // Trigger the event to refresh data
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška pri čuvanju podataka!");
            }
        }
    }
}
