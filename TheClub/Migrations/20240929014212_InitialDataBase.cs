using Microsoft.EntityFrameworkCore.Migrations;

namespace TheClub.Migrations
{
    public partial class InitialDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    iDProduto = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    iDNome = table.Column<string>(maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(maxLength: 1000, nullable: false),
                    preco = table.Column<decimal>(type: "Decimal (18,2)", nullable: false),
                    estoque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.iDProduto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
