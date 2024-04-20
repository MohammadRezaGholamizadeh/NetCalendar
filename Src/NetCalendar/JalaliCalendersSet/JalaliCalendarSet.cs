﻿using System;
using System.Linq;

namespace NetCalendar.JalaliCalendersSet
{
    public class JalaliCalendarSet
    {
        public JalaliDateTime ConvertGregorianToJalali(DateTime gregorianDate)
        {
            if (gregorianDate < new DateTime(0622, 03, 22))
                throw new Exception("Invalid DateTime !!! Hijri Shamis DateTime Must Bigger Than 0622-03-22 ");

            var totalGerogorianDays =
                (gregorianDate.Date - new DateTime(0622, 03, 22).Date).TotalDays + 1;

            var jalaliYear = CalendarRequirementSet.PersianCalendar.GetYear(gregorianDate);

            var totalDaysOfPreviousYears =
                (jalaliYear - 1) * 365 + CalendarKabisehSet.JalaliKabiseh.Count(_ => int.Parse(_) < jalaliYear);

            var totalDaysInCurrentYear = totalGerogorianDays - totalDaysOfPreviousYears;
            var jalaliMonth =
                totalDaysInCurrentYear == 186
                ? 6
                : totalDaysInCurrentYear < 186
                  ? (int)(totalDaysInCurrentYear / 31) + 1
                  : totalDaysInCurrentYear >= 365
                    ? 12
                    : (int)((totalDaysInCurrentYear - 186) / 30) + 7;

            var jalaliDay =
                jalaliMonth - 1 <= 6
                ? (totalDaysInCurrentYear - (jalaliMonth - 1) * 31) % 30 == 0
                   ? 30
                   : (totalDaysInCurrentYear - (jalaliMonth - 1) * 31) % 30
                : (totalDaysInCurrentYear - 186) % 30 == 0
                  ? 30
                  : (totalDaysInCurrentYear - 186) % 30;

            return new JalaliDateTime(jalaliYear, jalaliMonth, (int)jalaliDay);
        }
        public bool IsLeapYear(int year)
        {
            return CalendarKabisehSet.JalaliKabiseh.Any(_ => int.Parse(_) == year);
        }
    }
}

