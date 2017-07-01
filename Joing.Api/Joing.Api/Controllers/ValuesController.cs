using Joing.Core;
using Joing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Joing.Api.Controllers
{ 
    public class ValuesController : ApiController
    {
        private IEventRepository repository;
        public ValuesController() {
        }
        public ValuesController(IEventRepository repo)
        {
            repository = repo;
        }
        // GET api/values
        public IEnumerable<Event> Get()
        {
            return repository.GetAll().ToList();
        }

        // GET api/values/5
        public List<Event> Get(int id)
        {
            return repository.GetAll().ToList();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            Event e = Event.Create("First Event", "Description", "At my home", DateTime.Now.AddHours(6), DateTime.Now.AddHours(4));
            repository.Insert(e);
                        
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
