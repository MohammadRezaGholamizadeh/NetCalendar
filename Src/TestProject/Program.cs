using NetCalendar;
using NetCalendar.JalaliCalendersSet;


for (int i = 0; i < 100; i++)
{
    var gregorianDate = NetCalendars.GregorianCalendar.ConvertJalaliToGregorian(new JalaliDateTime(1399 + i, 1, 1));
    var jalaliDate = NetCalendars.JalaliCalander.ConvertGregorianToJalali(gregorianDate);
    Console.WriteLine($"{jalaliDate.Year} - {jalaliDate.Month} - {jalaliDate.Day}   ---- i = 1");
    for (int j = 2; j < 367; j++)
    {
        jalaliDate.AddDays(7);
        Console.WriteLine($"{jalaliDate.Year} - {jalaliDate.Month} - {jalaliDate.Day}   ---- i = {j}");
    }
}







