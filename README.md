# Saurabh AI Creative Hub

A curated creative platform for practical AI image prompts, scene-based video-generation workflows, AI tools and creator tutorials.

## Product scope

- **Image prompts:** product photography, portrait photography, fashion, lifestyle, wedding and birthday invitations, festival creatives and social media creatives.
- **Video workflows:** product videos, promotional videos, social reels, cinematic videos, camera movements, transitions and motion effects.
- **Scene details:** each video scene can contain a reference image, image prompt, video prompt, subject movement and camera movement.
- **AI tools:** a directory of creative tools such as ChatGPT, Gemini, Google Flow, Veo, Kling, Runway and Midjourney.
- **Tutorials:** prompt-writing and creative workflow learning resources.
- **Content workspace:** a JSON editor/export screen at `/admin` for preparing updated content files.

Client-specific mythological work, character-design projects and abstract-art work are intentionally outside this product's scope.

## Technology

- ASP.NET Core / Blazor Web App (.NET 8)
- Interactive Server rendering
- JSON-backed temporary content repository
- Responsive custom CSS

## Content structure

```
src/Saurabh.AICreativeHub.Web/
├── ContentData/
│   ├── image-prompts.json
│   ├── video-prompts.json
│   ├── ai-tools.json
│   └── tutorials.json
├── Models/
├── Services/
│   ├── IContentRepository.cs
│   └── JsonContentRepository.cs
├── Components/
│   ├── Layout/
│   └── Pages/
└── wwwroot/
    ├── css/
    ├── js/
    └── media/
        ├── images/
        └── videos/
```

The UI reads content through `IContentRepository`. The current implementation reads JSON files from `ContentData/`. A database-backed implementation can replace this repository later without changing the page components.

## Media

Use relative paths beginning with `/media/` for local images and video assets, or use full HTTPS URLs for externally hosted media. Keep large video files on suitable external media storage rather than committing them to Git.

## Content workspace notes

The `/admin` page currently edits JSON in the browser and downloads the selected JSON file. It does not write to GitHub or directly update a deployed site. Review the downloaded file and replace the corresponding file in `ContentData/` through a Git commit/PR.

This temporary editor is not an authenticated production admin system. Do not put secrets, API keys or private content in the JSON files. A secure admin login and server-side persistence should be added when a proper hosting/database environment is selected.

## Run locally

1. Install the .NET 8 SDK.
2. Open a terminal in the repository root.
3. Run:

   ```bash
   dotnet run --project src/Saurabh.AICreativeHub.Web
   ```

## Current implementation

- Responsive homepage with search, category filtering and starter prompt previews.
- Searchable image prompt listing and individual prompt details with copy.
- Searchable video workflow listing and scene-by-scene details with per-prompt and copy-all actions.
- AI tools directory and tutorial listing.
- JSON content repository and media folder structure.
- Temporary content workspace with JSON validation and download/export.

The project still needs a successful .NET build/run verification and real media assets before it is production-ready.
