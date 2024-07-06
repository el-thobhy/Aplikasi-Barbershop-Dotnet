using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AplikasiBarbershop.Migrations
{
    /// <inheritdoc />
    public partial class gnticustomerjadibiodata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterServicesTable_MasterCustomerTable_CustomerId",
                table: "MasterServicesTable");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterTeamTable_MasterCustomerTable_CustomerId",
                table: "MasterTeamTable");

            migrationBuilder.DropTable(
                name: "MasterCustomerTable");

            migrationBuilder.DropIndex(
                name: "IX_MasterTeamTable_CustomerId",
                table: "MasterTeamTable");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "MasterTeamTable",
                newName: "BiodataId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "MasterServicesTable",
                newName: "BiodataId");

            migrationBuilder.RenameIndex(
                name: "IX_MasterServicesTable_CustomerId",
                table: "MasterServicesTable",
                newName: "IX_MasterServicesTable_BiodataId");

            migrationBuilder.CreateTable(
                name: "MasterBiodataTable",
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
                    table.PrimaryKey("PK_MasterBiodataTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MasterBiodataTable",
                columns: new[] { "Id", "Address", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Email", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Jl. Semangka No.2, jakarta", "admin", new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1466), null, null, "irfan@gmail.com", false, null, null, "Irfan Hakim", "08123809123" },
                    { 2, "Jl. Mangga No.5, jakarta", "admin", new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1476), null, null, "andreas@gmail.com", false, null, null, "Andreas", "081234809123" },
                    { 3, "Jl. Nangka No.2, jakarta", "admin", new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1481), null, null, "paul@gmail.com", false, null, null, "Paul", "081123123341" },
                    { 4, "Jl. Pisang No.2, jakarta", "admin", new DateTime(2024, 7, 7, 6, 14, 49, 441, DateTimeKind.Local).AddTicks(1485), null, null, "barbara@gmail.com", false, null, null, "Barbara", "0845546309123" }
                });

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 6, 14, 49, 440, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.CreateIndex(
                name: "IX_MasterTeamTable_BiodataId",
                table: "MasterTeamTable",
                column: "BiodataId",
                unique: true,
                filter: "[BiodataId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterServicesTable_MasterBiodataTable_BiodataId",
                table: "MasterServicesTable",
                column: "BiodataId",
                principalTable: "MasterBiodataTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterTeamTable_MasterBiodataTable_BiodataId",
                table: "MasterTeamTable",
                column: "BiodataId",
                principalTable: "MasterBiodataTable",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterServicesTable_MasterBiodataTable_BiodataId",
                table: "MasterServicesTable");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterTeamTable_MasterBiodataTable_BiodataId",
                table: "MasterTeamTable");

            migrationBuilder.DropTable(
                name: "MasterBiodataTable");

            migrationBuilder.DropIndex(
                name: "IX_MasterTeamTable_BiodataId",
                table: "MasterTeamTable");

            migrationBuilder.RenameColumn(
                name: "BiodataId",
                table: "MasterTeamTable",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "BiodataId",
                table: "MasterServicesTable",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_MasterServicesTable_BiodataId",
                table: "MasterServicesTable",
                newName: "IX_MasterServicesTable_CustomerId");

            migrationBuilder.CreateTable(
                name: "MasterCustomerTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCustomerTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MasterCustomerTable",
                columns: new[] { "Id", "Address", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Email", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Jl. Semangka No.2, jakarta", "admin", new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2984), null, null, "irfan@gmail.com", false, null, null, "Irfan Hakim", "08123809123" },
                    { 2, "Jl. Mangga No.5, jakarta", "admin", new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2994), null, null, "andreas@gmail.com", false, null, null, "Andreas", "081234809123" },
                    { 3, "Jl. Nangka No.2, jakarta", "admin", new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2996), null, null, "paul@gmail.com", false, null, null, "Paul", "081123123341" },
                    { 4, "Jl. Pisang No.2, jakarta", "admin", new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2999), null, null, "barbara@gmail.com", false, null, null, "Barbara", "0845546309123" }
                });

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.CreateIndex(
                name: "IX_MasterTeamTable_CustomerId",
                table: "MasterTeamTable",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterServicesTable_MasterCustomerTable_CustomerId",
                table: "MasterServicesTable",
                column: "CustomerId",
                principalTable: "MasterCustomerTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterTeamTable_MasterCustomerTable_CustomerId",
                table: "MasterTeamTable",
                column: "CustomerId",
                principalTable: "MasterCustomerTable",
                principalColumn: "Id");
        }
    }
}
