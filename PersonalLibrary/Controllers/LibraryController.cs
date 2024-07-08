using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalLibrary.Models;
using PersonalLibrary.Services;

namespace PersonalLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Library>>> GetLibraries()
        {
            var libraries = await _libraryService.GetLibrariesAsync();
            return Ok(libraries);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Library>> GetLibrary(Guid id)
        {
            var library = await _libraryService.GetLibraryByIdAsync(id);
            if (library == null)
            {
                return NotFound();
            }
            return Ok(library);
        }

        [HttpPost]
        public async Task<ActionResult<Library>> CreateLibrary(Library library)
        {
            var createdLibrary = await _libraryService.CreateLibraryAsync(library);
            return CreatedAtAction(nameof(GetLibrary), new { id = createdLibrary.Id }, createdLibrary);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLibrary(Guid id, Library library)
        {
            if (id != library.Id)
            {
                return BadRequest();
            }
            await _libraryService.UpdateLibraryAsync(library);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibrary(Guid id)
        {
            await _libraryService.DeleteLibraryAsync(id);
            return NoContent();
        }
    }
}
