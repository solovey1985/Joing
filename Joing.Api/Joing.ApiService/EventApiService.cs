using Joing.Core;
using Joing.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.ApiService
{
    public interface IEventApiService
    {
         IEnumerable<Event> GetAll();
    }
    public class EventApiService:ApiService<Event>, IEventApiService
    {
        public EventApiService() { }
        public EventApiService(IEventRepository repo):base(repo) {
               
        }
    }
}
