using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AplikasiBarbershop.Migrations
{
    /// <inheritdoc />
    public partial class initulang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterBiodataTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "MasterUserTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    BiodataId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_MasterUserTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterUserTable_MasterBiodataTable_BiodataId",
                        column: x => x.BiodataId,
                        principalTable: "MasterBiodataTable",
                        principalColumn: "Id");
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
                    UserId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_MasterServicesTable_MasterUserTable_UserId",
                        column: x => x.UserId,
                        principalTable: "MasterUserTable",
                        principalColumn: "Id");
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
                    UserId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_MasterTeamTable_MasterUserTable_UserId",
                        column: x => x.UserId,
                        principalTable: "MasterUserTable",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "MasterBiodataTable",
                columns: new[] { "Id", "Address", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Email", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Jl. Semangka No.2, jakarta", "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(7570), null, null, "irfan@gmail.com", false, null, null, "Irfan Hakim", "08123809123" },
                    { 2, "Jl. Mangga No.5, jakarta", "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(7577), null, null, "andreas@gmail.com", false, null, null, "Andreas", "081234809123" },
                    { 3, "Jl. Nangka No.2, jakarta", "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(7579), null, null, "paul@gmail.com", false, null, null, "Paul", "081123123341" },
                    { 4, "Jl. Pisang No.2, jakarta", "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(7581), null, null, "barbara@gmail.com", false, null, null, "Barbara", "0845546309123" }
                });

            migrationBuilder.InsertData(
                table: "MasterServicesTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "ServicesName", "UserId" },
                values: new object[,]
                {
                    { 2, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(1726), null, null, "Style comma haircut, modern hair style", "https://www.k-craze.com/wp-content/uploads/2021/09/image-138.jpg", false, null, null, 250000.0, "Haircut Comma hair", null },
                    { 3, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(1728), null, null, "Style Mohawk haircut, short side", "https://www.hottesthaircuts.com/wp-content/uploads/2018/02/3.-High-Mohawk-Fade.jpg", false, null, null, 150000.0, "Haircut Mohawk", null },
                    { 4, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(1730), null, null, "Style wolfcut style, Modern wolfcut", "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg", false, null, null, 500000.0, "Haircut wolfcut style", null }
                });

            migrationBuilder.InsertData(
                table: "MasterTeamTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Email", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Phone", "Role", "Status", "UserId" },
                values: new object[] { 3, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(3491), null, null, "putri@gmail.com", false, null, null, "Putri", "081278911232", 1, 0, null });

            migrationBuilder.InsertData(
                table: "MasterUserTable",
                columns: new[] { "Id", "BiodataId", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(9561), null, null, false, null, null, "5f9235e4a01a1426a8b791e239f0c72f65ad1bc8a7cc3a6c163486c1f86037a0", 0, "admin" },
                    { 2, 2, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(9566), null, null, false, null, null, "f7cc0b90dbc18a9255efa5d8193dffb78d9cfa193d5900f1a64d548c53d2e78c", 1, "andreas" },
                    { 3, 3, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(9568), null, null, false, null, null, "dd6fa3a9f24e38363058d610c26f935bf7952f9c4f74ea60d52a1de1b27aa7f6", 1, "paul" },
                    { 4, 4, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(9571), null, null, false, null, null, "1d1f5e19b999d7e8a96bcc99b83c13c5d0f1aa134b25dd638c9d4a7d871cec0a", 1, "barbara" }
                });

            migrationBuilder.InsertData(
                table: "MasterServicesTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "ServicesName", "UserId" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(1712), null, null, "Style mullet haircut, short side", "https://haircutinspiration.com/wp-content/uploads/perm-mullet-with-quiff-750x937.jpg", false, null, null, 200000.0, "Haircut Mullet style", 2 },
                    { 5, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(1732), null, null, "Cream bath Services, Dandruff care", "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg", false, null, null, 400000.0, "Hair Care", 2 }
                });

            migrationBuilder.InsertData(
                table: "MasterTeamTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "DeletedBy", "DeletedDate", "Email", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Phone", "Role", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(3484), null, null, "buid@gmail.com", false, null, null, "Budi", "081278912302", 0, 1, 2 },
                    { 2, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(3489), null, null, "asep@gmail.com", false, null, null, "Asep", "081123122302", 0, 1, 3 },
                    { 4, "admin", new DateTime(2024, 7, 7, 9, 5, 13, 297, DateTimeKind.Local).AddTicks(3493), null, null, "susi@gmail.com", false, null, null, "Susi", "0812789123112", 2, 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasterBiodataTable_Email",
                table: "MasterBiodataTable",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterServicesTable_UserId",
                table: "MasterServicesTable",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterTeamTable_UserId",
                table: "MasterTeamTable",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MasterUserTable_BiodataId",
                table: "MasterUserTable",
                column: "BiodataId",
                unique: true,
                filter: "[BiodataId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MasterUserTable_UserName",
                table: "MasterUserTable",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterServicesTable");

            migrationBuilder.DropTable(
                name: "MasterTeamTable");

            migrationBuilder.DropTable(
                name: "MasterUserTable");

            migrationBuilder.DropTable(
                name: "MasterBiodataTable");
        }
    }
}
