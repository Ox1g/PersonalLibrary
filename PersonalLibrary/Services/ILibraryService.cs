using PersonalLibrary.Models;

namespace PersonalLibrary.Services
{
    public interface ILibraryService
    {
        Task<IEnumerable<Library>> GetLibrariesAsync();
        Task<Library> GetLibraryByIdAsync(Guid id);
        Task<Library> CreateLibraryAsync(Library library);
        Task UpdateLibraryAsync(Library library);
        Task DeleteLibraryAsync(Guid id);
    }
}
