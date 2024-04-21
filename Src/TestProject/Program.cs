using NetCalendar;

var gregorianDate = new DateTime(2025 , 02 , 12);

var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);

jalaliDate
   .AddMonths(1);

var convertedDateFromJalaliToGregorian =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate);

var convertedDateFromJalaliToGregorian2 =
    NetCalendars.GregorianCalendar
                .ConvertJalaliToGregorian(jalaliDate.Year, jalaliDate.Month, jalaliDate.Day);






