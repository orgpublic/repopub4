using Microsoft.EntityFrameworkCore;
using NonCQRSWebApi.Data;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("InMemoryDbContext") ?? throw new InvalidOperationException("Connection string 'InMemoryDbContext' not found.");

// Add services to the container.
builder.Services.AddDbContext<InMemoryDbContext>((options) => options.UseInMemoryDatabase( databaseName:"InMemoryDb"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

//app.MapPlayerEndpoints();

app.Run();
