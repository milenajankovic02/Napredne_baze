using Projekat.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projekat
{
    public partial class PrikaziHerbarijume : Form
    {
        private int selectedHerbariumID = -1;
        DataTable data;

        SqlDataAdapter sqlDataAdapter;
        SqlCommandBuilder sqlCommandBuilder;

        public PrikaziHerbarijume()
        {
            InitializeComponent();
            // Menus
            this.addPlantMenuItem.Click += AddPlantMenuItem_Click;
            this.addHerbariumMenuItem.Click += AddHerbariumMenuItem_Click;
            this.exitMenuItem.Click += ExitMenuItem_Click;
            this.addPlantInHerbariumMenuItem.Click += AddPlantInHerbariumMenuItem_Click;
            // Buttons
            this.btnSearch.Click += BtnSearch_Click;
            this.deleteHerbariumBtn.Click += BtnDelete_Click;
            this.changeHerbariumBtn.Click += ChangeHerbariumBtn_Click;

            // Automatic row update
            this.dgHerbariums.RowValidated += DgHerbariums_RowValidated;
            this.dgHerbariums.CellClick += DgHerbariums_CellClick; // Event for cell click
            InitDataSqlAdapter();


            //izvjestaji
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
            string descriptionSearchText = this.txtDescriptionSearch.Text;

            // Search herbaria by name, description, and founding date
            this.data = HerbarijumRepository.SearchHerbariums(nameSearchText, descriptionSearchText);

            if (this.data != null)
            {
                this.dgHerbariums.DataSource = this.data;
            }
            else
            {
                MessageBox.Show("Greska pri ucitavanju herbarijuma!");
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
            FrmHerbarijum herbariumForm = new FrmHerbarijum(-1);
            herbariumForm.DataUpdated += InitData;
            herbariumForm.ShowDialog();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPlantInHerbariumMenuItem_Click(object sender, EventArgs e)
        {
            FrmOboje addPlantToHerbariumForm = new FrmOboje(-1);
            addPlantToHerbariumForm.FormClosed += (s, args) => InitData();
            addPlantToHerbariumForm.ShowDialog();
        }

        private void ChangeHerbariumBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedHerbariumID == -1)
            {
                MessageBox.Show("Odaberite herbarijum!");
            }
            else
            {
                FrmHerbarijum changeHerbariumForm = new FrmHerbarijum(selectedHerbariumID);
                changeHerbariumForm.FormClosed += (s, args) => InitData();
                changeHerbariumForm.ShowDialog();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedHerbariumID == -1)
            {
                MessageBox.Show("Odaberite herbarijum!");
            }
            else
            {
                CustomDialog customDialog = new CustomDialog("Da li ste sigurni da želite da izbrišete herbarijum?");
                DialogResult dialogR = customDialog.ShowDialog();
                if (dialogR == DialogResult.Yes)
                {
                    bool result = HerbarijumRepository.DeleteHerbarium(this.selectedHerbariumID);
                    if (result)
                    {
                        this.InitData();
                        MessageBox.Show("Herbarijum izbrisan!");
                    }
                    else
                    {
                        MessageBox.Show("Greska pri brisanju!");
                    }
                }
            }
        }

        private void DgHerbariums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex != -1 && rowIndex < this.data.Rows.Count)
            {
                DataRow dataRow = this.data.Rows[rowIndex];
                this.selectedHerbariumID = (int)dataRow.ItemArray[0];
            }
        }

        public void InitData()
        {
            this.data = HerbarijumRepository.GetHerbariumsDataTable();
            if (this.data != null)
            {
                this.dgHerbariums.DataSource = this.data;
                this.dgHerbariums.AllowUserToAddRows = false;
                this.dgHerbariums.AllowUserToDeleteRows = false;
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju herbarijuma!");
            }
        }

        public void InitDataSqlAdapter()
        {
            string selectCommandText = "SELECT * FROM Herbarijum";
            string connectionString = "Server=Milena;Database=HerbarijumDB;Trusted_Connection=True;";
            sqlDataAdapter = new SqlDataAdapter(selectCommandText, connectionString);
            sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            this.dgHerbariums.DataSource = dataSet.Tables[0];
            this.data = dataSet.Tables[0];
        }

        private void DgHerbariums_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)this.dgHerbariums.DataSource).GetChanges();

            if (changes != null)
            {
                sqlDataAdapter.Update(changes);
                ((DataTable)this.dgHerbariums.DataSource).AcceptChanges();
            }
        }
    }
}
