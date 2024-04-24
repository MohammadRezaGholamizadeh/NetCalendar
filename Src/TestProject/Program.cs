using NetCalendar;
using NetCalendar.JalaliCalendersSet;
using System.Globalization;

var gregorianDate = new DateTime(0622, 03, 22);
var min = new PersianCalendar().MinSupportedDateTime - DateTime.MinValue;
var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);
var ss = (gregorianDate.Date - new DateTime(0622, 03, 22).Date).TotalDays + 1;
for (int i = 2; i < 4018; i++)
{
    jalaliDate.AddDays(1);
    Console.WriteLine($"{jalaliDate.Year} - {jalaliDate.Month} - {jalaliDate.Day}   ---- i = {i}");
}

for (int i = 0; i < 2000; i++)
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






