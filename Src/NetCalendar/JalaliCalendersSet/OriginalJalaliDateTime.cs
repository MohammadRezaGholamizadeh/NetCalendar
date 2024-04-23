using System;
using System.Linq;

namespace NetCalendar.JalaliCalendersSet
{
    public class OriginalJalaliDateTime
    {
        public OriginalJalaliDateTime(
            int year,
            int month,
            int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

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

