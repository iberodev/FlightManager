using FlightManager.Data.Models;
using FlightManager.Web.Services.DistanceServices;

namespace FlightManager.Web.Services.FlightServices
{
    public class FlightInformationService : IFlightInformationService
    {
        private readonly IDistanceService _distanceService;

        public FlightInformationService(IDistanceService distanceService)
        {
            _distanceService = distanceService;
        }

        public double GetEstimatedFuelNeedInMeters(double originLatitude, double originLongitude, 
            double destinationLatitude, double destinationLongitude, 
            AirplaneType airplaneType = AirplaneType.Medium, int averageEstimatedAltitude = 9000)
        {
            var distanceInMeters = _distanceService.GetDistanceInMeters(originLatitude, originLongitude,
                destinationLatitude, destinationLongitude);
            const double reserve = 2000;
            var consumptionPerMeter = GetEstimatedFuelConsumptionPerFlightMeter(airplaneType);
            var altitudeCoeficient = GetAltitudeCoeficient(averageEstimatedAltitude);
            double litres = reserve 
                + consumptionPerMeter * distanceInMeters 
                + altitudeCoeficient * distanceInMeters;
            return litres;
        }

        private double GetEstimatedFuelConsumptionPerFlightMeter(AirplaneType airplaneType)
        {
            if(AirplaneType.Large == airplaneType)
            {
                return 4.56;
            }
            else if (AirplaneType.Small == airplaneType)
            {
                return 1.34;
            }
            return 3.23;
        }

        private double GetAltitudeCoeficient(int averageEstimatedAltitude)
        {
            if (averageEstimatedAltitude < 4500)
            {
                return 0.987;
            }
            return 1.123;
        }
    }
}
