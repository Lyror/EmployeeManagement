namespace EMLib
{
	partial class FrmCheckedListBox
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
			this.btClose = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.lvMapping = new System.Windows.Forms.ListView();
			this.lvcDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// btClose
			// 
			this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btClose.Location = new System.Drawing.Point(388, 408);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(75, 23);
			this.btClose.TabIndex = 1;
			this.btClose.Text = "Schließen";
			this.btClose.UseVisualStyleBackColor = true;
			// 
			// btSave
			// 
			this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btSave.Location = new System.Drawing.Point(307, 408);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "Speichern";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// lvMapping
			// 
			this.lvMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvMapping.CheckBoxes = true;
			this.lvMapping.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcDepartment});
			this.lvMapping.Location = new System.Drawing.Point(12, 12);
			this.lvMapping.Name = "lvMapping";
			this.lvMapping.Size = new System.Drawing.Size(451, 390);
			this.lvMapping.TabIndex = 3;
			this.lvMapping.UseCompatibleStateImageBehavior = false;
			this.lvMapping.View = System.Windows.Forms.View.Details;
			this.lvMapping.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvMapping_ItemChecked);
			// 
			// lvcDepartment
			// 
			this.lvcDepartment.Text = "Abteilung";
			this.lvcDepartment.Width = 443;
			// 
			// FrmCheckedListBox
			// 
			this.AcceptButton = this.btSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btClose;
			this.ClientSize = new System.Drawing.Size(475, 443);
			this.Controls.Add(this.lvMapping);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.btClose);
			this.Name = "FrmCheckedListBox";
			this.Text = "Auswahlliste";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.ListView lvMapping;
		private System.Windows.Forms.ColumnHeader lvcDepartment;
	}
}