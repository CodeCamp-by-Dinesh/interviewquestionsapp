using ProgramminAPIProj.ModelsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProgramminAPIProj.Controllers
{
    public class FetchDataController : ApiController
    {
        private IntVM[] users = new IntVM[]
    {
        new IntVM { id = 1, name = "Haleemah Redfern", email = "email1@mail.com", phone = "01111111", role = 1},
        new IntVM { id = 2, name = "Aya Bostock", email = "email2@mail.com", phone = "01111111", role = 1},
        new IntVM { id = 3, name = "Sohail Perez", email = "email3@mail.com", phone = "01111111", role = 1},
        new IntVM { id = 4, name = "Merryn Peck", email = "email4@mail.com", phone = "01111111", role = 2},
        new IntVM { id = 5, name = "Cairon Reynolds", email = "email5@mail.com", phone = "01111111", role = 3}
    };

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}