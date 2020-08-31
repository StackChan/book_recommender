﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using recommender.Data;

namespace recommender.Migrations
{
    [DbContext(typeof(BookRatedContext))]
    partial class BookRatedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("recommender.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("authors")
                        .HasColumnType("TEXT");

                    b.Property<double>("average_rating")
                        .HasColumnType("REAL");

                    b.Property<int>("book_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("image_url")
                        .HasColumnType("TEXT");

                    b.Property<int>("isbn")
                        .HasColumnType("INTEGER");

                    b.Property<string>("language_code")
                        .HasColumnType("TEXT");

                    b.Property<string>("original_title")
                        .HasColumnType("TEXT");

                    b.Property<double>("ratings_count")
                        .HasColumnType("REAL");

                    b.Property<string>("title")
                        .HasColumnType("TEXT");

                    b.Property<double>("year")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Book");
                });
#pragma warning restore 612, 618
        }
    }
}
