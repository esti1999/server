using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace WebApplication4.Controllers
{
    public class VolunteerController : ApiController
    {
        // GET: api/Volunteer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        // POST: api/Volunteer
        [HttpPost]
        public bool AddVolunteer(Personal_Information_volunteerEntity valunteer)
        {
            return BL.VolunteerBL.AddVolunteer(valunteer);
        }

        // PUT: api/Volunteer/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Volunteer/5
        public void Delete(int id)
        {
        }
    }
}
