using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    /// <inheritdoc />
    public partial class mig_NtwrkRfrns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "NetworkReferances",
                type: "nchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "NetworkReferances");
        }
    }
}
