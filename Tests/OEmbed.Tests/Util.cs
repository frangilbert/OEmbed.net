using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OEmbed.Tests
{
    public class Util
    {
        public static Stream GetEmbeddedResource(string assemblyFileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceStream(assemblyFileName);
        }
    }
}
