using BankServices.Data;
using BankServices.Services;
using Microsoft.EntityFrameworkCore;

namespace BankServices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<BankDbContext>(
                context => context.UseNpgsql(builder.Configuration.GetConnectionString("Ef_Postgres_db"))
            );

            builder.Services.AddScoped<IAccountService, AccountService>();
            builder.Services.AddScoped<IBankService, BankService>();


            builder.Services.AddControllers();

            var app = builder.Build();

            // Apply database migrations and create the database if it doesn't exist.
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<BankDbContext>();
                dbContext.Database.Migrate();
            }

            // Configure the HTTP request pipeline.
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
