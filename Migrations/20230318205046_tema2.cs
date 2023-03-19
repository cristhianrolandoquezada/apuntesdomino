using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApuntesDominoAPI.Migrations
{
    public partial class tema2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tfondos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fonnombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Defecto = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Fonruta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fonpie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tfondos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timagenes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Imgnomimagevid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgcomentcorto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgcomentlargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imgtipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idpatro = table.Column<byte>(type: "tinyint", nullable: true),
                    Idtema = table.Column<byte>(type: "tinyint", nullable: true),
                    Imgruta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timagenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tpatrocinadores",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Idpatro = table.Column<byte>(type: "tinyint", nullable: false),
                    Nombrepatro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abreviapatro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccionpatro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono1patro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono2patro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tpatrocinadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ttemas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temnombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Defecto = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ttemas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tfondos");

            migrationBuilder.DropTable(
                name: "Timagenes");

            migrationBuilder.DropTable(
                name: "Tpatrocinadores");

            migrationBuilder.DropTable(
                name: "Ttemas");
        }
    }
}
