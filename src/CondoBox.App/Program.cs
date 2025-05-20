namespace CondoBox.App;

using CondoBox.Applications.Persist;
using CondoBox.Applications.Persist.Interface;
using CondoBox.Applications.Validator.EmployeeValid;
using CondoBox.Applications.Validator.EmployeeValid.Interface;
using CondoBox.Applications.Validator.ResidentValid;
using CondoBox.Applications.Validator.ResidentValid.Interface;
using CondoBox.Applications.Validator.SettingEmailValid;
using CondoBox.Applications.Validator.SettingEmailValid.Interface;
using CondoBox.Domain;
using CondoBox.Infrastructure.Data;
using CondoBox.Infrastructure.Repository;
using CondoBox.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var host = CreateHostBuilder().Build();

        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Resolve a tela inicial com dependências injetadas
        var form = host.Services.GetRequiredService<Form1>();
        Application.Run(form);
    }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                var dbFolder = @"C:\InfraCondoBox";
                var dbPath = Path.Combine(dbFolder, "InfraCondoBox.db");

                if (!Directory.Exists(dbFolder))
                {
                    Directory.CreateDirectory(dbFolder);
                }
                // Registrar DbContext com SQLite
                services.AddDbContext<AppDbContext>( options =>
                    options.UseSqlite($"Data Source={dbPath}")
                );
                // Registrar suas classes (Forms, Repositories, Services)
                services.AddScoped<Form1>();
                //Employee
                services.AddScoped<IEmployeeValid, EmployeeValid>();
                services.AddScoped<IEmployeePersist, EmployeePersist>();
                services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                //Resident
                services.AddScoped<IResidentValid, ResidentValid>();
                services.AddScoped<IResidentRepository, ResidentRepository>();
                services.AddScoped<IResidentPersist, ResidentPersist>();
                //Unit
                services.AddScoped<IUnitRepository, UnitRepository>();
                services.AddScoped<IUnitPersist, UnitPersist>();
                //Generic
                services.AddScoped<IGenericRepository, GenericRepository>();
                // SettingEmail
                services.AddScoped<ISettingEmailValid, SettingEmailValid>();
                services.AddScoped<ISettingEmailPersist, SettingEmailPersist>();
                services.AddScoped<ISettingEmailRepository, SettingEmailRepository>();
                //Mail
                services.AddScoped<IMailRepository, MailRepository>();
                services.AddScoped<IMailPersist, MailPersist>();

            });
    }
}