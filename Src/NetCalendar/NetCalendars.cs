using NetCalendar.GregorianCalendersSet;
using NetCalendar.JalaliCalendersSet;

namespace NetCalendar
{
    public static class NetCalendars
    {
        public static JalaliCalendarSet JalaliCalander => new JalaliCalendarSet();
        public static GregorianCalendarSet GregorianCalendar => new GregorianCalendarSet();
    }
}
