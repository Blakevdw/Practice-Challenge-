using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using PracticeChallenge.Models;

namespace PracticeChallenge.Controllers
{
	public class BooksController : ApiController
	{
		//GET ISBN AND TITLE//
		public Books Get(int ISBN, string Title)
		{
			SqlConnection conn = DBconnection.GetConnection();

			string query = "select * from Books where ISBN and Title = " + ISBN + Title;
			Books output = new Books();
			SqlCommand cmd;
			SqlDataReader rdr;

			try
			{
				conn.Open();

				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output = (new Books(Convert.ToInt32(rdr.GetValue(0)), Convert.ToString(rdr.GetValue(1)), Convert.ToString(rdr.GetValue(2)), Convert.ToString(rdr.GetValue(3))));
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

		// GET ALL ISBN, TITLE, BORROWER//
		public Books Get(int ISBN, string Title, string Borrower)
		{
			SqlConnection conn = DBconnection.GetConnection();

			string query = "select * from Books where ISBN and Title and Borrower = " + ISBN + Title + Borrower;
			Books output = new Books();
			SqlCommand cmd;
			SqlDataReader rdr;

			try
			{
				conn.Open();

				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output = (new Books(Convert.ToInt32(rdr.GetValue(0)), Convert.ToString(rdr.GetValue(1)), Convert.ToString(rdr.GetValue(2)), Convert.ToString(rdr.GetValue(3))));
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

		// GET ALL BOOKS THAT ARE NOT BORROWED (ISBN, TITLE) //
		public Books Get(int ISBN)
		{
			SqlConnection conn = DBconnection.GetConnection();

			string query = "select * from Books where ISBN and Title and Borrower = " + ISBN + Title;
			Books output = new Books();
			SqlCommand cmd;
			SqlDataReader rdr;

			try
			{
				conn.Open();

				cmd = new SqlCommand(query, conn);
				rdr = cmd.ExecuteReader();

				while (rdr.Read())
				{

					output = (new Books(Convert.ToInt32(rdr.GetValue(0)), Convert.ToString(rdr.GetValue(1)), Convert.ToString(rdr.GetValue(2)), Convert.ToString(rdr.GetValue(3))));
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


		// POST: api/Books
		public void Post([FromBody]string value)
		{
		}

		// PUT: api/Books/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE: api/Books/5
		public void Delete(int id)
		{
		}
	}
}
