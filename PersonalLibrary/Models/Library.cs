using System.Reflection.Metadata;

namespace PersonalLibrary.Models
{
    public class Library
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public List<Document> Documents { get; set; } = new List<Document>();
    }
}
