using FlightManager.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Web.Services.MappingServices
{
    /// <summary>
    /// this service could be replaced by some mapping tool like AutoMapper, but for
    /// demonstrating purposes I'll use my own mapping service
    /// </summary>
    public interface IMappingService
    {
        Airport GetAirport(Data.Models.Airport airport);

        Flight GetFlight(Data.Models.Flight flight);

        Data.Models.Flight GetFlight(Flight flight);
    }
}
