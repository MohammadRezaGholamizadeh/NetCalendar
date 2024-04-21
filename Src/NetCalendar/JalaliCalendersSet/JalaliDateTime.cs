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
        }

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public string Date => $"{Year}-{Month}-{Day}";

        public JalaliDateTime AddDays(int days)
        {
            var totalDays =
                (Year - 1) * 365 + CalendarKabisehSet.JalaliKabiseh.Count(_ => int.Parse(_) < Year)
                + (Month <= 6
                  ? (Month - 1) * 31 + Day
                  : 186 + (Month - 7) * 30 + Day);

            totalDays += days;

            var newCalculatedYear = totalDays / 365 + 1;
            var remainigDay = totalDays % 365;
            var kabisehCount = CalendarKabisehSet.JalaliKabiseh.Count(_ => int.Parse(_) < newCalculatedYear);

            if (kabisehCount > 365)
            {
                for (int i = 0; i < (int)(kabisehCount / 365); i++)
                {
                    newCalculatedYear -= 1;
                    if (CalendarRequirementSet.PersianCalendar.IsLeapYear(newCalculatedYear - 1))
                    {
                        remainigDay += 1;
                    }
                }
            }

            if (remainigDay <= (kabisehCount % 365))
            {
                newCalculatedYear -= 1;
                remainigDay =
                    (CalendarRequirementSet.PersianCalendar.IsLeapYear(newCalculatedYear)
                    ? 366
                    : 365)
                    + remainigDay
                    - (kabisehCount % 365);
            }

            var newJalaliMonth =
               remainigDay == 186
               ? 6
               : remainigDay < 186
                 ? remainigDay / 31 + 1
                 : remainigDay >= 365
                   ? 12
                   : (remainigDay - 186) / 30 + 7;

            var newJalaliDay =
                newJalaliMonth - 1 <= 6
                ? (remainigDay - (newJalaliMonth - 1) * 31) % 30 == 0
                   ? 30
                   : (remainigDay - (newJalaliMonth - 1) * 31) % 30
                : (remainigDay - 186) % 30 == 0
                  ? 30
                  : (remainigDay - 186) % 30;

            Year = newCalculatedYear;
            Month = newJalaliMonth;
            Day = newJalaliDay;

            return this;
        }

        public JalaliDateTime AddYears(int years)
        {
            Year += years;
            return this;
        }

        public JalaliDateTime AddMonths(int months)
        {
            Year += months / 12;
            Month += months % 12;
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
    }
}

