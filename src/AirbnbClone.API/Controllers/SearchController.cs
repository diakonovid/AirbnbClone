using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AirbnbClone.API.Models.Request;
using AirbnbClone.API.Models.Response;
using AirbnbClone.Domain.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace AirbnbClone.API.Controllers
{
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IPlaceRepository _placeRepository;
        
        public SearchController(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }
        
        [HttpGet("api/v1/places/search")]
        public async Task<IActionResult> Search([FromQuery] PlaceRequest request, CancellationToken token)
        {
            var places = await _placeRepository.GetPlacesAsync(request.Limit, request.Page,
                request.Sort, request.Direction, token);
            
            return Ok(places.Adapt<List<PlaceResponse>>());
        }
    }
}