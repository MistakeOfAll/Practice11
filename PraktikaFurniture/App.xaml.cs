using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using PraktikaFurniture.Models;
using System;
using System.Windows;

namespace PraktikaFurniture
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var host = new HostBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<HardwareStoreDbContext>(options =>
                    {
                        options.UseSqlServer("Server=localhost;Database=HardwareStore;User Id=anton;Password=123; TrustServerCertificate=True;");
                    });
                })
                .Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var serviceProvider = serviceScope.ServiceProvider;
                try
                {
                    var dbContext = serviceProvider.GetRequiredService<HardwareStoreDbContext>();
                    dbContext.Database.Migrate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении миграций: {ex.Message}");
                }
            }
        }
    }
}
