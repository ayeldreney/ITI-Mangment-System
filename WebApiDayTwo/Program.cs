using Microsoft.EntityFrameworkCore;
using WebApiDayTwo.BL;
using WebApiDayTwo.BL.Managers.Doctors;
using WebApiDayTwo.DAL.Data.Context;
using WebApiDayTwo.DAL.Repos.Doctors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region DataBase
//database

string? ConnectionString = builder.Configuration.GetConnectionString("Hospital") ;

builder.Services.AddDbContext<HospitalContext>(options=>options.UseSqlServer(ConnectionString));



#endregion

#region Repos

builder.Services.AddScoped<IDoctorRepo,DoctorsRepo>();
builder.Services.AddScoped<IDoctorManager, DoctorsManager>();

#endregion



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
