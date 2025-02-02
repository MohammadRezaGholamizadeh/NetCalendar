using NetCalendar;
using NetCalendar.GregorianCalendersSet;
using NetCalendar.JalaliCalendersSet;


for (int i = 0; i < 100; i++)
{
    var Date = new DateTime(2024, 01, 01, 1, 1, 5).ConvertToJalali();
    var gregorianDate = NetCalendars.GregorianCalendar.ConvertJalaliToGregorian(Date);
    var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);
    Console.WriteLine($"{jalaliDate.Year} - {jalaliDate.Month} - {jalaliDate.Day}   ---- i = 1");
    for (int j = 2; j < 367; j++)
    {
        jalaliDate.AddDays(7);
        Console.WriteLine($"{jalaliDate.Year} - {jalaliDate.Month} - {jalaliDate.Day} - {jalaliDate.Hour} - {jalaliDate.Minute} - {jalaliDate.Second}   ---- i = {j}");
    }
}



// Convert Jalali To Gregorian Date Time 
var JalaliDateTime = new JalaliDateTime(
                         year: 1403,
                         month: 11,
                         day: 14,
                         hour: 10,
                         minute: 52,
                         second: 25);

var gregorianDateTime = JalaliDateTime.ConvertToGregorian();
gregorianDateTime
    .AddYears(1)
    .AddMonths(1)
    .AddDays(1)
    .AddHours(1)
    .AddMinutes(1)
    .AddSeconds(1)
    .AddMilliseconds(1);

// Or

gregorianDateTime = new GregorianCalendarSet()
                        .ConvertJalaliToGregorian(JalaliDateTime);
gregorianDateTime
    .AddYears(1)
    .AddMonths(1)
    .AddDays(1)
    .AddHours(1)
    .AddMinutes(1)
    .AddSeconds(1)
    .AddMilliseconds(1);




