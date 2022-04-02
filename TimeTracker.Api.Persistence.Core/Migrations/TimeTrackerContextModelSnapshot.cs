﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeTracker.Api.Persistence.Core.EntityFrameworkCore;

namespace TimeTracker.Api.Persistence.Core.Migrations
{
    [DbContext(typeof(TimeTrackerContext))]
    partial class TimeTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("EntryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("End")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectUserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("ProjectUserId");

                    b.HasIndex(new[] { "Name", "Description" }, "UniqueEntryIndex")
                        .IsUnique();

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Pause", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("PauseId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("End")
                        .HasColumnType("TEXT");

                    b.Property<int>("EntryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Start")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("EntryId");

                    b.HasIndex(new[] { "Name", "Description", "EntryId" }, "UniquePauseIndex")
                        .IsUnique();

                    b.ToTable("Pause");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ProjectId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Name" }, "UniqueNameIndex")
                        .IsUnique();

                    b.ToTable("Project");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.ProjectUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ProjectUserId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "ProjectId", "UserId" }, "UniqueProjectUserIndex")
                        .IsUnique();

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.ProjectUserTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Version")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TagId");

                    b.ToTable("ProjectUserTag");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ResourceId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex(new[] { "Name", "ProjectId", "Link" }, "UniqueResourceIndex")
                        .IsUnique();

                    b.ToTable("Resource");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("TagId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("UserId");

                    b.Property<string>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccountType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "AccountId", "AccountType" }, "UniqueUserIndex")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Entry", b =>
                {
                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.ProjectUser", "ProjectUser")
                        .WithMany("Entries")
                        .HasForeignKey("ProjectUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectUser");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Pause", b =>
                {
                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.Entry", "Entry")
                        .WithMany("Pauses")
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entry");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.ProjectUser", b =>
                {
                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.Project", "Project")
                        .WithMany("Users")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.User", "User")
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.ProjectUserTag", b =>
                {
                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.ProjectUser", "Project")
                        .WithMany("Tags")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.Tag", "Tag")
                        .WithMany("Projects")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Resource", b =>
                {
                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.Project", "Project")
                        .WithMany("Resources")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Tag", b =>
                {
                    b.HasOne("TimeTracker.Api.Persistence.Core.Models.User", "User")
                        .WithMany("Tags")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Entry", b =>
                {
                    b.Navigation("Pauses");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Project", b =>
                {
                    b.Navigation("Resources");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.ProjectUser", b =>
                {
                    b.Navigation("Entries");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.Tag", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("TimeTracker.Api.Persistence.Core.Models.User", b =>
                {
                    b.Navigation("Projects");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
