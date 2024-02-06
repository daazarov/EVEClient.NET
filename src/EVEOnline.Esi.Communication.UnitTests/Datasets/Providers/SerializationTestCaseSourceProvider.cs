using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.UnitTests.Datasets.Providers
{
    public class SerializationTestCaseSourceProvider<T>
    {
        private static string _dataFilesSubFolder => "Datasets/Json/SerializationTests";
        private static string _fileName;
        private static string _customSectionName;

        private static string GetFileContent()
        {
            return EmbeddedResourceUtility.GetFileContents(_dataFilesSubFolder, _fileName);
        }

        private static T Item()
        {
            var content = GetFileContent();
            var testFixtureParams = JsonConvert.DeserializeObject<JObject>(content);
            var sectionName = string.IsNullOrEmpty(_customSectionName) ? $"{typeof(T).Name}" : _customSectionName;
            var item = testFixtureParams[sectionName].ToObject<T>();

            return item;
        }

        public static IEnumerable GetTestData(string fileName, string customSectionName)
        {
            _fileName = fileName;
            _customSectionName = customSectionName;

            yield return new object[] { Item() };
        }
    }
}
