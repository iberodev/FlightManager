using GeoCoordinatePortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Web.Services.DistanceServices
{
    public class DistanceService : IDistanceService
    {
        public double GetDistanceInMeters(double originLatitude, double originLongitude, 
            double destinationLatitude, double destinationLongitude)
        {
            var originCoordinates = new GeoCoordinate(originLatitude, originLongitude);
            var destinationCoordinates = new GeoCoordinate(destinationLatitude, destinationLongitude);
            var distanceInMetres = originCoordinates.GetDistanceTo(destinationCoordinates);
            return distanceInMetres;
        }
    }
}
