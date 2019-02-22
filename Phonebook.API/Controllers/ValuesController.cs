using Phonebook.API.Filtres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Phonebook.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //[OverrideExceptionFilters]
        [ZeroDivideHandlerFilter]

        public IHttpActionResult Get()
        {
             List<string> result
                = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                result.Add((i/i-i).ToString());
            }
            return Ok(result);

            
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
