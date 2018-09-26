using System.Threading.Tasks;
using NaviaddressProjectServer.BusinessLogic.Contract;
using NaviaddressProjectServer.BusinessLogic.Contract.Models;

namespace NaviaddressProjectServer.BusinessLogic.MockServices
{
    public class LocationsServiceMock : ILocationsService
    {
        public Task<Location> GetLocation(string locationId)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> CreateLocation(Location map)
        {
            throw new System.NotImplementedException();
        }

        public Task<LocationRatings> GetLocationRatings(string locationId)
        {
            throw new System.NotImplementedException();
        }
    }
}