using Infrastructure.Data;
using Infrastructure.Seeding;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


if (!builder.Environment.IsDevelopment())
{
    builder.WebHost.UseUrls("http://0.0.0.0:80");

}


// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Necesario para Swagger
builder.Services.AddSwaggerGen();



// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MySqlContext>(options =>
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    });

}
else
{
    builder.Services.AddDbContext<MySqlContext>(options =>
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultDockerConnection");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    });

}



var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MySqlContext>();
    context.Database.Migrate(); // <-- this apply the migrations automaticaly
    DbSeeder.Seed(context);// <-- this apply run the seeder with basic data population
}

// Swagger Middleware
app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

app.Run();

