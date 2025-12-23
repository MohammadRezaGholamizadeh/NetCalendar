using DotNetReportsEngine.ReadmeGeneration.Details;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NetCalendar.JalaliCalendersSet
{
    [RenderInReadmeFile]
    public sealed class JalaliDateTime
    {
        public JalaliDateTime(
               int year,
               int month,
               int day,
               int hour = 0,
               double minute = 0,
               double second = 0)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
            OriginalValue = new OriginalJalaliDateTime(year, month, day, hour, minute, second);
        }

        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        [Range(0, 23)]
        public int Hour { get; set; }
        [Range(0, 59.999999999999999)]
        public double Minute { get; set; }
        [Range(0, 59.999999999999999)]
        public double Second { get; set; }

        internal OriginalJalaliDateTime OriginalValue { get; private set; }

        public string Date => $"{Year}-{Month}-{Day}";
        public string DateTime => $"{Year}-{Month}-{Day} | {Hour}:{Minute}:{Second}";

        public JalaliDateTime AddHours(int hours)
        {
            var gregorian = NetCalendarSet.GregorianCalendar.ConvertJalaliToGregorian(this);
            gregorian = gregorian.AddHours(hours);
            var jalali = NetCalendarSet.JalaliCalander.ConvertGregorianToJalali(gregorian);

            Year = jalali.Year;
            Month = jalali.Month;
            Day = jalali.Day;
            Hour = jalali.Hour;
            Minute = jalali.Minute;
            Second = jalali.Second;

            return this;
        }

        public JalaliDateTime AddMinutes(int minutes)
        {
            var gregorian = NetCalendarSet.GregorianCalendar.ConvertJalaliToGregorian(this);
            gregorian = gregorian.AddMinutes(minutes);
            var jalali = NetCalendarSet.JalaliCalander.ConvertGregorianToJalali(gregorian);

            Year = jalali.Year;
            Month = jalali.Month;
            Day = jalali.Day;
            Hour = jalali.Hour;
            Minute = jalali.Minute;
            Second = jalali.Second;

            return this;
        }

        public JalaliDateTime AddSeconds(int seconds)
        {
            var gregorian = NetCalendarSet.GregorianCalendar.ConvertJalaliToGregorian(this);
            gregorian = gregorian.AddSeconds(seconds);
            var jalali = NetCalendarSet.JalaliCalander.ConvertGregorianToJalali(gregorian);

            Year = jalali.Year;
            Month = jalali.Month;
            Day = jalali.Day;
            Hour = jalali.Hour;
            Minute = jalali.Minute;
            Second = jalali.Second;

            return this;
        }

        public JalaliDateTime AddDays(int days)
        {
            var gregorian = NetCalendarSet.GregorianCalendar.ConvertJalaliToGregorian(this);
            var gregorianAfterAddDays = gregorian.AddDays(days);
            var jalali = NetCalendarSet.JalaliCalander.ConvertGregorianToJalali(gregorianAfterAddDays);

            Year = jalali.Year;
            Month = jalali.Month;
            Day = jalali.Day;
            Hour = jalali.Hour;
            Minute = jalali.Minute;
            Second = jalali.Second;

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

