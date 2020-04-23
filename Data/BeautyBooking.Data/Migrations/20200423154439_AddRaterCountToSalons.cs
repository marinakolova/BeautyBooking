namespace BeautyBooking.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddRaterCountToSalons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatersCount",
                table: "Salons",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatersCount",
                table: "Salons");
        }
    }
}
