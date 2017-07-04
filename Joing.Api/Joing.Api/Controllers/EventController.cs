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
        public EventDto Get(Guid id)
        {
            return Mapper.Map<EventDto>(apiService.GetById(id));
        }

        // POST: api/Event
        public void Post([FromBody]EventDto evnt)
        {
            apiService.Insert(Mapper.Map<Event>(evnt));
        }

        // PUT: api/Event/5
        public void Put([FromBody]EventDto evnt)
        {
            apiService.Update(Mapper.Map<Event>(evnt));
        }

        // DELETE: api/Event/5
        public void DeleteById(Guid id)
        {
            apiService.DeleteById(id);
        }
    }
}
