﻿// <auto-generated />
using System;
using KeepMovinAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KeepMovinAPI.Migrations
{
    [DbContext(typeof(KeepMovinDbContext))]
    [Migration("20220302082206_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventUser", b =>
                {
                    b.Property<Guid>("EventsEventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersUserid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventsEventId", "UsersUserid");

                    b.HasIndex("UsersUserid");

                    b.ToTable("EventUser");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Event", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndEvent")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ExperienceLevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ProfilePicturePictureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("SportsSportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartEvent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventId");

                    b.HasIndex("ExperienceLevelId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProfilePicturePictureId");

                    b.HasIndex("SportsSportId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.EventType", b =>
                {
                    b.Property<Guid>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.ToTable("EventType");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.ExperienceLevel", b =>
                {
                    b.Property<Guid>("ExperienceLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExperienceLevelId");

                    b.ToTable("ExperienceLevel");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Organisation", b =>
                {
                    b.Property<Guid>("OrganisationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsVerify")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganisationId");

                    b.ToTable("Organisation");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Picture", b =>
                {
                    b.Property<Guid>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PictureInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PicturePath")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("PictureId");

                    b.HasIndex("EventId");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Setting", b =>
                {
                    b.Property<Guid>("SettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AboutMe")
                        .HasColumnType("bit");

                    b.Property<bool>("FollowersFollowing")
                        .HasColumnType("bit");

                    b.Property<bool>("Location")
                        .HasColumnType("bit");

                    b.Property<bool>("Photo")
                        .HasColumnType("bit");

                    b.Property<bool>("PreviousEvents")
                        .HasColumnType("bit");

                    b.Property<bool>("Statistics")
                        .HasColumnType("bit");

                    b.Property<bool>("UpcomingEvents")
                        .HasColumnType("bit");

                    b.HasKey("SettingsId");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Sport", b =>
                {
                    b.Property<Guid>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportId");

                    b.ToTable("Sport");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.User", b =>
                {
                    b.Property<Guid>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Userid");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.UserProfile", b =>
                {
                    b.Property<Guid>("UserProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("OrganisationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PersonalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SettingsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Userid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserProfileId");

                    b.HasIndex("LocationId");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("PictureId");

                    b.HasIndex("SettingsId");

                    b.HasIndex("Userid");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<Guid>("FollowedUserid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FollowersUserid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FollowedUserid", "FollowersUserid");

                    b.HasIndex("FollowersUserid");

                    b.ToTable("UserUser");
                });

            modelBuilder.Entity("EventUser", b =>
                {
                    b.HasOne("KeepMovinAPI.Domain.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeepMovinAPI.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Event", b =>
                {
                    b.HasOne("KeepMovinAPI.Domain.ExperienceLevel", "ExperienceLevel")
                        .WithMany()
                        .HasForeignKey("ExperienceLevelId");

                    b.HasOne("KeepMovinAPI.Domain.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("KeepMovinAPI.Domain.Picture", "ProfilePicture")
                        .WithMany()
                        .HasForeignKey("ProfilePicturePictureId");

                    b.HasOne("KeepMovinAPI.Domain.Sport", "Sports")
                        .WithMany()
                        .HasForeignKey("SportsSportId");

                    b.HasOne("KeepMovinAPI.Domain.EventType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.HasOne("KeepMovinAPI.Domain.UserProfile", "User")
                        .WithMany()
                        .HasForeignKey("UserProfileId");

                    b.Navigation("ExperienceLevel");

                    b.Navigation("Location");

                    b.Navigation("ProfilePicture");

                    b.Navigation("Sports");

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Picture", b =>
                {
                    b.HasOne("KeepMovinAPI.Domain.Event", null)
                        .WithMany("Pictures")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.UserProfile", b =>
                {
                    b.HasOne("KeepMovinAPI.Domain.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("KeepMovinAPI.Domain.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationId");

                    b.HasOne("KeepMovinAPI.Domain.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");

                    b.HasOne("KeepMovinAPI.Domain.Setting", "Setting")
                        .WithMany()
                        .HasForeignKey("SettingsId");

                    b.HasOne("KeepMovinAPI.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid");

                    b.Navigation("Location");

                    b.Navigation("Organisation");

                    b.Navigation("Picture");

                    b.Navigation("Setting");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("KeepMovinAPI.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("FollowedUserid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KeepMovinAPI.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("FollowersUserid")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Event", b =>
                {
                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}