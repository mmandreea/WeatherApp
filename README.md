This desktop application, developed in C# using Windows Forms, fetches and displays real-time weather data for any global city by integrating with the OpenWeatherMap API.


Language: C#
Platform: .NET Framework / .NET Core (Windows Forms)
External API: OpenWeatherMap API
JSON Deserialization: Newtonsoft.Json (Json.NET)
Networking: System.Net.WebClient

Code Structure:
The project is divided into two main files:
1. Form1.cs
This file handles the application logic and UI interaction:
getWeather(): The core method that constructs the API URL, downloads the JSON data using WebClient, and deserializes it into the C# model.
convertDateTime(): A utility function that converts the UNIX Timestamp (seconds) received from the API into a local C# DateTime object.
Data Display: Logic will update UI controls (condition_label, details_label, picIcon, etc.) with the processed weather information.
2. ModelWeather.cs
This file contains the data model classes required for JSON deserialization. The nested classes (coord, weather, main, wind, sys, and root) mirror the exact hierarchical structure of the OpenWeatherMap JSON response.

<img width="1071" height="736" alt="image" src="https://github.com/user-attachments/assets/67678fa3-9f85-4fd6-874d-20f246450293" />
