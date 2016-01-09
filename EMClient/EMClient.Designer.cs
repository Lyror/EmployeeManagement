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
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Mitarbeiter bearbeiten");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Mitarbeiter", new System.Windows.Forms.TreeNode[] {
            treeNode9});
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Abteilungen");
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("");
			this.ribbon1 = new System.Windows.Forms.Ribbon();
			this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
			this.tvNavigation = new System.Windows.Forms.TreeView();
			this.pControls = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// ribbon1
			// 
			this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ribbon1.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.Minimized = false;
			this.ribbon1.Name = "ribbon1";
			// 
			// 
			// 
			this.ribbon1.OrbDropDown.BorderRoundness = 8;
			this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
			this.ribbon1.OrbDropDown.Name = "";
			this.ribbon1.OrbDropDown.OptionItems.Add(this.ribbonOrbOptionButton1);
			this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
			this.ribbon1.OrbDropDown.TabIndex = 0;
			this.ribbon1.OrbImage = null;
			this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
			this.ribbon1.Size = new System.Drawing.Size(1152, 52);
			this.ribbon1.TabIndex = 0;
			this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
			this.ribbon1.Text = "ribbon1";
			this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
			// 
			// ribbonOrbOptionButton1
			// 
			this.ribbonOrbOptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.Image")));
			this.ribbonOrbOptionButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.SmallImage")));
			this.ribbonOrbOptionButton1.Text = "Beenden";
			// 
			// tvNavigation
			// 
			this.tvNavigation.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tvNavigation.Location = new System.Drawing.Point(0, 50);
			this.tvNavigation.Name = "tvNavigation";
			treeNode9.Name = "nodeEmployeeEdit";
			treeNode9.Text = "Mitarbeiter bearbeiten";
			treeNode10.Name = "nodeEmployee";
			treeNode10.Text = "Mitarbeiter";
			treeNode11.Name = "nodeDepartment";
			treeNode11.Text = "Abteilungen";
			treeNode12.Name = "";
			treeNode12.Text = "";
			this.tvNavigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
			this.tvNavigation.ShowRootLines = false;
			this.tvNavigation.Size = new System.Drawing.Size(153, 650);
			this.tvNavigation.TabIndex = 1;
			this.tvNavigation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNavigation_AfterSelect);
			// 
			// pControls
			// 
			this.pControls.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pControls.Location = new System.Drawing.Point(159, 56);
			this.pControls.Name = "pControls";
			this.pControls.Size = new System.Drawing.Size(993, 632);
			this.pControls.TabIndex = 2;
			// 
			// EMClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1152, 695);
			this.Controls.Add(this.pControls);
			this.Controls.Add(this.tvNavigation);
			this.Controls.Add(this.ribbon1);
			this.Name = "EMClient";
			this.Text = "EMClient";
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton1;
        private System.Windows.Forms.TreeView tvNavigation;
        private System.Windows.Forms.Panel pControls;
    }
}

