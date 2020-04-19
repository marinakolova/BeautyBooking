namespace BeautyBooking.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddSalonServiceToAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalonServiceId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceSalonId",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ServiceSalonId_ServiceId",
                table: "Appointments",
                columns: new[] { "ServiceSalonId", "ServiceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_SalonServices_ServiceSalonId_ServiceId",
                table: "Appointments",
                columns: new[] { "ServiceSalonId", "ServiceId" },
                principalTable: "SalonServices",
                principalColumns: new[] { "SalonId", "ServiceId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_SalonServices_ServiceSalonId_ServiceId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_ServiceSalonId_ServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SalonServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ServiceSalonId",
                table: "Appointments");
        }
    }
}
