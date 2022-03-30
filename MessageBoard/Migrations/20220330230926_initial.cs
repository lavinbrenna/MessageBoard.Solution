using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    UserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MessageBody = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Group = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Group", "MessageBody", "MessageDate", "Title", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, "Recipes", "This is a test", new DateTime(2000, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 1", null, "user2@test.com" },
                    { 2, "Giveaways", "This is another test", new DateTime(2002, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 2", null, "user@test.com" },
                    { 3, "Random", "This is another another test", new DateTime(2003, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 3", null, "user2@test.com" },
                    { 4, "Recipes", "This is a title", new DateTime(2004, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 4", null, "user2@test.com" },
                    { 5, "Giveaways", "This is another title", new DateTime(2005, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 5", null, "user@test.com" },
                    { 6, "Random", "This is another another title", new DateTime(2006, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 6", null, "user2@test.com" },
                    { 7, "Recipes", "This is a test", new DateTime(2000, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 1", null, "user2@test.com" },
                    { 8, "Giveaways", "This is another test", new DateTime(2002, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 2", null, "user@test.com" },
                    { 9, "Random", "This is another another test", new DateTime(2003, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 3", null, "user2@test.com" },
                    { 10, "Recipes", "This is a title", new DateTime(2004, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 4", null, "user2@test.com" },
                    { 11, "Giveaways", "This is another title", new DateTime(2005, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 5", null, "user@test.com" },
                    { 12, "Random", "This is another another title", new DateTime(2006, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test 6", null, "user2@test.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "ApplicationUser");
        }
    }
}
