using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core { 
    public partial class Event:Entity
    {
        public static Event Create(string title, string description, string address, DateTime startedAt, DateTime endedAt)
        {
            Event newEvent = new Event()
            {
                Id = Guid.NewGuid(),
                Title = title,
                Description = description,
                Place = Location.Create(address),
                CreatedAt = DateTime.Now,
                Privacy = PrivacyType.Public,
                StartedAt = startedAt,
                EndAt = endedAt
            };
             return newEvent;
        }

        public Event Create(Event newEvent)
        {
            base.Create(newEvent);
            return newEvent;
        }
    }
}
