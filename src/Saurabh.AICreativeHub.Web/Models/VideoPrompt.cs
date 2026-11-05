namespace Saurabh.AICreativeHub.Web.Models;

public sealed class VideoPrompt
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Tool { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int DurationSeconds { get; set; }
    public string AspectRatio { get; set; } = "9:16";
    public string? Thumbnail { get; set; }
    public List<VideoScene> Scenes { get; set; } = [];
}

public sealed class VideoScene
{
    public int SceneNumber { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? ReferenceImage { get; set; }
    public string ImagePrompt { get; set; } = string.Empty;
    public string VideoPrompt { get; set; } = string.Empty;
    public string SubjectMovement { get; set; } = string.Empty;
    public string CameraMovement { get; set; } = string.Empty;
}
