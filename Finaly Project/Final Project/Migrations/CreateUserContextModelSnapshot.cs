﻿// <auto-generated />
using Final_Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(CreateUserContext))]
    partial class CreateUserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final_Project.CreateUser", b =>
                {
                    b.Property<string>("CreateUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CreateUserId");

                    b.ToTable("CreateUser");

                    b.HasData(
                        new
                        {
                            CreateUserId = "Jacobjames310",
                            CompanyName = "James Trucking",
                            Email = "jacobjames339@yahoo.com",
                            FirstName = "Jacob",
                            LastName = "James",
                            Password = "jjames339"
                        },
                        new
                        {
                            CreateUserId = "Roshellec494",
                            CompanyName = "Chen Publishing",
                            Email = "rchen1020@gmail.com",
                            FirstName = "Roshelle",
                            LastName = "Chen",
                            Password = "rchen191"
                        },
                        new
                        {
                            CreateUserId = "NyckJ111",
                            CompanyName = "Johnson Ice-Cream",
                            Email = "njohnson104@yahoo.com",
                            FirstName = "Nyck",
                            LastName = "Johnson",
                            Password = "njohnson220"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
