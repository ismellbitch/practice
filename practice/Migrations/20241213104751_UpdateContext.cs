using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practice.Migrations
{
    /// <inheritdoc />
    public partial class UpdateContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "material",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    picture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    minCount = table.Column<int>(type: "int", nullable: false),
                    itemsInPackage = table.Column<int>(type: "int", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TIN = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    workSince = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplier_1", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "materialsupplier",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    material = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    supplier = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materialsupplier", x => x.id);
                    table.ForeignKey(
                        name: "FK_materialsupplier_material",
                        column: x => x.material,
                        principalTable: "material",
                        principalColumn: "name");
                    table.ForeignKey(
                        name: "FK_materialsupplier_supplier",
                        column: x => x.supplier,
                        principalTable: "supplier",
                        principalColumn: "name");
                });

            migrationBuilder.CreateIndex(
                name: "IX_materialsupplier_material",
                table: "materialsupplier",
                column: "material");

            migrationBuilder.CreateIndex(
                name: "IX_materialsupplier_supplier",
                table: "materialsupplier",
                column: "supplier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "materialsupplier");

            migrationBuilder.DropTable(
                name: "material");

            migrationBuilder.DropTable(
                name: "supplier");
        }
    }
}
