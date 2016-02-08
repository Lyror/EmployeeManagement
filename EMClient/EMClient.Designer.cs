namespace EMClient
{
	partial class EMClient
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

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMClient));
			this.scMain = new System.Windows.Forms.SplitContainer();
			this.lvEmployees = new System.Windows.Forms.ListView();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tsActions = new System.Windows.Forms.ToolStrip();
			this.tsbNewEmployee = new System.Windows.Forms.ToolStripButton();
			this.tsbDeleteEmployee = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbLocations = new System.Windows.Forms.ToolStripButton();
			this.tsbDepartments = new System.Windows.Forms.ToolStripButton();
			this.tsbMapping = new System.Windows.Forms.ToolStripButton();
			this.pgEmployee = new System.Windows.Forms.PropertyGrid();
			this.tsbLoad = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
			this.scMain.Panel1.SuspendLayout();
			this.scMain.Panel2.SuspendLayout();
			this.scMain.SuspendLayout();
			this.tsActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// scMain
			// 
			this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scMain.Location = new System.Drawing.Point(0, 0);
			this.scMain.Name = "scMain";
			// 
			// scMain.Panel1
			// 
			this.scMain.Panel1.Controls.Add(this.lvEmployees);
			this.scMain.Panel1.Controls.Add(this.tsActions);
			// 
			// scMain.Panel2
			// 
			this.scMain.Panel2.Controls.Add(this.pgEmployee);
			this.scMain.Size = new System.Drawing.Size(790, 500);
			this.scMain.SplitterDistance = 263;
			this.scMain.TabIndex = 0;
			// 
			// lvEmployees
			// 
			this.lvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
			this.lvEmployees.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvEmployees.HideSelection = false;
			this.lvEmployees.Location = new System.Drawing.Point(3, 28);
			this.lvEmployees.Name = "lvEmployees";
			this.lvEmployees.Size = new System.Drawing.Size(257, 469);
			this.lvEmployees.TabIndex = 1;
			this.lvEmployees.UseCompatibleStateImageBehavior = false;
			this.lvEmployees.View = System.Windows.Forms.View.Details;
			this.lvEmployees.SelectedIndexChanged += new System.EventHandler(this.lvEmployees_SelectedIndexChanged);
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.chName.Width = 250;
			// 
			// tsActions
			// 
			this.tsActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoad,
            this.tsbNewEmployee,
            this.tsbDeleteEmployee,
            this.toolStripSeparator1,
            this.tsbLocations,
            this.tsbDepartments,
            this.tsbMapping});
			this.tsActions.Location = new System.Drawing.Point(0, 0);
			this.tsActions.Name = "tsActions";
			this.tsActions.Size = new System.Drawing.Size(263, 25);
			this.tsActions.TabIndex = 0;
			this.tsActions.Text = "toolStrip1";
			// 
			// tsbNewEmployee
			// 
			this.tsbNewEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewEmployee.Image")));
			this.tsbNewEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNewEmployee.Name = "tsbNewEmployee";
			this.tsbNewEmployee.Size = new System.Drawing.Size(23, 22);
			this.tsbNewEmployee.Text = "Mitarbeiter hinzufügen";
			this.tsbNewEmployee.Click += new System.EventHandler(this.tsbNewEmployee_Click);
			// 
			// tsbDeleteEmployee
			// 
			this.tsbDeleteEmployee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDeleteEmployee.Enabled = false;
			this.tsbDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteEmployee.Image")));
			this.tsbDeleteEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDeleteEmployee.Name = "tsbDeleteEmployee";
			this.tsbDeleteEmployee.Size = new System.Drawing.Size(23, 22);
			this.tsbDeleteEmployee.Text = "Mitarbeiter löschen";
			this.tsbDeleteEmployee.Click += new System.EventHandler(this.tsbDeleteEmployee_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbLocations
			// 
			this.tsbLocations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbLocations.Image = ((System.Drawing.Image)(resources.GetObject("tsbLocations.Image")));
			this.tsbLocations.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLocations.Name = "tsbLocations";
			this.tsbLocations.Size = new System.Drawing.Size(23, 22);
			this.tsbLocations.Text = "Standorte verändern";
			this.tsbLocations.Click += new System.EventHandler(this.tsbLocations_Click);
			// 
			// tsbDepartments
			// 
			this.tsbDepartments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDepartments.Image = ((System.Drawing.Image)(resources.GetObject("tsbDepartments.Image")));
			this.tsbDepartments.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDepartments.Name = "tsbDepartments";
			this.tsbDepartments.Size = new System.Drawing.Size(23, 22);
			this.tsbDepartments.Text = "Abteilungen";
			this.tsbDepartments.Click += new System.EventHandler(this.tsbDepartments_Click);
			// 
			// tsbMapping
			// 
			this.tsbMapping.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbMapping.Image = ((System.Drawing.Image)(resources.GetObject("tsbMapping.Image")));
			this.tsbMapping.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbMapping.Name = "tsbMapping";
			this.tsbMapping.Size = new System.Drawing.Size(23, 22);
			this.tsbMapping.Text = "Standorte und Abteilungen verknüpfen";
			this.tsbMapping.Click += new System.EventHandler(this.tsbMapping_Click);
			// 
			// pgEmployee
			// 
			this.pgEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgEmployee.Location = new System.Drawing.Point(0, 0);
			this.pgEmployee.Name = "pgEmployee";
			this.pgEmployee.Size = new System.Drawing.Size(523, 500);
			this.pgEmployee.TabIndex = 0;
			this.pgEmployee.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgEmployee_PropertyValueChanged);
			// 
			// tsbLoad
			// 
			this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoad.Image")));
			this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLoad.Name = "tsbLoad";
			this.tsbLoad.Size = new System.Drawing.Size(23, 22);
			this.tsbLoad.Text = "Laden";
			this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click);
			// 
			// EMClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 500);
			this.Controls.Add(this.scMain);
			this.Name = "EMClient";
			this.Text = "EMClient";
			this.scMain.Panel1.ResumeLayout(false);
			this.scMain.Panel1.PerformLayout();
			this.scMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
			this.scMain.ResumeLayout(false);
			this.tsActions.ResumeLayout(false);
			this.tsActions.PerformLayout();
			this.ResumeLayout(false);

		}

        #endregion
		private System.Windows.Forms.SplitContainer scMain;
		private System.Windows.Forms.ListView lvEmployees;
		private System.Windows.Forms.ToolStrip tsActions;
		private System.Windows.Forms.ToolStripButton tsbNewEmployee;
		private System.Windows.Forms.ToolStripButton tsbDeleteEmployee;
		private System.Windows.Forms.PropertyGrid pgEmployee;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbLocations;
		private System.Windows.Forms.ToolStripButton tsbDepartments;
		private System.Windows.Forms.ToolStripButton tsbMapping;
		private System.Windows.Forms.ToolStripButton tsbLoad;
    }
}

