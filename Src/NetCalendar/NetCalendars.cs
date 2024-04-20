using DotNetReportsEngine.ReadmeGeneration.Details;
using NetCalendar.GregorianCalendersSet;
using NetCalendar.JalaliCalendersSet;

namespace NetCalendar
{
    [RenderInReadmeFile]
    public static class NetCalendars
    {
        public static JalaliCalendarSet JalaliCalander => new JalaliCalendarSet();
        public static GregorianCalendarSet GregorianCalendar => new GregorianCalendarSet();
    }
}
