using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core
{
    public class Condition : Entity
    {
        public string Name { get; private set; }
        public object Value { get; private set; }
        public ConditionValueEnum ValueType { get; private set; }
        public LogicEnum Logic { get; private set; }

        public Guid EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
