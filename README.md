# .NET and Why You Should Care

[Slides](https://slides.levizitting.com/dotnet-and-why-you-should-care)

## Prerequisites

- [.NET 7](https://dotnet.microsoft.com/en-us/download)
- [.NET MAUI Workload](https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/install)

## Running

- Start by training the model
  - Navigate to the `SentimentModel` project directory
  - run `dotnet run -c Release`
- Start the ASP.NET Server
  - Navigate to the `Api` project directory
  - run `dotnet run` (this will take over the current terminal. Start an additional terminal for subsequent commands)
    - Note; You can access the swagger docs by going to http://localhost:5113/swagger/ in the browser once the app is running
- Run the MAUI App
  - Navigate to the `App` project directory
  - run `dotnet build -t:Run -f net7.0-maccatalyst`
    - Note: this will only work on a Mac. There is some [additional setup](https://learn.microsoft.com/en-us/dotnet/maui/windows/setup?view=net-maui-7.0) required to run/deploy the MAUI app on Windows.
