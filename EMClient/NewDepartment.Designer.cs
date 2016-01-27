namespace EMClient
{
	partial class NewDepartment
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
			this.dgDepartments = new System.Windows.Forms.DataGridView();
			this.dgcLocations = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btClose = new System.Windows.Forms.Button();
			this.laInfo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).BeginInit();
			this.SuspendLayout();
			// 
			// dgDepartments
			// 
			this.dgDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcLocations});
			this.dgDepartments.Location = new System.Drawing.Point(12, 12);
			this.dgDepartments.Name = "dgDepartments";
			this.dgDepartments.Size = new System.Drawing.Size(308, 236);
			this.dgDepartments.TabIndex = 0;
			this.dgDepartments.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDepartmentss_CellEndEdit);
			this.dgDepartments.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDepartmentss_RowValidating);
			this.dgDepartments.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgDepartmentss_UserAddedRow);
			this.dgDepartments.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgDepartmentss_UserDeletedRow);
			// 
			// dgcLocations
			// 
			this.dgcLocations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgcLocations.HeaderText = "Abteilungen";
			this.dgcLocations.Name = "dgcLocations";
			// 
			// btClose
			// 
			this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btClose.Location = new System.Drawing.Point(245, 254);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(75, 23);
			this.btClose.TabIndex = 1;
			this.btClose.Text = "Schließen";
			this.btClose.UseVisualStyleBackColor = true;
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// laInfo
			// 
			this.laInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.laInfo.AutoSize = true;
			this.laInfo.Location = new System.Drawing.Point(48, 254);
			this.laInfo.Name = "laInfo";
			this.laInfo.Size = new System.Drawing.Size(123, 26);
			this.laInfo.TabIndex = 2;
			this.laInfo.Text = "Alle Änderungen werden\r\nautomatisch gespeichert";
			// 
			// NewDepartment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 289);
			this.Controls.Add(this.laInfo);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.dgDepartments);
			this.Name = "NewDepartment";
			this.Text = "Abteilungen";
			this.Load += new System.EventHandler(this.NewDepartment_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgDepartments)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgDepartments;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDepartments;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Label laInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDepartment;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcLocations;
	}
}