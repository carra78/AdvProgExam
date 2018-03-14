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
	public partial class Arrears_Report : Form
	{
		List<Account> accRec;
		public Arrears_Report(List<Account> accountRecords)
		{
			InitializeComponent();
			accRec = accountRecords;
		}

		private void btnQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Arrears_Report_Load(object sender, EventArgs e)
		{

			dgvArrears.DataSource = (from account in accRec
									 let totalArrearsInMonths = (account.PaymentPeriod == PayPeriod.Annual ? account.ArrearsCount * 12
													: account.PaymentPeriod == PayPeriod.BiAnnual ? account.ArrearsCount * 6
													: account.PaymentPeriod == PayPeriod.Quarterly ? account.ArrearsCount * 3
													: account.ArrearsCount)
									where account.ArrearsCount > 0
									select new
											 {
												 account.AccountID,
												 account.PaymentPeriod,
												 totalArrearsInMonths
											 }).ToList();
		}
	}
	
}
