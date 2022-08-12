using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contact_information_infromationid",
                table: "contact");

            migrationBuilder.DropIndex(
                name: "IX_contact_infromationid",
                table: "contact");

            migrationBuilder.DropColumn(
                name: "infromationid",
                table: "contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "infromationid",
                table: "contact",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_contact_infromationid",
                table: "contact",
                column: "infromationid");

            migrationBuilder.AddForeignKey(
                name: "FK_contact_information_infromationid",
                table: "contact",
                column: "infromationid",
                principalTable: "information",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
