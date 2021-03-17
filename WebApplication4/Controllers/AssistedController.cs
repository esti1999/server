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
    [RoutePrefix("api/assisted")]
    public class AssistedController : ApiController
    {
        // GET: api/Assisted
        [Route("get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Assisted/5
        [Route("get/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Assisted
        [HttpPost]
        [Route("addAssisted")]
        public bool AddAssisted( Assisted assisted)
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
        [HttpGet]
        [Route("GetPersonalStatus")]
        public List<PersonalStatus> GetPersonalStatuses()
        {
            return BL.AssistedBL.GetPersonalStatuses();
        }
        [HttpGet]
        [Route("GetGender")]
        public List<Gender> GetGender()
        {
            return BL.AssistedBL.GetGender();
        }
    }
}
