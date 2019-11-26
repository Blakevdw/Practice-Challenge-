using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeChallenge.Controllers
{
    public class BorrowerController : ApiController
    {
        // GET: api/Borrower
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Borrower/5
        public string Get(int id)
        {
            return "value";
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
