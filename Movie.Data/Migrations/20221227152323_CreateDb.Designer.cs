﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie.Data.Data;

namespace Movie.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221227152323_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movie.Model.Models.Celebtiry", b =>
                {
                    b.Property<int>("CelebrityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CelebrityActorORActress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelebrityCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CelebrityMovies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelebrityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("CelebrityYearofBirth")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CelebrityID");

                    b.ToTable("Celebtiries");
                });

            modelBuilder.Entity("Movie.Model.Models.Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectorID");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("Movie.Model.Models.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Movie.Model.Models.Moviee", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MovieDirector")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("MovieGenres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MovieReleaseDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieReview")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieRuntime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieStars")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieWriter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudioID")
                        .HasColumnType("int");

                    b.HasKey("MovieID");

                    b.HasIndex("StudioID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Movie.Model.Models.Studio", b =>
                {
                    b.Property<int>("StudioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudioName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudioID");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("Movie.Model.Models.Moviee", b =>
                {
                    b.HasOne("Movie.Model.Models.Studio", "Studio")
                        .WithMany()
                        .HasForeignKey("StudioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
