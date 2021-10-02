﻿// <auto-generated />
using KodAdıAfacanlar.Services.World;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KodAdıAfacanlar.Migrations
{
    [DbContext(typeof(WorldDatabase))]
    [Migration("20211001220416_UpdateIdAsLectureIdInLecture")]
    partial class UpdateIdAsLectureIdInLecture
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("KodAdıAfacanlar.Models.Lecture", b =>
                {
                    b.Property<int>("LectureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DownloadPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Downloaded")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JavascriptCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LessonId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Teacher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("ToDownload")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LectureId");

                    b.HasIndex("LessonId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("KodAdıAfacanlar.Models.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HtmlId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LessonId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("KodAdıAfacanlar.Models.Lecture", b =>
                {
                    b.HasOne("KodAdıAfacanlar.Models.Lesson", null)
                        .WithMany("LectureList")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KodAdıAfacanlar.Models.Lesson", b =>
                {
                    b.Navigation("LectureList");
                });
#pragma warning restore 612, 618
        }
    }
}
