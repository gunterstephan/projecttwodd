﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projecttwodd.Models;

namespace projecttwodd.Migrations
{
    [DbContext(typeof(IndividualContext))]
    [Migration("20201114153230_JobLevel")]
    partial class JobLevel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("projecttwodd.Models.Individual", b =>
                {
                    b.Property<int>("IndivId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Attrition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessTravel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DailyRate")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistanceFromHome")
                        .HasColumnType("int");

                    b.Property<int>("Education")
                        .HasColumnType("int");

                    b.Property<string>("EducationField")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvironmentSatisfaction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HourlyRate")
                        .HasColumnType("int");

                    b.Property<int>("JobInvolvement")
                        .HasColumnType("int");

                    b.Property<int>("JobLevel")
                        .HasColumnType("int");

                    b.Property<string>("JobRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobSatisfaction")
                        .HasColumnType("int");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthlyIncome")
                        .HasColumnType("int");

                    b.Property<int>("MonthlyRaate")
                        .HasColumnType("int");

                    b.Property<int>("NCompaniesWorked")
                        .HasColumnType("int");

                    b.Property<string>("OverEighteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Overtime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PercentSalaryHike")
                        .HasColumnType("int");

                    b.Property<int>("PerformanceRating")
                        .HasColumnType("int");

                    b.Property<int>("RelationshipSatisfaction")
                        .HasColumnType("int");

                    b.Property<int>("StandardHours")
                        .HasColumnType("int");

                    b.Property<int>("StockOptionLevel")
                        .HasColumnType("int");

                    b.Property<int>("TotalWorkingYears")
                        .HasColumnType("int");

                    b.Property<int>("TrainingTimesLastYear")
                        .HasColumnType("int");

                    b.Property<int>("WorkLifeBalance")
                        .HasColumnType("int");

                    b.Property<int>("YearsAtCompany")
                        .HasColumnType("int");

                    b.Property<int>("YearsInCurrentRole")
                        .HasColumnType("int");

                    b.Property<int>("YearsSinceLastPromotion")
                        .HasColumnType("int");

                    b.Property<int>("YearsWithCurrentManager")
                        .HasColumnType("int");

                    b.HasKey("IndivId");

                    b.ToTable("Individuals");
                });
#pragma warning restore 612, 618
        }
    }
}
