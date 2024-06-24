using CsharpAdvanced23_24.Data;
using Microsoft.EntityFrameworkCore;
// Mischa van den Berg S1132511 voor C Sharp Advanced 23/24

var builder = WebApplication.CreateBuilder(args);
// Mischa van den Berg S1132511 voor C Sharp Advanced 23/24

builder.Services.AddDbContext<CsharpAdvanced23_24Context>(options =>
// Mischa van den Berg S1132511 voor C Sharp Advanced 23/24

    options.UseSqlServer(builder.Configuration.GetConnectionString("CsharpAdvanced23_24Context") ?? throw new InvalidOperationException("Connection string 'CsharpAdvanced23_24Context' not found.")));

// Add services to the container.

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
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
