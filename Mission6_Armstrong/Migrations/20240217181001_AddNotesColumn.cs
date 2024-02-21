using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Armstrong.Migrations
{
    /// <inheritdoc />
    public partial class AddNotesColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
            name: "Notes",
            table: "Applications",
            nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
