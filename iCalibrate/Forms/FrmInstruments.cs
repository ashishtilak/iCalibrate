using iCalibrate.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using iCalibrate.Helper;
using iCalibrate.Properties;

namespace iCalibrate.Forms
{
    public partial class FrmInstruments : Form
    {
        private ModelContext _context;

        public FrmInstruments()
        {
            InitializeComponent();
            _context = new ModelContext();
        }

        private void FrmInstruments_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //Refresh binding source data
            _instrumentsBS.DataSource = _context.Instruments
                .Include(i => i.InstrumentMaster)
                .Include(i => i.Location)
                .ToList();

            grid.Refresh();

            gridView1.BestFitColumns();

            //Refresh location combobox
            var loc = _context.Locations.ToList();

            txtLocations.Properties.DataSource = loc;
            txtLocations.Properties.ValueMember = "LocationId";
            txtLocations.Properties.DisplayMember = "LocationName";

            //Refresh Instrument masters combobox
            var instMast = _context.InstrumentMasters.ToList();

            txtInstrumentMaster.Properties.DataSource = instMast;
            txtInstrumentMaster.Properties.ValueMember = "InstrumentMasterId";
            txtInstrumentMaster.Properties.DisplayMember = "InstrumentMasterName";
        }

        private void grid_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = groupMain.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = true;
            _instrumentsBS.Add(new Instruments());
            _instrumentsBS.MoveLast();
            txtInstrumentName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = false;
            LoadData();
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            _instrumentsBS.ResetBindings(false);
            LoadData();
            groupMain.Enabled = true;
            txtInstrumentName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate(Convert.ToInt32(txtInstrumentId.Text), txtIdentificationNo.Text))
            {
                MessageBox.Show(Resources.ERROR_Duplicate_description, Resources.MSGBOX_Error, MessageBoxButtons.OK);
                LoadData();
                txtIdentificationNo.Focus();
                return;
            }

            //Get current location from BindingSource
            Instruments inst = _instrumentsBS.Current as Instruments;

            if (inst == null) return;

            if (_context.Entry(inst).State == EntityState.Detached)
                _context.Set<Instruments>().Attach(inst);

            //If Id is zero, means new record is added, else old is modified
            _context.Entry(inst).State = Convert.ToInt32(txtInstrumentId.Text) == 0
                ? EntityState.Added
                : EntityState.Modified;

            //save changes to Db.
            _context.SaveChanges();

            MessageBox.Show(Resources.OK_Saved_Successfully, Resources.MSGBOX_Info, MessageBoxButtons.OK);

            groupMain.Enabled = false;
            LoadData();
        }

        private bool Validate(int instrumentId, string identificationNo)
        {
            var inst = _context.Instruments.FirstOrDefault(
                i => i.InstrumentId != instrumentId && i.IdentificationNo == identificationNo);

            return inst == null;

        }
    }
}