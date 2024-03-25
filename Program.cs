
using StudentSystem_WebApiDB.Data;
using StudentSystem_WebApiDB.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentSystem_WebApiDB.Services;
using StudentSystem_WebApiDB.Interface;

namespace StudentSystem_WebApiDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(builder.Configuration.GetConnectionString("MainConn")));

            builder.Services.AddScoped<IStudentService,StudentService>();
            builder.Services.AddScoped<ILectorService, LectorService>();
           
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
        }
    }
}
