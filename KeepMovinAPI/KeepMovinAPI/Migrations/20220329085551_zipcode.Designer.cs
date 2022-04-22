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
    [Migration("20220329085551_zipcode")]
    partial class zipcode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
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
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

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
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.Property<Guid?>("ProfilePicturePictureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Rating")
                        .HasPrecision(3, 2)
                        .HasColumnType("decimal(3,2)");

                    b.Property<Guid?>("SportsSportId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartEvent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

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
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("TypeId");

                    b.ToTable("EventType");

                    b.HasData(
                        new
                        {
                            TypeId = new Guid("84d93e03-21b0-447b-aeeb-8e67ffdf7b40"),
                            Name = "Professional"
                        },
                        new
                        {
                            TypeId = new Guid("b46bd9da-87f6-41cc-a96f-cac4682c1a0e"),
                            Name = "Recreational"
                        });
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.ExperienceLevel", b =>
                {
                    b.Property<Guid>("ExperienceLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ExperienceLevelId");

                    b.ToTable("ExperienceLevel");

                    b.HasData(
                        new
                        {
                            ExperienceLevelId = new Guid("5415ebf2-c409-48a4-8012-1c658e16a625"),
                            Name = "Beginner"
                        },
                        new
                        {
                            ExperienceLevelId = new Guid("4f2a9d57-1df4-46f5-94e5-dd6f910d4289"),
                            Name = "Intermediate"
                        },
                        new
                        {
                            ExperienceLevelId = new Guid("59c32956-c86d-4d34-93de-fe2c49287d67"),
                            Name = "Expert"
                        });
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Location", b =>
                {
                    b.Property<Guid>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Country")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = new Guid("7058005f-937f-40c7-84f5-b1ec42e54dc2"),
                            City = "Krakow",
                            Country = "Poland",
                            ZipCode = "30-389"
                        },
                        new
                        {
                            LocationId = new Guid("f0b7d5cb-2d2d-4f18-8524-ea32a7343bb2"),
                            City = "Warszawa",
                            Country = "Poland",
                            ZipCode = "30-389"
                        },
                        new
                        {
                            LocationId = new Guid("ad2102c1-d90e-4a4b-b741-2821a895d2b5"),
                            City = "Gdansk",
                            Country = "Poland",
                            ZipCode = "30-389"
                        },
                        new
                        {
                            LocationId = new Guid("859a9925-0174-4492-901d-cc2a33c25d87"),
                            City = "Opole",
                            Country = "Poland",
                            ZipCode = "30-389"
                        });
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.Organisation", b =>
                {
                    b.Property<Guid>("OrganisationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IsVerify")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

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
                        .IsRequired()
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
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("SportId");

                    b.ToTable("Sport");

                    b.HasData(
                        new
                        {
                            SportId = new Guid("221802c4-edc2-4ecc-bb64-8d2d617c9908"),
                            Name = "Baseball"
                        },
                        new
                        {
                            SportId = new Guid("ed1c73a2-660d-4278-be0b-bb154bd39d86"),
                            Name = "Football"
                        },
                        new
                        {
                            SportId = new Guid("fe5c7d28-741e-45c5-8fef-e2c662674607"),
                            Name = "Cycling"
                        },
                        new
                        {
                            SportId = new Guid("f3e52cb7-b33b-4fd3-8512-4e422b49dec0"),
                            Name = "HandBall"
                        },
                        new
                        {
                            SportId = new Guid("d78e9654-50cd-4422-b581-9ea7b50e2eb0"),
                            Name = "Climbing"
                        },
                        new
                        {
                            SportId = new Guid("8cf34b6e-0948-463f-838d-bdfeca8898b9"),
                            Name = "Fishing"
                        },
                        new
                        {
                            SportId = new Guid("b7f94744-5e0b-401d-952b-1a1e31464763"),
                            Name = "Running"
                        },
                        new
                        {
                            SportId = new Guid("be1fab94-936b-4a4e-99ad-e2f6318418cf"),
                            Name = "Volleyball"
                        },
                        new
                        {
                            SportId = new Guid("da0b6af1-5db8-4dcb-bd41-c56a5b3b7add"),
                            Name = "Basketball"
                        },
                        new
                        {
                            SportId = new Guid("3919586f-f75b-4a8b-8f63-ccd037d57b05"),
                            Name = "Nordic Walking"
                        });
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.User", b =>
                {
                    b.Property<Guid>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Userid");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KeepMovinAPI.Domain.UserProfile", b =>
                {
                    b.Property<Guid>("UserProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid?>("OrganisationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("OrganiserUserid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PersonalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<Guid?>("PictureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SettingsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Surname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserProfileId");

                    b.HasIndex("LocationId");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("OrganiserUserid");

                    b.HasIndex("PictureId");

                    b.HasIndex("SettingsId");

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

                    b.HasOne("KeepMovinAPI.Domain.User", "Organiser")
                        .WithMany()
                        .HasForeignKey("OrganiserUserid");

                    b.HasOne("KeepMovinAPI.Domain.Picture", "Picture")
                        .WithMany()
                        .HasForeignKey("PictureId");

                    b.HasOne("KeepMovinAPI.Domain.Setting", "Setting")
                        .WithMany()
                        .HasForeignKey("SettingsId");

                    b.Navigation("Location");

                    b.Navigation("Organisation");

                    b.Navigation("Organiser");

                    b.Navigation("Picture");

                    b.Navigation("Setting");
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