namespace SirSoiActivity
{
	partial class MainForm
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
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
			this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
			this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
			this.teFirstName = new DevExpress.XtraEditors.TextEdit();
			this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
			this.teLastName = new DevExpress.XtraEditors.TextEdit();
			this.cbCivilStatus = new DevExpress.XtraEditors.ComboBoxEdit();
			this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
			this.lc2MiddleName = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.lcSex = new DevExpress.XtraEditors.LabelControl();
			this.lcCivilStatus = new DevExpress.XtraEditors.LabelControl();
			this.cbSex = new DevExpress.XtraEditors.ComboBoxEdit();
			this.gvPeople = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcPeople = new DevExpress.XtraGrid.GridControl();
			((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbCivilStatus.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvPeople)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcPeople)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 307);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(112, 307);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Update";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(112, 354);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(12, 354);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			// 
			// teFirstName
			// 
			this.teFirstName.Location = new System.Drawing.Point(28, 43);
			this.teFirstName.Name = "teFirstName";
			this.teFirstName.Size = new System.Drawing.Size(144, 20);
			this.teFirstName.TabIndex = 5;
			// 
			// teMiddleName
			// 
			this.teMiddleName.Location = new System.Drawing.Point(28, 88);
			this.teMiddleName.Name = "teMiddleName";
			this.teMiddleName.Size = new System.Drawing.Size(144, 20);
			this.teMiddleName.TabIndex = 6;
			// 
			// teLastName
			// 
			this.teLastName.Location = new System.Drawing.Point(28, 133);
			this.teLastName.Name = "teLastName";
			this.teLastName.Size = new System.Drawing.Size(144, 20);
			this.teLastName.TabIndex = 7;
			// 
			// cbCivilStatus
			// 
			this.cbCivilStatus.Location = new System.Drawing.Point(28, 223);
			this.cbCivilStatus.Name = "cbCivilStatus";
			this.cbCivilStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbCivilStatus.Properties.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced"});
			this.cbCivilStatus.Size = new System.Drawing.Size(144, 20);
			this.cbCivilStatus.TabIndex = 9;
			// 
			// lcFirstName
			// 
			this.lcFirstName.Location = new System.Drawing.Point(28, 24);
			this.lcFirstName.Name = "lcFirstName";
			this.lcFirstName.Size = new System.Drawing.Size(51, 13);
			this.lcFirstName.TabIndex = 10;
			this.lcFirstName.Text = "First Name";
			// 
			// lc2MiddleName
			// 
			this.lc2MiddleName.Location = new System.Drawing.Point(28, 69);
			this.lc2MiddleName.Name = "lc2MiddleName";
			this.lc2MiddleName.Size = new System.Drawing.Size(60, 13);
			this.lc2MiddleName.TabIndex = 11;
			this.lc2MiddleName.Text = "Middle Name";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(28, 114);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(50, 13);
			this.labelControl3.TabIndex = 12;
			this.labelControl3.Text = "Last Name";
			// 
			// lcSex
			// 
			this.lcSex.Location = new System.Drawing.Point(28, 159);
			this.lcSex.Name = "lcSex";
			this.lcSex.Size = new System.Drawing.Size(18, 13);
			this.lcSex.TabIndex = 13;
			this.lcSex.Text = "Sex";
			// 
			// lcCivilStatus
			// 
			this.lcCivilStatus.Location = new System.Drawing.Point(28, 204);
			this.lcCivilStatus.Name = "lcCivilStatus";
			this.lcCivilStatus.Size = new System.Drawing.Size(53, 13);
			this.lcCivilStatus.TabIndex = 14;
			this.lcCivilStatus.Text = "Civil Status";
			// 
			// cbSex
			// 
			this.cbSex.Location = new System.Drawing.Point(28, 179);
			this.cbSex.Name = "cbSex";
			this.cbSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cbSex.Properties.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cbSex.Size = new System.Drawing.Size(144, 20);
			this.cbSex.TabIndex = 15;
			// 
			// gvPeople
			// 
			this.gvPeople.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
			this.gvPeople.GridControl = this.gcPeople;
			this.gvPeople.Name = "gvPeople";
			this.gvPeople.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "First Name";
			this.gridColumn1.FieldName = "FirstName";
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Middle Name";
			this.gridColumn2.FieldName = "MiddleName";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 1;
			// 
			// gridColumn3
			// 
			this.gridColumn3.Caption = "Last Name";
			this.gridColumn3.FieldName = "LastName";
			this.gridColumn3.Name = "gridColumn3";
			this.gridColumn3.Visible = true;
			this.gridColumn3.VisibleIndex = 2;
			// 
			// gridColumn4
			// 
			this.gridColumn4.Caption = "Sex";
			this.gridColumn4.FieldName = "Sex";
			this.gridColumn4.Name = "gridColumn4";
			this.gridColumn4.Visible = true;
			this.gridColumn4.VisibleIndex = 3;
			// 
			// gridColumn5
			// 
			this.gridColumn5.Caption = "Civil Status";
			this.gridColumn5.FieldName = "CivilStatus";
			this.gridColumn5.Name = "gridColumn5";
			this.gridColumn5.Visible = true;
			this.gridColumn5.VisibleIndex = 4;
			// 
			// gcPeople
			// 
			this.gcPeople.Dock = System.Windows.Forms.DockStyle.Right;
			this.gcPeople.Location = new System.Drawing.Point(210, 0);
			this.gcPeople.MainView = this.gvPeople;
			this.gcPeople.Name = "gcPeople";
			this.gcPeople.Size = new System.Drawing.Size(565, 407);
			this.gcPeople.TabIndex = 4;
			this.gcPeople.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPeople});
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 407);
			this.Controls.Add(this.cbSex);
			this.Controls.Add(this.lcCivilStatus);
			this.Controls.Add(this.lcSex);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.lc2MiddleName);
			this.Controls.Add(this.lcFirstName);
			this.Controls.Add(this.cbCivilStatus);
			this.Controls.Add(this.teLastName);
			this.Controls.Add(this.teMiddleName);
			this.Controls.Add(this.teFirstName);
			this.Controls.Add(this.gcPeople);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Name = "MainForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbCivilStatus.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbSex.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvPeople)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcPeople)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnAdd;
		private DevExpress.XtraEditors.SimpleButton btnUpdate;
		private DevExpress.XtraEditors.SimpleButton btnLoad;
		private DevExpress.XtraEditors.SimpleButton btnDelete;
		private DevExpress.XtraEditors.TextEdit teFirstName;
		private DevExpress.XtraEditors.TextEdit teMiddleName;
		private DevExpress.XtraEditors.TextEdit teLastName;
		private DevExpress.XtraEditors.ComboBoxEdit cbCivilStatus;
		private DevExpress.XtraEditors.LabelControl lcFirstName;
		private DevExpress.XtraEditors.LabelControl lc2MiddleName;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl lcSex;
		private DevExpress.XtraEditors.LabelControl lcCivilStatus;
		private DevExpress.XtraEditors.ComboBoxEdit cbSex;
		private DevExpress.XtraGrid.Views.Grid.GridView gvPeople;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
		private DevExpress.XtraGrid.GridControl gcPeople;
	}
}

