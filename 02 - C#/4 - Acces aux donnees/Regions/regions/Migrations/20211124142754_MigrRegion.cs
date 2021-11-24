using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace regions.Migrations
{
    public partial class MigrRegion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    IdRegion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomRegion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.IdRegion);
                });

            migrationBuilder.CreateTable(
                name: "Depatements",
                columns: table => new
                {
                    IdDepartement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomDepartement = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    RegionsIdRegion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depatements", x => x.IdDepartement);
                    table.ForeignKey(
                        name: "FK_Depatements_Regions_RegionsIdRegion",
                        column: x => x.RegionsIdRegion,
                        principalTable: "Regions",
                        principalColumn: "IdRegion",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Villes",
                columns: table => new
                {
                    IdVille = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NomVille = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DepartementsIdDepartement = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villes", x => x.IdVille);
                    table.ForeignKey(
                        name: "FK_Villes_Depatements_DepartementsIdDepartement",
                        column: x => x.DepartementsIdDepartement,
                        principalTable: "Depatements",
                        principalColumn: "IdDepartement",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depatements_RegionsIdRegion",
                table: "Depatements",
                column: "RegionsIdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_Villes_DepartementsIdDepartement",
                table: "Villes",
                column: "DepartementsIdDepartement");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villes");

            migrationBuilder.DropTable(
                name: "Depatements");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
