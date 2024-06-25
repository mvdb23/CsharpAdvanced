using CsharpAdvanced23_24.Models;
using CsharpAdvanced23_24.Repositories;

namespace CsharpAdvanced23_24.Services
{
    public class SearchService : ISearchService
    {
        private readonly IAirbnbRepository<Location> _airbnbRepository;
        public SearchService(IAirbnbRepository<Location> airbnbRepository)
        {
            _airbnbRepository = airbnbRepository;
        }

        public Task<IEnumerable<Location>> GetAllLocations()
        {
            return _airbnbRepository.GetAllAsync();
        }
    }
}
