using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sellora.Server.Migrations
{
    /// <inheritdoc />
    public partial class Complete_DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserHPNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserLastOnline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastOnline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffFirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StaffLastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StaffEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffHireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffPosition = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StaffAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StaffHPNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffDepartment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ItemPrice = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ItemDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ItemLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemLikes = table.Column<int>(type: "int", nullable: false),
                    ItemClicks = table.Column<int>(type: "int", nullable: false),
                    ItemStatus = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleTransactions_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SaleTransactions_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SwapTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUser1Id = table.Column<int>(type: "int", nullable: false),
                    SwapItem1Id = table.Column<int>(type: "int", nullable: false),
                    AppUser2Id = table.Column<int>(type: "int", nullable: false),
                    SwapItem2Id = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwapTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SwapTransactions_AppUsers_AppUser1Id",
                        column: x => x.AppUser1Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SwapTransactions_AppUsers_AppUser2Id",
                        column: x => x.AppUser2Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SwapTransactions_Items_SwapItem1Id",
                        column: x => x.SwapItem1Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SwapTransactions_Items_SwapItem2Id",
                        column: x => x.SwapItem2Id,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReportContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    SaleTransactionID = table.Column<int>(type: "int", nullable: true),
                    SwapTransactionID = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_SaleTransactions_SaleTransactionID",
                        column: x => x.SaleTransactionID,
                        principalTable: "SaleTransactions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reports_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reports_SwapTransactions_SwapTransactionID",
                        column: x => x.SwapTransactionID,
                        principalTable: "SwapTransactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReviewRating = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SaleTransactionID = table.Column<int>(type: "int", nullable: true),
                    SwapTransactionID = table.Column<int>(type: "int", nullable: true),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_SaleTransactions_SaleTransactionID",
                        column: x => x.SaleTransactionID,
                        principalTable: "SaleTransactions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_SwapTransactions_SwapTransactionID",
                        column: x => x.SwapTransactionID,
                        principalTable: "SwapTransactions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy", "UserDescription", "UserEmail", "UserFirstName", "UserHPNum", "UserLastName", "UserLastOnline", "UserName", "UserPassword", "UserRegDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Passionate about all things digital and SEO wizardry 🚀 | Helping businesses climb the search engine ranks 📈 | Coffee enthusiast ☕ | Explorer of new tech and trends 🌐 | #SEOExpert #DigitalMarketing", "sy123@gmail.com", "Seo", "88123123", "Yeong", new DateTime(2024, 2, 1, 1, 15, 47, 375, DateTimeKind.Local).AddTicks(9335), "SeoCoolSeoYeong", "AQAAAAIAAYagAAAAEIK0RkkFU97DaxnPb04SbyU/1FCe3Ga18VJX5CdDRTOpKOkrh8z0kEeWSk4a1YvuVQ==", new DateTime(2024, 2, 1, 1, 15, 47, 375, DateTimeKind.Local).AddTicks(9321) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Creative soul navigating the digital realm 🌟 | Graphic designer by day, dreamer by night ✨ | Turning ideas into visual wonders 🎨 | Coffee addict ☕ | Embracing the beauty of design and storytelling 🖌️ | #GraphicDesigner #Dreamer", "tt123@gmail.com", "Tina", "88445566", "Tan", new DateTime(2024, 2, 1, 1, 15, 47, 423, DateTimeKind.Local).AddTicks(2174), "TT_4Me", "AQAAAAIAAYagAAAAEBY3RDBBGIqZeISpegvBc0zb1T427JBTr/Cq0KykZzAQJuuGJEZTo5aNhRMFC1a0xg==", new DateTime(2024, 2, 1, 1, 15, 47, 423, DateTimeKind.Local).AddTicks(2160) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Adventurous spirit with a flair for tech and innovation 🚀 | Coding maestro by day, gaming wizard by night 🎮 | Constantly exploring the digital frontier 💻 | Fuelled by curiosity and a love for challenges 🌐 | Living life one line of code at a time! #TechExplorer #GamingEnthusiast", "kl23@gmail.com", "Kaynan", "85445666", "Loh", new DateTime(2024, 2, 1, 1, 15, 47, 474, DateTimeKind.Local).AddTicks(7731), "Kay_today", "AQAAAAIAAYagAAAAEJIiNaMO0tkMtTIk0ztGNbcQ76nxYS89IL2AudEmqAONm9ckkpIYNo0yZ+/pCEXYbg==", new DateTime(2024, 2, 1, 1, 15, 47, 474, DateTimeKind.Local).AddTicks(7717) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Passionate about coding adventures and tech wonders 🌟 | Coffee-fueled developer by day, gaming enthusiast by night 🎮 | Embracing challenges and turning ideas into reality 💡 | #CodeExplorer #TechEnthusiast", "alex.smith@example.com", "Alex", "98765210", "Smith", new DateTime(2024, 2, 1, 1, 15, 47, 528, DateTimeKind.Local).AddTicks(3878), "AdventureCoder", "AQAAAAIAAYagAAAAEJhis6c3x13GJncju9eV/ofieM1wGJbFDsyghI00fJWsxXA48hVZx0zK1kKxqzqdcA==", new DateTime(2024, 2, 1, 1, 15, 47, 528, DateTimeKind.Local).AddTicks(3860) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Digital nomad exploring the virtual realms 🌍 | Coding on-the-go and crafting unique digital experiences ✨ | Passionate about connecting through technology 🚀 | #DigitalNomad #CodeExplorer", "emma.johnson@example.com", "Emma", "87654109", "Johnson", new DateTime(2024, 2, 1, 1, 15, 47, 585, DateTimeKind.Local).AddTicks(6153), "DigitalNomad21", "AQAAAAIAAYagAAAAEFe7teDvWyOEM/7bJ8+PTJjQwtWurblx30UUVyzS1vLjB87yr8mDkyGuHMNps2HNSg==", new DateTime(2024, 2, 1, 1, 15, 47, 585, DateTimeKind.Local).AddTicks(6138) },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tech enthusiast looking to swap and sell gadgets 📱💻 | Always up for the latest tech trends and innovations 🚀 | Let's connect and trade! #TechSwap #GadgetLover", "alex.smith@example.com", "Alex", "98763210", "Smith", new DateTime(2024, 2, 1, 1, 15, 47, 636, DateTimeKind.Local).AddTicks(5352), "TechEnthusiast", "AQAAAAIAAYagAAAAEOWPe1MsvM66jqPDX/7tl1vcQWnzch7fG1wFpuZs70BV6CZd3NWq1cSTJtrzJk1yXA==", new DateTime(2024, 2, 1, 1, 15, 47, 636, DateTimeKind.Local).AddTicks(5338) },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fashionista with a passion for style and trends 👗👠 | Closet cleanout and trendy swaps | Let's trade fashion finds! #FashionSwap #StyleExplorer", "sophie.miller@example.com", "Sophie", "87698765", "Miller", new DateTime(2024, 2, 1, 1, 15, 47, 689, DateTimeKind.Local).AddTicks(574), "Fashionista23", "AQAAAAIAAYagAAAAENSuUHC634jh9JKqYgHeWB5SbBk1jUGIkqSTkgf6Vr22Go/3QxZSciClksfMoU00Dw==", new DateTime(2024, 2, 1, 1, 15, 47, 689, DateTimeKind.Local).AddTicks(560) },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gaming pro seeking to trade and sell video games 🎮 | From classics to the latest releases | Let's level up together! #GameSwap #GamerLife", "ryan.clark@example.com", "Ryan", "90345678", "Clark", new DateTime(2024, 2, 1, 1, 15, 47, 739, DateTimeKind.Local).AddTicks(5297), "GamingPro99", "AQAAAAIAAYagAAAAECaXeXf9hXPTUpvSF1LQl8G/TXMBuN5aueUFli7YZMJ6TpWRd/rjANl30wa0QDQQ6g==", new DateTime(2024, 2, 1, 1, 15, 47, 739, DateTimeKind.Local).AddTicks(5278) },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bookworm passionate about literature 📚 | Looking to swap and sell books of all genres | Let's share the joy of reading! #BookSwap #LiteraryExplorer", "olivia.taylor@example.com", "Olivia", "87651256", "Taylor", new DateTime(2024, 2, 1, 1, 15, 47, 792, DateTimeKind.Local).AddTicks(3665), "BookWorm89", "AQAAAAIAAYagAAAAEC+/KaAZEA+d6ik4E4Jl2NCRJyH1XiSQ2quwxTGXOes6FSWK/ioESaaLdLYaSbVt3g==", new DateTime(2024, 2, 1, 1, 15, 47, 792, DateTimeKind.Local).AddTicks(3651) },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Outdoor enthusiast and adventurer 🏞️ | Swapping and selling outdoor gear and equipment | Let's explore the world together! #AdventureSwap #NatureExplorer", "jake.anderson@example.com", "Jake", "90129854", "Anderson", new DateTime(2024, 2, 1, 1, 15, 47, 841, DateTimeKind.Local).AddTicks(2582), "OutdoorAdventurer", "AQAAAAIAAYagAAAAELZVC2BiWvC2iiC0Pv16iOigzIBLZ3ZuPw4AyH+vUBEmNfYYfGU4ugI0NGmLvIzU8A==", new DateTime(2024, 2, 1, 1, 15, 47, 841, DateTimeKind.Local).AddTicks(2562) },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Home decor enthusiast with a flair for design 🏡 | Swapping and selling unique decor pieces | Let's create stylish living spaces! #DecorSwap #HomeDesign", "mia.ramirez@example.com", "Mia", "87652012", "Ramirez", new DateTime(2024, 2, 1, 1, 15, 47, 895, DateTimeKind.Local).AddTicks(9511), "HomeDecorGuru", "AQAAAAIAAYagAAAAEMwUCaZWDRL4bhN8NOdZSvQfhQjI4OXHRewqkWgl4VgtIGCHxGvy9uVeLKVvPjFLWg==", new DateTime(2024, 2, 1, 1, 15, 47, 895, DateTimeKind.Local).AddTicks(9497) },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fitness enthusiast on a journey to a healthier life 💪 | Swapping and selling workout gear and accessories | Let's achieve our fitness goals together! #FitnessSwap #HealthyLiving", "brandon.harris@example.com", "Brandon", "90125432", "Harris", new DateTime(2024, 2, 1, 1, 15, 47, 946, DateTimeKind.Local).AddTicks(6708), "FitnessFreak2024", "AQAAAAIAAYagAAAAEC1AR8hRqOhr6gG5tzxykRABCA1azSFx/r3REWd+IZFL0T22sGZOfi+bYsVsPx90UQ==", new DateTime(2024, 2, 1, 1, 15, 47, 946, DateTimeKind.Local).AddTicks(6689) },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Art lover and creative soul 🎨 | Swapping and selling unique artworks and handmade crafts | Let's appreciate and share the beauty of art! #ArtSwap #CreativeSpirit", "eva.chen@example.com", "Eva", "87655678", "Chen", new DateTime(2024, 2, 1, 1, 15, 47, 994, DateTimeKind.Local).AddTicks(6298), "ArtisticExplorer", "AQAAAAIAAYagAAAAELkHjefhTsODqRVckQRS7pQfgNFrxKp6N7dpC06BxkXYQIp+UJbxXpXzVwf42JcUOg==", new DateTime(2024, 2, 1, 1, 15, 47, 994, DateTimeKind.Local).AddTicks(6285) },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Passionate vintage collector and enthusiast 🕰️ | Swapping and selling unique retro finds | Let's cherish the charm of the past! #VintageSwap #RetroCollector", "lillian.baker@example.com", "Lillian", "90128543", "Baker", new DateTime(2024, 2, 1, 1, 15, 48, 42, DateTimeKind.Local).AddTicks(950), "VintageCollector", "AQAAAAIAAYagAAAAEEThSNn7JN4vdj7Xo84+IlA4b2EIvi5Cya00ejzx1XhIv5AazAO8SqeChQOoX3TqsQ==", new DateTime(2024, 2, 1, 1, 15, 48, 42, DateTimeKind.Local).AddTicks(936) },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Animal lover and pet enthusiast 🐾 | Swapping and selling pet accessories and supplies | Let's pamper our furry friends together! #PetSwap #AnimalCare", "david.nguyen@example.com", "David", "87656789", "Nguyen", new DateTime(2024, 2, 1, 1, 15, 48, 88, DateTimeKind.Local).AddTicks(2359), "PetLover21", "AQAAAAIAAYagAAAAENNbZnRKza0Vi8Z7VLREsee2tSQjv1S64ltfltg7pSvp/p7OrYgsHf8rmO5MjUNHtg==", new DateTime(2024, 2, 1, 1, 15, 48, 88, DateTimeKind.Local).AddTicks(2344) },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Film buff and cinephile 🎬 | Swapping and selling DVDs, Blu-rays, and movie memorabilia | Let's share our favorite cinematic experiences! #FilmSwap #Cinephilia", "rachel.mitchell@example.com", "Rachel", "9012654321", "Mitchell", new DateTime(2024, 2, 1, 1, 15, 48, 133, DateTimeKind.Local).AddTicks(4977), "FilmBuff87", "AQAAAAIAAYagAAAAENZkXx6lDemRiHQlXDJx67l/nMkjF8yWbUwq1QZ1lT1ixWQNv0RY+eNfQOItcoCzow==", new DateTime(2024, 2, 1, 1, 15, 48, 133, DateTimeKind.Local).AddTicks(4962) },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Music enthusiast and maestro 🎶 | Swapping and selling vinyl records, instruments, and music accessories | Let's create a symphony of sounds! #MusicSwap #MelodyMaker", "daniel.garcia@example.com", "Daniel", "8765567890", "Garcia", new DateTime(2024, 2, 1, 1, 15, 48, 181, DateTimeKind.Local).AddTicks(1869), "MusicMaestro", "AQAAAAIAAYagAAAAECbxh7p9IAZKUb7OCeZrREuWkE3jBE7YK2zGhAXGtstrov/7BpT9f0+g6Zn23T0xGw==", new DateTime(2024, 2, 1, 1, 15, 48, 181, DateTimeKind.Local).AddTicks(1851) },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DIY crafts enthusiast and artisan ✂️ | Swapping and selling handmade crafts and DIY supplies | Let's unleash our creative spirits! #CraftSwap #DIYArtisan", "ava.turner@example.com", "Ava", "9012543210", "Turner", new DateTime(2024, 2, 1, 1, 15, 48, 226, DateTimeKind.Local).AddTicks(9480), "DIYCraftsman", "AQAAAAIAAYagAAAAEHMliqCyfweeMtgHxCeiz1XOo3gnw1rsapFAivmUqEawGrw7bkVsrzDBtnRLPydkMg==", new DateTime(2024, 2, 1, 1, 15, 48, 226, DateTimeKind.Local).AddTicks(9466) },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Food lover and culinary adventurer 🍲 | Swapping and selling gourmet ingredients and kitchenware | Let's savor the flavors of the world! #FoodSwap #CulinaryExplorer", "isaac.evans@example.com", "Isaac", "8765678901", "Evans", new DateTime(2024, 2, 1, 1, 15, 48, 272, DateTimeKind.Local).AddTicks(9398), "FoodieExplorer", "AQAAAAIAAYagAAAAEIFXOTo80OyVs/iE6wQP8xnlkGiNRU/caq3BKHR2uw7g/bp/0wsmAUsIcpOnfLAyFw==", new DateTime(2024, 2, 1, 1, 15, 48, 272, DateTimeKind.Local).AddTicks(9383) },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fitness fanatic committed to a healthy lifestyle 💪 | Swapping and selling workout plans and fitness gear | Let's crush our fitness goals together! #FitnessSwap #HealthJunkie", "lily.carter@example.com", "Lily", "9012432109", "Carter", new DateTime(2024, 2, 1, 1, 15, 48, 319, DateTimeKind.Local).AddTicks(8642), "FitnessFanatic", "AQAAAAIAAYagAAAAEMQaxvTloyIRy8tgg3Jwv/rJexgP90emYVdbsWq/bb0h6IFPVZh0vocB6/ZnvEOoCQ==", new DateTime(2024, 2, 1, 1, 15, 48, 319, DateTimeKind.Local).AddTicks(8623) },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tech geek exploring the latest gadgets and innovations 🤖 | Swapping and selling tech accessories and devices | Let's embrace the digital revolution! #TechSwap #GadgetGeek", "logan.thompson@example.com", "Logan", "8765789012", "Thompson", new DateTime(2024, 2, 1, 1, 15, 48, 365, DateTimeKind.Local).AddTicks(8268), "TechGeek2024", "AQAAAAIAAYagAAAAEKV5phjNAXBu7cGCD34DZL3eeOHIbflmppOtkb/h1TgKHES8BdzaGAG2nhK7BnFFGQ==", new DateTime(2024, 2, 1, 1, 15, 48, 365, DateTimeKind.Local).AddTicks(8248) },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Plant enthusiast with a green thumb 🌿 | Swapping and selling unique plants and gardening tools | Let's cultivate our love for nature! #PlantSwap #GreenLiving", "sophia.williams@example.com", "Sophia", "9012321098", "Williams", new DateTime(2024, 2, 1, 1, 15, 48, 412, DateTimeKind.Local).AddTicks(2415), "PlantEnthusiast", "AQAAAAIAAYagAAAAEKGifakL+fImBXmNXZ1+V4jvWn6BWbldq0wLRiu29bWEEdvznWCF7dR76iCn4uJFbQ==", new DateTime(2024, 2, 1, 1, 15, 48, 412, DateTimeKind.Local).AddTicks(2400) },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Travel enthusiast with a passion for exploration ✈️ | Swapping and selling travel gear and accessories | Let's embark on new adventures! #TravelSwap #Wanderlust", "leo.hernandez@example.com", "Leo", "8765890123", "Hernandez", new DateTime(2024, 2, 1, 1, 15, 48, 458, DateTimeKind.Local).AddTicks(502), "TravelExplorer", "AQAAAAIAAYagAAAAEOAytrKN/rGYQ+2mXGobraY+Yz+wJc5wxA0EG5JcigtHfwYhoEFWnZYJv+CUv/TbZQ==", new DateTime(2024, 2, 1, 1, 15, 48, 458, DateTimeKind.Local).AddTicks(488) },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Board game enthusiast and strategist 🎲 | Swapping and selling classic and modern board games | Let's have fun game nights! #GameSwap #BoardGameMaster", "sophie.turner@example.com", "Sophie", "9012210987", "Turner", new DateTime(2024, 2, 1, 1, 15, 48, 505, DateTimeKind.Local).AddTicks(8668), "BoardGameMaster", "AQAAAAIAAYagAAAAEBTnyZ+xV6oA47F+yB/yZyEA02TsoOdtyRilzQYFvm2CWeotpxERa0xwTjxELVv37Q==", new DateTime(2024, 2, 1, 1, 15, 48, 505, DateTimeKind.Local).AddTicks(8654) },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fashion-forward individual with an eye for style 👗🕶️ | Swapping and selling trendy fashion items | Let's stay ahead in the fashion game! #FashionSwap #StyleInnovator", "mason.ward@example.com", "Mason", "8765987654", "Ward", new DateTime(2024, 2, 1, 1, 15, 48, 553, DateTimeKind.Local).AddTicks(3898), "FashionForward", "AQAAAAIAAYagAAAAEMQ3w/ySNcAORpeqvy1a3dn3U5qdBkXJSDood522ODmFbrQFYvqRxr78efIjNBn1sQ==", new DateTime(2024, 2, 1, 1, 15, 48, 553, DateTimeKind.Local).AddTicks(3878) },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tech innovator and early adopter of cutting-edge tech 🚀 | Swapping and selling innovative gadgets | Let's redefine the digital experience! #TechSwap #InnovationGeek", "zoe.barnes@example.com", "Zoe", "9012109876", "Barnes", new DateTime(2024, 2, 1, 1, 15, 48, 600, DateTimeKind.Local).AddTicks(6107), "TechInnovator", "AQAAAAIAAYagAAAAEIpWCzWKsOJPy+ep8JN+Xipcftr3W8piGpu9tzftpYVabW3MLbvWH8ykUP8LijDpgA==", new DateTime(2024, 2, 1, 1, 15, 48, 600, DateTimeKind.Local).AddTicks(6093) },
                    { 27, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Music explorer with a diverse taste in melodies 🎵 | Swapping and selling rare music albums and instruments | Let's discover new rhythms! #MusicSwap #SoundExplorer", "natalie.johnson@example.com", "Natalie", "8765098765", "Johnson", new DateTime(2024, 2, 1, 1, 15, 48, 647, DateTimeKind.Local).AddTicks(9973), "MusicExplorer", "AQAAAAIAAYagAAAAEKDxCwyFGeUM0kXMGQTCUixck2mFDCeiGAX6P6t5eVm8iPHdAW8ERb4YqcPhR1YgkA==", new DateTime(2024, 2, 1, 1, 15, 48, 647, DateTimeKind.Local).AddTicks(9959) },
                    { 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Artisan crafting unique handmade artworks and crafts 🎨 | Swapping and selling one-of-a-kind creations | Let's appreciate the beauty of craftsmanship! #ArtisanSwap #CraftedBeauty", "elijah.fisher@example.com", "Elijah", "9012987654", "Fisher", new DateTime(2024, 2, 1, 1, 15, 48, 694, DateTimeKind.Local).AddTicks(7774), "ArtisanCrafts", "AQAAAAIAAYagAAAAEPaqF0bcdeNKmugK9RW4N1bNUT/lpQcTTIPRutSIwBLofxk7m9/nkcCf2w56Hi8qvw==", new DateTime(2024, 2, 1, 1, 15, 48, 694, DateTimeKind.Local).AddTicks(7755) },
                    { 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Culinary connoisseur and food enthusiast 🍳 | Swapping and selling gourmet ingredients and kitchen tools | Let's create delicious masterpieces! #CulinarySwap #FoodieDelight", "hannah.clark@example.com", "Hannah", "8765234012", "Clark", new DateTime(2024, 2, 1, 1, 15, 48, 740, DateTimeKind.Local).AddTicks(6059), "CulinaryConnoisseur", "AQAAAAIAAYagAAAAEKQYMc/VbuPRXemdHbLqoKFZv4k1d4yIYWqljkJrTWNeJ7s6U1wztPV3YliE3b2bXw==", new DateTime(2024, 2, 1, 1, 15, 48, 740, DateTimeKind.Local).AddTicks(6040) },
                    { 30, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Board game enthusiast organizing epic game nights 🎲 | Swapping and selling classic and strategy board games | Let's roll the dice and have fun! #BoardGameSwap #GameNightOrganizer", "caleb.roberts@example.com", "Caleb", "9012765432", "Roberts", new DateTime(2024, 2, 1, 1, 15, 48, 785, DateTimeKind.Local).AddTicks(7268), "BoardGameEnthusiast", "AQAAAAIAAYagAAAAEAQwFUN7z6nDdrnCyRgaVwnYOZdepnAAC2zoK2kTcVxfE1+QgwAGktVy/nmRkGzv6Q==", new DateTime(2024, 2, 1, 1, 15, 48, 785, DateTimeKind.Local).AddTicks(7254) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "595b2485-3bfa-4b70-9209-7526bdb84f37", null, "Staff", "STAFF" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserDescription", "UserFirstName", "UserLastName", "UserLastOnline", "UserName", "UserRegDate" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "287eae3f-f6b9-4eae-b1cc-798efe5fd59f", "admin@localhost.com", false, false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAIAAYagAAAAECKgAjlYmxJ9AK7HdCx8ILEWt2x7g4/XKTUMO0+yenaKfUt/iSutDvGrH0btg/yk7g==", null, false, "e842806b-98a8-4e02-83bd-9e439d36ce8b", false, null, "Admin", "User", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4471), "Admin", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4462) },
                    { "b1675205-1948-44ec-8b55-b0cb71d1f84e", 0, "1c8c02c0-f422-4336-b5ff-e8daabd2c2ab", "user@localhost.com", false, false, null, "USER@LOCALHOST.COM", "USER", "AQAAAAIAAYagAAAAEHEf3liZfsNU7JdIpRf/g/p66wZN0tbnnjVS7Hg2hOVUiKylNsoxv5tyuQdGy/Xslw==", null, false, "6a8f05bd-d904-4919-bb9c-06c19dc1a7f9", false, null, "User", "User", new DateTime(2024, 2, 1, 1, 15, 47, 278, DateTimeKind.Local).AddTicks(5662), "user", new DateTime(2024, 2, 1, 1, 15, 47, 278, DateTimeKind.Local).AddTicks(5643) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Cars", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3903), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3912), "System" },
                    { 2, "Services", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3921), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3931), "System" },
                    { 3, "Property", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3950), "System" },
                    { 4, "Electronics", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3960), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3970), "System" },
                    { 5, "Fashion", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3979), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3988), "System" },
                    { 6, "Luxury", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4007), "System" },
                    { 7, "Toys & Hobbies", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4026), "System" },
                    { 8, "Games & Gaming", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4035), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4045), "System" },
                    { 9, "Home Living", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4064), "System" },
                    { 10, "Appliances", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4069), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4082), "System" },
                    { 11, "Parenthood", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4092), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4102), "System" },
                    { 12, "Health & Food", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4120), "System" },
                    { 13, "Sports", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4135), "System" },
                    { 14, "Pet Supplies", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4149), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4158), "System" },
                    { 15, "Jobs", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4167), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4177), "System" },
                    { 16, "Other Items", "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4187), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(4196), "System" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "StaffAddress", "StaffDepartment", "StaffEmail", "StaffFirstName", "StaffHPNum", "StaffHireDate", "StaffLastName", "StaffPosition", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(780), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(794), "Temasek Polytechnic", "Full Stack Development", "2102197G@student.tp.edu.sg", "Ryan", "99991111", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(771), "Chong", "Lead Developer", "System" },
                    { 2, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(832), "Temasek Polytechnic", "Full Stack Development", "2203567i@student.tp.edu.sg", "Lucas", "99992222", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(814), "Do", "Lead Developer", "System" },
                    { 3, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(861), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(870), "Design Avenue", "User Experience Design", "emily.ng@example.com", "Emily", "88882222", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(851), "Ng", "Senior UI/UX Designer", "System" },
                    { 4, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(908), "Data Center Lane", "Database Management", "daniel.liu@example.com", "Daniel", "77773333", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(889), "Liu", "Database Administrator", "System" },
                    { 5, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(936), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(946), "Code Street", "Software Engineering", "jessica.wong@example.com", "Jessica", "91112233", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(927), "Wong", "Software Developer", "System" },
                    { 6, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(984), "Connectivity Avenue", "Network Management", "ryan.tan@example.com", "Ryan", "92223344", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(964), "Tan", "Network Administrator", "System" },
                    { 7, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1022), "Tech Park", "System Analysis", "michelle.ng@example.com", "Michelle", "93334455", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1003), "Ng", "Systems Analyst", "System" },
                    { 8, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1050), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1059), "Secure Lane", "Information Security", "alex.cheng@example.com", "Alex", "94445566", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1040), "Cheng", "Security Specialist", "System" },
                    { 9, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1097), "Project Street", "Project Management", "emily.lim@example.com", "Emily", "95556677", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1079), "Lim", "Project Manager", "System" },
                    { 10, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1135), "Design Avenue", "Design Team", "patrick.goh@example.com", "Patrick", "96667788", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1116), "Goh", "UX/UI Designer", "System" },
                    { 11, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1163), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1173), "Data Center Lane", "Database Management", "vanessa.teo@example.com", "Vanessa", "97778899", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1154), "Teo", "Database Administrator", "System" },
                    { 12, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1201), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1211), "Business Street", "Business Analysis", "darren.ong@example.com", "Darren", "98889900", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1192), "Ong", "Business Analyst", "System" },
                    { 13, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1239), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1249), "Tech Support Lane", "Technical Support", "samantha.tan@example.com", "Samantha", "99990011", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1230), "Tan", "Technical Support Specialist", "System" },
                    { 14, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1277), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1286), "IT Management Street", "IT Management", "gary.koh@example.com", "Gary", "91110022", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1267), "Koh", "IT Manager", "System" },
                    { 15, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1315), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1325), "Testing Street", "Quality Assurance", "andrew.lau@example.com", "Andrew", "91112233", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1305), "Lau", "Software Tester", "System" },
                    { 16, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1362), "Networking Lane", "Network Engineering", "rachel.lim@example.com", "Rachel", "92223344", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1344), "Lim", "Network Engineer", "System" },
                    { 17, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1405), "Architecture Avenue", "System Architecture", "ethan.neo@example.com", "Ethan", "93334455", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1386), "Neo", "Systems Architect", "System" },
                    { 18, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1442), "Data Analysis Street", "Database Analysis", "sophia.chong@example.com", "Sophia", "94445566", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1420), "Chong", "Database Analyst", "System" },
                    { 19, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1471), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1480), "Project Coordination Lane", "Project Coordination", "nathan.loh@example.com", "Nathan", "95556677", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1462), "Loh", "Project Coordinator", "System" },
                    { 20, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1509), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1518), "Design Studio", "Design Team", "isabel.koh@example.com", "Isabel", "96667788", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1500), "Koh", "UI/UX Designer", "System" },
                    { 21, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1547), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1556), "Data Center Lane", "Database Management", "brian.ong@example.com", "Brian", "97778899", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1537), "Ong", "Database Administrator", "System" },
                    { 22, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1585), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1594), "Business Intelligence Street", "Business Intelligence", "catherine.yap@example.com", "Catherine", "98889900", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1575), "Yap", "Business Intelligence Analyst", "System" },
                    { 23, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1632), "Tech Support Lane", "Technical Support", "oscar.gan@example.com", "Oscar", "99990011", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1612), "Gan", "Technical Support Engineer", "System" },
                    { 24, "System", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1670), "IT Leadership Street", "IT Leadership", "hannah.chua@example.com", "Hannah", "91110022", new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(1651), "Chua", "IT Director", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "b1675205-1948-44ec-8b55-b0cb71d1f84e" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AppUserId", "CategoryId", "Condition", "CreatedBy", "DateCreated", "DateUpdated", "ImageUrl", "ItemClicks", "ItemDate", "ItemDescription", "ItemLikes", "ItemLocation", "ItemName", "ItemPrice", "ItemStatus", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 4, "Well Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1334, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2082), "Very good Keyboard, Served me for many years. Hope to find a new good owner for it.", 23, "Tampines West Street 42", "Tofu65 Keyboard", 200, 1, null },
                    { 2, 2, 5, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2100), "Stylish vintage leather jacket in excellent condition. A timeless fashion piece for any wardrobe.", 45, "Orchard Road, Singapore", "Vintage Leather Jacket", 80, 1, null },
                    { 3, 3, 13, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1222, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2124), "Giant Talon mountain bike in excellent condition. Perfect for off-road adventures and trail riding.", 78, "Bukit Timah Nature Reserve", "Mountain Bike - Giant Talon", 500, 1, null },
                    { 4, 4, 9, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2143), "Complete smart home security system with cameras and sensors. Enhance your home's safety with advanced technology.", 30, "Jurong West Street 21", "Smart Home Security System", 150, 1, null },
                    { 5, 5, 7, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2162), "Beautiful antique chess set with intricate detailing. Perfect for chess enthusiasts and collectors.", 15, "Katong, Singapore", "Antique Chess Set", 120, 1, null },
                    { 6, 6, 10, "Slightly Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2181), "Powerful KitchenAid stand mixer, perfect for baking and cooking. In great condition, ready to mix up some delicious recipes.", 40, "Serangoon Avenue 4", "KitchenAid Stand Mixer", 250, 1, null },
                    { 7, 7, 11, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2199), "Chicco Bravo baby stroller in excellent condition. Stylish and comfortable for your little one.", 25, "Ang Mo Kio, Singapore", "Baby Stroller - Chicco Bravo", 180, 1, null },
                    { 8, 8, 12, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2219), "Subscription to a healthy meal prep service. Enjoy nutritious and delicious meals delivered to your doorstep.", 60, "Novena, Singapore", "Healthy Meal Prep Service", 50, 1, null },
                    { 9, 9, 13, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2238), "Complete yoga mat and accessories set. Everything you need for a fulfilling yoga practice.", 35, "Clementi, Singapore", "Yoga Mat and Accessories Set", 40, 1, null },
                    { 10, 10, 14, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2256), "Multi-level cat tree condo for your feline friend. Provides entertainment and a cozy space for your cat to relax.", 18, "Woodlands, Singapore", "Cat Tree Condo", 60, 1, null },
                    { 11, 11, 2, "Available", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2275), "Offering part-time graphic design services. Experienced designer ready to bring your ideas to life.", 22, "Chinatown, Singapore", "Part-time Graphic Design Services", 30, 1, null },
                    { 12, 12, 1, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1102, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2294), "Xiaomi M365 electric scooter in good condition. Perfect for commuting and exploring the city with ease.", 33, "Raffles Place, Singapore", "Electric Scooter - Xiaomi M365", 300, 1, null },
                    { 13, 13, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2314), "Complete home theater system with surround sound speakers and HD projector. Elevate your movie nights at home.", 42, "Hougang, Singapore", "Home Theater System", 450, 1, null },
                    { 14, 14, 9, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2333), "L-shaped leather sofa in excellent condition. Stylish and comfortable for your living room.", 38, "Bedok, Singapore", "Leather Sofa - L-Shaped", 600, 1, null },
                    { 15, 15, 8, "Brand New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1234, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2356), "Brand new PlayStation 5 gaming console. Unopened and ready for an immersive gaming experience.", 50, "Yishun, Singapore", "Gaming Console - PlayStation 5", 700, 1, null },
                    { 16, 16, 6, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2374), "Vintage Polaroid camera in good working condition. Capture memories with the classic charm of instant photography.", 25, "Choa Chu Kang, Singapore", "Vintage Polaroid Camera", 80, 1, null },
                    { 17, 17, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 789, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2394), "Apple Watch Series 6 in like-new condition. Stay connected and track your fitness with this advanced smartwatch.", 28, "Pasir Ris, Singapore", "Smartwatch - Apple Watch Series 6", 350, 1, null },
                    { 18, 18, 7, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2413), "Bundle of classic board games for hours of family fun. Includes Monopoly, Scrabble, and Chess.", 20, "Tanjong Pagar, Singapore", "Classic Board Games Bundle", 40, 1, null },
                    { 19, 19, 13, "Slightly Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2431), "Complete home gym equipment set including dumbbells, resistance bands, and yoga mat. Achieve your fitness goals at home.", 36, "Marina Bay, Singapore", "Home Gym Equipment Set", 300, 1, null },
                    { 20, 20, 9, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2451), "Handcrafted wooden coffee table in good condition. Adds a touch of rustic charm to your living space.", 15, "Jurong East, Singapore", "Handmade Wooden Coffee Table", 120, 1, null },
                    { 21, 21, 10, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2469), "Compact and portable blender, perfect for making smoothies on the go. USB rechargeable for convenience.", 23, "Toa Payoh, Singapore", "Portable Blender - USB Rechargeable", 30, 1, null },
                    { 22, 22, 4, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1102, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2488), "Canon EOS digital camera in excellent condition. Capture stunning photos and videos with this high-quality camera.", 42, "Bishan, Singapore", "Digital Camera - Canon EOS", 600, 1, null },
                    { 23, 23, 5, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2507), "Fender Stratocaster electric guitar in like-new condition. Perfect for both beginners and experienced musicians.", 38, "Sentosa, Singapore", "Electric Guitar - Fender Stratocaster", 800, 1, null },
                    { 24, 24, 10, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2526), "Samsung Family Hub smart refrigerator with touchscreen and smart home features. In good working condition.", 55, "Clementi, Singapore", "Smart Refrigerator - Samsung Family Hub", 1200, 1, null },
                    { 25, 25, 7, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2545), "Set of collectible comic books in good condition. Dive into the world of superheroes and adventure.", 20, "Ang Mo Kio, Singapore", "Collectible Comic Books Set", 150, 1, null },
                    { 26, 26, 9, "Slightly Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2569), "Roomba robot vacuum cleaner in great condition. Effortlessly keep your home clean with smart technology.", 28, "Woodlands, Singapore", "Robot Vacuum Cleaner - Roomba", 300, 1, null },
                    { 27, 27, 7, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2587), "Bundle of educational toys for kids. Foster learning and creativity in a fun and engaging way.", 15, "Jurong West, Singapore", "Kids' Educational Toys Bundle", 50, 1, null },
                    { 28, 28, 13, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1102, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2606), "Complete weightlifting set with barbell and weights. Ideal for strength training at home or in the gym.", 33, "Yishun, Singapore", "Weightlifting Set", 200, 1, null },
                    { 29, 29, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2625), "Anker Nebula portable projector in like-new condition. Enjoy movies and presentations on the big screen.", 25, "Toa Payoh, Singapore", "Portable Projector - Anker Nebula", 150, 1, null },
                    { 30, 30, 5, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2645), "Elegant handmade jewelry set including necklace and earrings. Perfect for special occasions or daily wear.", 22, "Marina Bay Sands, Singapore", "Handmade Jewelry Set", 80, 1, null },
                    { 31, 1, 12, "Available", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2664), "Voucher for a gourmet cooking class. Learn culinary skills and enjoy a delightful cooking experience.", 18, "Chinatown, Singapore", "Gourmet Cooking Class Voucher", 60, 1, null },
                    { 32, 2, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1201, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2682), "DJI Mavic Air 2 drone in like-new condition. Capture breathtaking aerial footage with this advanced drone.", 48, "Orchard Road, Singapore", "DJI Mavic Air 2 Drone", 800, 1, null },
                    { 33, 3, 9, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2701), "Sturdy home office desk in good condition. Ideal for remote work or studying from home.", 32, "Bukit Timah, Singapore", "Home Office Desk", 150, 1, null },
                    { 34, 4, 13, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2720), "Collection of vintage vinyl records in good condition. Enjoy the classic sounds of music history.", 25, "Tampines, Singapore", "Vintage Vinyl Record Collection", 120, 1, null },
                    { 35, 5, 10, "Slightly Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2740), "Nest Learning smart thermostat for efficient climate control. Save energy and customize your home's temperature.", 35, "Katong, Singapore", "Smart Thermostat - Nest Learning", 100, 1, null },
                    { 36, 6, 7, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2758), "Schwinn kids' bicycle in good condition. Perfect for young riders to learn and enjoy cycling.", 18, "Serangoon, Singapore", "Kids' Bicycle - Schwinn", 80, 1, null },
                    { 37, 7, 6, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2777), "Abstract digital art print for home decor. Add a touch of modernity to your living space.", 20, "Hougang, Singapore", "Digital Art Print - Abstract", 40, 1, null },
                    { 38, 8, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2796), "Sony WF-1000XM4 wireless earbuds in like-new condition. Experience premium audio quality on the go.", 30, "Ang Mo Kio, Singapore", "Wireless Earbuds - Sony WF-1000XM4", 180, 1, null },
                    { 39, 9, 10, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2815), "Breville Barista Express coffee maker in excellent condition. Brew barista-quality coffee at home.", 40, "Woodlands, Singapore", "Coffee Maker - Breville Barista Express", 300, 1, null },
                    { 40, 10, 13, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2838), "Fitbit Charge 4 fitness tracker in good working condition. Monitor your health and stay active.", 25, "Tanjong Pagar, Singapore", "Fitness Tracker - Fitbit Charge 4", 80, 1, null },
                    { 41, 11, 9, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2857), "Handmade quilt with vintage-style patterns. Add warmth and style to your bedroom.", 22, "Toa Payoh, Singapore", "Handmade Quilt - Vintage Style", 100, 1, null },
                    { 42, 12, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1201, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2876), "Samsung 4K smart LED TV in like-new condition. Immerse yourself in stunning visuals and smart features.", 55, "Raffles Place, Singapore", "Smart LED TV - Samsung 4K", 700, 1, null },
                    { 43, 13, 1, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2895), "Segway Ninebot electric scooter in good condition. Convenient and eco-friendly mode of transportation.", 32, "Bishan, Singapore", "Electric Scooter - Segway Ninebot", 400, 1, null },
                    { 44, 14, 9, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2914), "Modern dining table set with chairs in excellent condition. Upgrade your dining space with contemporary style.", 45, "Bedok, Singapore", "Modern Dining Table Set", 550, 1, null },
                    { 45, 15, 4, "Slightly Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2932), "Wireless keyboard and mouse combo in great condition. Improve your productivity with cable-free peripherals.", 28, "Yishun, Singapore", "Wireless Keyboard and Mouse Combo", 50, 1, null },
                    { 46, 16, 6, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2952), "Collection of vintage fountain pens in good condition. Perfect for pen enthusiasts and collectors.", 25, "Choa Chu Kang, Singapore", "Vintage Fountain Pen Collection", 90, 1, null },
                    { 47, 17, 9, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 789, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2971), "Ring Video Doorbell in like-new condition. Enhance your home security with smart doorbell features.", 22, "Pasir Ris, Singapore", "Smart Doorbell - Ring Video Doorbell", 120, 1, null },
                    { 48, 18, 9, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(2990), "Set of artificial potted plants to add greenery to your home. No maintenance required!", 18, "Tanjong Pagar, Singapore", "Artificial Potted Plants Set", 30, 1, null },
                    { 49, 19, 13, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3009), "Bundle of outdoor camping gear including tent, sleeping bag, and camping stove. Gear up for your next adventure.", 36, "Marina Bay, Singapore", "Outdoor Camping Gear Bundle", 200, 1, null },
                    { 50, 20, 9, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3027), "Sturdy wooden bookshelf in good condition. Organize your book collection with style.", 15, "Jurong East, Singapore", "Wooden Bookshelf", 100, 1, null },
                    { 51, 21, 4, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3046), "Wireless charging pad for convenient charging of your devices. Stay powered up with this sleek accessory.", 23, "Toa Payoh, Singapore", "Wireless Charging Pad", 20, 1, null },
                    { 52, 22, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 1201, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3066), "Garmin Venu 2 smartwatch in like-new condition. Track your fitness and stay connected with this advanced wearable.", 40, "Bishan, Singapore", "Smartwatch - Garmin Venu 2", 250, 1, null },
                    { 53, 23, 8, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3089), "Vintage vinyl record player in good working condition. Enjoy your favorite tunes with a touch of nostalgia.", 28, "Sentosa, Singapore", "Vintage Vinyl Record Player", 180, 1, null },
                    { 54, 24, 4, "Good", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3127), "Portable Bluetooth speaker in good condition. Take your music wherever you go with this compact device.", 25, "Clementi, Singapore", "Portable Bluetooth Speaker", 50, 1, null },
                    { 55, 25, 10, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3146), "KitchenAid electric mixer in excellent condition. Make baking and cooking a breeze with this reliable appliance.", 32, "Ang Mo Kio, Singapore", "Electric Mixer - KitchenAid", 120, 1, null },
                    { 56, 26, 7, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3165), "Collection of popular board games in good condition. Bring friends and family together for game night fun.", 22, "Woodlands, Singapore", "Board Game Collection", 60, 1, null },
                    { 57, 27, 9, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3188), "Smart home security camera in like-new condition. Monitor your home remotely for added peace of mind.", 35, "Jurong West, Singapore", "Smart Home Security Camera", 90, 1, null },
                    { 58, 28, 6, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3207), "Vintage Royal typewriter in good working condition. Perfect for writers and collectors of retro items.", 18, "Yishun, Singapore", "Vintage Typewriter - Royal", 100, 1, null },
                    { 59, 29, 9, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3227), "Fiddle Leaf Fig indoor plant for a touch of greenery in your home. Low maintenance and aesthetically pleasing.", 20, "Toa Payoh, Singapore", "Indoor Plant - Fiddle Leaf Fig", 30, 1, null },
                    { 60, 30, 8, "Slightly Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3245), "Wacom Intuos digital art tablet in great condition. Ideal for digital artists and graphic designers.", 30, "Toa Payoh, Singapore", "Digital Art Tablet - Wacom Intuos", 80, 1, null },
                    { 61, 1, 13, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3264), "Set of fitness resistance bands for effective home workouts. Stay fit and healthy with these versatile exercise tools.", 25, "Chinatown, Singapore", "Fitness Resistance Bands Set", 20, 1, null },
                    { 62, 2, 9, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3283), "iRobot Roomba robot vacuum cleaner in good working condition. Effortlessly keep your home clean with smart technology.", 28, "Chinatown, Singapore", "Robot Vacuum Cleaner - iRobot Roomba", 300, 1, null },
                    { 63, 3, 8, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3302), "Logitech G Pro wireless gaming mouse in like-new condition. Elevate your gaming experience with precision and speed.", 32, "Bukit Timah, Singapore", "Wireless Gaming Mouse - Logitech G Pro", 80, 1, null },
                    { 64, 4, 10, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3321), "Portable espresso machine in excellent condition. Enjoy barista-quality coffee wherever you go.", 25, "Bedok, Singapore", "Portable Espresso Machine", 100, 1, null },
                    { 65, 5, 1, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3340), "Foldable electric scooter in like-new condition. Commute with ease and style using this convenient mode of transportation.", 35, "Tampines, Singapore", "Foldable Electric Scooter", 350, 1, null },
                    { 66, 6, 4, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3359), "Sony WH-1000XM4 Bluetooth headphones in excellent condition. Immerse yourself in high-quality audio with noise-canceling technology.", 42, "Hougang, Singapore", "Bluetooth Headphones - Sony WH-1000XM4", 250, 1, null },
                    { 67, 7, 4, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3377), "Nikon F2 vintage camera in good working condition. Capture timeless moments with this classic film camera.", 30, "Serangoon, Singapore", "Vintage Camera - Nikon F2", 180, 1, null },
                    { 68, 8, 9, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3397), "Set of smart LED bulbs for customizable lighting. Transform your home with modern and energy-efficient lighting.", 18, "Ang Mo Kio, Singapore", "Smart LED Bulbs Set", 40, 1, null },
                    { 69, 9, 5, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3416), "Yamaha P-125 digital piano in like-new condition. Perfect for aspiring musicians and music enthusiasts.", 25, "Woodlands, Singapore", "Digital Piano - Yamaha P-125", 600, 1, null },
                    { 70, 10, 8, "Slightly Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3439), "Razer BlackWidow wireless gaming keyboard in great condition. Enhance your gaming setup with this high-performance keyboard.", 28, "Jurong West, Singapore", "Wireless Gaming Keyboard - Razer BlackWidow", 120, 1, null },
                    { 71, 11, 4, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3458), "Canon EF 24-70mm professional camera lens in excellent condition. Capture sharp and detailed images with this high-quality lens.", 35, "Toa Payoh, Singapore", "Professional Camera Lens - Canon EF 24-70mm", 800, 1, null },
                    { 72, 12, 4, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3477), "Wireless charger stand for convenient charging of your devices. Stay organized and powered up with this sleek accessory.", 22, "Chinatown, Singapore", "Wireless Charger Stand", 30, 1, null },
                    { 73, 13, 6, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 543, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3496), "Stand for vintage vinyl record players in good condition. Showcase and organize your vinyl collection with style.", 18, "Bishan, Singapore", "Vintage Vinyl Record Player Stand", 70, 1, null },
                    { 74, 14, 4, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3515), "ASUS ZenScreen portable monitor in like-new condition. Boost your productivity with an additional display on the go.", 30, "Bedok, Singapore", "Portable Monitor - ASUS ZenScreen", 200, 1, null },
                    { 75, 15, 13, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3534), "Set of fitness dumbbells in good condition. Build strength and stay active with these versatile workout tools.", 20, "Ang Mo Kio, Singapore", "Fitness Dumbbell Set", 80, 1, null },
                    { 76, 16, 8, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 987, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3553), "PlayStation 5 gaming console in excellent condition. Immerse yourself in the latest gaming experiences with this powerful console.", 40, "Clementi, Singapore", "Gaming Console - PlayStation 5", 600, 1, null },
                    { 77, 17, 9, "New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3572), "Modern wall clock to enhance your home decor. Stay punctual in style with this contemporary timepiece.", 25, "Hougang, Singapore", "Modern Wall Clock", 25, 1, null },
                    { 78, 18, 8, "Like New", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 654, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3590), "Bose 700 wireless soundbar in like-new condition. Elevate your home entertainment experience with immersive sound.", 35, "Jurong West, Singapore", "Wireless Soundbar - Bose 700", 350, 1, null },
                    { 79, 19, 13, "Used", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 765, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3609), "4-person camping tent in good condition. Enjoy outdoor adventures with this reliable and spacious tent.", 22, "Marina Bay, Singapore", "Camping Tent - 4 Person", 120, 1, null },
                    { 80, 20, 9, "Excellent", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://via.placeholder.com/300", 876, new DateTime(2024, 2, 1, 1, 15, 47, 229, DateTimeKind.Local).AddTicks(3629), "Dyson Pure Cool air purifier in excellent condition. Breathe clean air with advanced filtration technology.", 30, "Tanjong Pagar, Singapore", "Air Purifier - Dyson Pure Cool", 300, 1, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Items_AppUserId",
                table: "Items",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_AppUserID",
                table: "Reports",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_SaleTransactionID",
                table: "Reports",
                column: "SaleTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_StaffID",
                table: "Reports",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_SwapTransactionID",
                table: "Reports",
                column: "SwapTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AppUserID",
                table: "Reviews",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SaleTransactionID",
                table: "Reviews",
                column: "SaleTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_SwapTransactionID",
                table: "Reviews",
                column: "SwapTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleTransactions_AppUserId",
                table: "SaleTransactions",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleTransactions_ItemId",
                table: "SaleTransactions",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SwapTransactions_AppUser1Id",
                table: "SwapTransactions",
                column: "AppUser1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SwapTransactions_AppUser2Id",
                table: "SwapTransactions",
                column: "AppUser2Id");

            migrationBuilder.CreateIndex(
                name: "IX_SwapTransactions_SwapItem1Id",
                table: "SwapTransactions",
                column: "SwapItem1Id");

            migrationBuilder.CreateIndex(
                name: "IX_SwapTransactions_SwapItem2Id",
                table: "SwapTransactions",
                column: "SwapItem2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "SaleTransactions");

            migrationBuilder.DropTable(
                name: "SwapTransactions");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
