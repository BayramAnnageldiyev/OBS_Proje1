using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBS_Proje.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler");

            migrationBuilder.AlterColumn<string>(
                name: "Numara",
                table: "Ogrenciler",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Dersler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "Siniflar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Dersler");

            migrationBuilder.AlterColumn<int>(
                name: "Numara",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Siniflar_SinifId",
                table: "Ogrenciler",
                column: "SinifId",
                principalTable: "Siniflar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
