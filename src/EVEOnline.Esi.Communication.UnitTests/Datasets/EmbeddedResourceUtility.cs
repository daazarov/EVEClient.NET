using System.Reflection;

namespace EVEOnline.Esi.Communication.UnitTests.Datasets
{
    public static class EmbeddedResourceUtility
    {
        public static string GetFileContents(string folderPath, string fileName)
        {
            return GetFileContents(Assembly.GetExecutingAssembly(), folderPath.Replace('/', '.'), fileName);
        }

        private static string GetFileContents(Assembly assembly, string folderPath, string fileName)
        {
            var resourcePath = BuildResourcePath(assembly.GetName().Name, folderPath, fileName);

            var stream = assembly.GetManifestResourceStream(resourcePath);

            if (stream == null)
            {
                throw new InvalidOperationException(string.Format("Assembly {0} doesn't contain embedded resource {1}. Check that {1} is marked as EmbeddedResource.",
                    assembly.FullName, resourcePath));
            }

            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private static string BuildResourcePath(string assemblyName, string folderPath, string fileName)
        {
            var resourcePath = string.Format("{0}.{1}.{2}", assemblyName, folderPath, fileName);
            return resourcePath;
        }
    }
}
