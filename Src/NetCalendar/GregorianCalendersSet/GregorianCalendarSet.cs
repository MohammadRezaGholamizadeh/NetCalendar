using NetCalendar.JalaliCalendersSet;
using System;
using System.Linq;

namespace NetCalendar.GregorianCalendersSet
{
    public class GregorianCalendarSet
    {
        public DateTime ConvertJalaliToGregorian(
            JalaliDateTime jalaliDateTime)
        {
            var totalGerogorianDays =
                (jalaliDateTime.Year - 1) * 365 +
                CalendarKabisehSet.JalaliKabiseh.Count(_ => int.Parse(_) < jalaliDateTime.Year) +
                (jalaliDateTime.Month <= 6
                ? (jalaliDateTime.Month - 1) * 31 + jalaliDateTime.Day
                : (jalaliDateTime.Month - 7) * 30 + jalaliDateTime.Day + 186)
                + 226895;


            var gerogorianYear =
                CalendarRequirementSet.PersianCalendar
                .ToDateTime(jalaliDateTime.Year, jalaliDateTime.Month, jalaliDateTime.Day, 01, 01, 01, 01)
                .Year;

            var totalDaysOfPreviousYears =
                (gerogorianYear - 1) * 365 + CalendarKabisehSet.GregorianKabiseh.Count(_ => int.Parse(_) < gerogorianYear);

            var totalDaysInCurrentYear = totalGerogorianDays - totalDaysOfPreviousYears;

            var tartibGerogorianDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int gerogorianMonth = 0;
            int gerogorianDays = totalDaysInCurrentYear;
            for (int i = 1; i < 13; i++)
            {
                gerogorianMonth = i;
                if (DateTime.IsLeapYear(gerogorianYear) && i == 2)
                {
                    gerogorianDays -= 29;
                }
                else if (gerogorianDays > tartibGerogorianDays[i - 1])
                {
                    gerogorianDays -= tartibGerogorianDays[i - 1];
                }
                else
                {
                    break;
                }
            }

            return new DateTime(gerogorianYear, gerogorianMonth, gerogorianDays);
        }

        public DateTime ConvertJalaliToGregorian(int year, int month, int day)
        {
            var totalGerogorianDays =
                (year - 1) * 365 +
                CalendarKabisehSet.JalaliKabiseh.Count(_ => int.Parse(_) < year) +
                (month <= 6
                ? (month - 1) * 31 + day
                : (month - 7) * 30 + day + 186)
                + 226895;


            var gerogorianYear =
                CalendarRequirementSet.PersianCalendar
                .ToDateTime(year, month, day, 01, 01, 01, 01)
                .Year;

            var totalDaysOfPreviousYears =
                (gerogorianYear - 1) * 365 + CalendarKabisehSet.GregorianKabiseh.Count(_ => int.Parse(_) < gerogorianYear);

            var totalDaysInCurrentYear = totalGerogorianDays - totalDaysOfPreviousYears;

            var tartibGerogorianDays = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int gerogorianMonth = 0;
            int gerogorianDays = totalDaysInCurrentYear;
            for (int i = 1; i < 13; i++)
            {
                gerogorianMonth = i;
                if (DateTime.IsLeapYear(gerogorianYear) && i == 2)
                {
                    gerogorianDays -= 29;
                }
                else if (gerogorianDays > tartibGerogorianDays[i - 1])
                {
                    gerogorianDays -= tartibGerogorianDays[i - 1];
                }
                else
                {
                    break;
                }
            }

            return new DateTime(gerogorianYear, gerogorianMonth, gerogorianDays);
        }
    }
}
