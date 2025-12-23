using NetCalendar;
using NetCalendar.GregorianCalendersSet;
using NetCalendar.JalaliCalendersSet;


for (int i = 0; i < 100; i++)
{
    var Date = new DateTime(2024, 01, 01, 1, 1, 5).ConvertToJalali();
    var gregorianDate = NetCalendarSet.GregorianCalendar.ConvertJalaliToGregorian(Date);
    var jalaliDate = NetCalendarSet.JalaliCalander.ConvertGregorianToJalali(gregorianDate);
    Console.WriteLine($"{jalaliDate.Year} - {jalaliDate.Month} - {jalaliDate.Day}   ---- i = 1");
    for (int j = 2; j < 367; j++)
    {
        jalaliDate.AddDays(7);
        Console.WriteLine($"{jalaliDate.Year} - {jalaliDate.Month} - {jalaliDate.Day} - {jalaliDate.Hour} - {jalaliDate.Minute} - {jalaliDate.Second}   ---- i = {j}");
    }
}



//var gregorianDateTime = DateTime.Now; // ForExample

//var jalaliDateTime = gregorianDateTime.ConvertToJalali();

////Or You Can Convert Like This :

//jalaliDateTime = gregorianDateTime.ConvertToJalali();


////And Then You Can Use :

//jalaliDateTime
//    .AddYears(1)
//    .AddMonths(1)
//    .AddDays(1)
//    .AddHours(1)
//    .AddMinutes(1)
//    .AddSeconds(1);

//jalaliDateTime.IsLeapYear();
//jalaliDateTime.IsLeapMonth();
//jalaliDateTime.IsLeapDay();








// Convert Jalali To Gregorian Date Time 

var JalaliDateTime = //For Example
    new JalaliDateTime(year: 1403, month: 11, day: 14,
                       hour: 10, minute: 52, second: 25);

var gregorianDateTime = JalaliDateTime.ConvertToGregorian();

//Or You Can Convert Like This :

gregorianDateTime = NetCalendarSet
                    .GregorianCalendar
                    .ConvertJalaliToGregorian(JalaliDateTime);

//And Then You Can Use :

gregorianDateTime
    .AddYears(1)
    .AddMonths(1)
    .AddDays(1)
    .AddHours(1)
    .AddMinutes(1)
    .AddSeconds(1)
    .AddMilliseconds(1);

gregorianDateTime.IsLeapYear();
gregorianDateTime.IsLeapYearInJalali();



