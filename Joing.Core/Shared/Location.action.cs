using Joing.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joing.Core
{
    public partial class Location: Entity
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
        public Location Create(string address, LocationType locationType, double lattitude, double longitude, string mapUrl)
        {
            return new Location() {
                Id = Guid.NewGuid(),
                Address = address,
                Type = locationType,
                Latitude = lattitude,
                Longitude = longitude,
                MapUrl = mapUrl
            };
        }

        public static Location Create(string address)
        {
            return new Location()
            {
                Id = Guid.NewGuid(),
                Address = address,
                Type = LocationType.Text,
                Latitude = null,
                Longitude = null,
                MapUrl = null
            };
        }
    }
}

