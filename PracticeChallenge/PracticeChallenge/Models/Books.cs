using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeChallenge.Models
{
	public class Books
	{
		public int ISBN { get; set; }
		public string Title { get; set; }
		public string Borrower { get; set; }
		public string Author { get; set; }

		public Books(int sISBN, string sTitle, string sBorrower, string sAuthor)
		{
			ISBN = sISBN;
			Title = sTitle;
			Borrower = sBorrower;
			Author = sAuthor;

		}

		public Books()
		{
		}
	}
}