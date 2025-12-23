using DotNetReportsEngine.ReadmeGeneration.Details;
using NetCalendar.GregorianCalendersSet;
using NetCalendar.JalaliCalendersSet;
using System;

namespace NetCalendar
{
    [RenderInReadmeFile]
    public static class NetCalendarSet
    {
        public static JalaliCalendarSet JalaliCalander => new JalaliCalendarSet();
        public static GregorianCalendarSet GregorianCalendar => new GregorianCalendarSet();

        public static JalaliDateTime ConvertToJalali(this DateTime dateTime)
        {
            return new JalaliCalendarSet().ConvertGregorianToJalali(dateTime);
        }

        public static bool IsLeapYearInJalali(this DateTime dateTime)
        {
            return new JalaliCalendarSet().IsLeapYear(dateTime.Year);
        }

        public static DateTime ConvertToGregorian(this JalaliDateTime dateTime)
        {
            return new GregorianCalendarSet().ConvertJalaliToGregorian(dateTime);
        }

        public static bool IsLeapYear(this DateTime dateTime)
        {
            return DateTime.IsLeapYear(dateTime.Year);
        }
    }
}

