using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core
{
    public partial class Location
    {

        public static Location Create(string address, double longitude, double latitude, string mapUrl, LocationType type )
        {
            return new Location()
            {
                Id = Guid.NewGuid(),
                MapUrl = mapUrl,
                Latitude = latitude,
                Longitude = longitude,
                Address = address,
                Type = type
            };
        }
        public static Location Create(string address)
        {
            return new Location() {
                Id = Guid.NewGuid(),
                Address = address,
                Type =LocationType.Text
            };
        }
    }
}
