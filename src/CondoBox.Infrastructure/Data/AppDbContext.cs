using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CondoBox.Domain;

namespace CondoBox.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base (options){}
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Resident> Residents { get; set; }
    public DbSet<Mail> Mails { get; set; }
    public DbSet<EmailSetting> EmailSend { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasIndex(employee => employee.Cpf).IsUnique();
        modelBuilder.Entity<Resident>().HasIndex(resident => resident.Cpf).IsUnique();

        modelBuilder.Entity<Unit>()
                    .HasMany(unit => unit.Residents)
                    .WithOne(resident => resident.Unit)
                    .HasForeignKey(resident => resident.UnitId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Unit>()
                    .HasMany(unit => unit.Mails)
                    .WithOne(mail => mail.Unit)
                    .HasForeignKey(mail => mail.UnitId)
                    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<EmailSetting>()
                    .HasKey(email => email.Id);
        modelBuilder.Entity<EmailSetting>()
                    .Property(email => email.Id)
                    .ValueGeneratedNever();

        modelBuilder.Entity<Unit>().HasData(
            new Unit { Id = 1, Building = "BLOCO I", Apt = "01" },
            new Unit { Id = 2, Building = "BLOCO I", Apt = "02" },
            new Unit { Id = 3, Building = "BLOCO I", Apt = "03" },
            new Unit { Id = 4, Building = "BLOCO I", Apt = "04" },
            new Unit { Id = 5, Building = "BLOCO I", Apt = "05" },
            new Unit { Id = 6, Building = "BLOCO I", Apt = "11" },
            new Unit { Id = 7, Building = "BLOCO I", Apt = "12" },
            new Unit { Id = 8, Building = "BLOCO I", Apt = "13" },
            new Unit { Id = 9, Building = "BLOCO I", Apt = "14" },
            new Unit { Id = 10, Building = "BLOCO I", Apt = "15" },
            new Unit { Id = 11, Building = "BLOCO I", Apt = "16" },
            new Unit { Id = 12, Building = "BLOCO I", Apt = "21" },
            new Unit { Id = 13, Building = "BLOCO I", Apt = "22" },
            new Unit { Id = 14, Building = "BLOCO I", Apt = "23" },
            new Unit { Id = 15, Building = "BLOCO I", Apt = "24" },
            new Unit { Id = 16, Building = "BLOCO I", Apt = "25" },
            new Unit { Id = 17, Building = "BLOCO I", Apt = "26" },
            new Unit { Id = 18, Building = "BLOCO I", Apt = "31" },
            new Unit { Id = 19, Building = "BLOCO I", Apt = "32" },
            new Unit { Id = 20, Building = "BLOCO I", Apt = "33" },
            new Unit { Id = 21, Building = "BLOCO I", Apt = "34" },
            new Unit { Id = 22, Building = "BLOCO I", Apt = "35" },
            new Unit { Id = 23, Building = "BLOCO I", Apt = "36" },
            new Unit { Id = 24, Building = "BLOCO I", Apt = "41" },
            new Unit { Id = 25, Building = "BLOCO I", Apt = "42" },
            new Unit { Id = 26, Building = "BLOCO I", Apt = "43" },
            new Unit { Id = 27, Building = "BLOCO I", Apt = "44" },
            new Unit { Id = 28, Building = "BLOCO I", Apt = "45" },
            new Unit { Id = 29, Building = "BLOCO I", Apt = "46" },
            new Unit { Id = 30, Building = "BLOCO I", Apt = "51" },
            new Unit { Id = 31, Building = "BLOCO I", Apt = "52" },
            new Unit { Id = 32, Building = "BLOCO I", Apt = "53" },
            new Unit { Id = 33, Building = "BLOCO I", Apt = "54" },
            new Unit { Id = 34, Building = "BLOCO I", Apt = "55" },
            new Unit { Id = 35, Building = "BLOCO I", Apt = "56" },
            new Unit { Id = 36, Building = "BLOCO I", Apt = "61" },
            new Unit { Id = 37, Building = "BLOCO I", Apt = "62" },
            new Unit { Id = 38, Building = "BLOCO I", Apt = "63" },
            new Unit { Id = 39, Building = "BLOCO I", Apt = "64" },
            new Unit { Id = 40, Building = "BLOCO I", Apt = "65" },
            new Unit { Id = 41, Building = "BLOCO I", Apt = "66" },
            new Unit { Id = 42, Building = "BLOCO I", Apt = "71" },
            new Unit { Id = 43, Building = "BLOCO I", Apt = "72" },
            new Unit { Id = 44, Building = "BLOCO I", Apt = "73" },
            new Unit { Id = 45, Building = "BLOCO I", Apt = "74" },
            new Unit { Id = 46, Building = "BLOCO I", Apt = "75" },
            new Unit { Id = 47, Building = "BLOCO I", Apt = "76" },
            new Unit { Id = 48, Building = "BLOCO I", Apt = "81" },
            new Unit { Id = 49, Building = "BLOCO I", Apt = "82" },
            new Unit { Id = 50, Building = "BLOCO I", Apt = "83" },
            new Unit { Id = 51, Building = "BLOCO I", Apt = "84" },
            new Unit { Id = 52, Building = "BLOCO I", Apt = "85" },
            new Unit { Id = 53, Building = "BLOCO I", Apt = "86" },
            new Unit { Id = 54, Building = "BLOCO I", Apt = "91" },
            new Unit { Id = 55, Building = "BLOCO I", Apt = "92" },
            new Unit { Id = 56, Building = "BLOCO I", Apt = "93" },
            new Unit { Id = 57, Building = "BLOCO I", Apt = "94" },
            new Unit { Id = 58, Building = "BLOCO I", Apt = "95" },
            new Unit { Id = 59, Building = "BLOCO I", Apt = "96" },
            new Unit { Id = 60, Building = "BLOCO I", Apt = "101" },
            new Unit { Id = 61, Building = "BLOCO I", Apt = "102" },
            new Unit { Id = 62, Building = "BLOCO I", Apt = "103" },
            new Unit { Id = 63, Building = "BLOCO I", Apt = "104" },
            new Unit { Id = 64, Building = "BLOCO I", Apt = "105" },
            new Unit { Id = 65, Building = "BLOCO I", Apt = "106" },
            new Unit { Id = 66, Building = "BLOCO I", Apt = "111" },
            new Unit { Id = 67, Building = "BLOCO I", Apt = "112" },
            new Unit { Id = 68, Building = "BLOCO I", Apt = "113" },
            new Unit { Id = 69, Building = "BLOCO I", Apt = "114" },
            new Unit { Id = 70, Building = "BLOCO I", Apt = "115" },
            new Unit { Id = 71, Building = "BLOCO I", Apt = "116" },
            new Unit { Id = 72, Building = "BLOCO I", Apt = "121" },
            new Unit { Id = 73, Building = "BLOCO I", Apt = "122" },
            new Unit { Id = 74, Building = "BLOCO I", Apt = "123" },
            new Unit { Id = 75, Building = "BLOCO I", Apt = "124" },
            new Unit { Id = 76, Building = "BLOCO I", Apt = "125" },
            new Unit { Id = 77, Building = "BLOCO I", Apt = "126" },
            new Unit { Id = 78, Building = "BLOCO I", Apt = "131" },
            new Unit { Id = 79, Building = "BLOCO I", Apt = "132" },
            new Unit { Id = 80, Building = "BLOCO I", Apt = "133" },
            new Unit { Id = 81, Building = "BLOCO I", Apt = "134" },
            new Unit { Id = 82, Building = "BLOCO I", Apt = "135" },
            new Unit { Id = 83, Building = "BLOCO I", Apt = "136" },
            // BLOCO II começa aqui
            new Unit { Id = 84, Building = "BLOCO II", Apt = "01" },
            new Unit { Id = 85, Building = "BLOCO II", Apt = "02" },
            new Unit { Id = 86, Building = "BLOCO II", Apt = "03" },
            new Unit { Id = 87, Building = "BLOCO II", Apt = "04" },
            new Unit { Id = 88, Building = "BLOCO II", Apt = "05" },
            new Unit { Id = 89, Building = "BLOCO II", Apt = "11" },
            new Unit { Id = 90, Building = "BLOCO II", Apt = "12" },
            new Unit { Id = 91, Building = "BLOCO II", Apt = "13" },
            new Unit { Id = 92, Building = "BLOCO II", Apt = "14" },
            new Unit { Id = 93, Building = "BLOCO II", Apt = "15" },
            new Unit { Id = 94, Building = "BLOCO II", Apt = "16" },
            new Unit { Id = 95, Building = "BLOCO II", Apt = "21" },
            new Unit { Id = 96, Building = "BLOCO II", Apt = "22" },
            new Unit { Id = 97, Building = "BLOCO II", Apt = "23" },
            new Unit { Id = 98, Building = "BLOCO II", Apt = "24" },
            new Unit { Id = 99, Building = "BLOCO II", Apt = "25" },
            new Unit { Id = 100, Building = "BLOCO II", Apt = "26" },
            new Unit { Id = 101, Building = "BLOCO II", Apt = "31" },
            new Unit { Id = 102, Building = "BLOCO II", Apt = "32" },
            new Unit { Id = 103, Building = "BLOCO II", Apt = "33" },
            new Unit { Id = 104, Building = "BLOCO II", Apt = "34" },
            new Unit { Id = 105, Building = "BLOCO II", Apt = "35" },
            new Unit { Id = 106, Building = "BLOCO II", Apt = "36" },
            new Unit { Id = 107, Building = "BLOCO II", Apt = "41" },
            new Unit { Id = 108, Building = "BLOCO II", Apt = "42" },
            new Unit { Id = 109, Building = "BLOCO II", Apt = "43" },
            new Unit { Id = 110, Building = "BLOCO II", Apt = "44" },
            new Unit { Id = 111, Building = "BLOCO II", Apt = "45" },
            new Unit { Id = 112, Building = "BLOCO II", Apt = "46" },
            new Unit { Id = 113, Building = "BLOCO II", Apt = "51" },
            new Unit { Id = 114, Building = "BLOCO II", Apt = "52" },
            new Unit { Id = 115, Building = "BLOCO II", Apt = "53" },
            new Unit { Id = 116, Building = "BLOCO II", Apt = "54" },
            new Unit { Id = 117, Building = "BLOCO II", Apt = "55" },
            new Unit { Id = 118, Building = "BLOCO II", Apt = "56" },
            new Unit { Id = 119, Building = "BLOCO II", Apt = "61" },
            new Unit { Id = 120, Building = "BLOCO II", Apt = "62" },
            new Unit { Id = 121, Building = "BLOCO II", Apt = "63" },
            new Unit { Id = 122, Building = "BLOCO II", Apt = "64" },
            new Unit { Id = 123, Building = "BLOCO II", Apt = "65" },
            new Unit { Id = 124, Building = "BLOCO II", Apt = "66" },
            new Unit { Id = 125, Building = "BLOCO II", Apt = "71" },
            new Unit { Id = 126, Building = "BLOCO II", Apt = "72" },
            new Unit { Id = 127, Building = "BLOCO II", Apt = "73" },
            new Unit { Id = 128, Building = "BLOCO II", Apt = "74" },
            new Unit { Id = 129, Building = "BLOCO II", Apt = "75" },
            new Unit { Id = 130, Building = "BLOCO II", Apt = "76" },
            new Unit { Id = 131, Building = "BLOCO II", Apt = "81" },
            new Unit { Id = 132, Building = "BLOCO II", Apt = "82" },
            new Unit { Id = 133, Building = "BLOCO II", Apt = "83" },
            new Unit { Id = 134, Building = "BLOCO II", Apt = "84" },
            new Unit { Id = 135, Building = "BLOCO II", Apt = "85" },
            new Unit { Id = 136, Building = "BLOCO II", Apt = "86" },
            new Unit { Id = 137, Building = "BLOCO II", Apt = "91" },
            new Unit { Id = 138, Building = "BLOCO II", Apt = "92" },
            new Unit { Id = 139, Building = "BLOCO II", Apt = "93" },
            new Unit { Id = 140, Building = "BLOCO II", Apt = "94" },
            new Unit { Id = 141, Building = "BLOCO II", Apt = "95" },
            new Unit { Id = 142, Building = "BLOCO II", Apt = "96" },
            new Unit { Id = 143, Building = "BLOCO II", Apt = "101" },
            new Unit { Id = 144, Building = "BLOCO II", Apt = "102" },
            new Unit { Id = 145, Building = "BLOCO II", Apt = "103" },
            new Unit { Id = 146, Building = "BLOCO II", Apt = "104" },
            new Unit { Id = 147, Building = "BLOCO II", Apt = "105" },
            new Unit { Id = 148, Building = "BLOCO II", Apt = "106" },
            new Unit { Id = 149, Building = "BLOCO II", Apt = "111" },
            new Unit { Id = 150, Building = "BLOCO II", Apt = "112" },
            new Unit { Id = 151, Building = "BLOCO II", Apt = "113" },
            new Unit { Id = 152, Building = "BLOCO II", Apt = "114" },
            new Unit { Id = 153, Building = "BLOCO II", Apt = "115" },
            new Unit { Id = 154, Building = "BLOCO II", Apt = "116" },
            new Unit { Id = 155, Building = "BLOCO II", Apt = "121" },
            new Unit { Id = 156, Building = "BLOCO II", Apt = "122" },
            new Unit { Id = 157, Building = "BLOCO II", Apt = "123" },
            new Unit { Id = 158, Building = "BLOCO II", Apt = "124" },
            new Unit { Id = 159, Building = "BLOCO II", Apt = "125" },
            new Unit { Id = 160, Building = "BLOCO II", Apt = "126" },
            new Unit { Id = 161, Building = "BLOCO II", Apt = "131" },
            new Unit { Id = 162, Building = "BLOCO II", Apt = "132" },
            new Unit { Id = 163, Building = "BLOCO II", Apt = "133" },
            new Unit { Id = 164, Building = "BLOCO II", Apt = "134" },
            new Unit { Id = 165, Building = "BLOCO II", Apt = "135" },
            new Unit { Id = 166, Building = "BLOCO II", Apt = "136" }
            );

        base.OnModelCreating(modelBuilder);
    }
}
