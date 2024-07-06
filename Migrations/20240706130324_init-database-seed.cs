using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AplikasiBarbershop.Migrations
{
    /// <inheritdoc />
    public partial class initdatabaseseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterCustomerTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCustomerTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterServicesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterServicesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterTeamTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterTeamTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MasterCustomerTable",
                columns: new[] { "Id", "Address", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Email", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Jl. Semangka No.2, jakarta", "admin", new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(201), null, null, "irfan@gmail.com", false, null, null, "Irfan Hakim", "08123809123" },
                    { 2, "Jl. Mangga No.5, jakarta", "admin", new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(209), null, null, "andreas@gmail.com", false, null, null, "Andreas", "081234809123" },
                    { 3, "Jl. Nangka No.2, jakarta", "admin", new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(213), null, null, "paul@gmail.com", false, null, null, "Paul", "081123123341" },
                    { 4, "Jl. Pisang No.2, jakarta", "admin", new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(217), null, null, "barbara@gmail.com", false, null, null, "Barbara", "0845546309123" }
                });

            migrationBuilder.InsertData(
                table: "MasterServicesTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "ServicesName" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5753), null, null, "Style mullet haircut, short side", "https://haircutinspiration.com/wp-content/uploads/perm-mullet-with-quiff-750x937.jpg", false, null, null, 200000.0, "Haircut Mullet style" },
                    { 2, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5771), null, null, "Style comma haircut, modern hair style", "https://www.k-craze.com/wp-content/uploads/2021/09/image-138.jpg", false, null, null, 250000.0, "Haircut Comma hair" },
                    { 3, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5775), null, null, "Style Mohawk haircut, short side", "https://www.hottesthaircuts.com/wp-content/uploads/2018/02/3.-High-Mohawk-Fade.jpg", false, null, null, 150000.0, "Haircut Mohawk" },
                    { 4, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5887), null, null, "Style wolfcut style, Modern wolfcut", "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg", false, null, null, 500000.0, "Haircut wolfcut style" }
                });

            migrationBuilder.InsertData(
                table: "MasterTeamTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Email", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Phone", "Role", "Status" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8457), null, null, "buid@gmail.com", false, null, null, "Budi", "081278912302", 0, 0 },
                    { 2, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8466), null, null, "asep@gmail.com", false, null, null, "Asep", "081123122302", 0, 0 },
                    { 3, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8470), null, null, "putri@gmail.com", false, null, null, "Putri", "081278911232", 1, 0 },
                    { 4, "admin", new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8474), null, null, "susi@gmail.com", false, null, null, "Susi", "0812789123112", 2, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterCustomerTable");

            migrationBuilder.DropTable(
                name: "MasterServicesTable");

            migrationBuilder.DropTable(
                name: "MasterTeamTable");
        }
    }
}
