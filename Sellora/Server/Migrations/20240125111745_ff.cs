using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sellora.Server.Migrations
{
    /// <inheritdoc />
    public partial class ff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 46, 135, DateTimeKind.Local).AddTicks(2095), "AQAAAAIAAYagAAAAEIp2y/7eDLCkRM9eku5qrCmzN8j5XVzbQtzQeaPxR0D32wgZMx0fQS7XFNPXO64ORA==", new DateTime(2024, 1, 25, 13, 27, 46, 135, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 46, 180, DateTimeKind.Local).AddTicks(9373), "AQAAAAIAAYagAAAAECydI5Bk2LCLrzwyetdxgR/X1gC97QdvlKFsTLDLprdD39q/vtIe9AEDHnqqQiek0Q==", new DateTime(2024, 1, 25, 13, 27, 46, 180, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 46, 227, DateTimeKind.Local).AddTicks(2542), "AQAAAAIAAYagAAAAELXjQjbJNeQ7sBEBnU2YEQ3gc6zF49Xah99EIxm4kPObEDuLbuiEQwHjHExY6bKSDQ==", new DateTime(2024, 1, 25, 13, 27, 46, 227, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 46, 274, DateTimeKind.Local).AddTicks(7283), "AQAAAAIAAYagAAAAEIkvVRbXr1S+075zGUEf5VDgrqjil93ydBjlB0ivN4MYs2hNSdyb/LSP6Iqt/EVUEQ==", new DateTime(2024, 1, 25, 13, 27, 46, 274, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 46, 320, DateTimeKind.Local).AddTicks(8341), "AQAAAAIAAYagAAAAEIctFDisCIKWZx51y6BQeY5hrGfT9bV4kepbW90s5CloVdEVGDqguqfY/l7iO9dFMg==", new DateTime(2024, 1, 25, 13, 27, 46, 320, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "4cde4dcd-2ee3-4033-8a61-d9ad77a5dd76", "AQAAAAIAAYagAAAAEMYA5w62e7kOoCU9Gq9C7gaRmwLIi4gGMINSS2XelHwPNwT1ZpP+pQXp7PIdcoOD6Q==", "fb32ccd1-17c8-48b5-a0ee-9c271f62068a", new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1675205-1948-44ec-8b55-b0cb71d1f84e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "5bdf2520-e55c-4cc5-b66d-15fbe78fddd0", "AQAAAAIAAYagAAAAEMuon+dmJ1DHo2yS3uaBjgdHKaky6YIVLKP2YE+DYy5S/hDa9r2mWNaANpNNOJ2MlA==", "37975fde-1c6d-4535-a3ad-87bc577bf75c", new DateTime(2024, 1, 25, 13, 27, 46, 44, DateTimeKind.Local).AddTicks(789), new DateTime(2024, 1, 25, 13, 27, 46, 44, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7487), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7023), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7070), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 1, 25, 13, 27, 45, 997, DateTimeKind.Local).AddTicks(7103) });
        }
    }
}
