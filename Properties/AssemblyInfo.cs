using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(uimonke.BuildInfo.Description)]
[assembly: AssemblyDescription(uimonke.BuildInfo.Description)]
[assembly: AssemblyCompany(uimonke.BuildInfo.Company)]
[assembly: AssemblyProduct(uimonke.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + uimonke.BuildInfo.Author)]
[assembly: AssemblyTrademark(uimonke.BuildInfo.Company)]
[assembly: AssemblyVersion(uimonke.BuildInfo.Version)]
[assembly: AssemblyFileVersion(uimonke.BuildInfo.Version)]
[assembly: MelonInfo(typeof(uimonke.uimonke), uimonke.BuildInfo.Name, uimonke.BuildInfo.Version, uimonke.BuildInfo.Author, uimonke.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

[assembly: MelonGame(null, null)]