﻿// <auto-generated />
using System;
using LogisticCompany.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LogisticCompany.Migrations
{
    [DbContext(typeof(LogisticCompanyContext))]
    [Migration("20240627065040_UpdatePackages")]
    partial class UpdatePackages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LogisticCompany.Data.Models.auth.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("address");

                    b.Property<DateOnly>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("CURRENT_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("company_pk");

                    b.ToTable("company", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.CompanyRate", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<decimal>("HomeDeliveryRate")
                        .HasColumnType("numeric(12,4)")
                        .HasColumnName("home_delivery_rate");

                    b.Property<decimal>("OfficeDeliveryRate")
                        .HasColumnType("numeric(12,4)")
                        .HasColumnName("office_delivery_rate");

                    b.Property<decimal>("PackageRatePerGram")
                        .HasColumnType("numeric(12,4)")
                        .HasColumnName("package_rate_per_gram");

                    b.HasKey("CompanyId")
                        .HasName("company_rate_pk");

                    b.ToTable("company_rate", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.CompanyRevenue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date")
                        .HasDefaultValueSql("CURRENT_DATE");

                    b.Property<decimal>("Revenue")
                        .HasColumnType("numeric(12,4)")
                        .HasColumnName("revenue");

                    b.HasKey("Id")
                        .HasName("company_revenue_pk");

                    b.HasIndex("CompanyId");

                    b.ToTable("company_revenue", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateOnly>("HireDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("hire_date")
                        .HasDefaultValueSql("CURRENT_DATE");

                    b.Property<int>("OfficeId")
                        .HasColumnType("integer")
                        .HasColumnName("office_id");

                    b.Property<int>("PositionId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Salary")
                        .HasColumnType("numeric(12,4)")
                        .HasColumnName("salary");

                    b.HasKey("Id")
                        .HasName("employee_pk");

                    b.HasIndex("OfficeId");

                    b.HasIndex("PositionId");

                    b.ToTable("employee", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("office_pk");

                    b.HasIndex("CompanyId");

                    b.ToTable("office", null, t =>
                        {
                            t.HasCheckConstraint("CK_office_phone_number_Phone", "phone_number ~ '^[\\d\\s+-.()]*\\d[\\d\\s+-.()]*((ext\\.|ext|x)\\s*\\d+)?\\s*$'");
                        });
                });

            modelBuilder.Entity("LogisticCompany.models.Package", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("CourierId")
                        .HasColumnType("uuid")
                        .HasColumnName("courier_id");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("delivery_address");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("delivery_date");

                    b.Property<Guid?>("ReceiverEmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("receiver_employee_id");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("uuid")
                        .HasColumnName("receiver_id");

                    b.Property<Guid?>("SenderEmployeeId")
                        .HasColumnType("uuid")
                        .HasColumnName("sender_employee_id");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uuid")
                        .HasColumnName("sender_id");

                    b.Property<DateTime?>("ShippingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("shipping_date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<string>("TrackerNumber")
                        .HasColumnType("text")
                        .HasColumnName("tracker_number");

                    b.Property<bool>("toAdress")
                        .HasColumnType("boolean")
                        .HasColumnName("to_address");

                    b.HasKey("Id");

                    b.HasIndex("CourierId");

                    b.HasIndex("ReceiverEmployeeId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderEmployeeId");

                    b.HasIndex("SenderId");

                    b.ToTable("package", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.PackageInfo", b =>
                {
                    b.Property<Guid>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("package_id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<bool?>("Fragile")
                        .HasColumnType("boolean")
                        .HasColumnName("fragile");

                    b.Property<bool?>("Hazardous")
                        .HasColumnType("boolean")
                        .HasColumnName("hazardous");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric(12,4)")
                        .HasColumnName("weight");

                    b.HasKey("PackageId")
                        .HasName("package_info_pk");

                    b.ToTable("package_info", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("PositionInfo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("position_info");

                    b.Property<string>("PositionType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("position_type");

                    b.HasKey("Id");

                    b.HasIndex("PositionType")
                        .IsUnique();

                    b.ToTable("position", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LogisticCompany.Data.Models.auth.ApplicationUserRole", b =>
                {
                    b.HasOne("LogisticCompany.models.UserRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogisticCompany.models.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LogisticCompany.models.CompanyRate", b =>
                {
                    b.HasOne("LogisticCompany.models.Company", "Company")
                        .WithOne("CompanyRate")
                        .HasForeignKey("LogisticCompany.models.CompanyRate", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("company_rate_company_id_fk");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("LogisticCompany.models.CompanyRevenue", b =>
                {
                    b.HasOne("LogisticCompany.models.Company", "Company")
                        .WithMany("CompanyRevenues")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("company_revenue_company_id_fk");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("LogisticCompany.models.Employee", b =>
                {
                    b.HasOne("LogisticCompany.models.ApplicationUser", "User")
                        .WithOne("Employee")
                        .HasForeignKey("LogisticCompany.models.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("employee_user_id_fk");

                    b.HasOne("LogisticCompany.models.Office", "Office")
                        .WithMany("Employees")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("employee_office_id_fk");

                    b.HasOne("LogisticCompany.models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Position");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LogisticCompany.models.Office", b =>
                {
                    b.HasOne("LogisticCompany.models.Company", "Company")
                        .WithMany("Offices")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("office_company_id_fk");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("LogisticCompany.models.Package", b =>
                {
                    b.HasOne("LogisticCompany.models.Employee", "Courier")
                        .WithMany("DeliveredPackages")
                        .HasForeignKey("CourierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("package_courier_id_fk");

                    b.HasOne("LogisticCompany.models.Employee", "ReceiverEmployee")
                        .WithMany("RegisterAcceptedPackages")
                        .HasForeignKey("ReceiverEmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("package_receiver_employee_id_fk");

                    b.HasOne("LogisticCompany.models.ApplicationUser", "Receiver")
                        .WithMany("RecievedPackages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("package_receiver_id_fk");

                    b.HasOne("LogisticCompany.models.Employee", "SenderEmployee")
                        .WithMany("RegisterSentPackages")
                        .HasForeignKey("SenderEmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("package_sender_employee_id_fk");

                    b.HasOne("LogisticCompany.models.ApplicationUser", "Sender")
                        .WithMany("SendPackages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("package_sender_id_fk");

                    b.Navigation("Courier");

                    b.Navigation("Receiver");

                    b.Navigation("ReceiverEmployee");

                    b.Navigation("Sender");

                    b.Navigation("SenderEmployee");
                });

            modelBuilder.Entity("LogisticCompany.models.PackageInfo", b =>
                {
                    b.HasOne("LogisticCompany.models.Package", "Package")
                        .WithOne("PackageInfo")
                        .HasForeignKey("LogisticCompany.models.PackageInfo", "PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("package_package_info_id_fk");

                    b.Navigation("Package");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("LogisticCompany.models.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("LogisticCompany.models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("LogisticCompany.models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("LogisticCompany.models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LogisticCompany.models.ApplicationUser", b =>
                {
                    b.Navigation("Employee");

                    b.Navigation("RecievedPackages");

                    b.Navigation("SendPackages");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("LogisticCompany.models.Company", b =>
                {
                    b.Navigation("CompanyRate");

                    b.Navigation("CompanyRevenues");

                    b.Navigation("Offices");
                });

            modelBuilder.Entity("LogisticCompany.models.Employee", b =>
                {
                    b.Navigation("DeliveredPackages");

                    b.Navigation("RegisterAcceptedPackages");

                    b.Navigation("RegisterSentPackages");
                });

            modelBuilder.Entity("LogisticCompany.models.Office", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("LogisticCompany.models.Package", b =>
                {
                    b.Navigation("PackageInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("LogisticCompany.models.UserRole", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
