using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class Updation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "send");

            migrationBuilder.AddColumn<int>(
                name: "infromationid",
                table: "contact",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "send",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailIDid = table.Column<int>(type: "int", nullable: true),
                    send_Letter = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_send", x => x.id);
                    table.ForeignKey(
                        name: "FK_send_newsLetters_EmailIDid",
                        column: x => x.EmailIDid,
                        principalTable: "newsLetters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_send_EmailIDid",
                table: "send",
                column: "EmailIDid");
        }
    }
}
