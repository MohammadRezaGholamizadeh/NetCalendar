using DotNetReportsEngine.ReadmeGeneration;
using DotNetReportsEngine.ReadmeGeneration.Details;
using NetCalendar;

var generatedReadme =
    new ReadmeGenerator()
        .AddAssembly(typeof(NetCalendars).Assembly)
        .SetProjectDetail("NetCalendar", "This Package Is For Using The Different TypeOf DateTime And Converting The Date Together With High Accuracy And Most Easily That You Can Imagine . This Package Support Hijri Calendar , Jalali Calander (Persian Calendar) , Gregorian Calendar" + Environment.NewLine +
        "This Is The Best Tools For Converting Date To Each Other. Enjoy It" + Environment.NewLine)
        .AddFeatures("Add Date And Time To Calendar", "Infrastructure Of Managing Time In Calendar", "Easy Way To Convert Gregorian To Jalali And Jalali To Gregorian")
        .SetLogo(new Logo()
        {
            Title = "Logo",
            LogoLink = "https://raw.githubusercontent.com/MohammadRezaGholamizadeh/NetCalendar/main/ReadmeCreator/Files/NetCalendar.png"
        })
        .AddAuthor("@Mohammadreza Gholamizadeh [Phoenix]", "https://github.com/MohammadRezaGholamizadeh")
        .SetGitHub_AboutMe("I MohammadReza Gholamizadeh. I`m Dotnet Software Developer That Always Try To Make All things Easy for Developing. Please Star the Project And Package to Cover And Enjoy When Using It.")
        .AddGitHub_Links(new List<GitHubLink>()
        {
            new GitHubLink()
            {
                Title = "Source Code",
                LogoType = LogoLinkType.Github,
                Link = "https://github.com/MohammadRezaGholamizadeh/NetCalendar/tree/main"
            },
            new GitHubLink()
            {
                LogoType = LogoLinkType.Github,
                Title = "MohammadReza Gholamizadeh GitHub",
                Link = "https://github.com/MohammadRezaGholamizadeh",
            },
            new GitHubLink()
            {
                LogoType = LogoLinkType.Github,
                Title = "Readme File",
                Link = "https://github.com/MohammadRezaGholamizadeh/NetCalendar/blob/main/README.md",
            },
            new GitHubLink()
            {
                LogoType = LogoLinkType.Nuget,
                Title = "Nuget",
                Link = "https://www.nuget.org/profiles/MohammadrezaGholamizadeh_Phoenix"
            },
            new GitHubLink()
            {
                LogoType = LogoLinkType.LinkedIn,
                Title = "LinkedIn",
                Link = "https://www.linkedin.com/in/mohammadreza-gholamizadeh-b94b1521b/"
            }
        })
        .SetLicense(new License()
        {
            Title = "Apache-2.0 license",
            LicenseLink = "https://github.com/MohammadRezaGholamizadeh/NetCalendar/blob/main/LICENSE"
        })
        .AddCustomText("Get Start With Sample Code", "You Can Use This Package And Tools Like This !!!")
        .AddCustomText("Converting Gregorian To Jalali", "Use Tools Like This !!!")
        .SetLogo("GregorianToJalali", "https://raw.githubusercontent.com/MohammadRezaGholamizadeh/NetCalendar/refs/heads/dev/ReadmeCreator/Files/JalaliToGregorian.png")
        .AddCustomText("Converting Jalali To Gregorian", "Use Tools Like This !!!")
        .SetLogo("JalaliToGregorian", "https://raw.githubusercontent.com/MohammadRezaGholamizadeh/NetCalendar/refs/heads/dev/ReadmeCreator/Files/JalaliToGregorian.png")
        .AddCustomBashCommand("Package Manager", @"NuGet\Install-Package NetCalendar -Version 2024.04.20")
        .RenderAllAssembliesToText()
        .GetText();

File.WriteAllText(@$"C:\NetCalendarRepo\NetCalendar\Src\NetCalendar\README.md", generatedReadme);