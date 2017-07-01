using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Joing.Infra.Data
{
    public interface IContext<T> : IDisposable where T : class
    {
        IDbSet<T> Set<T>() where T : class;
        int SaveChanges();
        void SetModified(T entity);
    }
}
