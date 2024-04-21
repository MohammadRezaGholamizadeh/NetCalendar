using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace NetCalendar
{
    internal static class CalendarRequirementSet
    {
        public static PersianCalendar PersianCalendar => new PersianCalendar();

        public static string GetKabisehYearFileDetail(
            string nameAndExtension)
        {
            var fontPath =
                $"{typeof(CalendarKabisehSet).Namespace}.KabisehYearFiles.{nameAndExtension}";
            using (Stream stream = typeof(CalendarKabisehSet).Assembly.GetManifestResourceStream(fontPath))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string fileContent =
                           reader.ReadToEnd();
                    return fileContent;
                }
            }
        }
        public static string[] SeperateAllLines(
            this string content)
        {
            var allContent = content.Split(Environment.NewLine).ToList();
            allContent.RemoveAll(_ => string.IsNullOrEmpty(_));
            return allContent.ToArray();
        }
    }
}
