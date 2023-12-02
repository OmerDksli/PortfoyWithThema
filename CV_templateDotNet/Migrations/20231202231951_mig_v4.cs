using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePaths_User_UserId",
                table: "ImagePaths");

            migrationBuilder.DropIndex(
                name: "IX_ImagePaths_UserId",
                table: "ImagePaths");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ImagePaths",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_UserId",
                table: "ImagePaths",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePaths_User_UserId",
                table: "ImagePaths",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePaths_User_UserId",
                table: "ImagePaths");

            migrationBuilder.DropIndex(
                name: "IX_ImagePaths_UserId",
                table: "ImagePaths");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ImagePaths",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_UserId",
                table: "ImagePaths",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePaths_User_UserId",
                table: "ImagePaths",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
