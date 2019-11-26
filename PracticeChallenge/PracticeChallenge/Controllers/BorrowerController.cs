using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using PracticeChallenge.Models;

namespace PracticeChallenge.Controllers
{
	public class BorrowerController : ApiController
	{
		// GET ALL FROM BORROWERS//
		public IEnumerable<Borrower> Get()
		{
			SqlConnection conn = DBconnection.GetConnection();
			SqlCommand cmd;
			SqlDataReader rdr;
			String query;
			List<Borrower> output = new List<Borrower>();

			try
			{
				conn.Open();


				query = "select * from Borrower";
				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output.Add(new Borrower(Convert.ToInt32(rdr.GetValue(0)), Convert.ToString(rdr.GetValue(1)), Convert.ToString(rdr.GetValue(2)), Convert.ToInt32(rdr.GetValue(3))));
				}

			}
			catch (Exception e)
			{
				throw;
			}
			finally
			{
				if (conn.State == System.Data.ConnectionState.Open)
				{
					conn.Close();
				}
			}

			return output;

		}


		// POST: api/Borrower
		public void Post([FromBody]string value)
		{
		}

		// PUT: api/Borrower/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE: api/Borrower/5
		public void Delete(int id)
		{
		}
	}
}
