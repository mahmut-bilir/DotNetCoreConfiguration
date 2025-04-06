using Microsoft.Extensions.Configuration;


// //Read configuration from appsetting.json

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// // Read values
// var appName = configuration["AppSettings:ApplicationName"];
// var version = configuration["AppSettings:Version"];
// var maxRetry = configuration["AppSettings:MaxRetry"];

// Console.WriteLine($"Application name: {appName}");
// Console.WriteLine($"Version: {version}");
// Console.WriteLine($"MaxRetry: {maxRetry}");

var appSettings = new AppSettings();
configuration.GetSection("AppSettings").Bind(appSettings);

Console.WriteLine($"Application : {appSettings.ApplicationName} | Version : {appSettings.Version}");