# NetCalendar
This Package Is For Using The Different TypeOf DateTime And Converting The Date Together With High Accuracy And Most Easily That You Can Imagine . This Package Support Hijri Calendar , Jalali Calander (Persian Calendar) , Gregorian Calendar , Solar Calendar
This Is The Best Tools For Converting Date To Each Other. Enjoy It

![Logo](https://raw.githubusercontent.com/MohammadRezaGholamizadeh/NetCalendar/main/ReadmeCreator/Files/NetCalendar.png)

## Authors
- [@Mohammadreza Gholamizadeh [Phoenix]](https://github.com/MohammadRezaGholamizadeh)
## 🚀 About Me
I MohammadReza Gholamizadeh. I`m Dotnet Software Developer That Always Try To Make All things Easy for Developing. Please Star the Project And Package to Cover And Enjoy When Using It.

## 🔗 Links
[![Source Code](https://img.shields.io/badge/Source_Code-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh/NetCalendar/tree/main)
[![MohammadReza Gholamizadeh GitHub](https://img.shields.io/badge/MohammadReza_Gholamizadeh_GitHub-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh)
[![Readme File]()](https://github.com/MohammadRezaGholamizadeh/NetCalendar/blob/main/README.md)
[![Nuget](https://img.shields.io/badge/Nuget-4974a5?style=for-the-badge&logo=nuget&logoColor=white)](https://www.nuget.org/profiles/MohammadrezaGholamizadeh_Phoenix)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/mohammadreza-gholamizadeh-b94b1521b/)

## Licenses
* [Apache-2.0 license](https://github.com/MohammadRezaGholamizadeh/NetCalendar/blob/main/LICENSE)

## Get Start With Sample Code
You Can Use This Package And Tools Like This !!!

![Sample](https://raw.githubusercontent.com/MohammadRezaGholamizadeh/NetCalendar/main/ReadmeCreator/Files/Sample.png)

## Commands
Package Manager
```bash
NuGet\Install-Package NetCalendar -Version 2024.04.20
```

# Class And Method Implementation
## Type : NetCalendars
### NetCalendars Methods : 


## Type : JalaliCalendarSet
### This Type Has 1 Custom Constructor : 
* Constructor Number 1 : [ Void ] 
### JalaliCalendarSet Methods : 

* ConvertGregorianToJalali(gregorianDate)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `gregorianDate` | `DateTime` | ** **Required.**                      |

* IsLeapYear(year)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `year` | `Int32` | ** **Required.**                      |


## Type : JalaliDateTime
### This Type Has 1 Custom Constructor : 
* Constructor Number 1 : 

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `year` | `Int32` | ** **Required.**                    |
| `month` | `Int32` | ** **Required.**                    |
| `day` | `Int32` | ** **Required.**                    |
### JalaliDateTime Methods : 

* AddDays(days)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `days` | `Int32` | ** **Required.**                      |

* AddYears(years)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `years` | `Int32` | ** **Required.**                      |

* AddMonths(months)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `months` | `Int32` | ** **Required.**                      |

* IsLeapYear()


* IsLeapMonth()


* IsLeapDay()



## Type : GregorianCalendarSet
### This Type Has 1 Custom Constructor : 
* Constructor Number 1 : [ Void ] 
### GregorianCalendarSet Methods : 

* ConvertJalaliToGregorian(jalaliDateTime)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `jalaliDateTime` | `JalaliDateTime` | ** **Required.**                      |

* ConvertJalaliToGregorian(year, month, day)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `year` | `Int32` | ** **Required.**                      |
| `month` | `Int32` | ** **Required.**                      |
| `day` | `Int32` | ** **Required.**                      |


