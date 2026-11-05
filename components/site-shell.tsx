"use client";
import Link from "next/link";
import {useEffect,useState} from "react";
import {Menu, X, Moon, Sun} from "lucide-react";
const logo = process.env.NODE_ENV === "production" ? "/saurabh-ai-creative-hub/media/saurabh-aicreates-logo.png" : "/media/saurabh-aicreates-logo.png";
const links=[["/image-prompts/","Image Prompts"],["/video-prompts/","Video Prompts"],["/ai-tools/","AI Tools"],["/tutorials/","Tutorials"]];
export function SiteHeader(){
 const [open,setOpen]=useState(false);const [dark,setDark]=useState(false);
 useEffect(()=>{const saved=window.localStorage.getItem("saurabh-theme");const enabled=saved==="dark";setDark(enabled);document.documentElement.dataset.theme=enabled?"dark":"light";},[]);
 function toggleTheme(){const next=!dark;setDark(next);document.documentElement.dataset.theme=next?"dark":"light";window.localStorage.setItem("saurabh-theme",next?"dark":"light");}
 return <header className="site-header"><div className="nav-shell">
  <Link href="/" className="brand" onClick={()=>setOpen(false)}><img src={logo} alt="Saurabh.AICreates logo" className="brand-logo"/><span>SAURABH<span className="brand-dot">.</span>AI<span className="brand-muted">CREATES</span></span></Link>
  <nav className={open?"main-nav nav-open":"main-nav"}>{links.map(([href,label])=><Link key={href} href={href} onClick={()=>setOpen(false)}>{label}</Link>)}<Link className="nav-cta" href="/image-prompts/" onClick={()=>setOpen(false)}>Explore library ↗</Link></nav>
  <button className="theme-toggle" type="button" onClick={toggleTheme} aria-label={dark?"Switch to existing light theme":"Switch to dark theme"} title={dark?"Switch to existing light theme":"Switch to dark theme"}><span className="theme-toggle-icon">{dark?<Sun size={16}/>:<Moon size={16}/>}</span><span>{dark?"Light mode":"Dark mode"}</span></button>
  <button className="menu-toggle" onClick={()=>setOpen(!open)} aria-label="Toggle navigation">{open?<X/>:<Menu/>}</button>
 </div></header>
}
export function SiteFooter(){return <footer className="site-footer"><div className="footer-inner"><div className="footer-brand-lockup"><img src={logo} alt="Saurabh.AICreates logo" className="footer-logo"/><div><Link href="/" className="footer-brand">SAURABH<span>.</span>AICREATES</Link><p>Make ideas visible. Create with intention.</p></div></div><div className="footer-links">{links.map(([href,label])=><Link key={href} href={href}>{label}</Link>)}</div><small>© 2026 Saurabh.AICreates</small></div></footer>}
