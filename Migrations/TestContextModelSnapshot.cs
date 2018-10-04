﻿// <auto-generated />
using System;
using ConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp.Domain.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnotherExternalId");

                    b.Property<int?>("ExternalId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("ConsoleApp.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExternalId")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ConsoleApp.Domain.UserTask", b =>
                {
                    b.Property<int?>("ExternalTaskId");

                    b.Property<int?>("ExternalUserId");

                    b.HasKey("ExternalTaskId", "ExternalUserId");

                    b.HasIndex("ExternalUserId");

                    b.ToTable("ExternalUser");
                });

            modelBuilder.Entity("ConsoleApp.Domain.UserTask", b =>
                {
                    b.HasOne("ConsoleApp.Domain.Task", "Task")
                        .WithMany("UserTasks")
                        .HasForeignKey("ExternalTaskId")
                        .HasPrincipalKey("ExternalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp.Domain.User", "User")
                        .WithMany("UserTasks")
                        .HasForeignKey("ExternalUserId")
                        .HasPrincipalKey("ExternalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
