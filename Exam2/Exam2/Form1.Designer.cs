namespace Exam2
{
	partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.txtConfID = new System.Windows.Forms.TextBox();
			this.txtOrg = new System.Windows.Forms.TextBox();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnRegister);
			this.groupBox1.Controls.Add(this.txtConfID);
			this.groupBox1.Controls.Add(this.txtOrg);
			this.groupBox1.Controls.Add(this.txtSurname);
			this.groupBox1.Controls.Add(this.txtFirstName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 606);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(192, 304);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(195, 49);
			this.btnRegister.TabIndex = 12;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// txtConfID
			// 
			this.txtConfID.Location = new System.Drawing.Point(245, 207);
			this.txtConfID.Name = "txtConfID";
			this.txtConfID.Size = new System.Drawing.Size(234, 34);
			this.txtConfID.TabIndex = 9;
			// 
			// txtOrg
			// 
			this.txtOrg.Location = new System.Drawing.Point(245, 156);
			this.txtOrg.Name = "txtOrg";
			this.txtOrg.Size = new System.Drawing.Size(234, 34);
			this.txtOrg.TabIndex = 8;
			// 
			// txtSurname
			// 
			this.txtSurname.Location = new System.Drawing.Point(245, 97);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(234, 34);
			this.txtSurname.TabIndex = 7;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(245, 34);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(234, 34);
			this.txtFirstName.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "Conference ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "Organization";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Surname";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 631);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "ABC College Registration";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txtConfID;
		private System.Windows.Forms.TextBox txtOrg;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

