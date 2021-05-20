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
        [HttpPost]
        [Route("GetEmbededAssisteds")]
        public List<Assisted> EmbededAssisteds([FromBody] Volunteer volunteer)
        {
            return BL.AssistedBL.EmbededAssisteds(volunteer);
        }
        [HttpPost]
        [Route("addAssisted")]
        public bool AddAssisted( [FromBody] Assisted assisted)
        {

            return BL.AssistedBL.AddAssisted(assisted);
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
        [HttpGet]
        [Route("GetLanguage")]
        public List<Language> GetLanguage()
        {
            return BL.AssistedBL.GetLanguage();
        }
        [HttpGet]
        [Route("GetCity")]
        public List<City> GetCity()
        {
            return BL.AssistedBL.GetCity();
        }
        [HttpGet]
        [Route("GetDays")]
        public List<Days> GetDays()
        {
            return BL.VolunteerBL.GetDays();
        }
        [HttpGet]
        [Route("GetShift")]
        public List<Shift> GetShift()
        {
            return BL.VolunteerBL.GetShift();
        }
        [HttpGet]
        [Route("GetAvailabilitys")]
        public List<Availability> GetAvailabilitys()
        {
            return BL.AssistedBL.GetAvailabilitys();
        }
        [HttpGet]
        [Route("GetAvailability")]
        public List<Availability> GetAvailability()
        {
            return BL.VolunteerBL.GetAvailability();
        }
        [HttpGet]
        [Route("getById/{id_assisted}")]
        public Assisted getById(string id_assisted)
        {
            return BL.AssistedBL.getById(id_assisted);
        }
        //[HttpPost("SendMail/{volunteer}")]
        //public IActionResult SendMail(volunteer volunteer, [FromBody]  )
        //{
        //    try
        //    {
        //        var kimat_erua = erua.kimat_erua1 == 1 ? "אירוע" : "כמעט אירוע";
        //        var message = "<div style='direction:rtl;;font-family:Arial;'>" +
        //      "שלום רב, </br> </br>" +
        //       "דיווח: " + kimat_erua + " חריג " +
        //       "</br>" +
        //       "</br>" +
        //        " דווח על " + kimat_erua + " חריג. " + "</br>" + "עליך להכנס למערכת כדי לראות את פרטי האירוע ." + "</br>" +
        //        "מספר האירוע: " + erua.erua_no + "</br>" + "תאריך האירוע:  " + erua.taarich_erua.ToString();
        //        לשלוח מייל
        //        SendMail(volunteer, erua, " דיווח" + kimat_erua + " חריג ", message);
        //        return Ok(true);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
