using Microsoft.EntityFrameworkCore.Migrations;

namespace Bugger.Services.Migrations
{
    public partial class TablenameId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tickets",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Projects",
                newName: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Projects",
                newName: "ID");
        }
    }
}
