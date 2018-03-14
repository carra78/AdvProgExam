namespace Exam1
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
			this.btnSummary = new System.Windows.Forms.Button();
			this.btnArrears = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			this.dgvGasMeter = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdoMeterID = new System.Windows.Forms.RadioButton();
			this.rdoVolume = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGasMeter)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.btnSummary);
			this.groupBox1.Controls.Add(this.btnArrears);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.dgvAccount);
			this.groupBox1.Controls.Add(this.dgvGasMeter);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(736, 618);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnSummary
			// 
			this.btnSummary.Location = new System.Drawing.Point(554, 510);
			this.btnSummary.Name = "btnSummary";
			this.btnSummary.Size = new System.Drawing.Size(166, 62);
			this.btnSummary.TabIndex = 5;
			this.btnSummary.Text = "Summary";
			this.btnSummary.UseVisualStyleBackColor = true;
			this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
			// 
			// btnArrears
			// 
			this.btnArrears.Location = new System.Drawing.Point(361, 510);
			this.btnArrears.Name = "btnArrears";
			this.btnArrears.Size = new System.Drawing.Size(166, 62);
			this.btnArrears.TabIndex = 4;
			this.btnArrears.Text = "Arrears";
			this.btnArrears.UseVisualStyleBackColor = true;
			this.btnArrears.Click += new System.EventHandler(this.btnArrears_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 305);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 27);
			this.label2.TabIndex = 3;
			this.label2.Text = "Account Information";
			// 
			// dgvAccount
			// 
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.Location = new System.Drawing.Point(21, 339);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.RowTemplate.Height = 28;
			this.dgvAccount.Size = new System.Drawing.Size(699, 150);
			this.dgvAccount.TabIndex = 2;
			// 
			// dgvGasMeter
			// 
			this.dgvGasMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGasMeter.Location = new System.Drawing.Point(21, 61);
			this.dgvGasMeter.Name = "dgvGasMeter";
			this.dgvGasMeter.RowTemplate.Height = 28;
			this.dgvGasMeter.Size = new System.Drawing.Size(699, 223);
			this.dgvGasMeter.TabIndex = 1;
			this.dgvGasMeter.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGasMeter_RowEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gas Meter Records";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdoVolume);
			this.groupBox2.Controls.Add(this.rdoMeterID);
			this.groupBox2.Location = new System.Drawing.Point(21, 496);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(268, 100);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sort Gas Meter Records";
			// 
			// rdoMeterID
			// 
			this.rdoMeterID.AutoSize = true;
			this.rdoMeterID.Location = new System.Drawing.Point(19, 34);
			this.rdoMeterID.Name = "rdoMeterID";
			this.rdoMeterID.Size = new System.Drawing.Size(140, 31);
			this.rdoMeterID.TabIndex = 0;
			this.rdoMeterID.TabStop = true;
			this.rdoMeterID.Text = "By MeterID";
			this.rdoMeterID.UseVisualStyleBackColor = true;
			this.rdoMeterID.CheckedChanged += new System.EventHandler(this.rdoMeterID_CheckedChanged);
			// 
			// rdoVolume
			// 
			this.rdoVolume.AutoSize = true;
			this.rdoVolume.Location = new System.Drawing.Point(19, 68);
			this.rdoVolume.Name = "rdoVolume";
			this.rdoVolume.Size = new System.Drawing.Size(133, 31);
			this.rdoVolume.TabIndex = 1;
			this.rdoVolume.TabStop = true;
			this.rdoVolume.Text = "By Volume";
			this.rdoVolume.UseVisualStyleBackColor = true;
			this.rdoVolume.CheckedChanged += new System.EventHandler(this.rdoVolume_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 643);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGasMeter)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSummary;
		private System.Windows.Forms.Button btnArrears;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvAccount;
		private System.Windows.Forms.DataGridView dgvGasMeter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rdoVolume;
		private System.Windows.Forms.RadioButton rdoMeterID;
	}
}

