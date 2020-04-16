using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeautyBooking.Data.Migrations
{
    public partial class AddMultipleCategoriesToSalons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salons_Categories_CategoryId",
                table: "Salons");

            migrationBuilder.DropIndex(
                name: "IX_Salons_CategoryId",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Salons");

            migrationBuilder.CreateTable(
                name: "SalonCategories",
                columns: table => new
                {
                    SalonId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalonCategories", x => new { x.SalonId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_SalonCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalonCategories_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalonCategories_CategoryId",
                table: "SalonCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonCategories_IsDeleted",
                table: "SalonCategories",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalonCategories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Salons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Salons_CategoryId",
                table: "Salons",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salons_Categories_CategoryId",
                table: "Salons",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
