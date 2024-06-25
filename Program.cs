using CsharpAdvanced23_24.Data;
using CsharpAdvanced23_24.Repositories;
using CsharpAdvanced23_24.Services;
using Microsoft.EntityFrameworkCore;
// Mischa van den Berg S1132511 voor C Sharp Advanced 23/24

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CsharpAdvanced23_24Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CsharpAdvanced23_24Context") ?? throw new InvalidOperationException("Connection string 'CsharpAdvanced23_24Context' not found.")));

// Add services to the container.
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped(typeof(IAirbnbRepository<>), typeof(AirbnbRepository<>));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
