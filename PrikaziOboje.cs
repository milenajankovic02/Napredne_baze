using Projekat.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projekat
{
    public partial class PrikaziOboje : Form
    {
        private int selectedBiljkaHerbarijumID = -1;
        DataTable data;

        SqlDataAdapter sqlDataAdapter;
        SqlCommandBuilder sqlCommandBuilder;

        public PrikaziOboje()
        {
            InitializeComponent();
            // dugmad
            this.btnSearch.Click += BtnSearch_Click;
            this.changeBtn.Click += ChangeDataBtn_Click;
            this.deleteBtn.Click += DeleteDataBtn_Click;

            // iz menija
            this.addPlantMenuItem.Click += AddPlantMenuItem_Click;
            this.addHerbariumMenuItem.Click += AddHerbariumMenuItem_Click;
            this.addPlantInHerbariumMenuItem.Click += AddPlantInHerbariumMenuItem_Click;
            this.exitMenuItem.Click += ExitMenuItem_Click;

            this.dgPlantHebrarium.RowValidated += DgBiljkaHerbarijum_RowValidated;
            this.dgPlantHebrarium.CellClick += DgBiljkaHerbarijum_CellClick;


            this.allPlantsReport.Click += ReportPlants_Click;
            this.allHerbariumsReport.Click += ReportHerbariums_Click;
           
            InitDataSqlAdapter();
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
            string plantName = this.txtPlantNameSearch.Text;
            string herbariumName = this.txtHerbariumNameSearch.Text;


            this.data = BiljkaHerbRepository.SearchBiljkeHerbarijum(plantName, herbariumName);

            if (this.data != null)
            {
                this.dgPlantHebrarium.DataSource = this.data;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka!");
            }
        }

        private void AddPlantMenuItem_Click(object sender, EventArgs e)
        {
            FrmBiljka plantForm = new FrmBiljka(-1);
            plantForm.DataUpdated += InitData;
            plantForm.ShowDialog();
        }

        private void AddHerbariumMenuItem_Click(object sender, EventArgs e)
        {
            FrmHerbarijum projectForm = new FrmHerbarijum(-1);
            projectForm.ShowDialog();
        }

        private void AddPlantInHerbariumMenuItem_Click(object sender, EventArgs e)
        {
            FrmOboje addPlantToHerbariumForm = new FrmOboje(-1);
            addPlantToHerbariumForm.DataUpdated += InitData;
            addPlantToHerbariumForm.ShowDialog();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeDataBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedBiljkaHerbarijumID == -1)
            {
                MessageBox.Show("Odaberite podatak za izmjenu!");
            }
            else
            {
                FrmOboje editForm = new FrmOboje(this.selectedBiljkaHerbarijumID);
                editForm.DataUpdated += InitData;       
                editForm.ShowDialog();
            }
        }

        private void DeleteDataBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedBiljkaHerbarijumID == -1)
            {
                MessageBox.Show("Odaberite podatak koji želite da uklonite!");
            }
            else
            {
                CustomDialog customDialog = new CustomDialog("Da li ste sigurni da želite da izbrišete podatak?");
                DialogResult dialogR = customDialog.ShowDialog();
                if (dialogR == DialogResult.Yes)
                {
                    bool result = BiljkaHerbRepository.DeletePlantHerb(this.selectedBiljkaHerbarijumID);
                    if (result)
                    {
                        this.InitData();
                        MessageBox.Show("Podatak je izbrisan!");
                    }
                    else
                    {
                        MessageBox.Show("Greska pri brisanju!");
                    }
                }
            }
        }
        private void DgBiljkaHerbarijum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1 && rowIndex < this.data.Rows.Count)
            {
                DataRow dataRow = this.data.Rows[rowIndex];
                this.selectedBiljkaHerbarijumID = (int)dataRow.ItemArray[0];
            }
        }

        public void InitData()
        {
            this.data = BiljkaHerbRepository.GetBiljkeHerbarijumDataTable();
            if (this.data != null)
            {
                this.dgPlantHebrarium.DataSource = this.data;
                this.dgPlantHebrarium.AllowUserToAddRows = false;
                this.dgPlantHebrarium.AllowUserToDeleteRows = false;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka!");
            }
        }

        public void InitDataSqlAdapter()
        {
            string selectCommandText = @"
                SELECT 
                    bh.BiljkaHerbarijumID,
                    b.Naziv AS BiljkaNaziv,
                    h.Naziv AS HerbarijumNaziv,
                    bh.DatumSmještanja
                FROM 
                    BiljkaHerbarijum bh
                JOIN 
                    Biljka b ON bh.BiljkaID = b.BiljkaID
                JOIN 
                    Herbarijum h ON bh.HerbarijumID = h.HerbarijumID";
            string connectionString = "Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;";
            sqlDataAdapter = new SqlDataAdapter(selectCommandText, connectionString);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            this.dgPlantHebrarium.DataSource = dataSet.Tables[0];
            this.data = dataSet.Tables[0];
        }

        private void DgBiljkaHerbarijum_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)this.dgPlantHebrarium.DataSource).GetChanges();

            if (changes != null)
            {
                sqlDataAdapter.Update(changes);
                ((DataTable)this.dgPlantHebrarium.DataSource).AcceptChanges();
            }
        }
    }
}
