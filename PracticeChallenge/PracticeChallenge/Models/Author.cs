using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeChallenge.Models
{
	public class Author
	{
		public int AuthorID { get; set; }
		public string surname { get; set; }
		public string firstname { get; set; }


		public Author(int sAuthorID, string sSurname, string sFirstname)
		{
			AuthorID = sAuthorID;
			surname = sSurname;
			firstname = sFirstname;
		}

		public Author()
		{ }
	}
}