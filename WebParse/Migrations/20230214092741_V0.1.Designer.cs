﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebParse.Data;

#nullable disable

namespace WebParse.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20230214092741_V0.1")]
    partial class V01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmOyuncu", b =>
                {
                    b.Property<int>("FilmsID")
                        .HasColumnType("int");

                    b.Property<int>("OyuncularId")
                        .HasColumnType("int");

                    b.HasKey("FilmsID", "OyuncularId");

                    b.HasIndex("OyuncularId");

                    b.ToTable("FilmOyuncu");
                });

            modelBuilder.Entity("WebParse.Models.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TurId")
                        .HasColumnType("int");

                    b.Property<int>("Yıl")
                        .HasColumnType("int");

                    b.Property<string>("imdbId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("imdbPuanı")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("TurId");

                    b.ToTable("Filmler");
                });

            modelBuilder.Entity("WebParse.Models.IletisimBilgisi", b =>
                {
                    b.Property<int>("OyuncuID")
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("OyuncuID");

                    b.ToTable("IletisimBilgileri");
                });

            modelBuilder.Entity("WebParse.Models.Oyuncu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyAd")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Oyuncular");
                });

            modelBuilder.Entity("WebParse.Models.Tur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turler");
                });

            modelBuilder.Entity("FilmOyuncu", b =>
                {
                    b.HasOne("WebParse.Models.Film", null)
                        .WithMany()
                        .HasForeignKey("FilmsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebParse.Models.Oyuncu", null)
                        .WithMany()
                        .HasForeignKey("OyuncularId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebParse.Models.Film", b =>
                {
                    b.HasOne("WebParse.Models.Tur", "Tur")
                        .WithMany("Filmler")
                        .HasForeignKey("TurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tur");
                });

            modelBuilder.Entity("WebParse.Models.IletisimBilgisi", b =>
                {
                    b.HasOne("WebParse.Models.Oyuncu", "Oyuncu")
                        .WithOne("IletisimBilgisi")
                        .HasForeignKey("WebParse.Models.IletisimBilgisi", "OyuncuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oyuncu");
                });

            modelBuilder.Entity("WebParse.Models.Oyuncu", b =>
                {
                    b.Navigation("IletisimBilgisi")
                        .IsRequired();
                });

            modelBuilder.Entity("WebParse.Models.Tur", b =>
                {
                    b.Navigation("Filmler");
                });
#pragma warning restore 612, 618
        }
    }
}