using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BL;
using DTO;

namespace WebApplication4.Controllers
{
    //[RoutePrefix("Login")]
    public class LoginController : ApiController
    {
        // GET: api/Login
       [HttpGet]
       //[Route("login")]
        //public T Login<T>(string userName, string password)
        //{
        //    return BL.LoginBL.Login(userName, password);
        //}

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
