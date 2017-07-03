using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core
{
    public partial class Location : ValueObject<Location>
    {
        public string Address { get; private set; }
        public double? Longitude { get; private set; }
        public double? Latitude { get; private set; }
        public string MapUrl { get; private set; }
        public LocationType Type { get; private set; }
               
    }
}
