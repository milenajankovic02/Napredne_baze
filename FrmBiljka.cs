using Projekat.Models;
using Projekat.Repositories;
using System;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmBiljka : Form
    {
        private int selectedBiljkaID;
        public event Action DataUpdated;
        public FrmBiljka(int selectedBiljkaID)
        {
            InitializeComponent();
            this.selectedBiljkaID = selectedBiljkaID;
            this.btnSave.Click += BtnSave_Click;

            InitData();
        }

        private void InitData()
        {
            if (this.selectedBiljkaID != -1)
            {
                this.lblTitle.Text = "Izmijeni biljku";
                this.btnSave.Text = "Izmijeni";

                Biljka biljka = BiljkaRepository.GetPlantByID(this.selectedBiljkaID);
                if (biljka != null)
                {
                    this.txtNaziv.Text = biljka.Naziv;
                    this.txtVrsta.Text = biljka.Vrsta;
                    this.dtpDatumZalivanja.Value = biljka.DatumZalivanja;
                    this.txtOpis.Text = biljka.Opis;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO: VALIDACIJA

            Biljka biljka = new Biljka
            {
                Naziv = this.txtNaziv.Text,
                Vrsta = this.txtVrsta.Text,
                DatumZalivanja = this.dtpDatumZalivanja.Value,
                Opis = this.txtOpis.Text
            };

            bool result = false;
            if (this.selectedBiljkaID != -1)
            {
                // UPDATE
                biljka.BiljkaID = this.selectedBiljkaID;
                result = BiljkaRepository.UpdatePlant(biljka);
            }
            else
            {
                // INSERT
                result = BiljkaRepository.InsertPlant(biljka);
            }

            if (result)
            {
                MessageBox.Show("Uspješno sačuvana biljka!");
                DataUpdated?.Invoke(); // Trigger the event to refresh data
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška pri čuvanju biljke!");
            }
        }
    }
}
