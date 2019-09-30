﻿using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace RecordToCode
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
    ExportMetadata("BackgroundColor", "white"),
    ExportMetadata("PrimaryFontColor", "black"),
    ExportMetadata("SecondaryFontColor", "LightGray"),
    ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAABGdBTUEAALGPC/xhBQAAAAlwSFlzAAAOwgAADsIBFShKgAAAABh0RVh0U29mdHdhcmUAcGFpbnQubmV0IDQuMC45bDN+TgAABBZJREFUWEe9l99Pk1cYxw2dE2fcHEzn3HYzXTLjhS67MMuybBebF8u2zOxqF243S3YjmEVNDCl9C9gKAq8dRdoXWktFhDLKj9aX9oVCCwUs0MRt6sS/5ut5Drylb9/zQs1YT/JNmuac53z6Pc/znNM9ykgG3sHUrqqb6VZYcylKfu+enUZnKIHrvomy1OQdhdP7p0nN3VHTXJc/hj8GZtTNbaxHuQAtt8dw7P0PUL3/NZM++exruJW4aY3LPwnPXS26rRMvA3D47XfBlph0+uyXQgASd+KuZu3E/w1AIifkfgsnKgFAIohb/QInKgVAIojOUicqCUDaOI7klhNlA/SM4fiHJ1FTU2PS5199S0HRcUfluhl4gNbeGN+sRRCLOxFKbjhRPsA47FITJEkyyOFwwNcbQjb/HAtr61zzq8+4ZpaeYFRbYWefYOuN8Qji19+b1ZcCaJSa4XQ6TfL39RsARBpJ5HBDiRlitgUSqBgASc08YrkyWYjZGpiqLACJnNBj7hqA3OVHdDqPqLaGePoRMivPhJuTKDfk0BSPWQCghHCz8+FZy8rNLg/iqjvAP5cDYG9p59lOc0hk85D6UAhAikzl2LxNgFZlAt//9BvOfvENTnx0Bm/WHmEXzAEcOPgGGtoHigDG0GB3CAHcsq8wT5eLaWr+LyHA3MOnfA4HaPFGsK96v6m5VFXZUN/YVQhol+/j8uUrAgAJHuWesN6DoxlhbmTz67gZZL2CAKhxvGXR4U59/OnG8fTG8R1zqa6uTgDgRHBI5daXAnjCCQuA5/AOaBsAcljDuR8uCAFIh9iRHD76Hmy2V1BfX2/a3OVyI6IuCwHoV5ZurgP4hlJbSdjI7BUdQ7FsNnYkJgAJfaF7rNutCgHa+uIWAOtQhme3AMjm8xcuooptItqcJALokD1I51i7Ta4IAdqDKrJCgCIHOgp9YBI//nIJr+6r3hFAkhy47Q8gk3vKA1oBeMJJYQ4ssu+69Bzovj8XpR5AC8iJa239OHf+Z5w4eQa1R97B64dqeUlSeTbYJfgDYcS0rCGwFUB4nOYZNyfxKqAbkwDoSuwZmlPp7aYvJBDelFjQpu5RSF0j/OWrLf6DBcEvEgG0ssqZZfVeOpc0s/SYly0H0EexEyK52BFxAEHA8Zk1dLDz7mQlLbOr1zecQmLhb+FcUngiy2MaAJT8phMWENsBkCjZRAlXqtTyk8KNaADQR8+w2ImdAMrR/Oo6elj26zGFAOSEP5JWSyH+KwDdgkpk1tCyhQD68A2nDU4QwPTiY2HwUvHj2Mz+udy/mEjlhc+ybQHICWUkbciJwdgSe1Cs7KjB+DLuRDPsb1kSN9jjtHjTYm0LoA8lMl9wgkqtHJVuZKXyAHh1pK8ShN4fdkttwQReAHnM++z4lickAAAAAElFTkSuQmCC"),
    ExportMetadata("BigImageBase64", "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"),
    ExportMetadata("Name", "Record To Code"),
    ExportMetadata("Description", "Convert a specific record to C# code. Great for generate test")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}