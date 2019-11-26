using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticeChallenge.Models;

namespace PracticeChallenge
{
	public static class DBconnection
	{
		public static SqlConnection GetConnection()
		{
			string ConnString = @"Server=swin.database.windows.net;
								Database=DAD;User Id = DAD; Password=R@ndom!1";
			return new SqlConnection(ConnString);
		}
	}
}