# ASP.NET Core Razor Pages Bakery Site

## Introduction

This is an ASP.NET Core Razor Pages port of the [ASP.NET Web Pages](https://www.asp.net/web-pages) Bakery template site as featured in the series of tutorials on the [Learn Razor Pages web site](https://www.learnrazorpages.com/razor-pages/walkthroughs/bakery). 

![Razor Pages Bakery](https://www.learnrazorpages.com/images/27-11-2018-09-03-27.jpg)

This version of the project includes all the features covered in the first 7 tutorials in the series (up to and including [Adding Email](https://www.learnrazorpages.com/razor-pages/walkthroughs/bakery/email)). 

## Get Started

Download or clone this repository and then open the Bakery folder within Visual Studio Code. You should be prompted to add missing assets required to build and debug the project, and to perform a restore. Agree to both prompts. Once completed, execute the `dotnet run` command to launch the web site.

This version differs from the version that you create by following the series in one respect. The database file has not been included. Instead, the `Configure` method of the `Startup` class includes the following line of code:

```csharp
context.Database.Migrate();
```
This will cause the creation of the database file and the pending migration being executed.
