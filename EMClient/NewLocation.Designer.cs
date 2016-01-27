namespace EMClient
{
	partial class NewLocation
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
			this.laInfo = new System.Windows.Forms.Label();
			this.btClose = new System.Windows.Forms.Button();
			this.dgLocations = new System.Windows.Forms.DataGridView();
			this.dgcLocations = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgLocations)).BeginInit();
			this.SuspendLayout();
			// 
			// laInfo
			// 
			this.laInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.laInfo.AutoSize = true;
			this.laInfo.Location = new System.Drawing.Point(48, 252);
			this.laInfo.Name = "laInfo";
			this.laInfo.Size = new System.Drawing.Size(123, 26);
			this.laInfo.TabIndex = 5;
			this.laInfo.Text = "Alle Änderungen werden\r\nautomatisch gespeichert";
			// 
			// btClose
			// 
			this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btClose.Location = new System.Drawing.Point(245, 252);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(75, 23);
			this.btClose.TabIndex = 4;
			this.btClose.Text = "Schließen";
			this.btClose.UseVisualStyleBackColor = true;
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// dgLocations
			// 
			this.dgLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcLocations});
			this.dgLocations.Location = new System.Drawing.Point(12, 10);
			this.dgLocations.Name = "dgLocations";
			this.dgLocations.Size = new System.Drawing.Size(308, 236);
			this.dgLocations.TabIndex = 3;
			this.dgLocations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLocations_CellEndEdit);
			this.dgLocations.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgLocations_RowValidating);
			this.dgLocations.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgLocations_UserAddedRow);
			this.dgLocations.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgLocations_UserDeletedRow);
			// 
			// dgcLocations
			// 
			this.dgcLocations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcLocations.HeaderText = "Standorte";
			this.dgcLocations.Name = "dgcLocations";
			// 
			// NewLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 289);
			this.Controls.Add(this.laInfo);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.dgLocations);
			this.Name = "NewLocation";
			this.Text = "Standorte";
			this.Load += new System.EventHandler(this.NewLocation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgLocations)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label laInfo;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.DataGridView dgLocations;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcLocations;

	}
}