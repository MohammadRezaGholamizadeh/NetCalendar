using NetCalendar;

var gregorianDate = DateTime.Now;

var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);

jalaliDate
   .AddMonths(1)
   .AddDays(52000);

var convertedDateFromJalaliToGregorian =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate);

var convertedDateFromJalaliToGregorian2 =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate.Year, jalaliDate.Month, jalaliDate.Day);






