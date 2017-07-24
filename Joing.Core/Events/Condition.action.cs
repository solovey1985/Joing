using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core.Events
{
    public partial class Condition: Entity
    {
        public Condition Create (Condition condition)
        {
            base.Create(condition);
            return condition;
        }
    }
}
