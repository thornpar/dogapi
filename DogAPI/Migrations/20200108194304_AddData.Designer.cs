﻿// <auto-generated />
using System;
using DogAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DogAPI.Migrations
{
    [DbContext(typeof(DogContext))]
    [Migration("20200108194304_AddData")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DogAPI.Data.Dog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BestSkill");

                    b.Property<string>("Name");

                    b.Property<string>("Race");

                    b.HasKey("Id");

                    b.ToTable("Dogs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b403ba35-fd18-4516-ae30-c8b1a648c20a"),
                            BestSkill = "Policing",
                            Name = "Lasse",
                            Race = "German Sheperd"
                        },
                        new
                        {
                            Id = new Guid("3df54d3b-7b9f-4396-8628-fcb71d982058"),
                            BestSkill = "Allways ready to eat the food you dont want",
                            Name = "Ronny",
                            Race = "Golden Retriever"
                        },
                        new
                        {
                            Id = new Guid("1117c3e0-94cc-47dd-abb9-361e4421aa15"),
                            BestSkill = "Highly developed hunting instincts",
                            Name = "Pelle",
                            Race = "Weimaraner"
                        },
                        new
                        {
                            Id = new Guid("4063728d-40a9-4ee3-a5bb-e6455f128578"),
                            BestSkill = "Very loud",
                            Name = "Kalle",
                            Race = "Papillon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
