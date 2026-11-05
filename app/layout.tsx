import type {Metadata} from "next";
import "./globals.css";
import {SiteHeader,SiteFooter} from "@/components/site-shell";
export const metadata:Metadata={title:{default:"Saurabh.AICreates — AI Creative Hub",template:"%s | Saurabh.AICreates"},description:"Explore practical AI image prompts, video workflows, creative tools and tutorials.",openGraph:{title:"Saurabh.AICreates — AI Creative Hub",description:"A practical library of AI image prompts, video workflows and creator resources.",siteName:"Saurabh.AICreates",type:"website"}};
export default function RootLayout({children}:{children:React.ReactNode}){return <html lang="en"><body><SiteHeader/>{children}<SiteFooter/></body></html>}
