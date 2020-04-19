namespace BeautyBooking.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ChangeSalonSalonManagerLogicAndSalonServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Salons_AspNetUsers_SalonManagerId",
                table: "Salons");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Salons_SalonId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_SalonId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Salons_SalonManagerId",
                table: "Salons");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "SalonManagerId",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Services",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SalonServices",
                columns: table => new
                {
                    SalonId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Available = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalonServices", x => new { x.SalonId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_SalonServices_Salons_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalonServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonServices_IsDeleted",
                table: "SalonServices",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SalonServices_ServiceId",
                table: "SalonServices",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "SalonServices");

            migrationBuilder.DropIndex(
                name: "IX_Services_CategoryId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SalonManagerId",
                table: "Salons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_SalonId",
                table: "Services",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Salons_SalonManagerId",
                table: "Salons",
                column: "SalonManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salons_AspNetUsers_SalonManagerId",
                table: "Salons",
                column: "SalonManagerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Salons_SalonId",
                table: "Services",
                column: "SalonId",
                principalTable: "Salons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
