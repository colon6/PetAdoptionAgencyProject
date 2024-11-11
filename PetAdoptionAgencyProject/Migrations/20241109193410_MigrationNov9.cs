using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoptionAgencyProject.Migrations
{
    /// <inheritdoc />
    public partial class MigrationNov9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdoptionFee",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AnimalFriendly",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Bonded",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ChildFriendly",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdoptionFee",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AnimalFriendly",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Bonded",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "ChildFriendly",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Animals");
        }
    }
}
