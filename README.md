# Saurabh.AICreates — AI Creative Hub

A fast, static-first creative platform for practical AI image prompts, scene-based video-generation workflows, AI tools and creator tutorials.

## Technology
- Next.js 15 + React 19 + TypeScript
- Static export for fast CDN delivery
- JSON content files; no database or request-time server required for the public site
- GitHub Actions with Node.js 22 for type-checking and production builds
- Responsive custom CSS and Lucide icons

## Run locally
Run npm ci, then npm run dev.
For production verification run npm run typecheck and npm run build.
The static website is generated into the out directory and can be hosted on Vercel, Cloudflare Pages or any static host.

## Content
- content/image-prompts.json — product photography, portrait photography, fashion, lifestyle, invitations, festival and social creatives.
- content/video-prompts.json — scene-by-scene video workflows with reference paths, image prompts, video prompts, subject movement and camera movement.
- content/ai-tools.json — AI creative tools directory.
- content/tutorials.json — creator learning resources.

Mythological, character-design and abstract-art content is intentionally excluded.

## Content workspace
The /admin/ route is a static export/download workspace. It previews JSON collections and downloads a selected file. It does not write to GitHub or a deployed server. Never put API keys or tokens in public JSON. A future write-enabled admin requires secure authentication and server-side GitHub integration; never expose a GitHub token in browser code.

## Performance
Static generation for content and detail pages, lightweight client-side search and copy interactions, responsive CSS, and no database calls at visitor request time.

## Legacy
The previous .NET prototype remains in src/ for reference only. The deployed website and root build are Next.js-based.
