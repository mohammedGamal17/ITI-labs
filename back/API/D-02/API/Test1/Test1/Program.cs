
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Test1.Models;
using Test1.Service;

namespace Test1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            builder.Services.AddMvc()
                .AddJsonOptions(option =>
                {
                    option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                    //option.JsonSerializerOptions.PropertyNamingPolicy = null;
                    //option.JsonSerializerOptions.DictionaryKeyPolicy = null;
                });

            builder.Services.AddDbContext<SchoolContext>(
                options => options
                .UseSqlServer(
                    builder.Configuration.GetConnectionString("schoolCon")
                    )
                );

            builder.Services.AddScoped<IRepository<Department>, DepartmentService>();


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
            app.UseCors("AllowAll");

            app.Run();
        }
    }
}