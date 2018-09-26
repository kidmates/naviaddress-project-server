using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace NaviaddressProjectServer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationsService _locationsService;
        
        
        public LocationsController()
        {
            
        }
        
        // GET
        public async Task<Location> GetLocation(string locationId)
        {
            return 
                await _locationsService.GetLocation(locationId)
                .ConfigureAwait(false);

        }
    }
}