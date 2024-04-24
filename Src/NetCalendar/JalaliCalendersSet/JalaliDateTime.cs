using DotNetReportsEngine.ReadmeGeneration.Details;
using System.Linq;

namespace NetCalendar.JalaliCalendersSet
{
    [RenderInReadmeFile]
    public sealed class JalaliDateTime
    {
        public JalaliDateTime(
               int year,
               int month,
               int day)
        {
            Year = year;
            Month = month;
            Day = day;
            OriginalValue = new OriginalJalaliDateTime(year, month, day);
        }

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        internal OriginalJalaliDateTime OriginalValue { get; private set; }

        public string Date => $"{Year}-{Month}-{Day}";

        public JalaliDateTime AddDays(int days)
        {
            var gregorian = NetCalendars.GregorianCalendar.ConvertJalaliToGregorian(this);
            gregorian = gregorian.Date.AddDays(days);
            var jalali = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorian);

            Year = jalali.Year;
            Month = jalali.Month;
            Day = jalali.Day;

            return this;
        }


        public JalaliDateTime AddYears(int years)
        {
            Year += years;

            if (OriginalValue.Day > GetLastDayOfMonth())
            {
                Day = GetLastDayOfMonth();
            }

            return this;
        }

        public JalaliDateTime AddMonths(int months)
        {
            if (Month + months == 12)
            {
                Month += months;
            }

            else if ((Month + months) % 12 == 0)
            {
                Year += ((Month + months) / 12) - 1;
                Month = 12;
            }

            else
            {
                Year += (Month + months) / 12;
                Month = (Month + months) % 12;
            }

            if (OriginalValue.Day > GetLastDayOfMonth())
            {
                Day = GetLastDayOfMonth();
            }

            return this;
        }

        public bool IsLeapYear()
        {
            return CalendarKabisehSet.JalaliKabiseh.Any(_ => int.Parse(_) == Year);
        }

        public bool IsLeapMonth()
        {
            return IsLeapYear() && Month == 12;
        }

        public bool IsLeapDay()
        {
            return IsLeapMonth() && Day == 30;
        }

        private int GetLastDayOfMonth()
        {
            if (Month <= 6)
            {
                return 31;
            }
            else if (Month > 6 && Month < 12)
            {
                return 30;
            }
            else if (Month == 12 && CalendarKabisehSet.JalaliKabiseh.Any(_ => int.Parse(_) == Year))
            {
                return 30;
            }
            else
            {
                return 29;
            }
        }
    }
}

