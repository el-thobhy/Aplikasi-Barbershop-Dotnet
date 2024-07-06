using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplikasiBarbershop.Migrations
{
    /// <inheritdoc />
    public partial class addrelationcustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "MasterTeamTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "MasterServicesTable",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 21, 33, 55, 90, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "CustomerId" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6702), 2 });

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "CustomerId" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6714), null });

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "CustomerId" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6716), null });

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "CustomerId" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6718), null });

            migrationBuilder.InsertData(
                table: "MasterServicesTable",
                columns: new[] { "Id", "CreateBy", "CreateDate", "CustomerId", "DeletedBy", "DeletedDate", "Description", "ImageUrl", "IsDeleted", "ModifiedBy", "ModifiedDate", "Price", "ServicesName" },
                values: new object[] { 5, "admin", new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(6721), 2, null, null, "Cream bath Services, Dandruff care", "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg", false, null, null, 400000.0, "Hair Care" });

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "CustomerId", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8394), 1, 1 });

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "CustomerId" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8399), 2 });

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "CustomerId" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8401), null });

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "CustomerId" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 33, 55, 89, DateTimeKind.Local).AddTicks(8403), 4 });

            migrationBuilder.CreateIndex(
                name: "IX_MasterTeamTable_CustomerId",
                table: "MasterTeamTable",
                column: "CustomerId",
                unique: true,
                filter: "[CustomerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MasterServicesTable_CustomerId",
                table: "MasterServicesTable",
                column: "CustomerId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterServicesTable_MasterCustomerTable_CustomerId",
                table: "MasterServicesTable");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterTeamTable_MasterCustomerTable_CustomerId",
                table: "MasterTeamTable");

            migrationBuilder.DropIndex(
                name: "IX_MasterTeamTable_CustomerId",
                table: "MasterTeamTable");

            migrationBuilder.DropIndex(
                name: "IX_MasterServicesTable_CustomerId",
                table: "MasterServicesTable");

            migrationBuilder.DeleteData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "MasterTeamTable");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "MasterServicesTable");

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "MasterCustomerTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 615, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Status" },
                values: new object[] { new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8457), 0 });

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 6, 20, 3, 23, 614, DateTimeKind.Local).AddTicks(8474));
        }
    }
}
