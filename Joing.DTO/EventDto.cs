using Joing.Core;
using Joing.Dto;
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
        public LocationDto Place { get; set; }
    }
}
