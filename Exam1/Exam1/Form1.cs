using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
	public partial class Form1 : Form
	{
		List<GasMeter> gasMeterRecords = new List<GasMeter>();
		List<Account> accountsList = new List<Account>();

		public Form1()
		{
			InitializeComponent();
			gasMeterRecords.Add(new GasMeter
			{
				MeterID = 100,
				VolumeUsed = 6805,
				HasBeenServiced = true,
				AccountOwnerID = 50001
			});

			gasMeterRecords.Add(new GasMeter
			{
				MeterID = 101,
				VolumeUsed = 13609,
				HasBeenServiced = true,
				AccountOwnerID = 50002
			});

			gasMeterRecords.Add(new GasMeter
			{
				MeterID = 102,
				VolumeUsed = 28115,
				HasBeenServiced = false,
				AccountOwnerID = 50003
			});

			gasMeterRecords.Add(new GasMeter
			{
				MeterID = 103,
				VolumeUsed = 32191,
				HasBeenServiced = false,
				AccountOwnerID = 50004
			});

			gasMeterRecords.Add(new GasMeter
			{
				MeterID = 104,
				VolumeUsed = 19100,
				HasBeenServiced = false,
				AccountOwnerID = 50005
			});
			accountsList.Add(new Account
			{
				AccountID = 50001,
				Eircode = "DV4R102",
				PaymentPeriod = PayPeriod.BiAnnual,
				ArrearsCount = 2
			});

			accountsList.Add(new Account
			{
				AccountID = 50002,
				Eircode = "DV4R103",
				PaymentPeriod = PayPeriod.Annual,
				ArrearsCount = 2
			});

			accountsList.Add(new Account
			{
				AccountID = 50003,
				Eircode = "DV4R104",
				PaymentPeriod = PayPeriod.Monthly,
				ArrearsCount = 1
			});

			accountsList.Add(new Account
			{
				AccountID = 50004,
				Eircode = "DV4S101",
				PaymentPeriod = PayPeriod.Quarterly,
				ArrearsCount = 0
			});

			accountsList.Add(new Account
			{
				AccountID = 50005,
				Eircode = "DV4S102",
				PaymentPeriod = PayPeriod.Annual,
				ArrearsCount = 0
			});

			accountsList.Add(new Account
			{
				AccountID = 50006,
				Eircode = "DV4S103",
				PaymentPeriod = PayPeriod.BiAnnual,
				ArrearsCount = 0
			});


		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvGasMeter.DataSource = (from gm in gasMeterRecords
									  select gm).ToList();

			dgvAccount.DataSource = null;
		}

		private void dgvGasMeter_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				int selectedAccountID = Convert.ToInt32
					(dgvGasMeter.Rows[e.RowIndex].Cells[3].Value);


				dgvAccount.DataSource = (from accounts in accountsList
										  where accounts.AccountID == selectedAccountID
										  select accounts).ToList();
			}
		}

		private void rdoMeterID_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoMeterID.Checked)
			{
				dgvGasMeter.DataSource = (from gm in gasMeterRecords
										  orderby gm.MeterID
										  select gm).ToList();

				dgvAccount.DataSource = null;
			}

		}

		private void rdoVolume_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoVolume.Checked)
			{
				dgvGasMeter.DataSource = (from gm in gasMeterRecords
										  orderby gm.VolumeUsed
										  select gm).ToList();

				dgvAccount.DataSource = null;
			}
		}

		private void btnArrears_Click(object sender, EventArgs e)
		{
			Arrears_Report ar = new Arrears_Report(accountsList);
			ar.Show();
			
		}

		private void btnSummary_Click(object sender, EventArgs e)
		{
			int totalVolGasUsed = (from gasMeter in gasMeterRecords
									 select gasMeter.VolumeUsed).Sum();

			int totalAccountsInArrears = (from account in accountsList
										  where account.ArrearsCount > 0
										  select account.ArrearsCount).Count();

			string msg = $"Total volume of gas used = {totalVolGasUsed} & total number of accounts in arrears is {totalAccountsInArrears}";
			MessageBox.Show(msg);
		}
	}
}
