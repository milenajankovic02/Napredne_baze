using Projekat.Models;
using Projekat.Repositories;
using System;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmHerbarijum : Form
    {
        private int selectedHerbarijumID;
        public event Action DataUpdated;
        public FrmHerbarijum(int selectedHerbarijumID)
        {
            InitializeComponent();
            this.selectedHerbarijumID = selectedHerbarijumID;
            this.saveBtn.Click += BtnSave_Click;

            InitData();
        }

        private void InitData()
        {
            if (this.selectedHerbarijumID != -1)
            {
                this.lblTitle.Text = "Izmijeni herbarijum";
                this.saveBtn.Text = "Izmijeni";

                Herbarijum herbarijum = HerbarijumRepository.GetHerbariumByID(this.selectedHerbarijumID);
                if (herbarijum != null)
                {
                    this.txtNaziv.Text = herbarijum.Naziv;
                    this.txtOpis.Text = herbarijum.Opis;
                    this.dtpDatumOsnivanja.Value = herbarijum.DatumOsnivanja;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // TODO: VALIDACIJA

            Herbarijum herbarijum = new Herbarijum
            {
                Naziv = this.txtNaziv.Text,
                Opis = this.txtOpis.Text,
                DatumOsnivanja = this.dtpDatumOsnivanja.Value
            };

            bool result = false;
            if (this.selectedHerbarijumID != -1)
            {
                // UPDATE
                herbarijum.HerbarijumID = this.selectedHerbarijumID;
                result = HerbarijumRepository.UpdateHerbarium(herbarijum);
            }
            else
            {
                // INSERT
                result = HerbarijumRepository.InsertHerbarium(herbarijum);
            }

            if (result)
            {
                MessageBox.Show("Uspješno sačuvan herbarijum!");
                DataUpdated?.Invoke(); // Trigger the event to refresh data
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška pri čuvanju herbarijuma!");
            }
        }
    }
}
