namespace Saurabh.AICreativeHub.Web.Models;

public sealed class Tutorial
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string? ContentUrl { get; set; }
}
