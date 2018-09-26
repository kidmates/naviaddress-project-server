using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NaviaddressProjectServer.BusinessLogic.Contract;
using ApiModels = NaviaddressProjectServer.Api.Models;
using BlModels = NaviaddressProjectServer.BusinessLogic.Contract.Models;

namespace NaviaddressProjectServer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILocationsService _locationsService;

        public LocationsController(IMapper mapper, ILocationsService locationsService)
        {
            _mapper = mapper ?? throw new ArgumentNullException();
            _locationsService = locationsService ?? throw new ArgumentNullException();
        }

        [HttpGet("{locationId}")]
        public async Task<ApiModels.Location> GetLocation(string locationId)
        {
            return
                _mapper.Map<ApiModels.Location>(
                    await _locationsService.GetLocation(locationId)
                        .ConfigureAwait(false));
        }

        [HttpPost]
        public async Task<string> CreateLocation([FromBody] ApiModels.Location location)
        {
            try
            {
                return await _locationsService.CreateLocation(
                        _mapper.Map<BlModels.Location>(location))
                    .ConfigureAwait(false);
            }
            catch (ValidationException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{locationId}/ratings/")]
        public async Task<ApiModels.RatingResponseModel> GetRatings(string locationId)
        {
            return _mapper.Map<ApiModels.RatingResponseModel>(
                await _locationsService.GetLocationRatings(locationId)
                    .ConfigureAwait(false));
        }
    }
}