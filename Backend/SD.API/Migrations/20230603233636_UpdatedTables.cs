using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD.API.Migrations
{
<<<<<<<< HEAD:Backend/SD.API/Migrations/20230603233636_UpdatedTables.cs
    public partial class UpdatedTables : Migration
========
    public partial class CreateTables : Migration
>>>>>>>> b9974efe600a98b0c55b8de4a151690dbe186de6:Backend/SD.API/Migrations/20230601030457_CreateTables.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
<<<<<<<< HEAD:Backend/SD.API/Migrations/20230603233636_UpdatedTables.cs
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
========
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
>>>>>>>> b9974efe600a98b0c55b8de4a151690dbe186de6:Backend/SD.API/Migrations/20230601030457_CreateTables.cs
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
<<<<<<<< HEAD:Backend/SD.API/Migrations/20230603233636_UpdatedTables.cs
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sku = table.Column<long>(type: "bigint", nullable: false),
========
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
>>>>>>>> b9974efe600a98b0c55b8de4a151690dbe186de6:Backend/SD.API/Migrations/20230601030457_CreateTables.cs
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,2)", precision: 12, scale: 2, nullable: false),
                    Stock = table.Column<long>(type: "bigint", nullable: false),
<<<<<<<< HEAD:Backend/SD.API/Migrations/20230603233636_UpdatedTables.cs
                    CategoryId = table.Column<int>(type: "int", nullable: false)
========
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
>>>>>>>> b9974efe600a98b0c55b8de4a151690dbe186de6:Backend/SD.API/Migrations/20230601030457_CreateTables.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
