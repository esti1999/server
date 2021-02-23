﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;

namespace WebApplication4.Controllers
{
    public class VolunteeringDomainController : ApiController
    {
        // GET: api/VolunteeringDomain
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/VolunteeringDomain/5
        [HttpGet]
        public List<DomainEntity> GetDomainsList()
        {
            return BL.DomainBL.GetDomainsList();
        }
        public List<VolunteeringEntity> GetVolunteeringByDomain(int code_domain)
        {
            return BL.DomainBL.GetVolunteeringByDomain(code_domain);
        }
        // POST: api/VolunteeringDomain
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/VolunteeringDomain/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/VolunteeringDomain/5
        public void Delete(int id)
        {
        }
    }
}