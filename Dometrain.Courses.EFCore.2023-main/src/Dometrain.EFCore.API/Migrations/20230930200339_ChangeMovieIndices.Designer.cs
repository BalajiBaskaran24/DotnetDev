﻿// <auto-generated />
using System;
using Dometrain.EFCore.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dometrain.EFCore.API.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20230930200339_ChangeMovieIndices")]
    partial class ChangeMovieIndices
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dometrain.EFCore.API.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.ExternalInformation", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("ImdbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RottenTomatoesUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TmdbUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("ExternalInformations");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedAt");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.GenreName", b =>
                {
                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("GenreNames");

                    b.ToSqlQuery("SELECT Name FROM dbo.Genres");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.Movie", b =>
                {
                    b.Property<int>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identifier"));

                    b.Property<int>("AgeRating")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("InternetRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MainGenreName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Synopsis")
                        .HasColumnType("varchar(max)")
                        .HasColumnName("Plot");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar");

                    b.HasKey("Identifier");

                    b.HasAlternateKey("Title", "ReleaseDate");

                    b.HasIndex("AgeRating")
                        .IsDescending();

                    b.HasIndex("MainGenreName");

                    b.ToTable("Pictures", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Movie");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Movie_Actor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("Movie_Actor");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.CinemaMovie", b =>
                {
                    b.HasBaseType("Dometrain.EFCore.API.Models.Movie");

                    b.Property<decimal>("GrossRevenue")
                        .HasColumnType("decimal(18,2)");

                    b.HasDiscriminator().HasValue("CinemaMovie");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.TelevisionMovie", b =>
                {
                    b.HasBaseType("Dometrain.EFCore.API.Models.Movie");

                    b.Property<string>("ChannelFirstAiredOn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("TelevisionMovie");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.ExternalInformation", b =>
                {
                    b.HasOne("Dometrain.EFCore.API.Models.Movie", "Movie")
                        .WithOne("ExternalInformation")
                        .HasForeignKey("Dometrain.EFCore.API.Models.ExternalInformation", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.Movie", b =>
                {
                    b.HasOne("Dometrain.EFCore.API.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("MainGenreName")
                        .HasPrincipalKey("Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Movie_Actor", b =>
                {
                    b.HasOne("Dometrain.EFCore.API.Models.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MovieActor_Actor");

                    b.HasOne("Dometrain.EFCore.API.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MovieActor_Movie");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Dometrain.EFCore.API.Models.Movie", b =>
                {
                    b.Navigation("ExternalInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
