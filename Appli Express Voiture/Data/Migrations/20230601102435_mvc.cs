﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Appli_Express_Voiture.Data.Migrations
{
    /// <inheritdoc />
    public partial class mvc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voiture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voiture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reparation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeIntervention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoutIntervention = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoitureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reparation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reparation_Voiture_VoitureId",
                        column: x => x.VoitureId,
                        principalTable: "Voiture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reparation_VoitureId",
                table: "Reparation",
                column: "VoitureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reparation");

            migrationBuilder.DropTable(
                name: "Voiture");
        }
    }
}
