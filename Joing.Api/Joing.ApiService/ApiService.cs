using Joing.Data;
using Joing.Infra;
using Joing.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.ApiService
{
    public abstract class ApiService<T> where T:Entity
    {
        IRepository<T> repository;
        public ApiService() { }
        public ApiService(IRepository<T> repo) {
            repository = repo;
        }
        public virtual IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }
    }
}
