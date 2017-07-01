using Joing.Core;
using Joing.Data.Context;
using Joing.Data.UnitOfWork;
using Joing.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Data
{
    public interface IEventRepository : IRepository<Event>
    {

    }
    public class EventRepository : Repository<Event, EventContext>, IEventRepository
    {
        public EventRepository() { }
        public EventRepository(IEventUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
