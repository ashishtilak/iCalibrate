namespace iCalibrate.Forms
{
    partial class FrmInstrumentMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstrumentMaster));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this._instrumentMastersBS = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInstrumentMasterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstrumentMasterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCertificateNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCertificateNo = new System.Windows.Forms.TextBox();
            this.txtInstrumentMasterName = new System.Windows.Forms.TextBox();
            this.txtInstrumentMasterId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._instrumentMastersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.grid);
            this.splitContainerControl1.Panel1.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupMain);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(970, 589);
            this.splitContainerControl1.SplitterPosition = 399;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // grid
            // 
            this.grid.DataSource = this._instrumentMastersBS;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 59);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(399, 530);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.Click += new System.EventHandler(this.grid_Click);
            this.grid.DoubleClick += new System.EventHandler(this.grid_DoubleClick);
            // 
            // _instrumentMastersBS
            // 
            this._instrumentMastersBS.DataSource = typeof(iCalibrate.Models.InstrumentMasters);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInstrumentMasterId,
            this.colInstrumentMasterName,
            this.colCertificateNo});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInstrumentMasterId
            // 
            this.colInstrumentMasterId.FieldName = "InstrumentMasterId";
            this.colInstrumentMasterId.Name = "colInstrumentMasterId";
            this.colInstrumentMasterId.Visible = true;
            this.colInstrumentMasterId.VisibleIndex = 0;
            // 
            // colInstrumentMasterName
            // 
            this.colInstrumentMasterName.FieldName = "InstrumentMasterName";
            this.colInstrumentMasterName.Name = "colInstrumentMasterName";
            this.colInstrumentMasterName.Visible = true;
            this.colInstrumentMasterName.VisibleIndex = 1;
            // 
            // colCertificateNo
            // 
            this.colCertificateNo.FieldName = "CertificateNo";
            this.colCertificateNo.Name = "colCertificateNo";
            this.colCertificateNo.Visible = true;
            this.colCertificateNo.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 59);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(296, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.labelControl3);
            this.groupMain.Controls.Add(this.labelControl2);
            this.groupMain.Controls.Add(this.labelControl1);
            this.groupMain.Controls.Add(this.btnCancel);
            this.groupMain.Controls.Add(this.btnSave);
            this.groupMain.Controls.Add(this.txtCertificateNo);
            this.groupMain.Controls.Add(this.txtInstrumentMasterName);
            this.groupMain.Controls.Add(this.txtInstrumentMasterId);
            this.groupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupMain.Enabled = false;
            this.groupMain.Location = new System.Drawing.Point(0, 0);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(566, 589);
            this.groupMain.TabIndex = 2;
            this.groupMain.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Certificate Number";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Instrument Mast. Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Instrument Mast. Id";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(266, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(160, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCertificateNo
            // 
            this.txtCertificateNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._instrumentMastersBS, "CertificateNo", true));
            this.txtCertificateNo.Location = new System.Drawing.Point(160, 75);
            this.txtCertificateNo.Name = "txtCertificateNo";
            this.txtCertificateNo.Size = new System.Drawing.Size(128, 20);
            this.txtCertificateNo.TabIndex = 2;
            // 
            // txtInstrumentMasterName
            // 
            this.txtInstrumentMasterName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._instrumentMastersBS, "InstrumentMasterName", true));
            this.txtInstrumentMasterName.Location = new System.Drawing.Point(160, 49);
            this.txtInstrumentMasterName.Name = "txtInstrumentMasterName";
            this.txtInstrumentMasterName.Size = new System.Drawing.Size(128, 20);
            this.txtInstrumentMasterName.TabIndex = 3;
            // 
            // txtInstrumentMasterId
            // 
            this.txtInstrumentMasterId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._instrumentMastersBS, "InstrumentMasterId", true));
            this.txtInstrumentMasterId.Enabled = false;
            this.txtInstrumentMasterId.Location = new System.Drawing.Point(160, 23);
            this.txtInstrumentMasterId.Name = "txtInstrumentMasterId";
            this.txtInstrumentMasterId.Size = new System.Drawing.Size(128, 20);
            this.txtInstrumentMasterId.TabIndex = 4;
            // 
            // FrmInstrumentMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 589);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmInstrumentMaster";
            this.Text = "FrmInstrumentMaster";
            this.Load += new System.EventHandler(this.FrmInstrumentMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._instrumentMastersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.GroupBox groupMain;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtCertificateNo;
        private System.Windows.Forms.TextBox txtInstrumentMasterName;
        private System.Windows.Forms.TextBox txtInstrumentMasterId;
        private System.Windows.Forms.BindingSource _instrumentMastersBS;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumentMasterId;
        private DevExpress.XtraGrid.Columns.GridColumn colInstrumentMasterName;
        private DevExpress.XtraGrid.Columns.GridColumn colCertificateNo;
    }
}