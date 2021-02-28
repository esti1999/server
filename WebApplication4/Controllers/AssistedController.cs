using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;

namespace WebApplication4.Controllers
{
    public class AssistedController : ApiController
    {
        // GET: api/Assisted
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Assisted/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Assisted
        [HttpPost]
        public bool AddAssisted(Personal_Information_AssistedEntity assisted)
        {
            return BL.AssistedBL.AddAssisted(assisted);
        }

        // PUT: api/Assisted/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Assisted/5
        public void Delete(int id)
        {
        }
    }
}
