using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    public class SirensController : ApiController
    {
        // GET: api/Sirens
        public IEnumerable<Models.Siren> Get()
        {
            var sirenRepository = new APM.WebAPI.Models.SirenRepository();
            return sirenRepository.Retrieve();
                }

        // GET: api/Sirens/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sirens
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sirens/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sirens/5
        public void Delete(int id)
        {
        }
    }
}
