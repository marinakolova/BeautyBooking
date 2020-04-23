namespace BeautyBooking.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddOwnerToSalons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Salons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salons_OwnerId",
                table: "Salons",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Salons_AspNetUsers_OwnerId",
                table: "Salons",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salons_AspNetUsers_OwnerId",
                table: "Salons");

            migrationBuilder.DropIndex(
                name: "IX_Salons_OwnerId",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Salons");
        }
    }
}
