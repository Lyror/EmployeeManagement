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
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.pEmployee = new System.Windows.Forms.Panel();
			this.laFirstName = new System.Windows.Forms.Label();
			this.laLastName = new System.Windows.Forms.Label();
			this.laAdress = new System.Windows.Forms.Label();
			this.laBirthday = new System.Windows.Forms.Label();
			this.laEmail = new System.Windows.Forms.Label();
			this.laPhone = new System.Windows.Forms.Label();
			this.laHourPerDay = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tlpMain.SuspendLayout();
			this.pEmployee.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 3;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpMain.Controls.Add(this.pEmployee, 0, 0);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 1;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpMain.Size = new System.Drawing.Size(529, 289);
			this.tlpMain.TabIndex = 0;
			// 
			// pEmployee
			// 
			this.pEmployee.Controls.Add(this.laHourPerDay);
			this.pEmployee.Controls.Add(this.label8);
			this.pEmployee.Controls.Add(this.laBirthday);
			this.pEmployee.Controls.Add(this.laEmail);
			this.pEmployee.Controls.Add(this.laPhone);
			this.pEmployee.Controls.Add(this.laAdress);
			this.pEmployee.Controls.Add(this.laLastName);
			this.pEmployee.Controls.Add(this.laFirstName);
			this.pEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pEmployee.Location = new System.Drawing.Point(3, 3);
			this.pEmployee.Name = "pEmployee";
			this.pEmployee.Size = new System.Drawing.Size(248, 283);
			this.pEmployee.TabIndex = 0;
			// 
			// laFirstName
			// 
			this.laFirstName.AutoSize = true;
			this.laFirstName.Location = new System.Drawing.Point(29, 27);
			this.laFirstName.Name = "laFirstName";
			this.laFirstName.Size = new System.Drawing.Size(52, 13);
			this.laFirstName.TabIndex = 0;
			this.laFirstName.Text = "Vorname:";
			// 
			// laLastName
			// 
			this.laLastName.AutoSize = true;
			this.laLastName.Location = new System.Drawing.Point(29, 46);
			this.laLastName.Name = "laLastName";
			this.laLastName.Size = new System.Drawing.Size(62, 13);
			this.laLastName.TabIndex = 1;
			this.laLastName.Text = "Nachname:";
			// 
			// laAdress
			// 
			this.laAdress.AutoSize = true;
			this.laAdress.Location = new System.Drawing.Point(29, 72);
			this.laAdress.Name = "laAdress";
			this.laAdress.Size = new System.Drawing.Size(48, 13);
			this.laAdress.TabIndex = 2;
			this.laAdress.Text = "Adresse:";
			// 
			// laBirthday
			// 
			this.laBirthday.AutoSize = true;
			this.laBirthday.Location = new System.Drawing.Point(29, 95);
			this.laBirthday.Name = "laBirthday";
			this.laBirthday.Size = new System.Drawing.Size(59, 13);
			this.laBirthday.TabIndex = 5;
			this.laBirthday.Text = "Geburstag:";
			// 
			// laEmail
			// 
			this.laEmail.AutoSize = true;
			this.laEmail.Location = new System.Drawing.Point(29, 120);
			this.laEmail.Name = "laEmail";
			this.laEmail.Size = new System.Drawing.Size(39, 13);
			this.laEmail.TabIndex = 4;
			this.laEmail.Text = "E-Mail:";
			// 
			// laPhone
			// 
			this.laPhone.AutoSize = true;
			this.laPhone.Location = new System.Drawing.Point(29, 142);
			this.laPhone.Name = "laPhone";
			this.laPhone.Size = new System.Drawing.Size(46, 13);
			this.laPhone.TabIndex = 3;
			this.laPhone.Text = "Telefon:";
			// 
			// laHourPerDay
			// 
			this.laHourPerDay.AutoSize = true;
			this.laHourPerDay.Location = new System.Drawing.Point(29, 166);
			this.laHourPerDay.Name = "laHourPerDay";
			this.laHourPerDay.Size = new System.Drawing.Size(151, 13);
			this.laHourPerDay.TabIndex = 8;
			this.laHourPerDay.Text = "Anzahl Arbeitstage pro Woche";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "label8";
			// 
			// NewEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 289);
			this.Controls.Add(this.tlpMain);
			this.Name = "NewEmployee";
			this.Text = "NewEmployee";
			this.tlpMain.ResumeLayout(false);
			this.pEmployee.ResumeLayout(false);
			this.pEmployee.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.Panel pEmployee;
		private System.Windows.Forms.Label laHourPerDay;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label laBirthday;
		private System.Windows.Forms.Label laEmail;
		private System.Windows.Forms.Label laPhone;
		private System.Windows.Forms.Label laAdress;
		private System.Windows.Forms.Label laLastName;
		private System.Windows.Forms.Label laFirstName;
	}
}