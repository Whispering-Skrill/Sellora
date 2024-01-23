using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sellora.Server.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 520, DateTimeKind.Local).AddTicks(9435), "AQAAAAIAAYagAAAAEB/qmEKSC2lFEKSqUBGB4IlrNmqYPIqTuQRhsvEZdlLsZkwofP6RH394l9XNIm1Ceg==", new DateTime(2024, 1, 24, 0, 53, 23, 520, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 560, DateTimeKind.Local).AddTicks(4401), "AQAAAAIAAYagAAAAEO6BolcVu7eKa5wXuiY7z2toTuGHCkpmtvdjfvEUkTuDK6hsfdpxbitPP+TVLSRZow==", new DateTime(2024, 1, 24, 0, 53, 23, 560, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 613, DateTimeKind.Local).AddTicks(6215), "AQAAAAIAAYagAAAAEKg2YHxhsSIEyYEGtJRxEoaQzPtICtJKiwQRuB0g2ljmQArAAaEgH7o5+gfKW9PKoA==", new DateTime(2024, 1, 24, 0, 53, 23, 613, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 671, DateTimeKind.Local).AddTicks(7644), "AQAAAAIAAYagAAAAELDNntfXQcl0B2Z5Yq7THNMKSgZFSo55+0I0ayeFXJgw+tgGpBLLU27OeUTD06EzOA==", new DateTime(2024, 1, 24, 0, 53, 23, 671, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 716, DateTimeKind.Local).AddTicks(6385), "AQAAAAIAAYagAAAAEK2fzOgu15a9pr8tgS9VtlO1DJhQ9+v9lBu8Jf8HWf1trRyr4LJeFbXGro+zYskmeA==", new DateTime(2024, 1, 24, 0, 53, 23, 716, DateTimeKind.Local).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "26c1bc0e-8a38-439e-b358-566645ce271b", "AQAAAAIAAYagAAAAEKZ4/TwlKyRTJTmXLt5dp2m2sbkveGO8ZRu3WA4MClGoSOxvptYacDlLttG1ZKcQqQ==", "4e30f63a-fa89-4ace-89cd-cb1357e3a400", new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1675205-1948-44ec-8b55-b0cb71d1f84e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "dfc69937-8868-4932-9665-0e8bfa7a195b", "AQAAAAIAAYagAAAAELL16zjdedp7p31OmWSKLDqFyTYQ4KqTRjUKaWlNVZFG2C1CKFJ8S3tx//w7ThPd0g==", "7190a58c-fa68-4f5d-821a-8884b7b2c2ab", new DateTime(2024, 1, 24, 0, 53, 23, 440, DateTimeKind.Local).AddTicks(9868), new DateTime(2024, 1, 24, 0, 53, 23, 440, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(2040), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(2042), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1592), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1595), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1605), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1605), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1608), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1608), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1610), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1610), new DateTime(2024, 1, 24, 0, 53, 23, 400, DateTimeKind.Local).AddTicks(1609) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 443, DateTimeKind.Local).AddTicks(1809), "AQAAAAIAAYagAAAAEIhubNBPf/NlNZkmxlwwsKDE3tzy/Zksvo0CO+DN852svjO8y6H66tPUnbWkeF2dfQ==", new DateTime(2024, 1, 23, 19, 13, 36, 443, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 484, DateTimeKind.Local).AddTicks(140), "AQAAAAIAAYagAAAAEMfLIAky08vn+f8xWkm9e9KQCjroF2/tlFdoSmrXNg6mIsvreC+WD5+kyz0V7J+lJg==", new DateTime(2024, 1, 23, 19, 13, 36, 484, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 521, DateTimeKind.Local).AddTicks(9004), "AQAAAAIAAYagAAAAEHRzdH/4Cant9lLUvJey5wThqCz7oY6uhy+/8iW1mkPLjLz49Pj8FWx7nzeHEFSyBA==", new DateTime(2024, 1, 23, 19, 13, 36, 521, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 559, DateTimeKind.Local).AddTicks(2329), "AQAAAAIAAYagAAAAEDB9GLh8j/t+KVWVzrAKhV8+i7iUcr1CAAMBjXf3ghpjwhLrYxLM7eorVUWs18dyYw==", new DateTime(2024, 1, 23, 19, 13, 36, 559, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 598, DateTimeKind.Local).AddTicks(7547), "AQAAAAIAAYagAAAAEFTjthRElJp3xLs/r3DptoImhooZ10FdC8zL8IIznTNsOn7bsyDYebFN0vXw92Jedw==", new DateTime(2024, 1, 23, 19, 13, 36, 598, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "2df50eb4-c6c6-4f9c-97ac-5101d19b0d5e", "AQAAAAIAAYagAAAAECubqSovmy8RtvhXO82bg/t/8IwWxxNeKKX/mykOLYkGYlKq2EfzNk+B51X7+x/cdQ==", "2f2d1e03-3713-4b45-96de-bbc645802a81", new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1675205-1948-44ec-8b55-b0cb71d1f84e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "09519356-1281-4dce-806c-7a0e08ee528e", "AQAAAAIAAYagAAAAEN9QE30CBuLpf0m9TCNLi3u5JGJRRsADv14wnb2krdFLXLg9lVdpYDR55Woq3IgcIA==", "6cc4aa66-8ff3-4b0b-b7fe-440e62ae8462", new DateTime(2024, 1, 23, 19, 13, 36, 350, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 1, 23, 19, 13, 36, 350, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8418), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8148), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8154), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 1, 23, 19, 13, 36, 312, DateTimeKind.Local).AddTicks(8155) });
        }
    }
}
