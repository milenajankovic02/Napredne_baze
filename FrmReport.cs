using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekat.Enumerations;

namespace Projekat
{
    public partial class FrmReport : Form
    {
        public FrmReport(ReportType rptType )
        {
            InitializeComponent();

            if (rptType == ReportType.AllPlants)
            {
                RptAllPlants rptAllPlants = new RptAllPlants();
                this.rptViewer.ReportSource = rptAllPlants;
            }
            else if (rptType == ReportType.AllHerbariums)
            {
                RptAllHerbariums rptAllHerbariums = new RptAllHerbariums();
                this.rptViewer.ReportSource = rptAllHerbariums;
            }
        }
    }
}
