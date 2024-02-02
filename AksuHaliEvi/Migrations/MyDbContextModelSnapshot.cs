﻿// <auto-generated />
using System;
using AksuHaliEvi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AksuHaliEvi.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AksuHaliEvi.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MethodID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentMethodMethodID")
                        .HasColumnType("int");

                    b.HasKey("ExpenseID");

                    b.HasIndex("PaymentMethodMethodID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("AksuHaliEvi.Income", b =>
                {
                    b.Property<int>("IncomeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IncomeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MethodID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentMethodMethodID")
                        .HasColumnType("int");

                    b.HasKey("IncomeID");

                    b.HasIndex("PaymentMethodMethodID");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("AksuHaliEvi.PaymentMethod", b =>
                {
                    b.Property<int>("MethodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MethodName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MethodID");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("AksuHaliEvi.Turnover", b =>
                {
                    b.Property<int>("TurnoverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalExpense")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalIncome")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("TurnoverID");

                    b.ToTable("Turnovers");
                });

            modelBuilder.Entity("AksuHaliEvi.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AksuHaliEvi.Expense", b =>
                {
                    b.HasOne("AksuHaliEvi.PaymentMethod", "PaymentMethod")
                        .WithMany("Expenses")
                        .HasForeignKey("PaymentMethodMethodID");
                });

            modelBuilder.Entity("AksuHaliEvi.Income", b =>
                {
                    b.HasOne("AksuHaliEvi.PaymentMethod", "PaymentMethod")
                        .WithMany("Incomes")
                        .HasForeignKey("PaymentMethodMethodID");
                });
#pragma warning restore 612, 618
        }
    }
}
