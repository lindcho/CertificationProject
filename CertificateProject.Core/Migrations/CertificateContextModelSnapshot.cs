﻿// <auto-generated />
using System;
using CertificateProject.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CertificateProject.Infrastructure.Migrations
{
    [DbContext(typeof(CertificateContext))]
    partial class CertificateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CertificateProject.Infrastructure.Entities.CertificateEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Document")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SequenceNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SequenceNumber")
                        .IsUnique();

                    b.ToTable("CertificateEntities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IssueDate = new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SequenceNumber = 1110
                        },
                        new
                        {
                            Id = 2,
                            IssueDate = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SequenceNumber = 1111
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
