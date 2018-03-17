﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using VETHarbor.Data;

namespace VETHarbor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180317185825_Update_AppUser_Role")]
    partial class Update_AppUser_Role
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VETHarbor.Models.Events", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EventDescription");

                    b.Property<DateTime>("EventEnd");

                    b.Property<DateTime>("EventStart");

                    b.Property<string>("EventTitle");

                    b.Property<int>("OrgUserId");

                    b.Property<int?>("User_EventsUserEventId");

                    b.HasKey("EventId");

                    b.HasIndex("OrgUserId");

                    b.HasIndex("User_EventsUserEventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("VETHarbor.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OrganizationAddress");

                    b.Property<string>("OrganizationCity");

                    b.Property<string>("OrganizationName");

                    b.Property<string>("OrganizationState");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("VETHarbor.Models.Organizational_User", b =>
                {
                    b.Property<int>("OrgUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("OrganizationId");

                    b.Property<int>("UserId");

                    b.HasKey("OrgUserId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Organizational_User");
                });

            modelBuilder.Entity("VETHarbor.Models.Programs", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrgUserId");

                    b.Property<string>("Phone");

                    b.Property<string>("ProgramCity");

                    b.Property<string>("ProgramDescription");

                    b.Property<string>("ProgramState");

                    b.Property<string>("ProgramTitle");

                    b.Property<int?>("User_ProgramsUserProgId");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("ProgramId");

                    b.HasIndex("OrgUserId");

                    b.HasIndex("User_ProgramsUserProgId");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("VETHarbor.Models.User_Events", b =>
                {
                    b.Property<int>("UserEventId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("EventId");

                    b.Property<int>("UserId");

                    b.HasKey("UserEventId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("EventId");

                    b.ToTable("User_Events");
                });

            modelBuilder.Entity("VETHarbor.Models.User_Programs", b =>
                {
                    b.Property<int>("UserProgId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("ProgramId");

                    b.Property<int>("UserId");

                    b.HasKey("UserProgId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProgramId");

                    b.ToTable("User_Programs");
                });

            modelBuilder.Entity("VETHarbor.Models.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");


                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("VETHarbor.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("ApplicationRoleId");

                    b.Property<string>("RoleName");

                    b.Property<string>("UserAddress");

                    b.Property<string>("UserCity");

                    b.Property<string>("UserState");

                    b.Property<string>("UserZip");

                    b.HasIndex("ApplicationRoleId");

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VETHarbor.Models.Events", b =>
                {
                    b.HasOne("VETHarbor.Models.Organizational_User", "Organizational_User")
                        .WithMany()
                        .HasForeignKey("OrgUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VETHarbor.Models.User_Events")
                        .WithMany("Event")
                        .HasForeignKey("User_EventsUserEventId");
                });

            modelBuilder.Entity("VETHarbor.Models.Organizational_User", b =>
                {
                    b.HasOne("VETHarbor.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("VETHarbor.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VETHarbor.Models.Programs", b =>
                {
                    b.HasOne("VETHarbor.Models.Organizational_User", "Organizational_User")
                        .WithMany()
                        .HasForeignKey("OrgUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("VETHarbor.Models.User_Programs")
                        .WithMany("Program")
                        .HasForeignKey("User_ProgramsUserProgId");
                });

            modelBuilder.Entity("VETHarbor.Models.User_Events", b =>
                {
                    b.HasOne("VETHarbor.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("VETHarbor.Models.Events", "Events")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VETHarbor.Models.User_Programs", b =>
                {
                    b.HasOne("VETHarbor.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("VETHarbor.Models.Programs", "Programs")
                        .WithMany()
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VETHarbor.Models.ApplicationUser", b =>
                {
                    b.HasOne("VETHarbor.Models.ApplicationRole", "ApplicationRole")
                        .WithMany()
                        .HasForeignKey("ApplicationRoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
