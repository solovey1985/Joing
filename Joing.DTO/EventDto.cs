using Joing.Core;
using Joing.Infra;
using System;
using System.Collections.Generic;

namespace Joing.DTO
{
    public class EventDto: EntityDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public EventType Type { get; set; }
        public PrivacyType Privacy { get; set; }
        public List<ConditionDto> Conditions { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime? EndAt { get; set; }
        public DateTime? CanceledAt { get; set; }
        public DateTime? InterruptedAt { get; set; }
        public string Address { get; private set; }
        public double? Longitude { get; private set; }
        public double? Latitude { get; private set; }
        public string MapUrl { get; private set; }
        public LocationType LocationType { get; set; }
    }
}
