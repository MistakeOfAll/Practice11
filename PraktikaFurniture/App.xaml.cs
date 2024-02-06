using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

            // Инициализация и конфигурация служб
            var host = new HostBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<HardwareStoreDbContext>(options =>
                    {
                        options.UseNpgsql("Server=localhost;Database=HardwareStore;UserName=anton;Password=123");
                    });
                })
                .Build();

            // Запуск приложения
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
