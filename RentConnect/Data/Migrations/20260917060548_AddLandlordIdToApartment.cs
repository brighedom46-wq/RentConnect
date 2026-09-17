using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentConnect.Migrations
{
    /// <inheritdoc />
    public partial class AddLandlordIdToApartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LandlordId",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LandlordId",
                table: "Apartments");
        }
    }
}
