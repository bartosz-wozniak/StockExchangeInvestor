# StockExchangeInvestor

This ASP .NET MVC application entitled "Computer system to aid investing at the Warsaw Stock Exchange" is aimed to
verify effectiveness of chosen elements of technical analysis, namely technical indicators, in stock
investing. The users of the application can create an account and view stock charts. The key
features include a module that allows users to perform a simulation of a defined investment
strategy and a module designed to manage an investment wallet. The analysis of simulations’
results has been made to investigate whether using only technical indicators can be an effective
method of investment strategy planning.

This is ASP .NET MVC app with Entity Framework and MS SQL Server. Also Autofac was used for dependency injection, log4net for logging and DbUp for migrations. Bootstrap UI was used in front-end. Front-end libraries were installed with bower. Also a job was created to sync data from GPW. Except SQL database, cahce was used to make application load much faster. 

Website is deployed to Azure: https://ministockexchange.azurewebsites.net/

## Purpose

This project was developed as my B.Sc. Thesis. It was a group project and it allowed me to get more practice in creating ASP.NET MVC applications.

## Licence

This project is under the MIT License.
