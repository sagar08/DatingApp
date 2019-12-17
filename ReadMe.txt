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