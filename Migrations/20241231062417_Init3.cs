using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBS_Proje.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Dersler");

            migrationBuilder.AddColumn<string>(
                name: "DersKodu",
                table: "Dersler",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_DersKodu",
                table: "Dersler",
                column: "DersKodu",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Dersler_DersKodu",
                table: "Dersler");

            migrationBuilder.DropColumn(
                name: "DersKodu",
                table: "Dersler");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Dersler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
