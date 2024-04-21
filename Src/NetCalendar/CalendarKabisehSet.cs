namespace NetCalendar
{
    internal static class CalendarKabisehSet
    {
        public static string[] JalaliKabiseh
               => CalendarRequirementSet.GetKabisehYearFileDetail("JalaliKabiseh.txt").SeperateAllLines();

        public static string[] GregorianKabiseh
               => CalendarRequirementSet.GetKabisehYearFileDetail("GerogorianKabiseh.txt").SeperateAllLines();
    }
}
