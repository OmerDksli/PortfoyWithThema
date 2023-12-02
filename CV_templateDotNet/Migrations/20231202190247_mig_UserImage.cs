using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_UserImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "User");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "User",
                type: "char(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
