using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
	public enum PayPeriod
	{
		Annual = 1,
		BiAnnual,
		Quarterly,
		Monthly
	}


	public class Account
	{
		public int AccountID { get; set; }
		public string Eircode { get; set; }
		public PayPeriod PaymentPeriod { get; set; }
		public int ArrearsCount { get; set; }
	}
}
