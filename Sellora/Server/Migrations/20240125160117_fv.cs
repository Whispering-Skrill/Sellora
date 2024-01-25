using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sellora.Server.Migrations
{
    /// <inheritdoc />
    public partial class fv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 717, DateTimeKind.Local).AddTicks(4420), "AQAAAAIAAYagAAAAEFP12EuPLSgiGblyhsdxTWtlPd/scc3xwGh/eoxmLQSMP1Hscbw7TpNu7uxLdo5yDQ==", new DateTime(2024, 1, 26, 0, 1, 16, 717, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 762, DateTimeKind.Local).AddTicks(2156), "AQAAAAIAAYagAAAAEEgA2B0Q2STlPx7xtw2KsaOO2L+8cUs9LA2pLTNJQW2+MjfLktYWkedJ3KKVRGIONQ==", new DateTime(2024, 1, 26, 0, 1, 16, 762, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 802, DateTimeKind.Local).AddTicks(1269), "AQAAAAIAAYagAAAAELsev9dpHLSKdNHXXQcDnpbVpBJur5kXm88BQ5gXB0taAULy1ANuTH2E/A3A2RVkaQ==", new DateTime(2024, 1, 26, 0, 1, 16, 802, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 840, DateTimeKind.Local).AddTicks(5328), "AQAAAAIAAYagAAAAEJXCqm/Ahx7TjivEixPQE/cN3Jk7JHvADHzW8KAmu861bqj2JVahN+27VW/cZMBBcg==", new DateTime(2024, 1, 26, 0, 1, 16, 840, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 883, DateTimeKind.Local).AddTicks(4369), "AQAAAAIAAYagAAAAEAB+H5W3AAHhn5E2YrpFG22Q2ptwogFrSFpEyfB8iNPwxnU+jL61RZd0qQi9ASBePA==", new DateTime(2024, 1, 26, 0, 1, 16, 883, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "8001cc70-35dc-4b8c-83c0-c96e8e25ec03", "AQAAAAIAAYagAAAAEC0yc1M2ffQnDqUx9ermPRlF9OHm5sdx4SH5BOS/uDjxUjPS915YPcUY56mBAOdvAg==", "950ce4c6-fbd1-46b4-9f0f-68ae7e25ac52", new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9808), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1675205-1948-44ec-8b55-b0cb71d1f84e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "1484938b-fbc6-4674-9d56-8a37a54a7576", "AQAAAAIAAYagAAAAEH6NG/RJf8VNPB8aXKvG0q7HR+70IDAX7ynhJY37HgZ2JkMJUlKrO2JghFJKveHT5w==", "20d020e1-15b4-451d-b5e6-d9ed9d988d2e", new DateTime(2024, 1, 26, 0, 1, 16, 634, DateTimeKind.Local).AddTicks(1760), new DateTime(2024, 1, 26, 0, 1, 16, 634, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9634), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9636), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "Cars", "System", new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9637), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9637), "System" },
                    { 4, "Luxury", "System", new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9638), "System" },
                    { 5, "Property", "System", new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9640), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9640), "System" }
                });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9341), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9341), new DateTime(2024, 1, 26, 0, 1, 16, 595, DateTimeKind.Local).AddTicks(9340) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 139, DateTimeKind.Local).AddTicks(1869), "AQAAAAIAAYagAAAAENO673AtYdPO+vUnylfYhasFoJgGdSwz2e4fBeEdEz5p+Z5ymtSDNH6uy5Dm06MrJw==", new DateTime(2024, 1, 25, 19, 17, 45, 139, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 181, DateTimeKind.Local).AddTicks(2277), "AQAAAAIAAYagAAAAED63TyVCzpGHdLTDEtipb9fi37XlepUGclNx4m/iIwlknruz0Ml6lKQpUcX5NAhsyQ==", new DateTime(2024, 1, 25, 19, 17, 45, 181, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 224, DateTimeKind.Local).AddTicks(6191), "AQAAAAIAAYagAAAAEEZK2InD9yrcNcFzfmUXzeETCq/9JArCtWiMbnj5uG7ZqsYShFHvYrD8/Whj5vuHxQ==", new DateTime(2024, 1, 25, 19, 17, 45, 224, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 263, DateTimeKind.Local).AddTicks(702), "AQAAAAIAAYagAAAAEJLBORPRf4ni8vdMG3WYjOpt2iLMkfJjSarEGPzmXg3Al2FdK91isUwPgQtptQsHaQ==", new DateTime(2024, 1, 25, 19, 17, 45, 263, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 300, DateTimeKind.Local).AddTicks(1470), "AQAAAAIAAYagAAAAEMinDC7PtNRI/iQRKVkeQRbv40oeT50wNpezXJohGZs9YS8IwzGu9rmNnJWGTiujJA==", new DateTime(2024, 1, 25, 19, 17, 45, 300, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "282d3c5a-c765-4e7a-8d56-a7d31e356754", "AQAAAAIAAYagAAAAEBSYLyxda4XtGYA1WZqdi26jkOtQCyyw3VwCxzN8+mMDIFAitni+bM/BzW4suhFUWQ==", "af17f7c6-99d3-4bf4-aadd-a007182ca846", new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1675205-1948-44ec-8b55-b0cb71d1f84e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "e14f9805-1c8d-4ef2-ad25-0704ca6a2981", "AQAAAAIAAYagAAAAEBfX3BcwYoPeF1hEl8GF7SMf3r7DulWz6i3ty3pzzkw2HpCEd0up8UAdeTXdYNeZ3w==", "a61086c7-47de-46c6-a68d-204b66cbf230", new DateTime(2024, 1, 25, 19, 17, 45, 61, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 1, 25, 19, 17, 45, 61, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6104), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6105), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6108), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6109), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 1, 25, 19, 17, 45, 22, DateTimeKind.Local).AddTicks(6111) });
        }
    }
}
