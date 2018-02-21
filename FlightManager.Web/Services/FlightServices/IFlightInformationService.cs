using FlightManager.Data.Models;

namespace FlightManager.Web.Services.FlightServices
{
    public interface IFlightInformationService
    {
        /// <summary>
        /// Gets the estimated fuel needed in litres for a flight of a given length
        /// </summary>
        /// <param name="distanceInMetres">the distance in metres</param>
        /// <param name="airplaneType">(optional) the airplane size</param>
        /// <param name="averageEstimatedAltitude">(optional) estimated average altitude</param>
        /// <returns></returns>
        double GetEstimatedFuelNeedInMeters(double distanceInMetres,
            AirplaneType airplaneType = AirplaneType.Medium, int averageEstimatedAltitude = 9000);
    }
}
