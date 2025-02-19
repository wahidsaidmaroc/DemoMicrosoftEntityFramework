using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_ConsoleApp_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Test_valeur_ParDefaut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                schema: "dbo",
                table: "T_Produit",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "images/default.jpg",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                schema: "dbo",
                table: "T_Produit",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "images/default.jpg");
        }
    }
}
