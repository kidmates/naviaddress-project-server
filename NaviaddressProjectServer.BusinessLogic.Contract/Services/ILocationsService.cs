using System;
using System.Threading.Tasks;
using NaviaddressProjectServer.BusinessLogic.Contract.Models;

namespace NaviaddressProjectServer.BusinessLogic.Contract
{
    public interface ILocationsService
    {
        Task<Location> GetLocation(string locationId);
        Task<string> CreateLocation(Location map);
        Task<LocationRatings> GetLocationRatings(string locationId);
    }
}