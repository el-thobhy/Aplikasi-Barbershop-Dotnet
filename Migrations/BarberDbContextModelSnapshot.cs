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
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("MasterBiodataTable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Jl. Semangka No.2, jakarta",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8819),
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
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8825),
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
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8827),
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
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8829),
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

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MasterServicesTable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3846),
                            Description = "Style mullet haircut, short side",
                            ImageUrl = "https://haircutinspiration.com/wp-content/uploads/perm-mullet-with-quiff-750x937.jpg",
                            IsDeleted = false,
                            Price = 200000.0,
                            ServicesName = "Haircut Mullet style",
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3860),
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
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3862),
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
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3864),
                            Description = "Style wolfcut style, Modern wolfcut",
                            ImageUrl = "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg",
                            IsDeleted = false,
                            Price = 500000.0,
                            ServicesName = "Haircut wolfcut style"
                        },
                        new
                        {
                            Id = 5,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3866),
                            Description = "Cream bath Services, Dandruff care",
                            ImageUrl = "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg",
                            IsDeleted = false,
                            Price = 400000.0,
                            ServicesName = "Hair Care",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterTeamTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("MasterTeamTable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5396),
                            Email = "buid@gmail.com",
                            IsDeleted = false,
                            Name = "Budi",
                            Phone = "081278912302",
                            Role = 0,
                            Status = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5402),
                            Email = "asep@gmail.com",
                            IsDeleted = false,
                            Name = "Asep",
                            Phone = "081123122302",
                            Role = 0,
                            Status = 1,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5404),
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
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5406),
                            Email = "susi@gmail.com",
                            IsDeleted = false,
                            Name = "Susi",
                            Phone = "0812789123112",
                            Role = 2,
                            Status = 1,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterUserTable", b =>
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

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BiodataId")
                        .IsUnique()
                        .HasFilter("[BiodataId] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("MasterUserTable", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BiodataId = 1,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(774),
                            IsDeleted = false,
                            Password = "5f9235e4a01a1426a8b791e239f0c72f65ad1bc8a7cc3a6c163486c1f86037a0",
                            Role = 0,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            BiodataId = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(1801),
                            IsDeleted = false,
                            Password = "f7cc0b90dbc18a9255efa5d8193dffb78d9cfa193d5900f1a64d548c53d2e78c",
                            Role = 1,
                            UserName = "andreas"
                        },
                        new
                        {
                            Id = 3,
                            BiodataId = 3,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(1812),
                            IsDeleted = false,
                            Password = "dd6fa3a9f24e38363058d610c26f935bf7952f9c4f74ea60d52a1de1b27aa7f6",
                            Role = 1,
                            UserName = "paul"
                        },
                        new
                        {
                            Id = 4,
                            BiodataId = 4,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(1816),
                            IsDeleted = false,
                            Password = "1d1f5e19b999d7e8a96bcc99b83c13c5d0f1aa134b25dd638c9d4a7d871cec0a",
                            Role = 1,
                            UserName = "barbara"
                        });
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterServicesTable", b =>
                {
                    b.HasOne("AplikasiBarbershop.DataModel.MasterUserTable", "User")
                        .WithMany("Services")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterTeamTable", b =>
                {
                    b.HasOne("AplikasiBarbershop.DataModel.MasterUserTable", "User")
                        .WithOne("Team")
                        .HasForeignKey("AplikasiBarbershop.DataModel.MasterTeamTable", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterUserTable", b =>
                {
                    b.HasOne("AplikasiBarbershop.DataModel.MasterBiodataTable", "Biodata")
                        .WithOne("User")
                        .HasForeignKey("AplikasiBarbershop.DataModel.MasterUserTable", "BiodataId");

                    b.Navigation("Biodata");
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterBiodataTable", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("AplikasiBarbershop.DataModel.MasterUserTable", b =>
                {
                    b.Navigation("Services");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
