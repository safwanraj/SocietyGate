﻿// <auto-generated />
using System;
using GateCommunityMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GateCommunityMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230614061129_revis1")]
    partial class revis1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GateCommunityMvc.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Demos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Societyname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("demos");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Family", b =>
                {
                    b.Property<int>("FamilyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filepath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("relationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("residentid")
                        .HasColumnType("int");

                    b.HasKey("FamilyId");

                    b.HasIndex("residentid");

                    b.ToTable("familys");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Flatmodel", b =>
                {
                    b.Property<int>("Flatid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentuserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("SocietyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WingId")
                        .HasColumnType("int");

                    b.Property<int>("flatno")
                        .HasColumnType("int");

                    b.Property<string>("floorno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Flatid");

                    b.HasIndex("CurrentuserId");

                    b.HasIndex("SocietyId");

                    b.HasIndex("WingId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Security_Guard", b =>
                {
                    b.Property<int>("Guard_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Guard_Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guard_FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guard_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idfile_Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idfile_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Societyid")
                        .HasColumnType("int");

                    b.Property<string>("alternate_contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("currentuserid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("doc_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("updateddate")
                        .HasColumnType("datetime2");

                    b.HasKey("Guard_Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("Societyid");

                    b.HasIndex("currentuserid");

                    b.ToTable("Security_Guards");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.SocietyDetails", b =>
                {
                    b.Property<int>("Society_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postal_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("President_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Society_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Society_Id");

                    b.HasIndex("AdminID");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Societies");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Staff", b =>
                {
                    b.Property<int>("staffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aadharno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filepath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("flatid")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("residentid")
                        .HasColumnType("int");

                    b.Property<int?>("societyid")
                        .HasColumnType("int");

                    b.Property<string>("staffName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("wingid")
                        .HasColumnType("int");

                    b.Property<string>("workas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("staffId");

                    b.HasIndex("flatid");

                    b.HasIndex("residentid");

                    b.HasIndex("societyid");

                    b.HasIndex("userId");

                    b.HasIndex("wingid");

                    b.ToTable("staffs");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Tblresident", b =>
                {
                    b.Property<int>("residentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Idfile_Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idfile_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("doc_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("flatno")
                        .HasColumnType("int");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("societyid")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("wingid")
                        .HasColumnType("int");

                    b.HasKey("residentId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("flatno");

                    b.HasIndex("societyid");

                    b.HasIndex("wingid");

                    b.ToTable("tblResidents");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Vehicle", b =>
                {
                    b.Property<int>("vehicleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("residentid")
                        .HasColumnType("int");

                    b.Property<string>("vehicleno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicletype")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("vehicleid");

                    b.HasIndex("residentid");

                    b.ToTable("vehicles");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Visitors", b =>
                {
                    b.Property<int>("visitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("aadharno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("doc_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("flatid")
                        .HasColumnType("int");

                    b.Property<string>("from")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("purposeofvisit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("residentid")
                        .HasColumnType("int");

                    b.Property<int?>("societyid")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicleno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("visitorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("visitorType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("visitorcontact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("wingid")
                        .HasColumnType("int");

                    b.Property<string>("workas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("visitorId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("flatid");

                    b.HasIndex("residentid");

                    b.HasIndex("societyid");

                    b.HasIndex("wingid");

                    b.ToTable("visitors");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Wingmodel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Society_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nooffloors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("Society_Id");

                    b.ToTable("Wingmodels");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Family", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.Tblresident", "Tblresident")
                        .WithMany()
                        .HasForeignKey("residentid");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Flatmodel", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("CurrentuserId");

                    b.HasOne("GateCommunityMvc.Models.SocietyDetails", "SocietyDetails")
                        .WithMany("flatmodels")
                        .HasForeignKey("SocietyId");

                    b.HasOne("GateCommunityMvc.Models.Wingmodel", "Wingmodel")
                        .WithMany("Flatmodels")
                        .HasForeignKey("WingId");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Security_Guard", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("GateCommunityMvc.Models.SocietyDetails", "SocietyDetails")
                        .WithMany()
                        .HasForeignKey("Societyid");

                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "CurrentuseId")
                        .WithMany()
                        .HasForeignKey("currentuserid");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.SocietyDetails", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminID");

                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Staff", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.Flatmodel", "Flatmodel")
                        .WithMany()
                        .HasForeignKey("flatid");

                    b.HasOne("GateCommunityMvc.Models.Tblresident", "Tblresident")
                        .WithMany()
                        .HasForeignKey("residentid");

                    b.HasOne("GateCommunityMvc.Models.SocietyDetails", "societyDetails")
                        .WithMany()
                        .HasForeignKey("societyid");

                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "Applicationuser")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.HasOne("GateCommunityMvc.Models.Wingmodel", "Wingmodel")
                        .WithMany()
                        .HasForeignKey("wingid");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Tblresident", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("GateCommunityMvc.Models.Flatmodel", "Flatmodel")
                        .WithMany()
                        .HasForeignKey("flatno");

                    b.HasOne("GateCommunityMvc.Models.SocietyDetails", "SocietyDetails")
                        .WithMany()
                        .HasForeignKey("societyid");

                    b.HasOne("GateCommunityMvc.Models.Wingmodel", "Wingmodel")
                        .WithMany("Tblresidents")
                        .HasForeignKey("wingid");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Vehicle", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.Tblresident", "Tblresident")
                        .WithMany()
                        .HasForeignKey("residentid");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Visitors", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("GateCommunityMvc.Models.Flatmodel", "Flatmodel")
                        .WithMany()
                        .HasForeignKey("flatid");

                    b.HasOne("GateCommunityMvc.Models.Tblresident", "Tblresident")
                        .WithMany()
                        .HasForeignKey("residentid");

                    b.HasOne("GateCommunityMvc.Models.SocietyDetails", "societyDetails")
                        .WithMany()
                        .HasForeignKey("societyid");

                    b.HasOne("GateCommunityMvc.Models.Wingmodel", "Wingmodel")
                        .WithMany()
                        .HasForeignKey("wingid");
                });

            modelBuilder.Entity("GateCommunityMvc.Models.Wingmodel", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("GateCommunityMvc.Models.SocietyDetails", "SocietyDetails")
                        .WithMany("wingmodels")
                        .HasForeignKey("Society_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GateCommunityMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
