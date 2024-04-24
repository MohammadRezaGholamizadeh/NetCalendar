# NetCalendar 2024.04.28
This Package Is For Using The Different TypeOf DateTime And Converting The Date Together With High Accuracy And Most Easily That You Can Imagine . This Package Support Hijri Calendar , Jalali Calander (Persian Calendar) , Gregorian Calendar
This Is The Best Tools For Converting Date To Each Other. Enjoy It

![Logo](https://raw.githubusercontent.com/MohammadRezaGholamizadeh/NetCalendar/main/ReadmeCreator/Files/NetCalendar.png) 

## Authors
- [@Mohammadreza Gholamizadeh [Phoenix]](https://github.com/MohammadRezaGholamizadeh)
## 🚀 About Me
I MohammadReza Gholamizadeh. I`m Dotnet Software Developer That Always Try To Make All things Easy for Developing. Please Star the Project And Package to Cover And Enjoy When Using It.

## 🔗 Links
[![Source Code](https://img.shields.io/badge/Source_Code-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh/NetCalendar/tree/main)
[![MohammadReza Gholamizadeh GitHub](https://img.shields.io/badge/MohammadReza_Gholamizadeh_GitHub-000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh)
[![Readme File](https://img.shields.io/badge/Readme_File-e23a08?style=for-the-badge&logo=github&logoColor=white)](https://github.com/MohammadRezaGholamizadeh/NetCalendar/blob/main/README.md)
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
NuGet\Install-Package NetCalendar -Version 2024.04.28
```
## Feature Of Version 2024.04.28
* Some Bugs Fixed 
* Improve Performance In Calculation
* Improve Accuracy Of Converting Dates

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

With This Method We Can Convert Gregorian Date Time To jalali Date Time With Hight Accuracy.

* IsLeapYear(year)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `year` | `Int32` | ** **Required.**                      |

 This MEthod Tell Us That A Year Be Leap Or Not.

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

With This Method We Can Add Days To Current Date In Jalali Format.

* AddYears(years)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `years` | `Int32` | ** **Required.**                      |

With This Method We Can Add Years To Current Date In Jalali Format.

* AddMonths(months)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `months` | `Int32` | ** **Required.**                      |

With This Method We Can Add Months To Current Date In Jalali Format.

* IsLeapYear()

 This MEthod Tell Us That A Year Be Leap Or Not.

* IsLeapMonth()

 This MEthod Tell Us That A Month Be Leap Or Not.

* IsLeapDay()

 This MEthod Tell Us That A Day Be Leap Or Not.


## Type : GregorianCalendarSet
### This Type Has 1 Custom Constructor : 
* Constructor Number 1 : [ Void ] 
### GregorianCalendarSet Methods : 

* ConvertJalaliToGregorian(jalaliDateTime)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `jalaliDateTime` | `JalaliDateTime` | ** **Required.**                      |

With This Method We Can Convert Jalali Date To Gregorian Date With High Accuracy.

* ConvertJalaliToGregorian(year, month, day)

| Parameter | Type     | Description                |
| -------- | ------- | ------------------------- |
| `year` | `Int32` | ** **Required.**                      |
| `month` | `Int32` | ** **Required.**                      |
| `day` | `Int32` | ** **Required.**                      |

With This Method We Can Convert Jalali Date To Gregorian Date With High Accuracy.

