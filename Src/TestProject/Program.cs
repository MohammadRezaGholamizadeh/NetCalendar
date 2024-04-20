using NetCalendar;

var gregorianDate = DateTime.Now;

var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);

jalaliDate
    .AddYears(1)
    .AddMonths(1)
    .AddDays(1);

var convertedDateFromJalaliToGregorian =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate);

var convertedDateFromJalaliToGregorian2 =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate.Year, jalaliDate.Month, jalaliDate.Day);






