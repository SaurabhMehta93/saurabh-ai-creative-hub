namespace Saurabh.AICreativeHub.Web.Models;

public sealed class ImagePrompt
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Tool { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Prompt { get; set; } = string.Empty;
    public string? Thumbnail { get; set; }
    public bool Featured { get; set; }
}
