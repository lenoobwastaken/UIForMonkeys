using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(UIForMonkeys.BuildInfo.Description)]
[assembly: AssemblyDescription(UIForMonkeys.BuildInfo.Description)]
[assembly: AssemblyCompany(UIForMonkeys.BuildInfo.Company)]
[assembly: AssemblyProduct(UIForMonkeys.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + UIForMonkeys.BuildInfo.Author)]
[assembly: AssemblyTrademark(UIForMonkeys.BuildInfo.Company)]
[assembly: AssemblyVersion(UIForMonkeys.BuildInfo.Version)]
[assembly: AssemblyFileVersion(UIForMonkeys.BuildInfo.Version)]
[assembly: MelonInfo(typeof(UIForMonkeys.uimonke), UIForMonkeys.BuildInfo.Name, UIForMonkeys.BuildInfo.Version, UIForMonkeys.BuildInfo.Author, UIForMonkeys.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

[assembly: MelonGame(null, null)]