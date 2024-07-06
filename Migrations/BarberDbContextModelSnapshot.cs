﻿// <auto-generated />
using System;
using AplikasiBarbershop.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AplikasiBarbershop.Migrations
{
    [DbContext(typeof(BarberDbContext))]
    partial class BarberDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterBiodataTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MasterBiodataTable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Jl. Semangka No.2, jakarta",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1466),
                            Email = "irfan@gmail.com",
                            IsDeleted = false,
                            Name = "Irfan Hakim",
                            Phone = "08123809123"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Jl. Mangga No.5, jakarta",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1476),
                            Email = "andreas@gmail.com",
                            IsDeleted = false,
                            Name = "Andreas",
                            Phone = "081234809123"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Jl. Nangka No.2, jakarta",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1481),
                            Email = "paul@gmail.com",
                            IsDeleted = false,
                            Name = "Paul",
                            Phone = "081123123341"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Jl. Pisang No.2, jakarta",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1485),
                            Email = "barbara@gmail.com",
                            IsDeleted = false,
                            Name = "Barbara",
                            Phone = "0845546309123"
                        });
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterServicesTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BiodataId")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("float(18)");

                    b.Property<string>("ServicesName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BiodataId");

                    b.ToTable("MasterServicesTable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BiodataId = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1179),
                            Description = "Style mullet haircut, short side",
                            ImageUrl = "https://haircutinspiration.com/wp-content/uploads/perm-mullet-with-quiff-750x937.jpg",
                            IsDeleted = false,
                            Price = 200000.0,
                            ServicesName = "Haircut Mullet style"
                        },
                        new
                        {
                            Id = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1209),
                            Description = "Style comma haircut, modern hair style",
                            ImageUrl = "https://www.k-craze.com/wp-content/uploads/2021/09/image-138.jpg",
                            IsDeleted = false,
                            Price = 250000.0,
                            ServicesName = "Haircut Comma hair"
                        },
                        new
                        {
                            Id = 3,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1212),
                            Description = "Style Mohawk haircut, short side",
                            ImageUrl = "https://www.hottesthaircuts.com/wp-content/uploads/2018/02/3.-High-Mohawk-Fade.jpg",
                            IsDeleted = false,
                            Price = 150000.0,
                            ServicesName = "Haircut Mohawk"
                        },
                        new
                        {
                            Id = 4,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1215),
                            Description = "Style wolfcut style, Modern wolfcut",
                            ImageUrl = "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg",
                            IsDeleted = false,
                            Price = 500000.0,
                            ServicesName = "Haircut wolfcut style"
                        },
                        new
                        {
                            Id = 5,
                            BiodataId = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1219),
                            Description = "Cream bath Services, Dandruff care",
                            ImageUrl = "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg",
                            IsDeleted = false,
                            Price = 400000.0,
                            ServicesName = "Hair Care"
                        });
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterTeamTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BiodataId")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BiodataId")
                        .IsUnique()
                        .HasFilter("[BiodataId] IS NOT NULL");

                    b.ToTable("MasterTeamTable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BiodataId = 1,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3687),
                            Email = "buid@gmail.com",
                            IsDeleted = false,
                            Name = "Budi",
                            Phone = "081278912302",
                            Role = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            BiodataId = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3695),
                            Email = "asep@gmail.com",
                            IsDeleted = false,
                            Name = "Asep",
                            Phone = "081123122302",
                            Role = 0,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3698),
                            Email = "putri@gmail.com",
                            IsDeleted = false,
                            Name = "Putri",
                            Phone = "081278911232",
                            Role = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            BiodataId = 4,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3702),
                            Email = "susi@gmail.com",
                            IsDeleted = false,
                            Name = "Susi",
                            Phone = "0812789123112",
                            Role = 2,
                            Status = 0
                        });
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterServicesTable", b =>
                {
                    b.HasOne("AplikasiBarbershop.DataModel.MasterBiodataTable", "Biodata")
                        .WithMany("Services")
                        .HasForeignKey("BiodataId");

                    b.Navigation("Biodata");
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterTeamTable", b =>
                {
                    b.HasOne("AplikasiBarbershop.DataModel.MasterBiodataTable", "Biodata")
                        .WithOne("Team")
                        .HasForeignKey("AplikasiBarbershop.DataModel.MasterTeamTable", "BiodataId");

                    b.Navigation("Biodata");
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterBiodataTable", b =>
                {
                    b.Navigation("Services");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
