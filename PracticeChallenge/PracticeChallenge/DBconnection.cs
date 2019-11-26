using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PracticeChallenge.Models;

namespace PracticeChallenge
{
	public static class DBconnection
	{
		public static SqlConnection GetConnection()
		{
			string ConnString = @"Server=tcp:civapi.database.windows.net (Links to an external site.),1433;Initial
           Catalog = civapi; User ID = civ_user; Password = Monday1330";


			return new SqlConnection(ConnString);
		}
	}
}