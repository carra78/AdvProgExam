namespace Exam1
{
	partial class Arrears_Report
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
			this.dgvArrears = new System.Windows.Forms.DataGridView();
			this.btnQuit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvArrears)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvArrears
			// 
			this.dgvArrears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvArrears.Location = new System.Drawing.Point(20, 74);
			this.dgvArrears.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvArrears.Name = "dgvArrears";
			this.dgvArrears.RowTemplate.Height = 28;
			this.dgvArrears.Size = new System.Drawing.Size(596, 234);
			this.dgvArrears.TabIndex = 0;
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(220, 348);
			this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(181, 85);
			this.btnQuit.TabIndex = 1;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvArrears);
			this.groupBox1.Controls.Add(this.btnQuit);
			this.groupBox1.Location = new System.Drawing.Point(16, 18);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(637, 491);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// Arrears_Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 525);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Arrears_Report";
			this.Text = "Arrears_Report";
			this.Load += new System.EventHandler(this.Arrears_Report_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvArrears)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvArrears;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}