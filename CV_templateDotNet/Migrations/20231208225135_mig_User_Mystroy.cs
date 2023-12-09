using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_User_Mystroy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyStory",
                table: "User",
                type: "nchar(500)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyStory",
                table: "User");
        }
    }
}
