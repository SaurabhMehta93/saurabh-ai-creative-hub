using System.Text.Json;
using Saurabh.AICreativeHub.Web.Models;

namespace Saurabh.AICreativeHub.Web.Services;

/// <summary>
/// Temporary JSON-backed content store. The interface allows a database-backed
/// repository to replace this implementation later without changing UI pages.
/// </summary>
public sealed class JsonContentRepository(IWebHostEnvironment environment) : IContentRepository
{
    private readonly string _contentDirectory = Path.Combine(environment.ContentRootPath, "ContentData");
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
    {
        PropertyNameCaseInsensitive = true
    };

    public Task<IReadOnlyList<ImagePrompt>> GetImagePromptsAsync(CancellationToken cancellationToken = default) =>
        ReadAsync<ImagePrompt>("image-prompts.json", cancellationToken);

    public Task<IReadOnlyList<VideoPrompt>> GetVideoPromptsAsync(CancellationToken cancellationToken = default) =>
        ReadAsync<VideoPrompt>("video-prompts.json", cancellationToken);

    public Task<IReadOnlyList<AiTool>> GetAiToolsAsync(CancellationToken cancellationToken = default) =>
        ReadAsync<AiTool>("ai-tools.json", cancellationToken);

    public Task<IReadOnlyList<Tutorial>> GetTutorialsAsync(CancellationToken cancellationToken = default) =>
        ReadAsync<Tutorial>("tutorials.json", cancellationToken);

    private async Task<IReadOnlyList<T>> ReadAsync<T>(string fileName, CancellationToken cancellationToken)
    {
        var path = Path.Combine(_contentDirectory, fileName);
        if (!File.Exists(path))
            return [];

        await using var stream = File.OpenRead(path);
        return await JsonSerializer.DeserializeAsync<List<T>>(stream, JsonOptions, cancellationToken) ?? [];
    }
}
