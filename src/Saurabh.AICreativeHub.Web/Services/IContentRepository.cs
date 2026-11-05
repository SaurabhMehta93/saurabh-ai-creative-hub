using Saurabh.AICreativeHub.Web.Models;

namespace Saurabh.AICreativeHub.Web.Services;

public interface IContentRepository
{
    Task<IReadOnlyList<ImagePrompt>> GetImagePromptsAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyList<VideoPrompt>> GetVideoPromptsAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyList<AiTool>> GetAiToolsAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Tutorial>> GetTutorialsAsync(CancellationToken cancellationToken = default);
}
