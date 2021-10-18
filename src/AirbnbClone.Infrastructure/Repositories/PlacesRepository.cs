using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AirbnbClone.Domain.Interfaces;
using AirbnbClone.Domain.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace AirbnbClone.Infrastructure.Repositories
{
    public class PlacesRepository: IPlaceRepository
    {
        private const int DefaultPlacesPerPage = 20;
        private const string DefaultSortKey = "price";
        private const int DefaultSortOrder = -1;
        private readonly IMongoCollection<Place> _placesCollection;

        public PlacesRepository(IMongoClient mongoClient)
        {
            var camelCaseConvention = new ConventionPack {new CamelCaseElementNameConvention()};
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);
            _placesCollection = mongoClient.GetDatabase("sample_airbnb").GetCollection<Place>("listingsAndReviews");
        }

        /// <summary>
        ///     Get a <see cref="IReadOnlyList{T}" /> of <see cref="Place" /> documents from the repository.
        /// </summary>
        /// <param name="placesPerPage">The maximum number of places to return.</param>
        /// <param name="page">
        ///     The page number, used in conjunction with <paramref name="placesPerPage" /> to skip <see cref="Place" />
        ///     documents for pagination.
        /// </param>
        /// <param name="sort">The field on which to sort the results.</param>
        /// <param name="sortDirection">
        ///     The direction to use when sorting the <see cref="Place" />. 1 for ascending, -1 for
        ///     descending
        /// </param>
        /// <param name="cancellationToken">Allows the UI to cancel an asynchronous request. Optional.</param>
        /// <returns>A <see cref="IReadOnlyList{T}" /> of <see cref="Place" /> objects.</returns>
        public async Task<IReadOnlyList<Place>> GetPlacesAsync(int placesPerPage = DefaultPlacesPerPage, int page = 0,
            string sort = DefaultSortKey, int sortDirection = DefaultSortOrder,
            CancellationToken cancellationToken = default)
        {
            var skip =  placesPerPage * page;
            var limit = placesPerPage;
            sort ??= DefaultSortKey;
            
            var sortFilter = new BsonDocument(sort, sortDirection);
            var movies = await _placesCollection
                .Find(Builders<Place>.Filter.Empty)
                .Limit(limit)
                .Skip(skip)
                .Sort(sortFilter)
                .ToListAsync(cancellationToken);

            return movies;
        }
    }
}