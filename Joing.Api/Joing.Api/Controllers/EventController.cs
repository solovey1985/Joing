using Joing.ApiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Joing.Core;
using Joing.DTO;

namespace Joing.Api.Controllers
{
    public class EventController : ApiController
    {
        IEventApiService apiService;
        public EventController() { }
        public EventController(IEventApiService service)
        {
            apiService = service;
        }
        // GET: api/Event
        public IEnumerable<EventDto> Get()
        {
            List<Event> events = apiService.GetAll().ToList();
            return events.Select(e => Mapper.Map<EventDto>(e)).ToList();
        }

        // GET: api/Event/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Event
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Event/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Event/5
        public void Delete(int id)
        {
        }
    }
}
