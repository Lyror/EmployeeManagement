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
			this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tpEmployees = new System.Windows.Forms.TabPage();
			this.tpDepartments = new System.Windows.Forms.TabPage();
			this.tpLocations = new System.Windows.Forms.TabPage();
			this.ucEmployeeView = new EmployeeView();
			this.tcMain.SuspendLayout();
			this.tpEmployees.SuspendLayout();
			this.SuspendLayout();
			// 
			// ribbonOrbOptionButton1
			// 
			this.ribbonOrbOptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.Image")));
			this.ribbonOrbOptionButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.SmallImage")));
			// 
			// tcMain
			// 
			this.tcMain.Controls.Add(this.tpEmployees);
			this.tcMain.Controls.Add(this.tpDepartments);
			this.tcMain.Controls.Add(this.tpLocations);
			this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMain.Location = new System.Drawing.Point(0, 0);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(1366, 561);
			this.tcMain.TabIndex = 0;
			this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
			// 
			// tpEmployees
			// 
			this.tpEmployees.Controls.Add(this.ucEmployeeView);
			this.tpEmployees.Location = new System.Drawing.Point(4, 22);
			this.tpEmployees.Name = "tpEmployees";
			this.tpEmployees.Padding = new System.Windows.Forms.Padding(3);
			this.tpEmployees.Size = new System.Drawing.Size(1358, 535);
			this.tpEmployees.TabIndex = 0;
			this.tpEmployees.Text = "Mitarbeiter";
			this.tpEmployees.UseVisualStyleBackColor = true;
			// 
			// tpDepartments
			// 
			this.tpDepartments.Location = new System.Drawing.Point(4, 22);
			this.tpDepartments.Name = "tpDepartments";
			this.tpDepartments.Padding = new System.Windows.Forms.Padding(3);
			this.tpDepartments.Size = new System.Drawing.Size(754, 370);
			this.tpDepartments.TabIndex = 1;
			this.tpDepartments.Text = "Abteilungen";
			this.tpDepartments.UseVisualStyleBackColor = true;
			// 
			// tpLocations
			// 
			this.tpLocations.Location = new System.Drawing.Point(4, 22);
			this.tpLocations.Name = "tpLocations";
			this.tpLocations.Size = new System.Drawing.Size(754, 370);
			this.tpLocations.TabIndex = 2;
			this.tpLocations.Text = "Standort";
			this.tpLocations.UseVisualStyleBackColor = true;
			// 
			// ucEmployeeView
			// 
			this.ucEmployeeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucEmployeeView.Location = new System.Drawing.Point(3, 3);
			this.ucEmployeeView.Name = "ucEmployeeView";
			this.ucEmployeeView.Size = new System.Drawing.Size(1352, 529);
			this.ucEmployeeView.TabIndex = 0;
			// 
			// EMClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1366, 561);
			this.Controls.Add(this.tcMain);
			this.Name = "EMClient";
			this.Text = "EMClient";
			this.tcMain.ResumeLayout(false);
			this.tpEmployees.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

		private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton1;
		private System.Windows.Forms.TabControl tcMain;
		private System.Windows.Forms.TabPage tpEmployees;
		private System.Windows.Forms.TabPage tpDepartments;
		private System.Windows.Forms.TabPage tpLocations;
		private EmployeeView ucEmployeeView;
    }
}

