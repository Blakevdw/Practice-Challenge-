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
			string ConnString = @"Server=civapi.database.windows.net; Database = civapi; User ID = civ_user; Password = Monday1330 ";



			return new SqlConnection(ConnString);
		}
	}
}