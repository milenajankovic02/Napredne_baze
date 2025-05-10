using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekat.Repositories;

namespace Projekat
{
    public partial class FrmBiljke : Form
    {
        private int selectedPlantID = -1; // Dodata deklaracija promenljive
        private int selectedHerbariumID = -1; // Dodata deklaracija promenljive

        public FrmBiljke()
        {
            InitializeComponent();
            // Povezivanje dugmadi sa funkcijama
            this.herbariumBtn.Click += HerbariumBtn_Click;
            this.plantsBtn.Click += PlantsBtn_Click;
            this.addPlantInHerbariumBtn.Click += AddPlantInHerbariumBtn_Click;
            this.seeDataBtn.Click += SeeDataBtn_Click;

            // Povezivanje menija sa funkcijama
            this.exitMenuItem.Click += ExitMenuItem_Click;
            this.addPlantMenuItem.Click += AddPlantMenuItem_Click;
            this.addHerbariumMenuItem.Click += AddHerbariumMenuItem_Click;
            this.addPlantInHerbariumMenuItem.Click += AddPlantInHerbariumMenuItem_Click;
            this.seeDataMenuItem.Click += SeeDataMenuItem_Click;

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
        private void HerbariumBtn_Click(object sender, EventArgs e)
        {
            PrikaziHerbarijume herbariumForm = new PrikaziHerbarijume();
            herbariumForm.ShowDialog();
        }

        private void PlantsBtn_Click(object sender, EventArgs e)
        {
            PrikaziBiljke plantsForm = new PrikaziBiljke();
            plantsForm.ShowDialog();
        }
        private void AddPlantInHerbariumBtn_Click(object sender, EventArgs e)
        {
            FrmOboje addPlantToHerbariumForm = new FrmOboje(-1);
            addPlantToHerbariumForm.ShowDialog();
        }
        private void SeeDataBtn_Click(object sender, EventArgs e)
        {
            PrikaziOboje prikaziObojeForm = new PrikaziOboje();
            prikaziObojeForm.ShowDialog();
        }

        //meni
        private void AddHerbariumMenuItem_Click(object sender, EventArgs e)
        {
             FrmHerbarijum addHerbariumForm = new FrmHerbarijum(-1);
             addHerbariumForm.ShowDialog();
        }

        private void AddPlantMenuItem_Click(object sender, EventArgs e)
        {
            FrmBiljka addPlantForm = new FrmBiljka( -1);
            addPlantForm.ShowDialog();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddPlantInHerbariumMenuItem_Click(object sender, EventArgs e)
        {
            FrmOboje addPlantToHerbariumForm = new FrmOboje(-1); 

            addPlantToHerbariumForm.ShowDialog();
        }
        
        private void SeeDataMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziOboje prikaziObojeForm = new PrikaziOboje();
            prikaziObojeForm.ShowDialog();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiljke));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlantMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHerbariumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlantInHerbariumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allPlantsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.allHerbariumsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantsBtn = new System.Windows.Forms.Button();
            this.herbariumBtn = new System.Windows.Forms.Button();
            this.addPlantInHerbariumBtn = new System.Windows.Forms.Button();
            this.seeDataBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem,
            this.izvještajToolStripMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlantMenuItem,
            this.addHerbariumMenuItem,
            this.addPlantInHerbariumMenuItem,
            this.seeDataMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // addPlantMenuItem
            // 
            this.addPlantMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.addPlantMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPlantMenuItem.Name = "addPlantMenuItem";
            this.addPlantMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addPlantMenuItem.Text = "Dodaj biljku";
            // 
            // addHerbariumMenuItem
            // 
            this.addHerbariumMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.addHerbariumMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addHerbariumMenuItem.Name = "addHerbariumMenuItem";
            this.addHerbariumMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addHerbariumMenuItem.Text = "Dodaj herbarijum";
            // 
            // addPlantInHerbariumMenuItem
            // 
            this.addPlantInHerbariumMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.addPlantInHerbariumMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPlantInHerbariumMenuItem.Name = "addPlantInHerbariumMenuItem";
            this.addPlantInHerbariumMenuItem.Size = new System.Drawing.Size(261, 26);
            this.addPlantInHerbariumMenuItem.Text = "Dodaj biljku u herbarijum";
            // 
            // seeDataMenuItem
            // 
            this.seeDataMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.seeDataMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seeDataMenuItem.Name = "seeDataMenuItem";
            this.seeDataMenuItem.Size = new System.Drawing.Size(261, 26);
            this.seeDataMenuItem.Text = "Pristup svim podacima";
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.izvještajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allPlantsReport,
            this.allHerbariumsReport});
            this.izvještajToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.izvještajToolStripMenuItem.Text = "Izvještaj";
            // 
            // allPlantsReport
            // 
            this.allPlantsReport.BackColor = System.Drawing.Color.LightCoral;
            this.allPlantsReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allPlantsReport.Name = "allPlantsReport";
            this.allPlantsReport.Size = new System.Drawing.Size(191, 26);
            this.allPlantsReport.Text = "Sve biljke";
            // 
            // allHerbariumsReport
            // 
            this.allHerbariumsReport.BackColor = System.Drawing.Color.LightCoral;
            this.allHerbariumsReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allHerbariumsReport.Name = "allHerbariumsReport";
            this.allHerbariumsReport.Size = new System.Drawing.Size(191, 26);
            this.allHerbariumsReport.Text = "Svi herbarijumi";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(74, 24);
            this.exitMenuItem.Text = "Napusti";
            // 
            // plantsBtn
            // 
            this.plantsBtn.BackColor = System.Drawing.Color.MistyRose;
            this.plantsBtn.Location = new System.Drawing.Point(133, 268);
            this.plantsBtn.Name = "plantsBtn";
            this.plantsBtn.Size = new System.Drawing.Size(216, 66);
            this.plantsBtn.TabIndex = 3;
            this.plantsBtn.Text = "Prikaži biljke";
            this.plantsBtn.UseVisualStyleBackColor = false;
            // 
            // herbariumBtn
            // 
            this.herbariumBtn.BackColor = System.Drawing.Color.MistyRose;
            this.herbariumBtn.Location = new System.Drawing.Point(137, 183);
            this.herbariumBtn.Name = "herbariumBtn";
            this.herbariumBtn.Size = new System.Drawing.Size(216, 69);
            this.herbariumBtn.TabIndex = 4;
            this.herbariumBtn.Text = "Prikaži herbarijume";
            this.herbariumBtn.UseVisualStyleBackColor = false;
            // 
            // addPlantInHerbariumBtn
            // 
            this.addPlantInHerbariumBtn.BackColor = System.Drawing.Color.MistyRose;
            this.addPlantInHerbariumBtn.Location = new System.Drawing.Point(133, 354);
            this.addPlantInHerbariumBtn.Name = "addPlantInHerbariumBtn";
            this.addPlantInHerbariumBtn.Size = new System.Drawing.Size(216, 69);
            this.addPlantInHerbariumBtn.TabIndex = 5;
            this.addPlantInHerbariumBtn.Text = "Dodaj biljku u herbarijum";
            this.addPlantInHerbariumBtn.UseVisualStyleBackColor = false;
            // 
            // seeDataBtn
            // 
            this.seeDataBtn.BackColor = System.Drawing.Color.MistyRose;
            this.seeDataBtn.Location = new System.Drawing.Point(133, 441);
            this.seeDataBtn.Name = "seeDataBtn";
            this.seeDataBtn.Size = new System.Drawing.Size(216, 70);
            this.seeDataBtn.TabIndex = 6;
            this.seeDataBtn.Text = "Pristup svim podacima";
            this.seeDataBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(131, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Izaberi neku od opcija";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(86, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 466);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBiljke
            // 
            this.BackgroundImage = global::Projekat.Properties.Resources.pocetna;
            this.ClientSize = new System.Drawing.Size(503, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seeDataBtn);
            this.Controls.Add(this.addPlantInHerbariumBtn);
            this.Controls.Add(this.herbariumBtn);
            this.Controls.Add(this.plantsBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBiljke";
            this.Text = "Plants and Herbariums";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
