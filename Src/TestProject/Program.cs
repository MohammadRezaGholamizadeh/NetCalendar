using NetCalendar;
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







