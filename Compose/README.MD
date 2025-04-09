- Command to create a dbcontext class with MySql Connection Values Using a DATABASE FIRST.Using DOTNET 8.0.14:
  dotnet ef dbcontext scaffold "server=localhost;port=3306;database=my_database;user=my_user;password=my_password;" Pomelo.EntityFrameworkCore.MySql -s API -p Infrastructure --context MySqlContext --context-dir Data --output-dir Entities

-This command should create <root>/Infrastructure/Data/MySqlContext.cs -- context for MySql Server Database
-This command should create <root>/Infrastructure/Data/Entities/Product.cs --Classes created from database first approach
