using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Infra.Guard
{
    public class Guard
    {
        public static void IsNotNull(Entity entity)
        {
            if (entity == null) throw new NullReferenceException("Entity");
        }
    }
}
