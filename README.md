# Saurabh AI Creative Hub

A curated AI creative platform for discovering practical image-generation prompts, video-generation prompts, creative workflows and AI tool resources.

## Product scope

- **Image Prompts:** product photography, portraits, fashion, lifestyle, invitations, festival creatives and social media content.
- **Video Prompts:** promotional videos, product videos, social media reels, cinematic workflows, camera movements, transitions and motion guidance.
- **AI Tools:** discover tools such as ChatGPT, Gemini, Google Flow, Veo, Kling and Runway.
- **Tutorials:** practical guides and prompt-engineering resources.
- **Admin experience (planned):** manage prompts, video scenes, categories and media without editing code.

Client-specific mythological work, character-design projects and abstract-art work are intentionally outside this product's scope.

## Technology

- ASP.NET Core / Blazor Web App (.NET 8)
- Interactive Server rendering
- Responsive custom CSS
- Temporary JSON-backed content repository (`ContentData/`)
- Local media asset folders under `wwwroot/media/`

## Run locally

1. Install the .NET 8 SDK.
2. Open a terminal in the repository root.
3. Run:

   ```bash
   dotnet run --project src/Saurabh.AICreativeHub.Web
   ```

## Current status

The first development increment establishes the Blazor application, responsive landing page, navigation, starter category filters and initial sample cards. The homepage now reads starter image and video prompt records from JSON files through `IContentRepository`. AI tool and tutorial data files are also in place. Media folders are ready for local image/video assets. This is temporary file-based storage; there is no SQL/database server yet. The repository interface is designed so a database-backed implementation can replace the JSON implementation later. Admin editing, authentication and full detail pages remain future work.
