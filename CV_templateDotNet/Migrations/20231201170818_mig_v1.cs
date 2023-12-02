using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePaths_User_userId",
                table: "ImagePaths");

            migrationBuilder.DropIndex(
                name: "IX_ImagePaths_userId",
                table: "ImagePaths");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "ImagePaths");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "ImagePaths",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_userId",
                table: "ImagePaths",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePaths_User_userId",
                table: "ImagePaths",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
