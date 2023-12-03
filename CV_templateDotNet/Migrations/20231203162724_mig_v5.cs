using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePaths_Projects_PojectId",
                table: "ImagePaths");

            migrationBuilder.DropIndex(
                name: "IX_ImagePaths_PojectId",
                table: "ImagePaths");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "ImagePaths",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_ProjectId",
                table: "ImagePaths",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePaths_Projects_ProjectId",
                table: "ImagePaths",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagePaths_Projects_ProjectId",
                table: "ImagePaths");

            migrationBuilder.DropIndex(
                name: "IX_ImagePaths_ProjectId",
                table: "ImagePaths");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "ImagePaths");

            migrationBuilder.CreateIndex(
                name: "IX_ImagePaths_PojectId",
                table: "ImagePaths",
                column: "PojectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagePaths_Projects_PojectId",
                table: "ImagePaths",
                column: "PojectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
