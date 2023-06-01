using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appli_Express_Voiture.Data.Migrations
{
    /// <inheritdoc />
    public partial class correctif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voiture",
                table: "Voiture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reparation",
                table: "Reparation");

            migrationBuilder.RenameTable(
                name: "Voiture",
                newName: "Voitures");

            migrationBuilder.RenameTable(
                name: "Reparation",
                newName: "Reparations");

            migrationBuilder.RenameIndex(
                name: "IX_Reparation_VoitureId",
                table: "Reparations",
                newName: "IX_Reparations_VoitureId");

            migrationBuilder.AlterColumn<float>(
                name: "CoutIntervention",
                table: "Reparations",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voitures",
                table: "Voitures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reparations",
                table: "Reparations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparations_Voitures_VoitureId",
                table: "Reparations",
                column: "VoitureId",
                principalTable: "Voitures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reparations_Voitures_VoitureId",
                table: "Reparations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voitures",
                table: "Voitures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reparations",
                table: "Reparations");

            migrationBuilder.RenameTable(
                name: "Voitures",
                newName: "Voiture");

            migrationBuilder.RenameTable(
                name: "Reparations",
                newName: "Reparation");

            migrationBuilder.RenameIndex(
                name: "IX_Reparations_VoitureId",
                table: "Reparation",
                newName: "IX_Reparation_VoitureId");

            migrationBuilder.AlterColumn<string>(
                name: "CoutIntervention",
                table: "Reparation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voiture",
                table: "Voiture",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reparation",
                table: "Reparation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reparation_Voiture_VoitureId",
                table: "Reparation",
                column: "VoitureId",
                principalTable: "Voiture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
