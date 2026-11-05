namespace Saurabh.AICreativeHub.Web.Models;

public sealed class AiTool
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? WebsiteUrl { get; set; }
}
