using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core
{
    public partial class Event : Entity
    {
        public String Title { get; private set; }
        public String Description { get; private set; }
        public Location Place { get; private set; }
        public EventType Type { get; private set; }
        public PrivacyType Privacy { get; private set; }
        public ICollection<Condition> Conditions { get; private set; }
        public DateTime StartedAt { get; private set; }
        public DateTime? EndAt { get; private set; }
        public DateTime? CanceledAt { get; private set; }
        public DateTime? InterruptedAt { get; private set; }

    }

}
