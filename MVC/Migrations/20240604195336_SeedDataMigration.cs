using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Farm",
                keyColumn: "Id",
                keyValue: new Guid("6f67877d-28c5-4a89-8083-609976b90509"));

            migrationBuilder.DeleteData(
                table: "CattleType",
                keyColumn: "Id",
                keyValue: new Guid("f571f132-1320-40dc-96a0-85b326790ca0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("706304b7-8b75-49f9-8bb7-c51d421cc08a"));

            migrationBuilder.AlterColumn<string>(
                name: "Img3",
                table: "FarmImg",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Img2",
                table: "FarmImg",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Img1",
                table: "FarmImg",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Img5",
                table: "FarmExpense",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Img4",
                table: "FarmExpense",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Img3",
                table: "FarmExpense",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Img2",
                table: "FarmExpense",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Img1",
                table: "FarmExpense",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CattleType",
                columns: new[] { "Id", "Is_active", "Name", "Note" },
                values: new object[] { new Guid("4bce702e-f150-4769-9463-2f54fe7cf171"), true, "Type1", "Note for Type1" });

            migrationBuilder.InsertData(
                table: "FarmExpenseCategory",
                columns: new[] { "Id", "Is_active", "Name" },
                values: new object[] { new Guid("8d886e56-f601-4c35-94d1-de3de9a44be9"), true, "Feed" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Is_active", "Name", "Password", "Phone", "Role" },
                values: new object[] { new Guid("9e0600a7-f0f3-40f0-8f30-698554d9705b"), "john.doe@example.com", true, "John Doe", "password123", "1234567890", "investor" });

            migrationBuilder.InsertData(
                table: "Farm",
                columns: new[] { "Id", "Buy_Price", "Code", "Female_Breeder", "Investor_Id", "Male_Breeder", "Sell_Price", "Status", "Treament_Price", "Type_Id" },
                values: new object[] { new Guid("0592d5c3-bf60-4ce8-b6bd-f48a26a2c7bc"), 1000, "FARM001", new Guid("043d9b20-b26b-48dd-b621-f86b4fb432f5"), new Guid("9e0600a7-f0f3-40f0-8f30-698554d9705b"), new Guid("77c7a5f9-018e-4f58-8b1b-3551ca5aac10"), 1500, 1, 200, new Guid("4bce702e-f150-4769-9463-2f54fe7cf171") });

            migrationBuilder.InsertData(
                table: "FarmExpense",
                columns: new[] { "Id", "Date", "Farm_Id", "Img1", "Img2", "Img3", "Img4", "Img5", "Total" },
                values: new object[] { new Guid("c30348ca-9ca5-45e1-b189-d05c3027a08f"), new DateTime(2024, 5, 26, 2, 53, 28, 508, DateTimeKind.Local).AddTicks(6684), new Guid("0592d5c3-bf60-4ce8-b6bd-f48a26a2c7bc"), null, null, null, null, null, "1000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FarmExpense",
                keyColumn: "Id",
                keyValue: new Guid("c30348ca-9ca5-45e1-b189-d05c3027a08f"));

            migrationBuilder.DeleteData(
                table: "FarmExpenseCategory",
                keyColumn: "Id",
                keyValue: new Guid("8d886e56-f601-4c35-94d1-de3de9a44be9"));

            migrationBuilder.DeleteData(
                table: "Farm",
                keyColumn: "Id",
                keyValue: new Guid("0592d5c3-bf60-4ce8-b6bd-f48a26a2c7bc"));

            migrationBuilder.DeleteData(
                table: "CattleType",
                keyColumn: "Id",
                keyValue: new Guid("4bce702e-f150-4769-9463-2f54fe7cf171"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9e0600a7-f0f3-40f0-8f30-698554d9705b"));

            migrationBuilder.UpdateData(
                table: "FarmImg",
                keyColumn: "Img3",
                keyValue: null,
                column: "Img3",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img3",
                table: "FarmImg",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FarmImg",
                keyColumn: "Img2",
                keyValue: null,
                column: "Img2",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img2",
                table: "FarmImg",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FarmImg",
                keyColumn: "Img1",
                keyValue: null,
                column: "Img1",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img1",
                table: "FarmImg",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FarmExpense",
                keyColumn: "Img5",
                keyValue: null,
                column: "Img5",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img5",
                table: "FarmExpense",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FarmExpense",
                keyColumn: "Img4",
                keyValue: null,
                column: "Img4",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img4",
                table: "FarmExpense",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FarmExpense",
                keyColumn: "Img3",
                keyValue: null,
                column: "Img3",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img3",
                table: "FarmExpense",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FarmExpense",
                keyColumn: "Img2",
                keyValue: null,
                column: "Img2",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img2",
                table: "FarmExpense",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "FarmExpense",
                keyColumn: "Img1",
                keyValue: null,
                column: "Img1",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Img1",
                table: "FarmExpense",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
        }
    }
}
