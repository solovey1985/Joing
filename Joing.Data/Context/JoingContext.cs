using Joing.Core;
using Joing.Infra.Data;
using System.Data.Entity;

namespace Joing.Data
{
    public class JoingContext<TContext> : DbContext where TContext : DbContext
    {
        static JoingContext() { System.Data.Entity.Database.SetInitializer<TContext>(null); }
        public JoingContext() : base("name=JoingEntity")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = true;
        }

      
    }
}
