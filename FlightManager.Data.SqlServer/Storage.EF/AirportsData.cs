using FlightManager.Data.Models;

namespace FlightManager.Data.SqlServer.Storage.EF
{
    public class AirportsData
    {
        public static Airport[] GetAirports()
        {
            var airports = new Airport[]
            {
                new Airport
                {
                    Code = "AGP",
                    Name = "Malaga",
                    Latitude = 36.67166398,
                    Longitude = -4.492831362
                },
                new Airport
                {
                    Code = "MAD",
                    Name = "Madrid - Barajas",
                    Latitude = 40.4839361,
                    Longitude = -3.5679514999999355
                },
                new Airport
                {
                    Code = "BIO",
                    Name = "Bilbao",
                    Latitude = 43.302494,
                    Longitude = -2.911116
                },
                new Airport
                {
                    Code = "CDG",
                    Name = "Paris",
                    Latitude = 49.0096906,
                    Longitude = 2.547924500000022
                }
            };
            return airports;
        }
    }
}
