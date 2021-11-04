using Microsoft.EntityFrameworkCore.Migrations;

namespace ListingTodos.Migrations
{
    public partial class updatedDBrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AssigneeID",
                table: "Todos",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AssigneeID",
                table: "Todos",
                column: "AssigneeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Assignees_AssigneeID",
                table: "Todos",
                column: "AssigneeID",
                principalTable: "Assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Assignees_AssigneeID",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AssigneeID",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "AssigneeID",
                table: "Todos");
        }
    }
}
