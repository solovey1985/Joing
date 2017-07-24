using Joing.Core;
using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Dto
{
    public partial class LocationDto : EntityDto
    {
        public string Address { get; private set; }
        public double? Longitude { get; private set; }
        public double? Latitude { get; private set; }
        public string MapUrl { get; private set; }
        public LocationType Type { get; private set; }
               
    }
}
