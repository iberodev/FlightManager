using FlightManager.Data.Models;

namespace FlightManager.Web.Services.FlightServices
{
    public class FlightInformationService : IFlightInformationService
    {
        public double GetEstimatedFuelNeedInMeters(double distanceInMetres,
            AirplaneType airplaneType = AirplaneType.Medium, int averageEstimatedAltitude = 9000)
        {
            const double reserve = 2000;
            var consumptionPerMeter = GetEstimatedFuelConsumptionPerFlightMeter(airplaneType);
            var altitudeCoeficient = GetAltitudeCoeficient(averageEstimatedAltitude);
            double litres = reserve 
                + consumptionPerMeter * distanceInMetres
                + altitudeCoeficient * distanceInMetres;
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
