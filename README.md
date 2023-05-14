# ERP
Tablebricks ERP system is an enterprise resource planning software to manage customer data, order information, articles and other important data. Also integrated are a digital warehouses to retrieve all stocks in a short time.

## Requirements
* MariaDB Database
* ASP.NET Core 7 Hosting Bundle x64

## Features
* Login via LDAP or local account
* Create unlimited amount of data
* Permissions can be specifically assigned to individual users

## Installation
This app ships with a fully installer for appsettings and database. Simply run `ERP.Installer.exe` as administrator and follow the setup wizzard.

## Hosting
Hosting this app is quite simple. It supports all hosting possibilities from ASP.NET Core. For more information take a look on the [official docs from Microsoft](https://learn.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/server?view=aspnetcore-7.0).

## Recommendations
This app is toring uploaded files within the database. The default limit from MariaDB is 1MB per request. We highly recommend you increase this setting on your server to something which fits your use case. This limit can be increased by changing the value of `max_allowed_packet` from your MariaDb server.

This can usually be done within the `my.ini` file.


## NOT READY YET
This Software is still in development and should not be used right now since it's missing some major core functionalities.
