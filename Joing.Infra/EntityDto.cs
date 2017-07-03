using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Infra
{
    public class EntityDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime? UpadatedAt { get; set; }
        public Guid? UpdatedAt { get; set; }
    }
}
