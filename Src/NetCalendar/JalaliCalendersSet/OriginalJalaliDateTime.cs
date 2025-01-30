using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NetCalendar.JalaliCalendersSet
{
    public class OriginalJalaliDateTime
    {
        public OriginalJalaliDateTime(
            int year,
            int month,
            int day,
            int? hour = 0,
            double? minute = 0,
            double? second = 0)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour ?? 0;
            Minute = minute ?? 0;
            Second = second ?? 0;
        }
        public int Year { get; set; }
        [Range(1, 12)]
        public int Month { get; set; }
        [Range(1, 31)]
        public int Day { get; set; }
        [Range(0, 23)]
        public int Hour { get; set; }
        [Range(0, 59.999999999999999)]
        public double Minute { get; set; }
        [Range(0, 59.999999999999999)]
        public double Second { get; set; }

        internal bool IsLastDayOfMonth()
        {
            if (Month <= 6)
            {
                return Day == 31;
            }
            else if (Month > 6 && Month < 12)
            {
                return Day == 30;
            }
            else if (CalendarKabisehSet.JalaliKabiseh.Any(_ => int.Parse(_) == Year) && Month == 12)
            {
                return Day == 30;
            }
            else
            {
                return Day == 29;
            }
        }

        internal bool IsKabiseh()
        {
            return CalendarKabisehSet.JalaliKabiseh.Any(_ => int.Parse(_) == Year);
        }
    }

}

