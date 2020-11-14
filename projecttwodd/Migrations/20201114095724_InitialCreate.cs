using Microsoft.EntityFrameworkCore.Migrations;

namespace projecttwodd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    IndivId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attrition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessTravel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyRate = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistanceFromHome = table.Column<int>(type: "int", nullable: false),
                    Education = table.Column<int>(type: "int", nullable: false),
                    EducationField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvironmentSatisfaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HourlyRate = table.Column<int>(type: "int", nullable: false),
                    JobInvolvement = table.Column<int>(type: "int", nullable: false),
                    JobRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobSatisfaction = table.Column<int>(type: "int", nullable: false),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlyIncome = table.Column<int>(type: "int", nullable: false),
                    MonthlyRaate = table.Column<int>(type: "int", nullable: false),
                    NCompaniesWorked = table.Column<int>(type: "int", nullable: false),
                    OverEighteen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Overtime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentSalaryHike = table.Column<int>(type: "int", nullable: false),
                    PerformanceRating = table.Column<int>(type: "int", nullable: false),
                    RelationshipSatisfaction = table.Column<int>(type: "int", nullable: false),
                    StandardHours = table.Column<int>(type: "int", nullable: false),
                    StockOptionLevel = table.Column<int>(type: "int", nullable: false),
                    TotalWorkingYears = table.Column<int>(type: "int", nullable: false),
                    TrainingTimesLastYear = table.Column<int>(type: "int", nullable: false),
                    WorkLifeBalance = table.Column<int>(type: "int", nullable: false),
                    YearsAtCompany = table.Column<int>(type: "int", nullable: false),
                    YearsInCurrentRole = table.Column<int>(type: "int", nullable: false),
                    YearsSinceLastPromotion = table.Column<int>(type: "int", nullable: false),
                    YearsWithCurrentManager = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.IndivId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Individuals");
        }
    }
}
