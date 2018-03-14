using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

 namespace Exam3UnitTest
{
	public class Baby
	{
		public int BabyID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Address { get; set; }
		public string ContactNumber { get; set; }
		public string Parent1 { get; set; }
		public string Parent2 { get; set; }


		public Baby(int id, string fname, string lname, DateTime start, DateTime end,
			string addr, string contactNumber, string parent1, string parent2 = null)
		{
			if (end > DateTime.Now)
			{
				throw new ArgumentOutOfRangeException("End date cannot be earlier than today");
			}
			if (end < start)
			{
				throw new ArgumentOutOfRangeException("End date cannot be before start date");
			}
			if (!Regex.IsMatch(contactNumber, "^(0)|(00)|(+)") || contactNumber.Length > 16)
			{
				throw new ArgumentException("Invalid contact number - try again");
			}
			BabyID = id;
			FirstName = fname;
			LastName = lname;
			StartDate = start;
			EndDate = end;
			Address = addr;
			ContactNumber = contactNumber;
			Parent1 = parent1;
			Parent2 = parent2;

		}

		

		}
	public class BabyList
	{
		public List<Baby> Babies { get; }

		public BabyList()
		{
			Babies = new List<Baby>();

		}

		public void AddBaby(Baby baby)
		{
			if (baby == null)
			{
				throw new ArgumentNullException();
			}
			Babies.Add(baby);
		}

		public void AddBabies(Baby[] babies)
		{
			foreach (Baby baby in babies)
			{
				if (baby == null)
				{
					throw new ArgumentNullException();
				}
				Babies.Add(baby);

			}
		}

		public void RemoveBaby(Baby baby)
		{
			if (Babies.Contains(baby))
			{
				Babies.Remove(baby);
			}
		}

	}
}
