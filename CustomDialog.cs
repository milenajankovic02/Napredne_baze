using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class CustomDialog : Form
    {
        public CustomDialog(string lblText)
        {
            InitializeComponent();
            this.lblTitle.Text = lblText;
            this.btnYes.Click += BtnYes_Click;
            this.btnNo.Click += BtnNo_Click;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
