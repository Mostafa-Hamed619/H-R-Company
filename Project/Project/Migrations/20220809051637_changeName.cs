using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class changeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_send_newsLetters_id1",
                table: "send");

            migrationBuilder.DropIndex(
                name: "IX_send_id1",
                table: "send");

            migrationBuilder.DropColumn(
                name: "id1",
                table: "send");

            migrationBuilder.AddColumn<int>(
                name: "EmailIDid",
                table: "send",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_send_EmailIDid",
                table: "send",
                column: "EmailIDid");

            migrationBuilder.AddForeignKey(
                name: "FK_send_newsLetters_EmailIDid",
                table: "send",
                column: "EmailIDid",
                principalTable: "newsLetters",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_send_newsLetters_EmailIDid",
                table: "send");

            migrationBuilder.DropIndex(
                name: "IX_send_EmailIDid",
                table: "send");

            migrationBuilder.DropColumn(
                name: "EmailIDid",
                table: "send");

            migrationBuilder.AddColumn<int>(
                name: "id1",
                table: "send",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_send_id1",
                table: "send",
                column: "id1");

            migrationBuilder.AddForeignKey(
                name: "FK_send_newsLetters_id1",
                table: "send",
                column: "id1",
                principalTable: "newsLetters",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
