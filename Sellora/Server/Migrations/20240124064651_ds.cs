using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sellora.Server.Migrations
{
    /// <inheritdoc />
    public partial class ds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 899, DateTimeKind.Local).AddTicks(3657), "AQAAAAIAAYagAAAAEG+zH6ECw992hT9IGsX2tnwvWjJyvNDLpuETdSC8fVzbAZjISYrRVgKENh7PoIbZSQ==", new DateTime(2024, 1, 24, 14, 46, 50, 899, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 959, DateTimeKind.Local).AddTicks(9486), "AQAAAAIAAYagAAAAEKMhVM/yy50bbexFGGMvjjV6kw3wylGEd+I78OegnTCOzMDay8c8YTbys9MHzkHYqQ==", new DateTime(2024, 1, 24, 14, 46, 50, 959, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 51, 39, DateTimeKind.Local).AddTicks(1357), "AQAAAAIAAYagAAAAEGT0vHOVW1NpVKaPHLwkIL5boo+0HjVsOFDvhgcioARVr3ha9amXoOXH9wrsH0RGHQ==", new DateTime(2024, 1, 24, 14, 46, 51, 39, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 51, 80, DateTimeKind.Local).AddTicks(1897), "AQAAAAIAAYagAAAAEJ6HXseKAnXDdFNCJ2MACFQJduRzUuSQNlsSxNczLE5ZWPhuR0XzMH+PCRJ6l1efdg==", new DateTime(2024, 1, 24, 14, 46, 51, 80, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 51, 136, DateTimeKind.Local).AddTicks(8656), "AQAAAAIAAYagAAAAEFotQAOxK8Z+IzGIUXqG2jd8ezrzc8qOb/GWPA2vZswpAlQdsXR9I9SY5Y18s0zWRA==", new DateTime(2024, 1, 24, 14, 46, 51, 136, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "3ea142ba-ba38-44b8-9b9f-7e60db68f6fd", "AQAAAAIAAYagAAAAEMtrXmAA8mOEVXNCEFcCMaiEJbXEXs1of9POVzedT5nGCBP/keBhRni/C7gxWzBIGg==", "38c1d572-42e5-4268-a312-9838908e77ea", new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(4287), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1675205-1948-44ec-8b55-b0cb71d1f84e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "7ced6f5c-2b4b-49ee-96a1-21ffa4c00854", "AQAAAAIAAYagAAAAEEKcO4NYc/+HButw/ZuH0oGAHlr2t0Ld5/vSbwffSneedpva1ukZ8BekDdV6nVrVDw==", "e7eedbe4-1cec-4255-8394-f33de6338efe", new DateTime(2024, 1, 24, 14, 46, 50, 812, DateTimeKind.Local).AddTicks(5037), new DateTime(2024, 1, 24, 14, 46, 50, 812, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3654), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3656), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3656), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 1, 24, 14, 46, 50, 770, DateTimeKind.Local).AddTicks(3657) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 931, DateTimeKind.Local).AddTicks(5565), "AQAAAAIAAYagAAAAEMV4CzaLtyAmgDaRxOssHy6FzoEMfH+KTg8eGRUHqg2DCCFqRTheMgjPfdl/4J2nxg==", new DateTime(2024, 1, 24, 11, 25, 51, 931, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 977, DateTimeKind.Local).AddTicks(7674), "AQAAAAIAAYagAAAAEImNY6vPW3Zn3Nk6c1sxnOVC5Wf6JA6jEApweb/qGVxcZFmtJnSgkByedZISDf98vg==", new DateTime(2024, 1, 24, 11, 25, 51, 977, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 52, 28, DateTimeKind.Local).AddTicks(8765), "AQAAAAIAAYagAAAAEDdGZo40TTGg95+uKTVOgApKkK0+0Edj95tGcLs6DAySdL8RHuRu2weIFjMcj5y6wg==", new DateTime(2024, 1, 24, 11, 25, 52, 28, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 52, 77, DateTimeKind.Local).AddTicks(2742), "AQAAAAIAAYagAAAAECdSxUslUYbjEBeqQqMlOUlAr1UjVjLOmkpmNyeScqWZn6COvZcAQhsQZ4qC1IH3ag==", new DateTime(2024, 1, 24, 11, 25, 52, 77, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UserLastOnline", "UserPassword", "UserRegDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 52, 126, DateTimeKind.Local).AddTicks(9251), "AQAAAAIAAYagAAAAEMxepGIenhuy7OtgpYbE+fbyZJPCbLYiTctKyxMSSigM/qf8iP1iXO/wnBSR/K/Fwg==", new DateTime(2024, 1, 24, 11, 25, 52, 126, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "9ac20708-8d62-4f27-be7d-360f7d69bc1f", "AQAAAAIAAYagAAAAEChtF88JPuqyoG6vijf6or6S5L1rdV1GnYFENzLd83SOONWAv2XvG1fdjQxYCiQ4xg==", "2013c9ad-bfd9-4499-95b4-6d949e89e2da", new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1675205-1948-44ec-8b55-b0cb71d1f84e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserLastOnline", "UserRegDate" },
                values: new object[] { "88434fbb-2f05-430c-834c-84d480ee4b18", "AQAAAAIAAYagAAAAEDPynsGBcMfybaJZGyNuKOH+95GXEijabDWmg67vRLy1ImMtlYH0b9tIqok+q9+Vzg==", "08e656ef-1a4c-462d-8f10-3d699c574dde", new DateTime(2024, 1, 24, 11, 25, 51, 839, DateTimeKind.Local).AddTicks(643), new DateTime(2024, 1, 24, 11, 25, 51, 839, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(6086), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(6105), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5499), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5513), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5551), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5565), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5598), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "StaffHireDate" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5660), new DateTime(2024, 1, 24, 11, 25, 51, 791, DateTimeKind.Local).AddTicks(5641) });
        }
    }
}
