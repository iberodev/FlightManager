using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Web.Services.DistanceServices
{
    public interface IDistanceService
    {
        double GetDistanceInMeters(double originLatitude, double originLongitude,
            double destinationLatitude, double destinationLongitude);
    }
}
