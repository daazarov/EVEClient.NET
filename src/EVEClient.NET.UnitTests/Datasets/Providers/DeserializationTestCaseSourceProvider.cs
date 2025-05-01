using System.Text.Json;

namespace EVEClient.NET.UnitTests.Datasets.Providers
{
    public class DeserializationTestCaseSourceProvider<T>
    {
        private static string _dataFilesSubFolder => "Datasets/Json/DeserializationTests";
        private static string _fileName;
        private static string _customSectionName;

        private static string GetFileContent()
        {
            return EmbeddedResourceUtility.GetFileContents(_dataFilesSubFolder, _fileName);
        }

        private static T Item()
        {
            var content = GetFileContent();

            using (var jsonDoc = JsonDocument.Parse(content))
            {
                var root = jsonDoc.RootElement;
                var sectionName = string.IsNullOrEmpty(_customSectionName) ? typeof(T).Name : _customSectionName;
                if (!root.TryGetProperty(sectionName, out var sectionElement))
                    throw new KeyNotFoundException($"Section '{sectionName}' not found in JSON.");

                return sectionElement.Deserialize<T>();
            }
        }

        public static IEnumerable<T> GetTestData(string fileName, string customSectionName)
        {
            _fileName = fileName;
            _customSectionName = customSectionName;

            yield return Item();
        }
    }
}
