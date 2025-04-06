using System;
using Microsoft.Extensions.Configuration;


//Read configuration from appsetting.json

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Değerleri oku
var appName = configuration["AppSettings:ApplicationName"];
var version = configuration["AppSettings:Version"];
var maxRetry = configuration["AppSettings:MaxRetry"];

Console.WriteLine($"Uygulama Adı: {appName}");
Console.WriteLine($"Versiyon: {version}");
Console.WriteLine($"MaxRetry: {maxRetry}");