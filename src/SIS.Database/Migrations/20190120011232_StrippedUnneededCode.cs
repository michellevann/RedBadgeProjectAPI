using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class StrippedUnneededCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationTableAccess");

            migrationBuilder.DropTable(
                name: "ContactTableAccess");

            migrationBuilder.DropTable(
                name: "DemographicTableAccess");

            migrationBuilder.DropTable(
                name: "EducationTableAccess");

            migrationBuilder.DropTable(
                name: "ExperienceTableAccess");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateModified = table.Column<DateTimeOffset>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "ContactTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "DemographicTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    Ethnicity = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Married = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemographicTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "EducationTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    CollegeGraduationInfo = table.Column<string>(nullable: true),
                    CurrentlyEnrolled = table.Column<bool>(nullable: false),
                    FieldOfStudy = table.Column<string>(nullable: true),
                    HighSchoolGraduationInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTableAccess", x => x.ApplicationEntityId);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceTableAccess",
                columns: table => new
                {
                    ApplicationEntityId = table.Column<Guid>(nullable: false),
                    EmploymentStatus = table.Column<string>(nullable: true),
                    IncomeLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceTableAccess", x => x.ApplicationEntityId);
                });
        }
    }
}
