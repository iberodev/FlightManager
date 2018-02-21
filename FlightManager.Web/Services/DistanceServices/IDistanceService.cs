namespace FlightManager.Web.Services.DistanceServices
{
    public interface IDistanceService
    {
        /// <summary>
        /// Retrieves the distance in metres between two coordinates
        /// </summary>
        /// <param name="originLatitude">origin latitude coordinate</param>
        /// <param name="originLongitude">origin longitude coordinate</param>
        /// <param name="destinationLatitude">destination latitude coordinate</param>
        /// <param name="destinationLongitude">destination longitude coordinate</param>
        /// <returns></returns>
        double GetDistanceInMeters(double originLatitude, double originLongitude,
            double destinationLatitude, double destinationLongitude);
    }
}
