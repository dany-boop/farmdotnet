using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CattleType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CattleType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FarmExpenseCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmExpenseCategory", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Is_active = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Farm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type_Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Investor_Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Buy_Price = table.Column<int>(type: "int", nullable: false),
                    Sell_Price = table.Column<int>(type: "int", nullable: false),
                    Treament_Price = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Male_Breeder = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Female_Breeder = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Farm_CattleType_Type_Id",
                        column: x => x.Type_Id,
                        principalTable: "CattleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Farm_User_Investor_Id",
                        column: x => x.Investor_Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FarmExpense",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Farm_Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Total = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img4 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img5 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmExpense", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FarmExpense_Farm_Farm_Id",
                        column: x => x.Farm_Id,
                        principalTable: "Farm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FarmImg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Farm_Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Category_Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Img1 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img2 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Img3 = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmImg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FarmImg_FarmExpenseCategory_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "FarmExpenseCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FarmImg_Farm_Farm_Id",
                        column: x => x.Farm_Id,
                        principalTable: "Farm",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CattleType",
                columns: new[] { "Id", "Is_active", "Name", "Note" },
                values: new object[] { new Guid("f571f132-1320-40dc-96a0-85b326790ca0"), true, "Type1", "Note for Type1" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Is_active", "Name", "Password", "Phone", "Role" },
                values: new object[] { new Guid("706304b7-8b75-49f9-8bb7-c51d421cc08a"), "john.doe@example.com", true, "John Doe", "password123", "1234567890", "investor" });

            migrationBuilder.InsertData(
                table: "Farm",
                columns: new[] { "Id", "Buy_Price", "Code", "Female_Breeder", "Investor_Id", "Male_Breeder", "Sell_Price", "Status", "Treament_Price", "Type_Id" },
                values: new object[] { new Guid("6f67877d-28c5-4a89-8083-609976b90509"), 1000, "FARM001", new Guid("30f5ebbb-5afb-4ac6-969b-972acc5a2dee"), new Guid("706304b7-8b75-49f9-8bb7-c51d421cc08a"), new Guid("10cb5f9b-6ca0-4fc1-a081-bdca6edf4e5d"), 1500, 1, 200, new Guid("f571f132-1320-40dc-96a0-85b326790ca0") });

            migrationBuilder.CreateIndex(
                name: "IX_Farm_Investor_Id",
                table: "Farm",
                column: "Investor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Farm_Type_Id",
                table: "Farm",
                column: "Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FarmExpense_Farm_Id",
                table: "FarmExpense",
                column: "Farm_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FarmImg_Category_Id",
                table: "FarmImg",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FarmImg_Farm_Id",
                table: "FarmImg",
                column: "Farm_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FarmExpense");

            migrationBuilder.DropTable(
                name: "FarmImg");

            migrationBuilder.DropTable(
                name: "FarmExpenseCategory");

            migrationBuilder.DropTable(
                name: "Farm");

            migrationBuilder.DropTable(
                name: "CattleType");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
