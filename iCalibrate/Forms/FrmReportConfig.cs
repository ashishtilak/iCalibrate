using iCalibrate.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using iCalibrate.Properties;

namespace iCalibrate.Forms
{
    public partial class FrmReportConfig : Form
    {
        private ModelContext _context;

        public FrmReportConfig()
        {
            InitializeComponent(); _context = new ModelContext();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupHeader.Enabled = true;
            _reportHeaderBS.Add(new ReportHeaderConfig());
            _reportHeaderBS.MoveLast();
            txtHFieldSerial.Focus();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            groupDetails.Enabled = true;
            _reportDetailsBS.Add(new ReportDetailsConfig());
            _reportDetailsBS.MoveLast();
            txtFieldSerialDetails.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupHeader.Enabled = false;
            LoadData(Convert.ToInt32(txtInstrumentMaster.EditValue));
        }

        private void btnCancelDetails_Click(object sender, EventArgs e)
        {
            groupDetails.Enabled = false;
            LoadData(Convert.ToInt32(txtInstrumentMaster.EditValue));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            LoadData(Convert.ToInt32(txtInstrumentMaster.EditValue));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int instrumentMasterId = Convert.ToInt32(txtInstrumentMaster.EditValue);

            string errorMessage;

            if (!ValidateHeader(Convert.ToInt32(txtHFieldId.Text), out errorMessage))
            {
                MessageBox.Show(errorMessage, Resources.MSGBOX_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData(instrumentMasterId);
                txtHFieldSerial.Focus();
                return;
            }

            //Get current location from BindingSource
            ReportHeaderConfig headerConfig = _reportHeaderBS.Current as ReportHeaderConfig;

            if (headerConfig == null) return;

            if (_context.Entry(headerConfig).State == EntityState.Detached)
                _context.Set<ReportHeaderConfig>().Attach(headerConfig);

            //If Id is zero, means new record is added, else old is modified
            int nextFieldId;
            if (Convert.ToInt32(txtHFieldId.Text) == 0)
            {
                _context.Entry(headerConfig).State = EntityState.Added;

                //get the next field id for this InstrumentMaster Header Config record
                try
                {
                    nextFieldId = _context.ReportHeaderConfigs
                        .Where(i => i.InstrumentMasterId == instrumentMasterId)
                        .Select(i => i.FieldId).Max();


                    // increment the next field id
                    nextFieldId += 1;

                }
                catch
                {
                    nextFieldId = 1;
                }

            }
            else
            {
                _context.Entry(headerConfig).State = EntityState.Modified;
                nextFieldId = headerConfig.FieldId;
            }


            // update other fields before saving
            headerConfig.InstrumentMasterId = instrumentMasterId;
            headerConfig.FieldId = nextFieldId;
            headerConfig.UserId = "SUPER";                      //TODO: Add user id too...
            headerConfig.UpdateDate = DateTime.Now;

            //now save changes to Db.

            _context.SaveChanges();

            MessageBox.Show(Resources.OK_Saved_Successfully, Resources.MSGBOX_Info, MessageBoxButtons.OK);

            groupHeader.Enabled = false;
            LoadData(instrumentMasterId);

        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            int instrumentMasterId = Convert.ToInt32(txtInstrumentMaster.EditValue);

            string errorMessage;

            if (!ValidateDetails(Convert.ToInt32(txtHFieldId.Text), out errorMessage))
            {
                MessageBox.Show(errorMessage, Resources.MSGBOX_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData(instrumentMasterId);
                txtFieldSerialDetails.Focus();
                return;
            }

            //Get current location from BindingSource
            ReportDetailsConfig detailsConfig = _reportDetailsBS.Current as ReportDetailsConfig;

            if (detailsConfig == null) return;

            if (_context.Entry(detailsConfig).State == EntityState.Detached)
                _context.Set<ReportDetailsConfig>().Attach(detailsConfig);

            //If Id is zero, means new record is added, else old is modified
            int nextFieldId;
            if (Convert.ToInt32(txtFieldIdDetails.Text) == 0)
            {
                _context.Entry(detailsConfig).State = EntityState.Added;

                //get the next field id for this InstrumentMaster Header Config record
                try
                {
                    nextFieldId = _context.ReportDetailsConfigs
                        .Where(i => i.InstrumentMasterId == instrumentMasterId)
                        .Select(i => i.FieldId).Max();

                    // increment the next field id
                    nextFieldId += 1;

                }
                catch
                {
                    nextFieldId = 1;
                }

            }
            else
            {
                _context.Entry(detailsConfig).State = EntityState.Modified;
                nextFieldId = detailsConfig.FieldId;
            }


            // update other fields before saving
            detailsConfig.InstrumentMasterId = instrumentMasterId;
            detailsConfig.FieldId = nextFieldId;
            detailsConfig.UserId = "SUPER";                      //TODO: Add user id too...
            detailsConfig.UpdateDate = DateTime.Now;

            //now save changes to Db.

            _context.SaveChanges();

            MessageBox.Show(Resources.OK_Saved_Successfully, Resources.MSGBOX_Info, MessageBoxButtons.OK);
            groupDetails.Enabled = false;
            LoadData(instrumentMasterId);
        }

        private void FrmReportConfig_Load(object sender, EventArgs e)
        {
            var instMast = _context.InstrumentMasters.ToList();

            txtInstrumentMaster.Properties.DataSource = instMast;
            txtInstrumentMaster.Properties.ValueMember = "InstrumentMasterId";
            txtInstrumentMaster.Properties.DisplayMember = "InstrumentMasterName";

            //by default don't enable entry fields
            groupHeader.Enabled = false;
            groupDetails.Enabled = false;
        }

        private void gridDetails_Click(object sender, EventArgs e)
        {
            if (groupDetails.Enabled)
                LoadData(Convert.ToInt32(txtInstrumentMaster.EditValue));

            groupHeader.Enabled = false;
            groupDetails.Enabled = false;
        }

        private void gridDetails_DoubleClick(object sender, EventArgs e)
        {
            _reportDetailsBS.ResetBindings(false);
            groupDetails.Enabled = true;
            txtFieldSerialDetails.Focus();
        }

        private void gridHeader_Click(object sender, EventArgs e)
        {
            if (groupHeader.Enabled)
                LoadData(Convert.ToInt32(txtInstrumentMaster.EditValue));

            groupHeader.Enabled = false;
            groupDetails.Enabled = false;
        }

        private void gridHeader_DoubleClick(object sender, EventArgs e)
        {
            _reportHeaderBS.ResetBindings(false);
            groupHeader.Enabled = true;
            txtHFieldSerial.Focus();
        }

        private void LoadData(int instrumentMasterId)
        {
            _context = new ModelContext();


            /* *************************************************
             * 
                    Load details of Report Header
             * 
             * *************************************************/

            _reportHeaderBS.DataSource = _context.ReportHeaderConfigs
                .Where(h => h.InstrumentMasterId == instrumentMasterId)
                .ToList();
            gridHeader.RefreshDataSource(); gridHeader.Refresh();
            gvHeader.BestFitColumns();


            /* *************************************************
             * 
                    Load details of Report Details
             * 
             * *************************************************/

            //field types
            _fieldTypesBS.DataSource = _context.FieldTypes.ToList();

            _reportDetailsBS.DataSource = _context.ReportDetailsConfigs
                .Where(d => d.InstrumentMasterId == instrumentMasterId)
                .ToList();

            gridDetails.RefreshDataSource();
            gridDetails.Refresh();
            gvDetails.BestFitColumns();

        }

        private bool ValidateDetails(int fieldId, out string message)
        {
            message = "";

            if (Convert.ToInt32(txtFieldSerialDetails.Text) == 0)
                message = string.Format(Resources.ERROR_Please_provide_input_in, "Field Serial \n");

            if (txtFieldNameDetails.Text == "")
                message = message + string.Format(Resources.ERROR_Please_provide_input_in, "Field Name \n");

            if (txtFieldCaptionDetails.Text == "")
                message = message + string.Format(Resources.ERROR_Please_provide_input_in, "Field Caption \n");

            return message == "";

        }

        private bool ValidateHeader(int fieldId, out string message)
        {
            //Field validations
            if (!txtHeaderFlag.Checked && !txtFooterFlag.Checked)
            {
                message = Resources.ERROR_Select_Header_or_Footer;
                return false;
            }

            message = "";
            return true;

        }
    }
}