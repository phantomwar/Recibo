using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace recibo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeEmissor = table.Column<string>(nullable: false),
                    DocumentoEmissor = table.Column<int>(nullable: false),
                    TelefoneEmissor = table.Column<int>(nullable: false),
                    NomePagador = table.Column<string>(nullable: false),
                    DocumentoPagador = table.Column<int>(nullable: false),
                    referente = table.Column<string>(nullable: false),
                    valor = table.Column<decimal>(nullable: false),
                    data = table.Column<string>(nullable: false),
                    cidade = table.Column<string>(nullable: true),
                    FormaPagamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibos");
        }
    }
}
