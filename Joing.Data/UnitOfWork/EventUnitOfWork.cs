using Joing.Data.Context;
using Joing.Infra.Data;
using Joing.Infra.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Data.UnitOfWork
{
    public interface IEventUnitOfWork : IUnitOfWork<EventContext>
    {
    }
    public class EventUnitOfWork : UnitOfWork<EventContext>, IEventUnitOfWork
    {
        public EventUnitOfWork(EventContext context) : base(context)
        {

        }
    }
}
