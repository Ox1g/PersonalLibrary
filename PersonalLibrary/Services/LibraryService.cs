using PersonalLibrary.Models;

namespace PersonalLibrary.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly List<Library> _libraries = new List<Library>();

        public Task<IEnumerable<Library>> GetLibrariesAsync()
        {
            return Task.FromResult(_libraries.AsEnumerable());
        }

        public Task<Library> GetLibraryByIdAsync(Guid id)
        {
            var library = _libraries.FirstOrDefault(l => l.Id == id);
            return Task.FromResult(library);
        }

        public Task<Library> CreateLibraryAsync(Library library)
        {
            library.Id = Guid.NewGuid();
            _libraries.Add(library);
            return Task.FromResult(library);
        }

        public Task UpdateLibraryAsync(Library library)
        {
            var existingLibrary = _libraries.FirstOrDefault(l => l.Id == library.Id);
            if (existingLibrary != null)
            {
                existingLibrary.Name = library.Name;
                existingLibrary.Documents = library.Documents;
            }
            return Task.CompletedTask;
        }

        public Task DeleteLibraryAsync(Guid id)
        {
            var library = _libraries.FirstOrDefault(l => l.Id == id);
            if (library != null)
            {
                _libraries.Remove(library);
            }
            return Task.CompletedTask;
        }
    }

}
