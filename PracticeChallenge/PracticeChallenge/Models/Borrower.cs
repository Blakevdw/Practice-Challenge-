using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeChallenge.Models
{
	public class Borrower
	{
		public int BorrowerID { get; set; }
		public string Surname { get; set; }
		public string Firstname { get; set; }
		public int DOB { get; set; }

		public Borrower(int sBorrowerID, string sSurname, string sFirstname, int sDOB)
		{
			BorrowerID = sBorrowerID;
			Surname = sSurname;
			Firstname = sFirstname;
			DOB = sDOB;
		}
	}
}