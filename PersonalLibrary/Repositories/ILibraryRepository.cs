using PersonalLibrary.Models;

namespace PersonalLibrary.Repositories
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Library>> GetLibrariesAsync();
        Task<Library> GetLibraryByIdAsync(Guid id);
        Task CreateLibraryAsync(Library library);
        Task UpdateLibraryAsync(Library library);
        Task DeleteLibraryAsync(Guid id);
    }

}
