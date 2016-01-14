namespace EMClient
{
	partial class NewEmployee
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
			this.laHeader = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.laFirstName = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.laLastName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btClose
			// 
			this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btClose.Location = new System.Drawing.Point(296, 107);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(75, 23);
			this.btClose.TabIndex = 0;
			this.btClose.Text = "Schließen";
			this.btClose.UseVisualStyleBackColor = true;
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// btSave
			// 
			this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btSave.Enabled = false;
			this.btSave.Location = new System.Drawing.Point(215, 107);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 1;
			this.btSave.Text = "Speichern";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// laHeader
			// 
			this.laHeader.AutoSize = true;
			this.laHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.laHeader.Location = new System.Drawing.Point(113, 9);
			this.laHeader.Name = "laHeader";
			this.laHeader.Size = new System.Drawing.Size(139, 20);
			this.laHeader.TabIndex = 4;
			this.laHeader.Text = "Neuer Mitarbeiter";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(70, 41);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(301, 20);
			this.tbFirstName.TabIndex = 6;
			this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
			// 
			// laFirstName
			// 
			this.laFirstName.AutoSize = true;
			this.laFirstName.Location = new System.Drawing.Point(12, 44);
			this.laFirstName.Name = "laFirstName";
			this.laFirstName.Size = new System.Drawing.Size(52, 13);
			this.laFirstName.TabIndex = 5;
			this.laFirstName.Text = "Vorname:";
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(70, 67);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(301, 20);
			this.tbLastName.TabIndex = 8;
			this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
			// 
			// laLastName
			// 
			this.laLastName.AutoSize = true;
			this.laLastName.Location = new System.Drawing.Point(2, 70);
			this.laLastName.Name = "laLastName";
			this.laLastName.Size = new System.Drawing.Size(62, 13);
			this.laLastName.TabIndex = 7;
			this.laLastName.Text = "Nachname:";
			// 
			// NewEmployee
			// 
			this.AcceptButton = this.btSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btClose;
			this.ClientSize = new System.Drawing.Size(383, 142);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.laLastName);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.laFirstName);
			this.Controls.Add(this.laHeader);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.btClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "NewEmployee";
			this.Text = "Neuer Mitarbeiter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Label laHeader;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label laFirstName;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.Label laLastName;
	}
}