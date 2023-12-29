
using Microsoft.EntityFrameworkCore;
using PolyFood.Business.Service.Impl;
using PolyFood.Business.Service.IService;
using PolyFood.Repository.Context;
using PolyFood.Repository.Repository.Impl;
using PolyFood.Repository.Repository.IRepo;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
{
    var service = builder.Services;
    var configuration = builder.Configuration;

    service.AddDbContext<AppDbContext>(
       option
           => option.UseSqlServer("Server = ADMIN-PC ;Database = test ;Integrated Security=True; TrustServerCertificate=True")
   );

    service.AddScoped<IDecentralizationRepo,DecentralizationRepo>();
    service.AddScoped<IAccountService, AccountService>();
    service.AddScoped<IAccountRepo, AccountRepo>();
    service.AddScoped<IJwtService, JwtService>();
    service.AddScoped<ITokenRepo, TokenRepo>();
    service.AddScoped<IUserRepo,UserRepo>();
    service.AddScoped<IMailSender, MailSender>();

}

builder.Services.AddControllers();
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
