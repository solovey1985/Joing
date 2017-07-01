using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joing.Infra;

namespace Joing.Infra.Data
{
    public class StateHelper
    {
        public static EntityState ConvertState(DbStateEnum state)
        {
            switch (state)
            {
                case DbStateEnum.Added: return EntityState.Added;
                case DbStateEnum.Modified: return EntityState.Modified;
                case DbStateEnum.Deleted: return EntityState.Deleted;
                case DbStateEnum.Unchanged: return EntityState.Unchanged;
                default: return EntityState.Unchanged;
            }
        }
    }
}
