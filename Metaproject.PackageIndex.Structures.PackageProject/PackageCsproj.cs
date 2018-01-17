using DevOps.Primitives.NuGet;
using DevOps.Primitives.VisualStudio.Projects;
using System.Collections.Generic;
using static DevOps.Primitives.VisualStudio.Projects.Helpers.DotNetCore.DotNetCoreProjects;
using static Metaproject.PackageIndex.Structures.PackageProject.NuGetPackageInfoFactory;

namespace Metaproject.PackageIndex.Structures.PackageProject
{
    public class PackageCsproj
    {
        public PackageCsproj(string name, string description, string version, List<NuGetReference> packageReferences)
        {
            Description = description;
            Name = name;
            PackageReferences = packageReferences;
            Version = version;
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }

        public List<NuGetReference> PackageReferences { get; set; }

        public Project GetProject()
            => Create(Name,
                PackageReferences,
                nuGetPackageInfo: PackageInfo(Name, Description, Version));
    }
}
