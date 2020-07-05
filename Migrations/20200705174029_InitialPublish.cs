using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jupiter.Migrations
{
    public partial class InitialPublish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    UserRating = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    GameCategory = table.Column<int>(nullable: false),
                    Carousel1 = table.Column<string>(nullable: true),
                    Carousel2 = table.Column<string>(nullable: true),
                    Carousel3 = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    videosource = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    TitleId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Horror" },
                    { 3, "Platformer" },
                    { 4, "Racing" },
                    { 5, "RPG" },
                    { 6, "Strategy" },
                    { 7, "Survival" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Carousel1", "Carousel2", "Carousel3", "CategoryId", "Description", "GameCategory", "ImageThumbnailUrl", "ImageUrl", "Name", "Price", "Publisher", "ReleaseDate", "UserRating", "videosource" },
                values: new object[,]
                {
                    { 8, "/images/carousel/c_xcom/xcom_01.jpg", "/images/carousel/c_xcom/xcom_02.jpg", "/images/carousel/c_xcom/xcom_03.jpg", 0, "XCOM: Enemy Unknown is a 2012 turn-based tactical video game developed by Firaxis Games and published by 2K Games. The game is a reimagined remake of the 1994 cult classic strategy game UFO: Enemy Unknown and a reboot of MicroProse's 1990s X-COM series.", 6, "/images/xcom.jpg", "/images/xcom.jpg", "XCOM: Enemy Unknown", 25m, "2K Games", "2014", "5/5", "https://www.youtube.com/embed/L2o2iW4mPR8" },
                    { 7, "/images/carousel/c_theforest/theforest_01.jpg", "/images/carousel/c_theforest/theforest_02.jpg", "/images/carousel/c_theforest/theforest_03.jpg", 0, "The Forest is a survival video game developed and published by Endnight Games. The game takes place on a remote, heavily forested peninsula where the player character Eric Leblanc and his son Timmy are survivors of a plane crash.", 7, "/images/theforest.jpg", "/images/theforest.jpg", "The Forest", 15m, "Endnight Games", "2017", "4/5", "https://www.youtube.com/embed/7mwn5U2PNvk" },
                    { 6, "/images/carousel/c_skyrim/skyrim_01.jpg", "/images/carousel/c_skyrim/skyrim_02.jpg", "/images/carousel/c_skyrim/skyrim_03.jpg", 0, "Ori and the Blind Forest is a platform-adventure Metroidvania video game developed by Moon Studios and published by Microsoft Studios. The game was released for Xbox One and Microsoft Windows on March 11, 2015 and for Nintendo Switch on September 27, 2019.", 5, "/images/skyrim.jpg", "/images/skyrim.jpg", "Skyrim", 15m, "Bethesda", "2011", "5/5", "https://www.youtube.com/embed/JSRtYpNRoN0" },
                    { 5, "/images/carousel/c_ori/ori_01.jpg", "/images/carousel/c_ori/ori_02.jpg", "/images/carousel/c_ori/ori_03.jpg", 0, "Ori And The Blind Forest", 3, "/images/ori.jpg", "/images/ori.jpg", "Ori And The Blind Forest", 25m, "Microsoft Studios", "2015", "4/5", "https://www.youtube.com/embed/cklw-Yu3moE" },
                    { 2, "/images/carousel/c_masseffect2/masseffect2_01.jpg", "/images/carousel/c_masseffect2/masseffect2_02.jpg", "/images/carousel/c_masseffect2/masseffect2_03.jpg", 0, "Mass Effect 2 is an action role-playing video game developed by BioWare and published by Electronic Arts. It was released for Microsoft Windows and Xbox 360 in 2010, and PlayStation 3 in 2011. Mass Effect 2 is the second installment of the Mass Effect series and a sequel to the original Mass Effect. ", 1, "/images/masseffect2.jpg", "/images/masseffect2.jpg", "Mass Effect 2", 10m, "Electronic Arts", "2010", "5/5", "https://www.youtube.com/embed/PHCA8tK117c" },
                    { 3, "/images/carousel/c_alienisolation/alienisolation_01.jpg", "/images/carousel/c_alienisolation/alienisolation_02.jpg", "/images/carousel/c_alienisolation/alienisolation_03.jpg", 0, "Alien: Isolation is a 2014 survival horror video game developed by Creative Assembly and published by Sega originally for Microsoft Windows, PlayStation 3, PlayStation 4, Xbox 360 and Xbox One.", 2, "/images/alienisolation.jpg", "/images/alienisolation.jpg", "Alien Isolation", 30m, "Sega", "2014", "4/5", "https://www.youtube.com/embed/7h0cgmvIrZw" },
                    { 9, "/images/carousel/c_doometernal/doometernal_01.jpg", "/images/carousel/c_doometernal/doometernal_02.jpg", "/images/carousel/c_doometernal/doometernal_03.jpg", 0, "Doom Eternal is a first-person shooter video game developed by id Software and published by Bethesda Softworks. The sequel to Doom, and the fifth main game in the Doom series, it was released on March 20, 2020, for Windows, PlayStation 4, Stadia and Xbox One, with a Nintendo Switch version planned.", 1, "/images/doometernal.jpg", "/images/doometernal.jpg", "Doom Eternal", 40m, "ID Software", "2019", "5/5", "https://www.youtube.com/embed/_oVwrpfo_QA" },
                    { 1, "/images/carousel/c_titanfall2/titanfall2_02.jpg", "/images/carousel/c_titanfall2/titanfall2_01.jpg", "/images/carousel/c_titanfall2/titanfall2_03.jpg", 0, "Titanfall 2 is a first-person shooter video game, developed by Respawn Entertainment and published by Electronic Arts. A sequel to 2014's Titanfall, the game was released worldwide on October 28, 2016 for Windows, PlayStation 4, and Xbox One.", 1, "/images/titanfall2.jpg", "/images/titanfall2.jpg", "TitanFall 2", 25m, "Electronic Arts", "2016", "5/5", "https://www.youtube.com/embed/VqeMjHmL9eg" },
                    { 4, "/images/carousel/c_dirt3/dirt3_01.jpg", "/images/carousel/c_dirt3/dirt3_02.jpg", "/images/carousel/c_dirt3/dirt3_03.jpg", 0, "Dirt 3 is a racing video game developed and published by Codemasters for Microsoft Windows, PlayStation 3 and Xbox 360. It is the eighth game in the Colin McRae Rally series.", 4, "/images/dirt3.jpg", "/images/dirt3.jpg", "Dirt 3", 20m, "Codemasters", "2010", "3.5/5", "https://www.youtube.com/embed/_MgSPOgcUyQ" },
                    { 10, "/images/carousel/c_stellaris/stellaris_01.jpg", "/images/carousel/c_stellaris/stellaris_02.jpg", "/images/carousel/c_stellaris/stellaris_03.jpg", 0, "Stellaris is a 4X grand strategy video game developed and published by Paradox Interactive. Stellaris's gameplay revolves around space exploration, managing an empire, diplomacy, and space warfare with other spacefaring civilizations.", 1, "/images/stellaris.jpg", "/images/stellaris.jpg", "Stellaris", 30m, "Paradox Interactive", "2016", "5/5", "https://www.youtube.com/embed/Zh9yZNrb62U" }
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
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_TitleId",
                table: "OrderDetails",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_TitleId",
                table: "ShoppingCartItems",
                column: "TitleId");
        }

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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
