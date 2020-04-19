namespace BeautyBooking.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class FixAppointmetsRelationToSalonServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_ClientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_SalonServices_ServiceSalonId_ServiceId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_SalonId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceSalonId_ServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SalonServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ServiceSalonId",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Appointments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SalonId_ServiceId",
                table: "Appointments",
                columns: new[] { "SalonId", "ServiceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId",
                table: "Appointments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_SalonServices_SalonId_ServiceId",
                table: "Appointments",
                columns: new[] { "SalonId", "ServiceId" },
                principalTable: "SalonServices",
                principalColumns: new[] { "SalonId", "ServiceId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Services_ServiceId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_SalonServices_SalonId_ServiceId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_SalonId_ServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "ClientId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonServiceId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceSalonId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClientId",
                table: "Appointments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SalonId",
                table: "Appointments",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceSalonId_ServiceId",
                table: "Appointments",
                columns: new[] { "ServiceSalonId", "ServiceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_ClientId",
                table: "Appointments",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_SalonServices_ServiceSalonId_ServiceId",
                table: "Appointments",
                columns: new[] { "ServiceSalonId", "ServiceId" },
                principalTable: "SalonServices",
                principalColumns: new[] { "SalonId", "ServiceId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
