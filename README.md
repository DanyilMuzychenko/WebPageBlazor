# BlazorWeb

<p align="center">
      <img src="https://i.ibb.co/BnkWthD/Blazor-T5-dark-1200x303.png" alt="Project Logo" width="746">
</p>

<p align="center">
   <img src="https://img.shields.io/badge/Engine-VS%20Community%202022-8B00FF" alt="Engine">
   <img src="https://img.shields.io/badge/Version-17.5.4-0000ff" alt="Visual Studio Version">
   <img src="https://img.shields.io/badge/DataBase-SQL%20Server%20MS%2019.1-FFA500" alt="DataBase Version">
</p>

## About

Strona internetowa o tematyce ligi MLB dostarcza dynamiczne wyświetlanie wyników meczów, informacji o drużynach, aktualności oraz sponsorów w zależności od wybranej kategorii.

Wykorzystano Blazor WebAssembly do budowy interfejsu klienta, wykorzystując język C# i .NET. Backend oparty na technologii ASP.NET Core obsługuje przetwarzanie zapytań, interakcje z bazą danych SQL Server MG oraz dostarczanie danych na stronę klienta.
## Documentation

### Classes
- - `ProfileData.cs` -
- - `News.cs` - 
- - `Games.cs` - 
- - `GameStats.cs` 

### Razor Components
- - `Index.razor` - Strona główna z wynikami lokalnych meczów i innymi informacjami
- - `LogIn.razor` - Strona logowania z formularzem do wprowadzania loginu i hasła.
- - `News.razor` - 
- - `SignIn.razor` - Strona rejestracji z formularzem do wprowadzania e-mail, hasło, lokalizacja i numer telefonu. Korzystając z walidacji danych i AccountService, przesywa formularz i tworzy nowe konto użytkownika, po czym przekierowuje użytkownika na stronę logowania.
- - `Teams.razor` - 
## Developers

- Danyil Muzychenko (https://github.com/DanyilMuzychenko)
