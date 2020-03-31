﻿// <auto-generated />
using System;
using CatBoardApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CatBoardApi.Migrations
{
    [DbContext(typeof(CatBoardApiContext))]
    partial class CatBoardApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CatBoardApi.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("BoardId");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            BoardId = 1,
                            Description = "Cats standing on their hind legs",
                            Name = "Cat's Standing Up"
                        },
                        new
                        {
                            BoardId = 2,
                            Description = "Cats",
                            Name = "Cat's Being Cute"
                        },
                        new
                        {
                            BoardId = 3,
                            Description = "Fighting cats",
                            Name = "Cat Fight"
                        },
                        new
                        {
                            BoardId = 4,
                            Description = "Cats living like tomorrow doesn't matter.",
                            Name = "Cats be cattin"
                        });
                });

            modelBuilder.Entity("CatBoardApi.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("EditDate");

                    b.Property<int>("PostId");

                    b.Property<int>("Score");

                    b.Property<int>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("CatBoardApi.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("BoardId");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("EditDate");

                    b.Property<int>("Score");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PostId");

                    b.HasIndex("BoardId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            AuthorId = 1,
                            BoardId = 1,
                            Body = "Cats standing on their hind legs",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 0,
                            Title = "OMG"
                        },
                        new
                        {
                            PostId = 2,
                            AuthorId = 1,
                            BoardId = 2,
                            Body = "Cats",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 0,
                            Title = "No no no"
                        },
                        new
                        {
                            PostId = 3,
                            AuthorId = 1,
                            BoardId = 1,
                            Body = "Fighting cats",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 0,
                            Title = "What!"
                        },
                        new
                        {
                            PostId = 4,
                            AuthorId = 1,
                            BoardId = 2,
                            Body = "Cats living like tomorrow doesn't matter.",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EditDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Score = 0,
                            Title = "That cat can sit."
                        });
                });

            modelBuilder.Entity("CatBoardApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "123@gmail",
                            Name = "John",
                            Password = "1"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "Cats@cats.com",
                            Name = "Markus",
                            Password = "1"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "ilovecats@gmail.com",
                            Name = "Lilly",
                            Password = "1"
                        },
                        new
                        {
                            UserId = 4,
                            Email = "dogseatcatpoo@yahoo.com",
                            Name = "Jordan",
                            Password = "1"
                        });
                });

            modelBuilder.Entity("CatBoardApi.Models.Comment", b =>
                {
                    b.HasOne("CatBoardApi.Models.Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CatBoardApi.Models.Post", b =>
                {
                    b.HasOne("CatBoardApi.Models.Board")
                        .WithMany("Posts")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
