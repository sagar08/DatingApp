Dotnet 

Entity framework code first
Json package -
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson --version 3.1.0
 
- Adding new table from code to datbase
dotnet ef migrations add AddedUserEntity
dotnet ef database update

- Update existing table 
dotnet ef migrations add ExtendedUserClass


- Revert migrations if database is not updated
dotnet ef migrations remove
-- This will remove the last added/updated tables schema  

- Revert migrations after database update dotnet
dotnet ef migrations database update <LastAddedMigrationName>
Note: This does not support for SQLite



package
 - dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 3.1.0

Git 
Remove item
 git rm launch.json --cached










VS code extensions
-------------------------------------
dotnet Core
1. C#
2. C# Extensions

Angular
1. angular snippets
2. Angular files
3. Angular Language Service
4. Auto Rename Tag
5. Bracket Pair Colorizer 2
6. Debugger for Chrome
7. Material Icon Theme
8. Prettier - Code formatter
9. TSLint
10.angular2-switcher
11. Auto Import

