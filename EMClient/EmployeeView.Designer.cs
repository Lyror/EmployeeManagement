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
			System.Windows.Forms.Button button1;
			this.dgvEmployeeView = new System.Windows.Forms.DataGridView();
			this.dgcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcDateCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcHourCountPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcHolidaysPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcDepartments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeView)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(0, 0);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(56, 40);
			button1.TabIndex = 0;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dgvEmployeeView
			// 
			this.dgvEmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvEmployeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployeeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcFirstName,
            this.dgcLastName,
            this.dgcAdress,
            this.dgcBirthday,
            this.dgcEmail,
            this.dgcPhone,
            this.dgcDateCount,
            this.dgcHourCountPerDay,
            this.dgcHolidaysPerYear,
            this.dgcDepartments,
            this.dgcLocation});
			this.dgvEmployeeView.Location = new System.Drawing.Point(0, 36);
			this.dgvEmployeeView.Name = "dgvEmployeeView";
			this.dgvEmployeeView.Size = new System.Drawing.Size(992, 329);
			this.dgvEmployeeView.TabIndex = 1;
			this.dgvEmployeeView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// dgcFirstName
			// 
			this.dgcFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcFirstName.HeaderText = "Vorname";
			this.dgcFirstName.Name = "dgcFirstName";
			this.dgcFirstName.Width = 74;
			// 
			// dgcLastName
			// 
			this.dgcLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcLastName.HeaderText = "Nachname";
			this.dgcLastName.Name = "dgcLastName";
			this.dgcLastName.Width = 84;
			// 
			// dgcAdress
			// 
			this.dgcAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcAdress.HeaderText = "Adresse";
			this.dgcAdress.Name = "dgcAdress";
			this.dgcAdress.Width = 70;
			// 
			// dgcBirthday
			// 
			this.dgcBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcBirthday.HeaderText = "Geburtstag";
			this.dgcBirthday.Name = "dgcBirthday";
			this.dgcBirthday.Width = 84;
			// 
			// dgcEmail
			// 
			this.dgcEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcEmail.HeaderText = "E-Mail";
			this.dgcEmail.Name = "dgcEmail";
			this.dgcEmail.Width = 61;
			// 
			// dgcPhone
			// 
			this.dgcPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcPhone.HeaderText = "Telefon";
			this.dgcPhone.Name = "dgcPhone";
			this.dgcPhone.Width = 68;
			// 
			// dgcDateCount
			// 
			this.dgcDateCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcDateCount.HeaderText = "Anzahl Arbeitstage pro Woche";
			this.dgcDateCount.Name = "dgcDateCount";
			this.dgcDateCount.Width = 129;
			// 
			// dgcHourCountPerDay
			// 
			this.dgcHourCountPerDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcHourCountPerDay.HeaderText = "Anzahl Stunden pro Tag";
			this.dgcHourCountPerDay.Name = "dgcHourCountPerDay";
			this.dgcHourCountPerDay.Width = 117;
			// 
			// dgcHolidaysPerYear
			// 
			this.dgcHolidaysPerYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcHolidaysPerYear.HeaderText = "Anzahl Urlaubstage pro Jahr";
			this.dgcHolidaysPerYear.Name = "dgcHolidaysPerYear";
			this.dgcHolidaysPerYear.Width = 132;
			// 
			// dgcDepartments
			// 
			this.dgcDepartments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcDepartments.HeaderText = "Abteilung";
			this.dgcDepartments.Name = "dgcDepartments";
			this.dgcDepartments.Width = 76;
			// 
			// dgcLocation
			// 
			this.dgcLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dgcLocation.HeaderText = "Ort";
			this.dgcLocation.Name = "dgcLocation";
			this.dgcLocation.Width = 46;
			// 
			// EmployeeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvEmployeeView);
			this.Controls.Add(button1);
			this.Name = "EmployeeView";
			this.Size = new System.Drawing.Size(995, 368);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeView)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dgvEmployeeView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcFirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcAdress;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcBirthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDateCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcHourCountPerDay;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcHolidaysPerYear;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDepartments;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcLocation;
	}
}
