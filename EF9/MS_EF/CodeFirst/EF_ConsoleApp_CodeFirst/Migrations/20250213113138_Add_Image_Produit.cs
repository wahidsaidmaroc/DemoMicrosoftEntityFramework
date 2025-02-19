using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_ConsoleApp_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Add_Image_Produit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                schema: "dbo",
                table: "T_Produit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                schema: "dbo",
                table: "T_Produit");
        }
    }
}
