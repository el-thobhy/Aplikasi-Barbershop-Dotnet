using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplikasiBarbershop.Migrations
{
    /// <inheritdoc />
    public partial class updatepropertyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 40, 974, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { 1, new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { 2, new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { 3, new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { 4, new DateTime(2024, 7, 7, 9, 22, 40, 975, DateTimeKind.Local).AddTicks(1816) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "MasterBiodataTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "MasterServicesTable",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "MasterTeamTable",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 7, 7, 9, 22, 3, 704, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 7, 9, 22, 3, 705, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 7, 9, 22, 3, 705, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 7, 9, 22, 3, 705, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "MasterUserTable",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BiodataId", "CreateDate" },
                values: new object[] { null, new DateTime(2024, 7, 7, 9, 22, 3, 705, DateTimeKind.Local).AddTicks(1198) });
        }
    }
}
