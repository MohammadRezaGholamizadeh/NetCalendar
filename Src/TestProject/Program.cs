using NetCalendar;
using NetCalendar.JalaliCalendersSet;
using System.Globalization;

//var gregorianDate = new DateTime(622, 03, 22);
var gregorianDate = new DateTime(2221, 03, 21);
//var s = new DateTime(2222, 02, 26);

//var sd = (s - gregorianDate).TotalDays;
var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);
//jalaliDate.AddDays(365);
jalaliDate.AddDays(365);
jalaliDate.AddDays(365);
var persian = new PersianCalendar().IsLeapYear(1601);
//var ger = NetCalendars.GregorianCalendar.ConvertJalaliToGregorian(jalaliDate);
//jalaliDate.AddDays(1);

//jalaliDate.AddYears(15).AddMonths(1);
for (int i = 0; i < 365; i++)
{
    jalaliDate.AddDays(1);
}

for (int i = 0; i < 180; i++)
{
    if (i == 14 || i == 26 || i == 38 || i == 50 || i == 62 || i == 74)
    {
        //jalaliDate.AddMonths(i - 1 );
    }
    jalaliDate.AddMonths(i);
    jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);
}

jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
jalaliDate.AddMonths(1);
var convertedDateFromJalaliToGregorian =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate);

var convertedDateFromJalaliToGregorian2 =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate.Year, jalaliDate.Month, jalaliDate.Day);






