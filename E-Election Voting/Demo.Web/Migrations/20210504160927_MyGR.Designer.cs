﻿// <auto-generated />
using System;
using Demo.Foundation.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Web.Migrations
{
    [DbContext(typeof(RegistrationContext))]
    [Migration("20210504160927_MyGR")]
    partial class MyGR
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.Foundation.Entities.ElectionCandidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ElectionCandidates");
                });

            modelBuilder.Entity("Demo.Foundation.Entities.ElectionRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("ElectionCandidateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ElectionCandidateId");

                    b.ToTable("ElectionRegistrations");
                });

            modelBuilder.Entity("Demo.Foundation.Entities.ElectionVoter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ElectionVoters");
                });

            modelBuilder.Entity("Demo.Foundation.Entities.MakeElection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CDName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CDName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CID1")
                        .HasColumnType("int");

                    b.Property<int?>("CID2")
                        .HasColumnType("int");

                    b.Property<int>("Count1")
                        .HasColumnType("int");

                    b.Property<int>("Count2")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ElectionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ElectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MakeElections");
                });

            modelBuilder.Entity("Demo.Foundation.Entities.PdfList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ElectionCandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ElectionCandidateId");

                    b.ToTable("PdfLists");
                });

            modelBuilder.Entity("Demo.Foundation.Entities.ElectionRegistration", b =>
                {
                    b.HasOne("Demo.Foundation.Entities.ElectionCandidate", "ElectionCandidate")
                        .WithMany()
                        .HasForeignKey("ElectionCandidateId");
                });

            modelBuilder.Entity("Demo.Foundation.Entities.PdfList", b =>
                {
                    b.HasOne("Demo.Foundation.Entities.ElectionCandidate", "ElectionCandidate")
                        .WithMany("PdfListUrl")
                        .HasForeignKey("ElectionCandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
