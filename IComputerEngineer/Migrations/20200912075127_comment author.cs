using Microsoft.EntityFrameworkCore.Migrations;

namespace IComputerEngineer.Migrations
{
    public partial class commentauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComments_MainComments_MainCommentId",
                table: "SubComments");

            migrationBuilder.AlterColumn<int>(
                name: "MainCommentId",
                table: "SubComments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "SubComments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "MainComments",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubComments_MainComments_MainCommentId",
                table: "SubComments",
                column: "MainCommentId",
                principalTable: "MainComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComments_MainComments_MainCommentId",
                table: "SubComments");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "SubComments");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "MainComments");

            migrationBuilder.AlterColumn<int>(
                name: "MainCommentId",
                table: "SubComments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_SubComments_MainComments_MainCommentId",
                table: "SubComments",
                column: "MainCommentId",
                principalTable: "MainComments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
