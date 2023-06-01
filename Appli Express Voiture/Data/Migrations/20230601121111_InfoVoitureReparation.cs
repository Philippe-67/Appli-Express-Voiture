using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appli_Express_Voiture.Data.Migrations
{
    /// <inheritdoc />
    public partial class InfoVoitureReparation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "PrixAchat",
                table: "Voitures",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrixAchat",
                table: "Voitures");
        }
    }
}
