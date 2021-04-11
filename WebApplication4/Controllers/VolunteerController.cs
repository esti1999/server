using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;

namespace WebApplication4.Controllers
{
    [RoutePrefix("api/volunteer")]
    public class VolunteerController : ApiController
    {
        // GET: api/Volunteer
        [Route("get")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Volunteer/5
        [Route("get/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Volunteer
        [HttpPost]
        [Route("addVolunteer")]
        public bool AddVolunteer(Volunteer valunteer)
        {
            return BL.VolunteerBL.AddVolunteer(valunteer);
        }

        //[HttpGet]
        //[Route("GetLanguages")]
        //public List<Language> GetLanguages()
        //{
        //    return BL.VolunteerBL.GetLanguages();
        //}

        // PUT: api/Volunteer/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Volunteer/5
        public void Delete(int id)
        {
        }
        [HttpGet]
        [Route("GetPersonalStatus")]
        public List<PersonalStatus> GetPersonalStatuses()
        {
            return BL.VolunteerBL.GetPersonalStatuses();
        }
        [HttpGet]
        [Route("GetGender")]
        public List<Gender> GetGender()
        {
            return BL.VolunteerBL.GetGender();
        }
    }
}
