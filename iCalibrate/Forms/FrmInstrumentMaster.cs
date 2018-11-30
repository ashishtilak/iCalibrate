using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCalibrate.Models;
using iCalibrate.Properties;

namespace iCalibrate.Forms
{
    public partial class FrmInstrumentMaster : Form
    {
        private ModelContext _context;

        public FrmInstrumentMaster()
        {
            InitializeComponent();
            _context = new ModelContext();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = true;
            _instrumentMastersBS.Add(new InstrumentMasters());
            _instrumentMastersBS.MoveLast();
            txtInstrumentMasterName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = false;
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate the record

            if (!Validate(Convert.ToInt32(txtInstrumentMasterId.Text), txtInstrumentMasterName.Text))
            {
                MessageBox.Show(Resources.ERROR_Duplicate_description,
                    Resources.MSGBOX_Error, MessageBoxButtons.OK);
                LoadData();
                txtInstrumentMasterName.Focus();
                return;
            }

            //Get current instrument master from BindingSource
            InstrumentMasters instMast = _instrumentMastersBS.Current as InstrumentMasters;

            if (instMast == null) return;

            if (_context.Entry(instMast).State == EntityState.Detached)
                _context.Set<InstrumentMasters>().Attach(instMast);

            //If Id is zero, means new record is added, else old is modified
            _context.Entry(instMast).State = Convert.ToInt32(txtInstrumentMasterId.Text) == 0
                ? EntityState.Added
                : EntityState.Modified;

            //save changes to Db.
            _context.SaveChanges();

            MessageBox.Show(Resources.OK_Saved_Successfully, Resources.MSGBOX_Info, MessageBoxButtons.OK);

            groupMain.Enabled = false;
            LoadData();
        }

        private void FrmInstrumentMaster_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grid_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = groupMain.Enabled = false;
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            _instrumentMastersBS.ResetBindings(false);
            LoadData();
            groupMain.Enabled = true;
        }

        private void LoadData()
        {
            _instrumentMastersBS.DataSource = _context.InstrumentMasters.ToList();
            grid.Refresh();
        }

        private bool Validate(int instrumentMasterId, string instrumentMasterName)
        {
            var inst = _context.InstrumentMasters.FirstOrDefault(
                i => i.InstrumentMasterId != instrumentMasterId &&
                     (i.InstrumentMasterName == instrumentMasterName)
            );

            return inst == null;
        }
    }
}
