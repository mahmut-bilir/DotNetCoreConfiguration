using System;
using Microsoft.Extensions.Configuration;


//Read configuration from appsetting.json

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Read values
var appName = configuration["AppSettings:ApplicationName"];
var version = configuration["AppSettings:Version"];
var maxRetry = configuration["AppSettings:MaxRetry"];

Console.WriteLine($"Application name: {appName}");
Console.WriteLine($"Version: {version}");
Console.WriteLine($"MaxRetry: {maxRetry}");