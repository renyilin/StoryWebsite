﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoryWebsite.Models;

namespace StoryWebsite.Data.Migrations
{
    [DbContext(typeof(StoryWebsiteDbContext))]
    [Migration("20190403010505_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoryWebsite.Models.Category", b =>
                {
                    b.Property<int>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("categoryID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("StoryWebsite.Models.Comment", b =>
                {
                    b.Property<int>("commentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("authoruserID");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("postTime");

                    b.Property<bool>("status");

                    b.Property<int?>("storyID");

                    b.HasKey("commentID");

                    b.HasIndex("authoruserID");

                    b.HasIndex("storyID");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("StoryWebsite.Models.Story", b =>
                {
                    b.Property<int>("storyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("authoruserID");

                    b.Property<int>("categoryID");

                    b.Property<string>("content")
                        .IsRequired();

                    b.Property<DateTime>("createTime");

                    b.Property<bool>("status");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("updateTime");

                    b.Property<string>("url");

                    b.HasKey("storyID");

                    b.HasIndex("authoruserID");

                    b.HasIndex("categoryID");

                    b.ToTable("stories");
                });

            modelBuilder.Entity("StoryWebsite.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("avatarURL")
                        .IsRequired();

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("userID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("StoryWebsite.Models.Comment", b =>
                {
                    b.HasOne("StoryWebsite.Models.User", "author")
                        .WithMany()
                        .HasForeignKey("authoruserID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StoryWebsite.Models.Story", "story")
                        .WithMany("comments")
                        .HasForeignKey("storyID");
                });

            modelBuilder.Entity("StoryWebsite.Models.Story", b =>
                {
                    b.HasOne("StoryWebsite.Models.User", "author")
                        .WithMany()
                        .HasForeignKey("authoruserID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StoryWebsite.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
