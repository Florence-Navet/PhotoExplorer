namespace PhotoExplorer.Api.Data.Models;

public class Photo
{
    public Guid Id { get; set; }
    public string Path { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
}
