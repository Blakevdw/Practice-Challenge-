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
			string ConnString = @"Server=tcp:civapi.database.windows.net
				,1433; InitialCatalog =civapi; User ID=civ_user; Password = Monday1330;";
			return new SqlConnection(ConnString);
		}
	}
}