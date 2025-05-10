using Projekat.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class PrikaziBiljke : Form
    {
        private int selectedPlantID = -1;
        DataTable data;

        SqlDataAdapter sqlDataAdapter;
        SqlCommandBuilder sqlCommandBuilder;

        public PrikaziBiljke()
        {
            InitializeComponent();
           //iz menija
            this.addPlantMenuItem.Click += AddPlantMenuItem_Click;
            this.addHerbariumMenuItem.Click += AddHerbariumMenuItem_Click;
            this.exitMenuItem.Click += ExitMenuItem_Click;
            this.addPlantInHerbariumMenuItem.Click += AddPlantInHerbariumMenuItem_Click;
           //buttons
            this.btnPretraga.Click += BtnSearch_Click;
            this.deletePlantBtn.Click += BtnDelete_Click;
            this.changePlantBtn.Click += ChangePlantBtn_Click;


            // ZA AUTOMATSKO UPDATE-OVANJE REDOVA 
            this.dgPlants.RowValidated += DgPlants_RowValidated;
            this.dgPlants.CellClick += DgPlants_CellClick; // Povezivanje događaja za klik na ćeliju
            InitDataSqlAdapter();

            this.allPlantsReport.Click += ReportPlants_Click;
            this.allHerbariumsReport.Click += ReportHerbariums_Click;
        }
        private void ReportPlants_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport(Enumerations.ReportType.AllPlants);
            frmReport.ShowDialog();
        }

        private void ReportHerbariums_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport(Enumerations.ReportType.AllHerbariums);
            frmReport.ShowDialog();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string nameSearchText = this.txtNameSearch.Text;
            string typeSearchText = this.txtTypeSearch.Text;


            // Pretražuje biljke prema imenu, vrsti i datumu sadnje
            this.data = BiljkaRepository.SearchPlants(nameSearchText, typeSearchText);

            if (this.data != null)
            {
                this.dgPlants.DataSource = this.data;
            }
            else
            {
                MessageBox.Show("Greska pri ucitavanju biljaka!");
            }
        }

        private void AddPlantMenuItem_Click(object sender, EventArgs e)
        {
            FrmBiljka plantForm = new FrmBiljka(-1);
            plantForm.DataUpdated += InitData;
            plantForm.ShowDialog();
        }

        //dodaj herbarijum preko menija
        private void AddHerbariumMenuItem_Click(object sender, EventArgs e)
        {
            FrmHerbarijum projectForm = new FrmHerbarijum(-1);
            projectForm.FormClosed += (s, args) => InitData();
            projectForm.ShowDialog();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddPlantInHerbariumMenuItem_Click(object sender, EventArgs e)
        {
            FrmOboje addPlantToHerbariumForm = new FrmOboje(-1); // Passing -1 for a new record
            addPlantToHerbariumForm.FormClosed += (s, args) => InitData();
            addPlantToHerbariumForm.ShowDialog();
        }



        //Frm biljka je forma i za izmjenu i za dodavanje
        private void ChangePlantBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedPlantID == -1)
            {
                MessageBox.Show("Odaberite biljku!");
            }
            else
            {
                FrmBiljka changePlantForm = new FrmBiljka(selectedPlantID);
                changePlantForm.FormClosed += (s, args) => InitData();
                changePlantForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedPlantID == -1)
            {
                MessageBox.Show("Odaberite biljku!");
            }
            else
            {
                CustomDialog customDialog = new CustomDialog("Da li ste sigurni da želite da izbrišete biljku?");
                DialogResult dialogR = customDialog.ShowDialog();
                if (dialogR == DialogResult.Yes)
                {
                    bool result = BiljkaRepository.DeletePlant(this.selectedPlantID);
                    if (result)
                    {
                        this.InitData();
                        MessageBox.Show("Biljka izbrisana!");
                    }
                    else
                    {
                        MessageBox.Show("Greska pri brisanju!");
                    }
                }
            }
        }

        private void DgPlants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1 && rowIndex < this.data.Rows.Count)
            {
                DataRow dataRow = this.data.Rows[rowIndex];
                this.selectedPlantID = (int)dataRow.ItemArray[0];
            }
        }

        public void InitData()
        {
            this.data = BiljkaRepository.GetPlantsDataTable();
            if (this.data != null)
            {
                this.dgPlants.DataSource = this.data;
                this.dgPlants.AllowUserToAddRows = false;
                this.dgPlants.AllowUserToDeleteRows = false;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju biljaka!");
            }
        }

        public void InitDataSqlAdapter()
        {
            string selectCommandText = "SELECT * FROM Biljka";
            string connectionString = "Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;";
            sqlDataAdapter = new SqlDataAdapter(selectCommandText, connectionString);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            this.dgPlants.DataSource = dataSet.Tables[0];
            this.data = dataSet.Tables[0];
        }

        private void DgPlants_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)this.dgPlants.DataSource).GetChanges();

            if (changes != null)
            {
                sqlDataAdapter.Update(changes);
                ((DataTable)this.dgPlants.DataSource).AcceptChanges();
            }
        }

    }
}
