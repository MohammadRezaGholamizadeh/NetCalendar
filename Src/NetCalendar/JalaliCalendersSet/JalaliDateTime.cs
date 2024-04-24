using DotNetReportsEngine.ReadmeGeneration.Details;
using System.Linq;
using System.Runtime.CompilerServices;

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


        public JalaliDateTime AddDays2(int days)
        {
            var totalDays =
                (Year - 1) * 365 + CalendarKabisehSet.JalaliKabiseh.Count(_ => int.Parse(_) < Year)
                + (Month <= 6
                  ? (Month - 1) * 31 + Day
                  : 186 + (Month - 7) * 30 + Day);

            totalDays += days;

            var newCalculatedYear = (totalDays % 365 == 0) ? (totalDays / 365) : (int)(totalDays / 365) + 1;
            var remainigDay = totalDays % 365 == 0 ? 1 : totalDays % 365;
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
            else
            {
                remainigDay -= kabisehCount % 365;
            }

            var newJalaliMonth =
               remainigDay == 186
               ? 6
               : remainigDay < 186
                 ? (remainigDay / 31) <= 1 && remainigDay % 31 == 0
                   ? 1
                   : (remainigDay % 31) == 0
                     ? (remainigDay / 31)
                     : (remainigDay / 31) + 1
                 : remainigDay >= 365
                   ? 12
                   : ((remainigDay - 186) % 30) == 0
                     ? ((remainigDay - 186) / 30) + 6
                     : ((remainigDay - 186) / 30) + 7;

            var newJalaliDay =
                newJalaliMonth == 1
                ? remainigDay
                : newJalaliMonth <= 6
                  ? remainigDay % 31 == 0
                     ? 31
                     : remainigDay % 31
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

