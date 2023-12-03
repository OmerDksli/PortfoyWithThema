using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_v5required : Migration
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

            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_UserId",
                table: "ImagePaths",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePaths_User_UserId",
                table: "ImagePaths",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
    }
}
