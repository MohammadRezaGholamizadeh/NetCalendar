using System.IO;

namespace NetCalendar
{
    internal static class CalendarKabisehSet
    {
        public static string[] JalaliKabiseh
               => File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "KabisehYearFiles", "JalaliKabiseh.txt"));

        public static string[] GregorianKabiseh
               => File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), "KabisehYearFiles", "GerogorianKabiseh.txt"));
    }
}
