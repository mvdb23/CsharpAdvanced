using CsharpAdvanced23_24.Models;

namespace CsharpAdvanced23_24.Services
{
    public interface ISearchService
    {
        public Task<IEnumerable<Location>> GetAllLocations();
    }
}
