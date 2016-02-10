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
			this.scMain = new System.Windows.Forms.SplitContainer();
			this.lvLocations = new System.Windows.Forms.ListView();
			this.chLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clbDepartments = new System.Windows.Forms.CheckedListBox();
			this.btClose = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
			this.scMain.Panel1.SuspendLayout();
			this.scMain.Panel2.SuspendLayout();
			this.scMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// scMain
			// 
			this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.scMain.Size = new System.Drawing.Size(425, 305);
			this.scMain.SplitterDistance = 193;
			this.scMain.TabIndex = 0;
			// 
			// lvLocations
			// 
			this.lvLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLocation});
			this.lvLocations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvLocations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvLocations.HideSelection = false;
			this.lvLocations.Location = new System.Drawing.Point(0, 0);
			this.lvLocations.Name = "lvLocations";
			this.lvLocations.Size = new System.Drawing.Size(193, 305);
			this.lvLocations.TabIndex = 0;
			this.lvLocations.UseCompatibleStateImageBehavior = false;
			this.lvLocations.View = System.Windows.Forms.View.Details;
			this.lvLocations.SelectedIndexChanged += new System.EventHandler(this.lvLocations_SelectedIndexChanged);
			// 
			// chLocation
			// 
			this.chLocation.Text = "Standort";
			this.chLocation.Width = 189;
			// 
			// clbDepartments
			// 
			this.clbDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clbDepartments.FormattingEnabled = true;
			this.clbDepartments.Location = new System.Drawing.Point(0, 0);
			this.clbDepartments.Name = "clbDepartments";
			this.clbDepartments.Size = new System.Drawing.Size(228, 305);
			this.clbDepartments.TabIndex = 0;
			this.clbDepartments.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDepartments_ItemCheck);
			// 
			// btClose
			// 
			this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btClose.Location = new System.Drawing.Point(362, 323);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(75, 23);
			this.btClose.TabIndex = 1;
			this.btClose.Text = "Schließen";
			this.btClose.UseVisualStyleBackColor = true;
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btSave
			// 
			this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btSave.Location = new System.Drawing.Point(281, 323);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "Speichern";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// Locations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 358);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.scMain);
			this.Name = "Locations";
			this.Text = "Standorte";
			this.Load += new System.EventHandler(this.Locations_Load);
			this.scMain.Panel1.ResumeLayout(false);
			this.scMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
			this.scMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer scMain;
		private System.Windows.Forms.ListView lvLocations;
		private System.Windows.Forms.ColumnHeader chLocation;
		private System.Windows.Forms.CheckedListBox clbDepartments;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btSave;
	}
}