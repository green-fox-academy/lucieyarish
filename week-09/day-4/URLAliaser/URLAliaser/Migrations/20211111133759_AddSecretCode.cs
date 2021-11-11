using Microsoft.EntityFrameworkCore.Migrations;

namespace URLAliaser.Migrations
{
    public partial class AddSecretCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Alias",
                table: "Links",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "SecretCode",
                table: "Links",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretCode",
                table: "Links");

            migrationBuilder.AlterColumn<long>(
                name: "Alias",
                table: "Links",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
