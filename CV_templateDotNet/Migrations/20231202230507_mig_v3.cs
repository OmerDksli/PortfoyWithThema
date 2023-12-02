using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_ImagePaths_ProfilImageId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ProfilImageId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProfilImageId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ImagePaths",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePaths_User_UserId",
                table: "ImagePaths");

            migrationBuilder.DropIndex(
                name: "IX_ImagePaths_UserId",
                table: "ImagePaths");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ImagePaths");

            migrationBuilder.AddColumn<int>(
                name: "ProfilImageId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ProfilImageId",
                table: "User",
                column: "ProfilImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_ImagePaths_ProfilImageId",
                table: "User",
                column: "ProfilImageId",
                principalTable: "ImagePaths",
                principalColumn: "Id");
        }
    }
}
