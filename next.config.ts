import type {NextConfig} from "next";
const isGitHubPages=process.env.GITHUB_PAGES==="true";
const basePath=isGitHubPages?"/saurabh-ai-creative-hub":"";
const nextConfig:NextConfig={output:"export",trailingSlash:true,images:{unoptimized:true},basePath:basePath||undefined,assetPrefix:basePath||undefined};
export default nextConfig;
