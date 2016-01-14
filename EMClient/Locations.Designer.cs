namespace EMClient
{
	partial class Locations
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locations));
			this.scMain = new System.Windows.Forms.SplitContainer();
			this.lvLocations = new System.Windows.Forms.ListView();
			this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tsActions = new System.Windows.Forms.ToolStrip();
			this.tsbNewLocation = new System.Windows.Forms.ToolStripButton();
			this.tsbDeleteLocation = new System.Windows.Forms.ToolStripButton();
			this.clbDepartments = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
			this.scMain.Panel1.SuspendLayout();
			this.scMain.Panel2.SuspendLayout();
			this.scMain.SuspendLayout();
			this.tsActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// scMain
			// 
			this.scMain.Location = new System.Drawing.Point(12, 12);
			this.scMain.Name = "scMain";
			// 
			// scMain.Panel1
			// 
			this.scMain.Panel1.Controls.Add(this.lvLocations);
			// 
			// scMain.Panel2
			// 
			this.scMain.Panel2.Controls.Add(this.clbDepartments);
			this.scMain.Size = new System.Drawing.Size(425, 318);
			this.scMain.SplitterDistance = 194;
			this.scMain.TabIndex = 0;
			// 
			// lvLocations
			// 
			this.lvLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLocation});
			this.lvLocations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvLocations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvLocations.Location = new System.Drawing.Point(0, 0);
			this.lvLocations.Name = "lvLocations";
			this.lvLocations.Size = new System.Drawing.Size(194, 318);
			this.lvLocations.TabIndex = 0;
			this.lvLocations.UseCompatibleStateImageBehavior = false;
			this.lvLocations.View = System.Windows.Forms.View.Details;
			// 
			// chLocation
			// 
			this.chLocation.Text = "Standort";
			this.chLocation.Width = 189;
			// 
			// tsActions
			// 
			this.tsActions.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tsActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewLocation,
            this.tsbDeleteLocation});
			this.tsActions.Location = new System.Drawing.Point(0, 333);
			this.tsActions.Name = "tsActions";
			this.tsActions.Size = new System.Drawing.Size(449, 25);
			this.tsActions.TabIndex = 1;
			this.tsActions.Text = "Aktionen";
			// 
			// tsbNewLocation
			// 
			this.tsbNewLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNewLocation.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewLocation.Image")));
			this.tsbNewLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNewLocation.Name = "tsbNewLocation";
			this.tsbNewLocation.Size = new System.Drawing.Size(23, 22);
			this.tsbNewLocation.Text = "Neuer Standort";
			// 
			// tsbDeleteLocation
			// 
			this.tsbDeleteLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDeleteLocation.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteLocation.Image")));
			this.tsbDeleteLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDeleteLocation.Name = "tsbDeleteLocation";
			this.tsbDeleteLocation.Size = new System.Drawing.Size(23, 22);
			this.tsbDeleteLocation.Text = "Standort löschen";
			// 
			// clbDepartments
			// 
			this.clbDepartments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clbDepartments.FormattingEnabled = true;
			this.clbDepartments.Location = new System.Drawing.Point(0, 0);
			this.clbDepartments.Name = "clbDepartments";
			this.clbDepartments.Size = new System.Drawing.Size(227, 318);
			this.clbDepartments.TabIndex = 0;
			// 
			// Locations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 358);
			this.Controls.Add(this.tsActions);
			this.Controls.Add(this.scMain);
			this.Name = "Locations";
			this.Text = "Standorte";
			this.scMain.Panel1.ResumeLayout(false);
			this.scMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
			this.scMain.ResumeLayout(false);
			this.tsActions.ResumeLayout(false);
			this.tsActions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer scMain;
		private System.Windows.Forms.ListView lvLocations;
		private System.Windows.Forms.ColumnHeader chLocation;
		private System.Windows.Forms.ToolStrip tsActions;
		private System.Windows.Forms.ToolStripButton tsbNewLocation;
		private System.Windows.Forms.CheckedListBox clbDepartments;
		private System.Windows.Forms.ToolStripButton tsbDeleteLocation;
	}
}