using NetCalendar;
using NetCalendar.JalaliCalendersSet;

var gregorianDate = new DateTime(3007, 12, 20);

var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);
jalaliDate.AddYears(15).AddMonths(1);
jalaliDate.AddDays(1);

for (int i = 0; i < 180; i++)
{
    if ( i == 14 || i == 26 || i == 38 || i == 50 || i == 62 || i == 74)
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






