using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCalibrate.Forms;

namespace iCalibrate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            FrmLocations f = new FrmLocations();
            f.Show();
        }

        private void btnInstMast_Click(object sender, EventArgs e)
        {
            FrmInstrumentMaster f = new FrmInstrumentMaster();
            f.Show();
        }

        private void btnInstruments_Click(object sender, EventArgs e)
        {
            FrmInstruments f = new FrmInstruments();
            f.Show();
        }

        private void btnReportConfig_Click(object sender, EventArgs e)
        {
            FrmReportConfig f = new FrmReportConfig();
            f.Show();
        }
    }
}
