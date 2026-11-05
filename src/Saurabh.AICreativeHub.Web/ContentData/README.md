# Content data

This folder is the temporary, file-based content store.

- `image-prompts.json`: image prompt records.
- `video-prompts.json`: video workflows and their scene-by-scene prompts.
- `ai-tools.json`: AI tool directory.
- `tutorials.json`: tutorials and learning resources.

The application reads these files through `IContentRepository`. Keep the UI dependent on that interface rather than reading JSON directly in Razor pages. Later, a SQL/database implementation can replace `JsonContentRepository` while keeping the same interface and page contracts.

Use relative paths beginning with `/media/` for local image/video assets. External HTTPS media URLs are also supported by the data model. Do not store secrets, API keys or private credentials in these JSON files.
