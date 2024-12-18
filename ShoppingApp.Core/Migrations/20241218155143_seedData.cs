using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Core.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    SoldCount = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    ShopTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ShopTypes_ShopTypeId",
                        column: x => x.ShopTypeId,
                        principalTable: "ShopTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductConditions",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductConditions", x => new { x.ProductId, x.ConditionId });
                    table.ForeignKey(
                        name: "FK_ProductConditions_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductConditions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductLocations",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLocations", x => new { x.ProductId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_ProductLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductLocations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPromotions",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPromotions", x => new { x.ProductId, x.PromotionId });
                    table.ForeignKey(
                        name: "FK_ProductPromotions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductPromotions_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductShippingMethods",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ShippingMethodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShippingMethods", x => new { x.ProductId, x.ShippingMethodId });
                    table.ForeignKey(
                        name: "FK_ProductShippingMethods_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductShippingMethods_ShippingMethods_ShippingMethodId",
                        column: x => x.ShippingMethodId,
                        principalTable: "ShippingMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "JBL" },
                    { 2, "Sony" },
                    { 3, "Bose" },
                    { 4, "Samsung" },
                    { 5, "ONTEKCO" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Audio Devices" },
                    { 2, "Gaming" },
                    { 3, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Used" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ha Noi" },
                    { 2, "Ho Chi Minh" },
                    { 3, "Da Nang" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "On Sale" },
                    { 2, "", "Best Price" }
                });

            migrationBuilder.InsertData(
                table: "ShippingMethods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Standard Shipping" },
                    { 2, "Express Shipping" },
                    { 3, "Overnight Shipping" }
                });

            migrationBuilder.InsertData(
                table: "ShopTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shopee Mall" },
                    { 2, "Favorite Shop" },
                    { 3, "Processed By Shopee" },
                    { 4, "Favorite Shop Plus" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bluetooth Speaker" },
                    { 2, 1, "Wired Speaker" },
                    { 3, 1, "Headphones" },
                    { 4, 2, "Gaming Consoles" },
                    { 5, 3, "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Name", "Price", "ShopTypeId", "SoldCount", "SubCategoryId", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(1791), "JBL Flip 5", 320000m, 1, 50, 1, 100 },
                    { 2, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2196), "Sony SRS-XB13", 450000m, 2, 75, 1, 150 },
                    { 3, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2198), "Bose SoundLink Mini II", 600000m, 3, 60, 1, 120 },
                    { 4, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2201), "Samsung Sound Tower", 1200000m, 1, 80, 2, 200 },
                    { 5, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2204), "ONTEKCO Bluetooth Speaker", 599000m, 4, 55, 1, 130 },
                    { 6, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2206), "Sony WH-1000XM4", 8000000m, 1, 180, 3, 320 },
                    { 7, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2226), "JBL Tune 510BT", 1200000m, 4, 150, 3, 290 },
                    { 8, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2290), "Bose QuietComfort 35 II", 9500000m, 1, 200, 3, 350 },
                    { 9, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2293), "Samsung Galaxy Buds Live", 3000000m, 4, 130, 3, 240 },
                    { 10, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2295), "ONTEKCO Smartwatch", 2500000m, 3, 60, 2, 150 },
                    { 11, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2298), "Sony WH-XB900N", 6500000m, 2, 160, 3, 310 },
                    { 12, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2301), "Samsung Galaxy Watch 4", 6000000m, 2, 170, 2, 350 },
                    { 13, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2304), "Bose SoundLink Revolve+", 7500000m, 1, 150, 1, 280 },
                    { 14, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2306), "JBL PartyBox 100", 3200000m, 3, 140, 2, 270 },
                    { 15, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2309), "ONTEKCO VR Headset", 10000000m, 4, 90, 4, 180 },
                    { 16, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2311), "Sony Soundbar", 4500000m, 2, 120, 2, 220 },
                    { 17, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2314), "Samsung Gear VR", 5000000m, 3, 150, 4, 280 },
                    { 18, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2316), "JBL Pulse 4", 5500000m, 4, 130, 2, 250 },
                    { 19, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2327), "Bose Smart Soundbar", 12000000m, 2, 200, 2, 350 },
                    { 20, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2330), "ONTEKCO Fitness Band", 1000000m, 1, 100, 2, 200 },
                    { 21, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2332), "Sony Xperia 5", 15000000m, 3, 250, 5, 400 },
                    { 22, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2335), "Samsung Smart Monitor", 8000000m, 2, 100, 5, 220 },
                    { 23, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2364), "Bose Gaming Headset", 9900000m, 1, 160, 4, 280 },
                    { 24, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2368), "JBL Bar 5.1", 18000000m, 4, 200, 2, 340 },
                    { 25, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2370), "ONTEKCO Wireless Charger", 1000000m, 1, 50, 5, 150 },
                    { 26, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2373), "Sony OLED TV", 50000000m, 3, 300, 2, 450 },
                    { 27, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2375), "Samsung QLED TV", 48000000m, 2, 290, 4, 410 },
                    { 28, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2378), "JBL Go 3", 1200000m, 1, 150, 1, 210 },
                    { 29, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2381), "Bose Wave Music System", 25000000m, 4, 180, 2, 320 },
                    { 30, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2383), "ONTEKCO Gaming Keyboard", 3000000m, 3, 90, 5, 180 },
                    { 31, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2393), "Sony WF-1000XM4", 6200000m, 4, 190, 3, 310 },
                    { 32, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2396), "Samsung Frame TV", 60000000m, 3, 310, 5, 480 },
                    { 33, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2398), "JBL Endurance Peak", 2000000m, 1, 120, 3, 220 },
                    { 34, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2401), "Bose Frames", 9000000m, 2, 140, 4, 260 },
                    { 35, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2404), "ONTEKCO Smart Glasses", 7000000m, 1, 100, 4, 200 },
                    { 36, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2406), "Sony HT-Z9F Soundbar", 15000000m, 4, 210, 2, 370 },
                    { 37, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2409), "Samsung Galaxy Tab S7", 14000000m, 1, 190, 5, 320 },
                    { 38, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2412), "JBL Free X", 2200000m, 3, 130, 3, 250 },
                    { 39, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2439), "Bose Noise Cancelling Earbuds", 9500000m, 1, 220, 3, 340 },
                    { 40, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2442), "ONTEKCO Mini Projector", 6000000m, 3, 80, 3, 150 },
                    { 41, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2444), "Sony Alpha a7 III", 50000000m, 2, 300, 1, 410 },
                    { 42, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2446), "Samsung Smart Fridge", 55000000m, 4, 270, 2, 390 },
                    { 43, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2449), "JBL Live 650BTNC", 4000000m, 2, 160, 3, 310 },
                    { 44, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2452), "Bose Home Speaker 500", 12000000m, 4, 180, 1, 300 },
                    { 45, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2454), "ONTEKCO Power Bank", 1000000m, 2, 90, 5, 150 },
                    { 46, 2, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2456), "Sony 4K Projector", 60000000m, 1, 320, 4, 500 },
                    { 47, 4, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2459), "Samsung Neo QLED TV", 70000000m, 3, 330, 3, 460 },
                    { 48, 1, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2461), "JBL Charge 5", 3000000m, 1, 140, 1, 210 },
                    { 49, 3, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2464), "Bose Portable Home Speaker", 15000000m, 4, 170, 1, 280 },
                    { 50, 5, new DateTime(2024, 12, 18, 15, 51, 43, 347, DateTimeKind.Utc).AddTicks(2467), "ONTEKCO Digital Clock", 800000m, 3, 60, 5, 120 }
                });

            migrationBuilder.InsertData(
                table: "ProductConditions",
                columns: new[] { "ConditionId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 1, 4 },
                    { 2, 5 },
                    { 1, 6 },
                    { 2, 7 },
                    { 1, 8 },
                    { 2, 9 },
                    { 1, 10 },
                    { 2, 11 },
                    { 1, 12 },
                    { 2, 13 },
                    { 1, 14 },
                    { 2, 15 },
                    { 1, 16 },
                    { 2, 17 },
                    { 1, 18 },
                    { 2, 19 },
                    { 1, 20 },
                    { 2, 21 },
                    { 1, 22 },
                    { 2, 23 },
                    { 1, 24 },
                    { 2, 25 },
                    { 1, 26 },
                    { 2, 27 },
                    { 1, 28 },
                    { 2, 29 },
                    { 1, 30 },
                    { 2, 31 },
                    { 1, 32 },
                    { 2, 33 },
                    { 1, 34 },
                    { 2, 35 },
                    { 1, 36 },
                    { 2, 37 },
                    { 1, 38 },
                    { 2, 39 },
                    { 1, 40 },
                    { 2, 41 },
                    { 1, 42 },
                    { 2, 43 },
                    { 1, 44 },
                    { 2, 45 },
                    { 1, 46 },
                    { 2, 47 },
                    { 1, 48 },
                    { 2, 49 },
                    { 1, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductLocations",
                columns: new[] { "LocationId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 1, 6 },
                    { 2, 7 },
                    { 3, 8 },
                    { 1, 9 },
                    { 2, 10 },
                    { 3, 11 },
                    { 1, 12 },
                    { 2, 13 },
                    { 3, 14 },
                    { 1, 15 },
                    { 2, 16 },
                    { 3, 17 },
                    { 1, 18 },
                    { 2, 19 },
                    { 3, 20 },
                    { 1, 21 },
                    { 2, 22 },
                    { 3, 23 },
                    { 1, 24 },
                    { 2, 25 },
                    { 3, 26 },
                    { 1, 27 },
                    { 2, 28 },
                    { 3, 29 },
                    { 1, 30 },
                    { 2, 31 },
                    { 3, 32 },
                    { 1, 33 },
                    { 2, 34 },
                    { 3, 35 },
                    { 1, 36 },
                    { 2, 37 },
                    { 3, 38 },
                    { 1, 39 },
                    { 2, 40 },
                    { 3, 41 },
                    { 1, 42 },
                    { 2, 43 },
                    { 3, 44 },
                    { 1, 45 },
                    { 2, 46 },
                    { 3, 47 },
                    { 1, 48 },
                    { 2, 49 },
                    { 3, 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductPromotions",
                columns: new[] { "ProductId", "PromotionId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 1 },
                    { 7, 2 },
                    { 8, 1 },
                    { 9, 2 },
                    { 10, 1 },
                    { 11, 2 },
                    { 12, 1 },
                    { 13, 2 },
                    { 14, 1 },
                    { 15, 2 },
                    { 16, 1 },
                    { 17, 2 },
                    { 18, 1 },
                    { 19, 2 },
                    { 20, 1 },
                    { 21, 2 },
                    { 22, 1 },
                    { 23, 2 },
                    { 24, 1 },
                    { 25, 2 },
                    { 26, 1 },
                    { 27, 2 },
                    { 28, 1 },
                    { 29, 2 },
                    { 30, 1 },
                    { 31, 2 },
                    { 32, 1 },
                    { 33, 2 },
                    { 34, 1 },
                    { 35, 2 },
                    { 36, 1 },
                    { 37, 2 },
                    { 38, 1 },
                    { 39, 2 },
                    { 40, 1 },
                    { 41, 2 },
                    { 42, 1 },
                    { 43, 2 },
                    { 44, 1 },
                    { 45, 2 },
                    { 46, 1 },
                    { 47, 2 },
                    { 48, 1 },
                    { 49, 2 },
                    { 50, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductShippingMethods",
                columns: new[] { "ProductId", "ShippingMethodId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 7, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 10, 2 },
                    { 11, 3 },
                    { 12, 1 },
                    { 13, 2 },
                    { 14, 3 },
                    { 15, 1 },
                    { 16, 2 },
                    { 17, 3 },
                    { 18, 1 },
                    { 19, 2 },
                    { 20, 3 },
                    { 21, 1 },
                    { 22, 2 },
                    { 23, 3 },
                    { 24, 1 },
                    { 25, 2 },
                    { 26, 3 },
                    { 27, 1 },
                    { 28, 2 },
                    { 29, 3 },
                    { 30, 1 },
                    { 31, 2 },
                    { 32, 3 },
                    { 33, 1 },
                    { 34, 2 },
                    { 35, 3 },
                    { 36, 1 },
                    { 37, 2 },
                    { 38, 3 },
                    { 39, 1 },
                    { 40, 2 },
                    { 41, 3 },
                    { 42, 1 },
                    { 43, 2 },
                    { 44, 3 },
                    { 45, 1 },
                    { 46, 2 },
                    { 47, 3 },
                    { 48, 1 },
                    { 49, 2 },
                    { 50, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating" },
                values: new object[,]
                {
                    { 1, "Review comment for product 1", 1, "2" },
                    { 2, "Review comment for product 2", 2, "3" },
                    { 3, "Review comment for product 3", 3, "4" },
                    { 4, "Review comment for product 4", 4, "5" },
                    { 5, "Review comment for product 5", 5, "1" },
                    { 6, "Review comment for product 6", 6, "2" },
                    { 7, "Review comment for product 7", 7, "3" },
                    { 8, "Review comment for product 8", 8, "4" },
                    { 9, "Review comment for product 9", 9, "5" },
                    { 10, "Review comment for product 10", 10, "1" },
                    { 11, "Review comment for product 11", 11, "2" },
                    { 12, "Review comment for product 12", 12, "3" },
                    { 13, "Review comment for product 13", 13, "4" },
                    { 14, "Review comment for product 14", 14, "5" },
                    { 15, "Review comment for product 15", 15, "1" },
                    { 16, "Review comment for product 16", 16, "2" },
                    { 17, "Review comment for product 17", 17, "3" },
                    { 18, "Review comment for product 18", 18, "4" },
                    { 19, "Review comment for product 19", 19, "5" },
                    { 20, "Review comment for product 20", 20, "1" },
                    { 21, "Review comment for product 21", 21, "2" },
                    { 22, "Review comment for product 22", 22, "3" },
                    { 23, "Review comment for product 23", 23, "4" },
                    { 24, "Review comment for product 24", 24, "5" },
                    { 25, "Review comment for product 25", 25, "1" },
                    { 26, "Review comment for product 26", 26, "2" },
                    { 27, "Review comment for product 27", 27, "3" },
                    { 28, "Review comment for product 28", 28, "4" },
                    { 29, "Review comment for product 29", 29, "5" },
                    { 30, "Review comment for product 30", 30, "1" },
                    { 31, "Review comment for product 31", 31, "2" },
                    { 32, "Review comment for product 32", 32, "3" },
                    { 33, "Review comment for product 33", 33, "4" },
                    { 34, "Review comment for product 34", 34, "5" },
                    { 35, "Review comment for product 35", 35, "1" },
                    { 36, "Review comment for product 36", 36, "2" },
                    { 37, "Review comment for product 37", 37, "3" },
                    { 38, "Review comment for product 38", 38, "4" },
                    { 39, "Review comment for product 39", 39, "5" },
                    { 40, "Review comment for product 40", 40, "1" },
                    { 41, "Review comment for product 41", 41, "2" },
                    { 42, "Review comment for product 42", 42, "3" },
                    { 43, "Review comment for product 43", 43, "4" },
                    { 44, "Review comment for product 44", 44, "5" },
                    { 45, "Review comment for product 45", 45, "1" },
                    { 46, "Review comment for product 46", 46, "2" },
                    { 47, "Review comment for product 47", 47, "3" },
                    { 48, "Review comment for product 48", 48, "4" },
                    { 49, "Review comment for product 49", 49, "5" },
                    { 50, "Review comment for product 50", 50, "1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_Name",
                table: "Brands",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_Name",
                table: "Conditions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Name",
                table: "Locations",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Name",
                table: "Orders",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductConditions_ConditionId",
                table: "ProductConditions",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductLocations_LocationId",
                table: "ProductLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderId",
                table: "ProductOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPromotions_PromotionId",
                table: "ProductPromotions",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopTypeId",
                table: "Products",
                column: "ShopTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductShippingMethods_ShippingMethodId",
                table: "ProductShippingMethods",
                column: "ShippingMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_Name",
                table: "Promotions",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingMethods_Name",
                table: "ShippingMethods",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopTypes_Name",
                table: "ShopTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_Name",
                table: "SubCategories",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductConditions");

            migrationBuilder.DropTable(
                name: "ProductLocations");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "ProductPromotions");

            migrationBuilder.DropTable(
                name: "ProductShippingMethods");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "ShippingMethods");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ShopTypes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
