namespace EMServer
{
	partial class EMServer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMServer));
			this.msAction = new System.Windows.Forms.MenuStrip();
			this.btServer = new System.Windows.Forms.ToolStripMenuItem();
			this.btServerStart = new System.Windows.Forms.ToolStripMenuItem();
			this.btServerStop = new System.Windows.Forms.ToolStripMenuItem();
			this.btOption = new System.Windows.Forms.ToolStripMenuItem();
			this.btSetConnectionString = new System.Windows.Forms.ToolStripMenuItem();
			this.pbStatus = new System.Windows.Forms.PictureBox();
			this.msAction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// msAction
			// 
			this.msAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btServer,
            this.btOption});
			this.msAction.Location = new System.Drawing.Point(0, 0);
			this.msAction.Name = "msAction";
			this.msAction.Size = new System.Drawing.Size(284, 24);
			this.msAction.TabIndex = 0;
			this.msAction.Text = "menuStrip1";
			// 
			// btServer
			// 
			this.btServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btServerStart,
            this.btServerStop});
			this.btServer.Image = global::EMServer.Properties.Resources.Home_Server_icon;
			this.btServer.Name = "btServer";
			this.btServer.Size = new System.Drawing.Size(67, 20);
			this.btServer.Text = "Server";
			// 
			// btServerStart
			// 
			this.btServerStart.Image = global::EMServer.Properties.Resources.start;
			this.btServerStart.Name = "btServerStart";
			this.btServerStart.Size = new System.Drawing.Size(98, 22);
			this.btServerStart.Text = "Start";
			this.btServerStart.Click += new System.EventHandler(this.btServerStart_Click);
			// 
			// btServerStop
			// 
			this.btServerStop.Image = global::EMServer.Properties.Resources._1195445190322000997molumen_red_round_error_warning_icon_svg_med;
			this.btServerStop.Name = "btServerStop";
			this.btServerStop.Size = new System.Drawing.Size(98, 22);
			this.btServerStop.Text = "Stop";
			this.btServerStop.Click += new System.EventHandler(this.btServerStop_Click);
			// 
			// btOption
			// 
			this.btOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSetConnectionString});
			this.btOption.Image = global::EMServer.Properties.Resources.option;
			this.btOption.Name = "btOption";
			this.btOption.Size = new System.Drawing.Size(85, 20);
			this.btOption.Text = "Optionen";
			// 
			// btSetConnectionString
			// 
			this.btSetConnectionString.Image = global::EMServer.Properties.Resources.automatic_link;
			this.btSetConnectionString.Name = "btSetConnectionString";
			this.btSetConnectionString.Size = new System.Drawing.Size(171, 22);
			this.btSetConnectionString.Text = "Verbindung setzen";
			this.btSetConnectionString.Click += new System.EventHandler(this.btSetConnectionString_Click);
			// 
			// pbStatus
			// 
			this.pbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbStatus.Image = global::EMServer.Properties.Resources.ampel_200a;
			this.pbStatus.Location = new System.Drawing.Point(12, 27);
			this.pbStatus.Name = "pbStatus";
			this.pbStatus.Size = new System.Drawing.Size(260, 222);
			this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbStatus.TabIndex = 1;
			this.pbStatus.TabStop = false;
			// 
			// EMServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.pbStatus);
			this.Controls.Add(this.msAction);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.msAction;
			this.Name = "EMServer";
			this.Text = "PMS Server";
			this.msAction.ResumeLayout(false);
			this.msAction.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msAction;
		private System.Windows.Forms.ToolStripMenuItem btServer;
		private System.Windows.Forms.ToolStripMenuItem btOption;
		private System.Windows.Forms.ToolStripMenuItem btServerStart;
		private System.Windows.Forms.ToolStripMenuItem btServerStop;
		private System.Windows.Forms.ToolStripMenuItem btSetConnectionString;
		private System.Windows.Forms.PictureBox pbStatus;

	}
}

