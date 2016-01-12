namespace EMClient
{
    partial class EmployeeView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
			this.dgEmployeeView = new System.Windows.Forms.DataGridView();
			this.dgcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcDateCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcHourCountPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcHourCountPerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcHolidaysPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcDepartments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgbDepartments = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dgbLocations = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tsActions = new System.Windows.Forms.ToolStrip();
			this.tsbLoad = new System.Windows.Forms.ToolStripButton();
			this.tsbSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tsbNewEmployee = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgEmployeeView)).BeginInit();
			this.tsActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgEmployeeView
			// 
			this.dgEmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgEmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmployeeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcFirstName,
            this.dgcLastName,
            this.dgcAdress,
            this.dgcBirthday,
            this.dgcEmail,
            this.dgcPhone,
            this.dgcDateCount,
            this.dgcHourCountPerDay,
            this.dgcHourCountPerWeek,
            this.dgcHolidaysPerYear,
            this.dgcDepartments,
            this.dgcLocation,
            this.dgbDepartments,
            this.dgbLocations});
			this.dgEmployeeView.Location = new System.Drawing.Point(0, 3);
			this.dgEmployeeView.Name = "dgEmployeeView";
			this.dgEmployeeView.Size = new System.Drawing.Size(992, 337);
			this.dgEmployeeView.TabIndex = 1;
			this.dgEmployeeView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgEmployeeView_UserAddedRow);
			this.dgEmployeeView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgEmployeeView_UserDeletedRow);
			// 
			// dgcFirstName
			// 
			this.dgcFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcFirstName.HeaderText = "Vorname";
			this.dgcFirstName.Name = "dgcFirstName";
			// 
			// dgcLastName
			// 
			this.dgcLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcLastName.HeaderText = "Nachname";
			this.dgcLastName.Name = "dgcLastName";
			// 
			// dgcAdress
			// 
			this.dgcAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcAdress.HeaderText = "Adresse";
			this.dgcAdress.Name = "dgcAdress";
			// 
			// dgcBirthday
			// 
			this.dgcBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcBirthday.HeaderText = "Geburtstag";
			this.dgcBirthday.Name = "dgcBirthday";
			// 
			// dgcEmail
			// 
			this.dgcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcEmail.HeaderText = "E-Mail";
			this.dgcEmail.Name = "dgcEmail";
			// 
			// dgcPhone
			// 
			this.dgcPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcPhone.HeaderText = "Telefon";
			this.dgcPhone.Name = "dgcPhone";
			// 
			// dgcDateCount
			// 
			this.dgcDateCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcDateCount.HeaderText = "Anzahl Arbeitstage pro Woche";
			this.dgcDateCount.Name = "dgcDateCount";
			// 
			// dgcHourCountPerDay
			// 
			this.dgcHourCountPerDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcHourCountPerDay.HeaderText = "Anzahl Stunden pro Tag";
			this.dgcHourCountPerDay.Name = "dgcHourCountPerDay";
			// 
			// dgcHourCountPerWeek
			// 
			this.dgcHourCountPerWeek.HeaderText = "Anzahl Stunden pro Woche";
			this.dgcHourCountPerWeek.Name = "dgcHourCountPerWeek";
			this.dgcHourCountPerWeek.ReadOnly = true;
			// 
			// dgcHolidaysPerYear
			// 
			this.dgcHolidaysPerYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcHolidaysPerYear.HeaderText = "Anzahl Urlaubstage pro Jahr";
			this.dgcHolidaysPerYear.Name = "dgcHolidaysPerYear";
			// 
			// dgcDepartments
			// 
			this.dgcDepartments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcDepartments.HeaderText = "Abteilung";
			this.dgcDepartments.Name = "dgcDepartments";
			// 
			// dgcLocation
			// 
			this.dgcLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcLocation.HeaderText = "Ort";
			this.dgcLocation.Name = "dgcLocation";
			// 
			// dgbDepartments
			// 
			this.dgbDepartments.HeaderText = "Abteilungen";
			this.dgbDepartments.Name = "dgbDepartments";
			this.dgbDepartments.Text = "Anzeigen";
			this.dgbDepartments.UseColumnTextForButtonValue = true;
			// 
			// dgbLocations
			// 
			this.dgbLocations.HeaderText = "Standorte";
			this.dgbLocations.Name = "dgbLocations";
			this.dgbLocations.Text = "Anzeigen";
			this.dgbLocations.UseColumnTextForButtonValue = true;
			// 
			// tsActions
			// 
			this.tsActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tsActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoad,
            this.tsbNewEmployee,
            this.tsbSave,
            this.toolStripButton1});
			this.tsActions.Location = new System.Drawing.Point(0, 343);
			this.tsActions.Name = "tsActions";
			this.tsActions.Size = new System.Drawing.Size(995, 25);
			this.tsActions.TabIndex = 2;
			this.tsActions.Text = "toolStrip1";
			// 
			// tsbLoad
			// 
			this.tsbLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad.Image")));
			this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLoad.Name = "tsbLoad";
			this.tsbLoad.Size = new System.Drawing.Size(59, 22);
			this.tsbLoad.Text = "Laden";
			this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click);
			// 
			// tsbSave
			// 
			this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
			this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSave.Name = "tsbSave";
			this.tsbSave.Size = new System.Drawing.Size(79, 22);
			this.tsbSave.Text = "Speichern";
			this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(59, 22);
			this.toolStripButton1.Text = "testen";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// tsbNewEmployee
			// 
			this.tsbNewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewEmployee.Image")));
			this.tsbNewEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNewEmployee.Name = "tsbNewEmployee";
			this.tsbNewEmployee.Size = new System.Drawing.Size(120, 22);
			this.tsbNewEmployee.Text = "Neuer Mitarbeiter";
			this.tsbNewEmployee.Click += new System.EventHandler(this.tsbNewEmployee_Click);
			// 
			// EmployeeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tsActions);
			this.Controls.Add(this.dgEmployeeView);
			this.Name = "EmployeeView";
			this.Size = new System.Drawing.Size(995, 368);
			((System.ComponentModel.ISupportInitialize)(this.dgEmployeeView)).EndInit();
			this.tsActions.ResumeLayout(false);
			this.tsActions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView dgEmployeeView;
		private System.Windows.Forms.ToolStrip tsActions;
		private System.Windows.Forms.ToolStripButton tsbLoad;
		private System.Windows.Forms.ToolStripButton tsbSave;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcFirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcAdress;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcBirthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDateCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcHourCountPerDay;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcHourCountPerWeek;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcHolidaysPerYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDepartments;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcLocation;
		private System.Windows.Forms.DataGridViewButtonColumn dgbDepartments;
		private System.Windows.Forms.DataGridViewButtonColumn dgbLocations;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton tsbNewEmployee;
	}
}
