using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeautyBooking.Data.Migrations
{
    public partial class AddServicesAndMappingTableSalonServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

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
                    DeletedOn = table.Column<DateTime>(nullable: true)
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
                name: "IX_Appointments_ServiceId",
                table: "Appointments",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalonServices_IsDeleted",
                table: "SalonServices",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_SalonServices_ServiceId",
                table: "SalonServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_IsDeleted",
                table: "Services",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "SalonServices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Appointments");
        }
    }
}
