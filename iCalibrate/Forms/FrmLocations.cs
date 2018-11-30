using iCalibrate.Models;
using iCalibrate.Properties;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace iCalibrate.Forms
{
    public partial class FrmLocations : Form
    {
        private ModelContext _context;

        public FrmLocations()
        {
            InitializeComponent();
            _context = new ModelContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = true;
            _locationsBS.Add(new Locations());
            _locationsBS.MoveLast();
            txtLocationName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = false;
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validate the record

            if (!Validate(Convert.ToInt32(txtLocationId.Text), Convert.ToInt32(txtLocationIndex.Text),
                txtLocationName.Text))
            {
                MessageBox.Show(Resources.ERROR_Duplicate_description + Resources.ERROR_Duplicate_location_index,
                    Resources.MSGBOX_Error, MessageBoxButtons.OK);
                LoadData();
                txtLocationIndex.Focus();
                return;
            }

            //Get current location from BindingSource
            Locations loc = _locationsBS.Current as Locations;

            if (loc == null) return;

            if (_context.Entry(loc).State == EntityState.Detached)
                _context.Set<Locations>().Attach(loc);

            //If Id is zero, means new record is added, else old is modified
            _context.Entry(loc).State = Convert.ToInt32(txtLocationId.Text) == 0
                ? EntityState.Added
                : EntityState.Modified;

            //save changes to Db.
            _context.SaveChanges();

            MessageBox.Show(Resources.OK_Saved_Successfully, Resources.MSGBOX_Info, MessageBoxButtons.OK);

            groupMain.Enabled = false;
            LoadData();
        }

        private bool Validate(int locationId, int locationIndex, string locationName)
        {
            var loc = _context.Locations.FirstOrDefault(
                l => l.LocationId != locationId &&
                     (l.LocationIndex == locationIndex || l.LocationName == locationName)
            );

            return loc == null;
        }

        private void FrmLocations_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grid_Click(object sender, EventArgs e)
        {
            groupMain.Enabled = groupMain.Enabled = false;
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            _locationsBS.ResetBindings(false);
            LoadData();
            groupMain.Enabled = true;
        }

        private void LoadData()
        {
            _locationsBS.DataSource = _context.Locations.ToList();
            grid.Refresh();
        }
    }
}