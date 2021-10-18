using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AirbnbClone.Domain.Models;

namespace AirbnbClone.Domain.Interfaces
{
    public interface IPlaceRepository
    {
        public Task<IReadOnlyList<Place>> GetPlacesAsync(int placesPerPage = 10, int page = 0,
            string sort = null, int sortDirection = 1, CancellationToken cancellationToken = default);
    }
}