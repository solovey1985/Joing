using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joing.Infra
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
    public interface IAggregateRoot : IEntity
    {

    }
    public abstract class Entity : IEntity
    {
        public Entity()
        {

        }
  
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime? UpadatedAt { get; set; }
        public Guid? UpdatedAt { get; set; }
        public DbStateEnum DbState { get; set; }

        
    }

    public enum DbStateEnum
    {
        Unchanged,
        Added,
        Modified,
        Deleted,
    }
}
