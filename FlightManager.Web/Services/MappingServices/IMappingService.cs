using FlightManager.Web.Model;

namespace FlightManager.Web.Services.MappingServices
{
    /// <summary>
    /// this service could be replaced by some mapping tool like AutoMapper, but for
    /// demonstrating purposes I'll use my own mapping service
    /// </summary>
    public interface IMappingService
    {
        /// <summary>
        /// Gets an airport web model from an airport entity
        /// </summary>
        /// <param name="airport">the airport entity</param>
        /// <returns>the airport web model</returns>
        Airport GetAirport(Data.Models.Airport airport);

        /// <summary>
        /// Gets a Flight web model from a Flight entity
        /// </summary>
        /// <param name="flight">the flight entity</param>
        /// <param name="distanceMetres">the distance in metres</param>
        /// <param name="estimatedFuelConsumptionLitres">the estimated fuel consumption in litres</param>
        /// <returns>the flight web model</returns>
        Flight GetFlight(Data.Models.Flight flight, double distanceMetres, double estimatedFuelConsumptionLitres);

        /// <summary>
        /// Gets a flight entity from a flightNew web model
        /// </summary>
        /// <param name="flightNew">the flightNew web model</param>
        /// <returns>the flight entity</returns>
        Data.Models.Flight GetFlight(FlightNew flightNew);
    }
}
