namespace PersonalLibrary.Models
{
    public class Document
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime UploadDate { get; set; }
        public long Size { get; set; }
        public string FilePath { get; set; }
    }
}
