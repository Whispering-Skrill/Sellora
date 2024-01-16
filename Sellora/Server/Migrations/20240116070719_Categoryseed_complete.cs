using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sellora.Server.Migrations
{
    /// <inheritdoc />
    public partial class Categoryseed_complete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Technology", "System", new DateTime(2024, 1, 16, 15, 7, 18, 902, DateTimeKind.Local).AddTicks(141), new DateTime(2024, 1, 16, 15, 7, 18, 902, DateTimeKind.Local).AddTicks(142), "System" },
                    { 2, "Fashion", "System", new DateTime(2024, 1, 16, 15, 7, 18, 902, DateTimeKind.Local).AddTicks(144), new DateTime(2024, 1, 16, 15, 7, 18, 902, DateTimeKind.Local).AddTicks(144), "System" }
                });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 7, 18, 901, DateTimeKind.Local).AddTicks(9761), new DateTime(2024, 1, 16, 15, 7, 18, 901, DateTimeKind.Local).AddTicks(9762), new DateTime(2024, 1, 16, 15, 7, 18, 901, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 7, 18, 901, DateTimeKind.Local).AddTicks(9794), new DateTime(2024, 1, 16, 15, 7, 18, 901, DateTimeKind.Local).AddTicks(9794), new DateTime(2024, 1, 16, 15, 7, 18, 901, DateTimeKind.Local).AddTicks(9793) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 16, 14, 13, 14, 0, DateTimeKind.Local).AddTicks(9534), new DateTime(2024, 1, 16, 14, 13, 14, 0, DateTimeKind.Local).AddTicks(9535), new DateTime(2024, 1, 16, 14, 13, 14, 0, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 16, 14, 13, 14, 0, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 1, 16, 14, 13, 14, 0, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 1, 16, 14, 13, 14, 0, DateTimeKind.Local).AddTicks(9538) });
        }
    }
}
