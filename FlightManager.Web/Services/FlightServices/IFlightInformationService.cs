using FlightManager.Data.Models;

namespace FlightManager.Web.Services.FlightServices
{
    public interface IFlightInformationService
    {
        /// <summary>
        /// Gets the estimated fuel needed in meters for a flight between given coordinates
        /// </summary>
        /// <param name="originLatitude">origin latitude coordinate</param>
        /// <param name="originLongitude">origin longitude coordinate</param>
        /// <param name="destinationLatitude">destination latitude coordinate</param>
        /// <param name="destinationLongitude">destination longitude coordinate</param>
        /// <param name="airplaneType">(optional) the airplane size</param>
        /// <param name="averageEstimatedAltitude">(optional) estimated average altitude</param>
        /// <returns></returns>
        double GetEstimatedFuelNeedInMeters(double originLatitude, double originLongitude,
            double destinationLatitude, double destinationLongitude, 
            AirplaneType airplaneType = AirplaneType.Medium, int averageEstimatedAltitude = 9000);
    }
}
