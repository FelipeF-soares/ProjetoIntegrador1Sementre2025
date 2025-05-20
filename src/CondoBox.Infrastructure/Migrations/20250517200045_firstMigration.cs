using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondoBox.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailSend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    EmailSender = table.Column<string>(type: "TEXT", nullable: false),
                    CryptoPassword = table.Column<string>(type: "TEXT", nullable: false),
                    SmtpClient = table.Column<string>(type: "TEXT", nullable: false),
                    SmtpPort = table.Column<string>(type: "TEXT", nullable: false),
                    EmailCC = table.Column<string>(type: "TEXT", nullable: false),
                    EmailSubject = table.Column<string>(type: "TEXT", nullable: false),
                    EmailBody = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Building = table.Column<string>(type: "TEXT", nullable: false),
                    Apt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTimeRegister = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CpfEmployee = table.Column<string>(type: "TEXT", nullable: false),
                    NameEmployee = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mails_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: false),
                    UnitId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residents_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Apt", "Building" },
                values: new object[,]
                {
                    { 1, "01", "BLOCO I" },
                    { 2, "02", "BLOCO I" },
                    { 3, "03", "BLOCO I" },
                    { 4, "04", "BLOCO I" },
                    { 5, "05", "BLOCO I" },
                    { 6, "11", "BLOCO I" },
                    { 7, "12", "BLOCO I" },
                    { 8, "13", "BLOCO I" },
                    { 9, "14", "BLOCO I" },
                    { 10, "15", "BLOCO I" },
                    { 11, "16", "BLOCO I" },
                    { 12, "21", "BLOCO I" },
                    { 13, "22", "BLOCO I" },
                    { 14, "23", "BLOCO I" },
                    { 15, "24", "BLOCO I" },
                    { 16, "25", "BLOCO I" },
                    { 17, "26", "BLOCO I" },
                    { 18, "31", "BLOCO I" },
                    { 19, "32", "BLOCO I" },
                    { 20, "33", "BLOCO I" },
                    { 21, "34", "BLOCO I" },
                    { 22, "35", "BLOCO I" },
                    { 23, "36", "BLOCO I" },
                    { 24, "41", "BLOCO I" },
                    { 25, "42", "BLOCO I" },
                    { 26, "43", "BLOCO I" },
                    { 27, "44", "BLOCO I" },
                    { 28, "45", "BLOCO I" },
                    { 29, "46", "BLOCO I" },
                    { 30, "51", "BLOCO I" },
                    { 31, "52", "BLOCO I" },
                    { 32, "53", "BLOCO I" },
                    { 33, "54", "BLOCO I" },
                    { 34, "55", "BLOCO I" },
                    { 35, "56", "BLOCO I" },
                    { 36, "61", "BLOCO I" },
                    { 37, "62", "BLOCO I" },
                    { 38, "63", "BLOCO I" },
                    { 39, "64", "BLOCO I" },
                    { 40, "65", "BLOCO I" },
                    { 41, "66", "BLOCO I" },
                    { 42, "71", "BLOCO I" },
                    { 43, "72", "BLOCO I" },
                    { 44, "73", "BLOCO I" },
                    { 45, "74", "BLOCO I" },
                    { 46, "75", "BLOCO I" },
                    { 47, "76", "BLOCO I" },
                    { 48, "81", "BLOCO I" },
                    { 49, "82", "BLOCO I" },
                    { 50, "83", "BLOCO I" },
                    { 51, "84", "BLOCO I" },
                    { 52, "85", "BLOCO I" },
                    { 53, "86", "BLOCO I" },
                    { 54, "91", "BLOCO I" },
                    { 55, "92", "BLOCO I" },
                    { 56, "93", "BLOCO I" },
                    { 57, "94", "BLOCO I" },
                    { 58, "95", "BLOCO I" },
                    { 59, "96", "BLOCO I" },
                    { 60, "101", "BLOCO I" },
                    { 61, "102", "BLOCO I" },
                    { 62, "103", "BLOCO I" },
                    { 63, "104", "BLOCO I" },
                    { 64, "105", "BLOCO I" },
                    { 65, "106", "BLOCO I" },
                    { 66, "111", "BLOCO I" },
                    { 67, "112", "BLOCO I" },
                    { 68, "113", "BLOCO I" },
                    { 69, "114", "BLOCO I" },
                    { 70, "115", "BLOCO I" },
                    { 71, "116", "BLOCO I" },
                    { 72, "121", "BLOCO I" },
                    { 73, "122", "BLOCO I" },
                    { 74, "123", "BLOCO I" },
                    { 75, "124", "BLOCO I" },
                    { 76, "125", "BLOCO I" },
                    { 77, "126", "BLOCO I" },
                    { 78, "131", "BLOCO I" },
                    { 79, "132", "BLOCO I" },
                    { 80, "133", "BLOCO I" },
                    { 81, "134", "BLOCO I" },
                    { 82, "135", "BLOCO I" },
                    { 83, "136", "BLOCO I" },
                    { 84, "01", "BLOCO II" },
                    { 85, "02", "BLOCO II" },
                    { 86, "03", "BLOCO II" },
                    { 87, "04", "BLOCO II" },
                    { 88, "05", "BLOCO II" },
                    { 89, "11", "BLOCO II" },
                    { 90, "12", "BLOCO II" },
                    { 91, "13", "BLOCO II" },
                    { 92, "14", "BLOCO II" },
                    { 93, "15", "BLOCO II" },
                    { 94, "16", "BLOCO II" },
                    { 95, "21", "BLOCO II" },
                    { 96, "22", "BLOCO II" },
                    { 97, "23", "BLOCO II" },
                    { 98, "24", "BLOCO II" },
                    { 99, "25", "BLOCO II" },
                    { 100, "26", "BLOCO II" },
                    { 101, "31", "BLOCO II" },
                    { 102, "32", "BLOCO II" },
                    { 103, "33", "BLOCO II" },
                    { 104, "34", "BLOCO II" },
                    { 105, "35", "BLOCO II" },
                    { 106, "36", "BLOCO II" },
                    { 107, "41", "BLOCO II" },
                    { 108, "42", "BLOCO II" },
                    { 109, "43", "BLOCO II" },
                    { 110, "44", "BLOCO II" },
                    { 111, "45", "BLOCO II" },
                    { 112, "46", "BLOCO II" },
                    { 113, "51", "BLOCO II" },
                    { 114, "52", "BLOCO II" },
                    { 115, "53", "BLOCO II" },
                    { 116, "54", "BLOCO II" },
                    { 117, "55", "BLOCO II" },
                    { 118, "56", "BLOCO II" },
                    { 119, "61", "BLOCO II" },
                    { 120, "62", "BLOCO II" },
                    { 121, "63", "BLOCO II" },
                    { 122, "64", "BLOCO II" },
                    { 123, "65", "BLOCO II" },
                    { 124, "66", "BLOCO II" },
                    { 125, "71", "BLOCO II" },
                    { 126, "72", "BLOCO II" },
                    { 127, "73", "BLOCO II" },
                    { 128, "74", "BLOCO II" },
                    { 129, "75", "BLOCO II" },
                    { 130, "76", "BLOCO II" },
                    { 131, "81", "BLOCO II" },
                    { 132, "82", "BLOCO II" },
                    { 133, "83", "BLOCO II" },
                    { 134, "84", "BLOCO II" },
                    { 135, "85", "BLOCO II" },
                    { 136, "86", "BLOCO II" },
                    { 137, "91", "BLOCO II" },
                    { 138, "92", "BLOCO II" },
                    { 139, "93", "BLOCO II" },
                    { 140, "94", "BLOCO II" },
                    { 141, "95", "BLOCO II" },
                    { 142, "96", "BLOCO II" },
                    { 143, "101", "BLOCO II" },
                    { 144, "102", "BLOCO II" },
                    { 145, "103", "BLOCO II" },
                    { 146, "104", "BLOCO II" },
                    { 147, "105", "BLOCO II" },
                    { 148, "106", "BLOCO II" },
                    { 149, "111", "BLOCO II" },
                    { 150, "112", "BLOCO II" },
                    { 151, "113", "BLOCO II" },
                    { 152, "114", "BLOCO II" },
                    { 153, "115", "BLOCO II" },
                    { 154, "116", "BLOCO II" },
                    { 155, "121", "BLOCO II" },
                    { 156, "122", "BLOCO II" },
                    { 157, "123", "BLOCO II" },
                    { 158, "124", "BLOCO II" },
                    { 159, "125", "BLOCO II" },
                    { 160, "126", "BLOCO II" },
                    { 161, "131", "BLOCO II" },
                    { 162, "132", "BLOCO II" },
                    { 163, "133", "BLOCO II" },
                    { 164, "134", "BLOCO II" },
                    { 165, "135", "BLOCO II" },
                    { 166, "136", "BLOCO II" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Cpf",
                table: "Employees",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mails_UnitId",
                table: "Mails",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_Cpf",
                table: "Residents",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Residents_UnitId",
                table: "Residents",
                column: "UnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailSend");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Mails");

            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
