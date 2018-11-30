namespace iCalibrate.Forms
{
    partial class FrmInstruments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstruments));
            this.MainSplitter = new DevExpress.XtraEditors.SplitContainerControl();
            this.TopSplitter = new DevExpress.XtraEditors.SplitContainerControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this._instrumentsBS = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInstrumentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumentMasterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumentMaster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRange = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.txtInstrumentName = new System.Windows.Forms.TextBox();
            this.txtIdentificationNo = new System.Windows.Forms.TextBox();
            this.txtInstrumentId = new System.Windows.Forms.TextBox();
            this.txtLocations = new DevExpress.XtraEditors.LookUpEdit();
            this.txtInstrumentMaster = new DevExpress.XtraEditors.LookUpEdit();
            this.groupDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).BeginInit();
            this.MainSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopSplitter)).BeginInit();
            this.TopSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._instrumentsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInstrumentMaster.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitter
            // 
            this.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitter.Horizontal = false;
            this.MainSplitter.Location = new System.Drawing.Point(0, 0);
            this.MainSplitter.Name = "MainSplitter";
            this.MainSplitter.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.MainSplitter.Panel1.Controls.Add(this.TopSplitter);
            this.MainSplitter.Panel1.Text = "Panel1";
            this.MainSplitter.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.MainSplitter.Panel2.Controls.Add(this.groupDetails);
            this.MainSplitter.Panel2.Text = "Panel2";
            this.MainSplitter.Size = new System.Drawing.Size(870, 539);
            this.MainSplitter.SplitterPosition = 243;
            this.MainSplitter.TabIndex = 0;
            this.MainSplitter.Text = "splitContainerControl1";
            // 
            // TopSplitter
            // 
            this.TopSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopSplitter.Location = new System.Drawing.Point(0, 0);
            this.TopSplitter.Name = "TopSplitter";
            this.TopSplitter.Panel1.Controls.Add(this.grid);
            this.TopSplitter.Panel1.Controls.Add(this.panel1);
            this.TopSplitter.Panel1.Text = "Panel1";
            this.TopSplitter.Panel2.Controls.Add(this.groupMain);
            this.TopSplitter.Panel2.Text = "Panel2";
            this.TopSplitter.Size = new System.Drawing.Size(866, 239);
            this.TopSplitter.SplitterPosition = 458;
            this.TopSplitter.TabIndex = 0;
            this.TopSplitter.Text = "splitContainerControl2";
            // 
            // grid
            // 
            this.grid.DataSource = this._instrumentsBS;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 53);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(458, 186);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.Click += new System.EventHandler(this.grid_Click);
            this.grid.DoubleClick += new System.EventHandler(this.grid_DoubleClick);
            // 
            // _instrumentsBS
            // 
            this._instrumentsBS.DataSource = typeof(iCalibrate.Models.Instruments);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInstrumentId,
            this.colInstrumentName,
            this.colInstrumentMasterId,
            this.colInstrumentMaster,
            this.colLocationId,
            this.colLocation,
            this.colIdentificationNo,
            this.colRange});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInstrumentId
            // 
            this.colInstrumentId.Caption = "Id";
            this.colInstrumentId.FieldName = "InstrumentId";
            this.colInstrumentId.Name = "colInstrumentId";
            this.colInstrumentId.Visible = true;
            this.colInstrumentId.VisibleIndex = 0;
            // 
            // colInstrumentName
            // 
            this.colInstrumentName.Caption = "Inst. Name";
            this.colInstrumentName.FieldName = "InstrumentName";
            this.colInstrumentName.Name = "colInstrumentName";
            this.colInstrumentName.Visible = true;
            this.colInstrumentName.VisibleIndex = 1;
            // 
            // colInstrumentMasterId
            // 
            this.colInstrumentMasterId.Caption = "Inst Mast Id";
            this.colInstrumentMasterId.FieldName = "InstrumentMasterId";
            this.colInstrumentMasterId.Name = "colInstrumentMasterId";
            this.colInstrumentMasterId.Visible = true;
            this.colInstrumentMasterId.VisibleIndex = 2;
            // 
            // colInstrumentMaster
            // 
            this.colInstrumentMaster.Caption = "Inst Mast Name";
            this.colInstrumentMaster.FieldName = "InstrumentMaster.InstrumentMasterName";
            this.colInstrumentMaster.Name = "colInstrumentMaster";
            this.colInstrumentMaster.Visible = true;
            this.colInstrumentMaster.VisibleIndex = 3;
            // 
            // colLocationId
            // 
            this.colLocationId.Caption = "Loc Id";
            this.colLocationId.FieldName = "LocationId";
            this.colLocationId.Name = "colLocationId";
            this.colLocationId.Visible = true;
            this.colLocationId.VisibleIndex = 4;
            // 
            // colLocation
            // 
            this.colLocation.Caption = "Loc Name";
            this.colLocation.FieldName = "Location.LocationName";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 5;
            // 
            // colIdentificationNo
            // 
            this.colIdentificationNo.Caption = "Inst ID";
            this.colIdentificationNo.FieldName = "IdentificationNo";
            this.colIdentificationNo.Name = "colIdentificationNo";
            this.colIdentificationNo.Visible = true;
            this.colIdentificationNo.VisibleIndex = 6;
            // 
            // colRange
            // 
            this.colRange.FieldName = "Range";
            this.colRange.Name = "colRange";
            this.colRange.Visible = true;
            this.colRange.VisibleIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.labelControl3);
            this.groupMain.Controls.Add(this.labelControl5);
            this.groupMain.Controls.Add(this.labelControl4);
            this.groupMain.Controls.Add(this.labelControl6);
            this.groupMain.Controls.Add(this.labelControl2);
            this.groupMain.Controls.Add(this.labelControl1);
            this.groupMain.Controls.Add(this.btnCancel);
            this.groupMain.Controls.Add(this.btnSave);
            this.groupMain.Controls.Add(this.txtRange);
            this.groupMain.Controls.Add(this.txtInstrumentName);
            this.groupMain.Controls.Add(this.txtIdentificationNo);
            this.groupMain.Controls.Add(this.txtInstrumentId);
            this.groupMain.Controls.Add(this.txtLocations);
            this.groupMain.Controls.Add(this.txtInstrumentMaster);
            this.groupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMain.Enabled = false;
            this.groupMain.Location = new System.Drawing.Point(0, 0);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(403, 239);
            this.groupMain.TabIndex = 0;
            this.groupMain.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Range";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 97);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Location";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Instrument Master";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 45);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Instrument Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Identification No";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Instrument Id";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(217, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(111, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRange
            // 
            this.txtRange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._instrumentsBS, "Range", true));
            this.txtRange.Location = new System.Drawing.Point(111, 146);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(206, 20);
            this.txtRange.TabIndex = 11;
            // 
            // txtInstrumentName
            // 
            this.txtInstrumentName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._instrumentsBS, "InstrumentName", true));
            this.txtInstrumentName.Location = new System.Drawing.Point(111, 42);
            this.txtInstrumentName.Name = "txtInstrumentName";
            this.txtInstrumentName.Size = new System.Drawing.Size(206, 20);
            this.txtInstrumentName.TabIndex = 3;
            // 
            // txtIdentificationNo
            // 
            this.txtIdentificationNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._instrumentsBS, "IdentificationNo", true));
            this.txtIdentificationNo.Location = new System.Drawing.Point(111, 120);
            this.txtIdentificationNo.Name = "txtIdentificationNo";
            this.txtIdentificationNo.Size = new System.Drawing.Size(206, 20);
            this.txtIdentificationNo.TabIndex = 9;
            // 
            // txtInstrumentId
            // 
            this.txtInstrumentId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._instrumentsBS, "InstrumentId", true));
            this.txtInstrumentId.Enabled = false;
            this.txtInstrumentId.Location = new System.Drawing.Point(111, 16);
            this.txtInstrumentId.Name = "txtInstrumentId";
            this.txtInstrumentId.Size = new System.Drawing.Size(128, 20);
            this.txtInstrumentId.TabIndex = 1;
            // 
            // txtLocations
            // 
            this.txtLocations.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this._instrumentsBS, "LocationId", true));
            this.txtLocations.Location = new System.Drawing.Point(111, 94);
            this.txtLocations.Name = "txtLocations";
            this.txtLocations.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtLocations.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLocations.Size = new System.Drawing.Size(206, 20);
            this.txtLocations.TabIndex = 7;
            // 
            // txtInstrumentMaster
            // 
            this.txtInstrumentMaster.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this._instrumentsBS, "InstrumentMasterId", true));
            this.txtInstrumentMaster.Location = new System.Drawing.Point(111, 68);
            this.txtInstrumentMaster.Name = "txtInstrumentMaster";
            this.txtInstrumentMaster.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtInstrumentMaster.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtInstrumentMaster.Size = new System.Drawing.Size(206, 20);
            this.txtInstrumentMaster.TabIndex = 5;
            // 
            // groupDetails
            // 
            this.groupDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetails.Location = new System.Drawing.Point(0, 0);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(866, 287);
            this.groupDetails.TabIndex = 0;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "History Data:";
            // 
            // FrmInstruments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 539);
            this.Controls.Add(this.MainSplitter);
            this.Name = "FrmInstruments";
            this.Text = "FrmInstruments";
            this.Load += new System.EventHandler(this.FrmInstruments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitter)).EndInit();
            this.MainSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopSplitter)).EndInit();
            this.TopSplitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._instrumentsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInstrumentMaster.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl MainSplitter;
        private DevExpress.XtraEditors.SplitContainerControl TopSplitter;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl grid;
        private System.Windows.Forms.BindingSource _instrumentsBS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumentId;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumentMasterId;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumentMaster;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationId;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colRange;
        private System.Windows.Forms.GroupBox groupMain;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.TextBox txtIdentificationNo;
        private System.Windows.Forms.TextBox txtInstrumentId;
        private DevExpress.XtraEditors.LookUpEdit txtLocations;
        private DevExpress.XtraEditors.LookUpEdit txtInstrumentMaster;
        private System.Windows.Forms.GroupBox groupDetails;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox txtInstrumentName;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumentName;
    }
}