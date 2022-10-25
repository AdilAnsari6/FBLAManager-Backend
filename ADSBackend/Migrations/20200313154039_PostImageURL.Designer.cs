﻿// <auto-generated />
using System;
using ADSBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADSBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200313154039_PostImageURL")]
    partial class PostImageURL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADSBackend.Models.BoardPost", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClubId");

                    b.Property<string>("Director");

                    b.Property<DateTime>("EditedTime");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Message");

                    b.Property<DateTime>("PostTime");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.Property<DateTime>("WriteTime");

                    b.HasKey("PostId");

                    b.HasIndex("ClubId");

                    b.ToTable("BoardPost");
                });

            modelBuilder.Entity("ADSBackend.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator");

                    b.Property<int>("CreatorId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("ClubId");

                    b.ToTable("Club");
                });

            modelBuilder.Entity("ADSBackend.Models.ClubMember", b =>
                {
                    b.Property<int>("ClubId");

                    b.Property<int>("MemberId");

                    b.HasKey("ClubId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("ClubMember");
                });

            modelBuilder.Entity("ADSBackend.Models.ConfigurationItem", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value");

                    b.HasKey("Key");

                    b.ToTable("ConfigurationItem");
                });

            modelBuilder.Entity("ADSBackend.Models.FAQ", b =>
                {
                    b.Property<int>("FAQId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Edited");

                    b.Property<string>("Question");

                    b.HasKey("FAQId");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("ADSBackend.Models.Identity.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

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
                });

            modelBuilder.Entity("ADSBackend.Models.Identity.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName");

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
                });

            modelBuilder.Entity("ADSBackend.Models.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllDay");

                    b.Property<int>("Capacity");

                    b.Property<string>("Color");

                    b.Property<string>("ContactId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("End");

                    b.Property<string>("EventName");

                    b.Property<string>("Organizer");

                    b.Property<int>("OrganizerId");

                    b.Property<string>("Password");

                    b.Property<DateTime>("Start");

                    b.Property<int>("Type");

                    b.HasKey("MeetingId");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("ADSBackend.Models.MeetingAttendees", b =>
                {
                    b.Property<int>("MeetingId");

                    b.Property<int>("MemberId");

                    b.HasKey("MeetingId", "MemberId");

                    b.HasIndex("MemberId");

                    b.ToTable("MeetingAttendees");
                });

            modelBuilder.Entity("ADSBackend.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("FullName");

                    b.Property<string>("Gender");

                    b.Property<int>("Grade");

                    b.Property<string>("LastName");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("RecruitedBy");

                    b.Property<string>("Salt");

                    b.Property<string>("State");

                    b.Property<string>("ZipCode");

                    b.Property<string>("profileImageSource");

                    b.HasKey("MemberId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("ADSBackend.Models.Officer", b =>
                {
                    b.Property<int>("OfficerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<string>("Position");

                    b.Property<string>("WebsiteLink");

                    b.HasKey("OfficerId");

                    b.ToTable("Officer");
                });

            modelBuilder.Entity("ADSBackend.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Key");

                    b.Property<DateTime>("LastAccessTime");

                    b.Property<int>("MemberId");

                    b.HasKey("SessionId");

                    b.ToTable("Session");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ADSBackend.Models.BoardPost", b =>
                {
                    b.HasOne("ADSBackend.Models.Club", "Club")
                        .WithMany("Messageboard")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ADSBackend.Models.ClubMember", b =>
                {
                    b.HasOne("ADSBackend.Models.Club", "Club")
                        .WithMany("ClubMembers")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ADSBackend.Models.Member", "Member")
                        .WithMany("ClubMembers")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ADSBackend.Models.MeetingAttendees", b =>
                {
                    b.HasOne("ADSBackend.Models.Meeting", "Meeting")
                        .WithMany("MeetingAttendees")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ADSBackend.Models.Member", "Member")
                        .WithMany("MeetingAttendees")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ADSBackend.Models.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
