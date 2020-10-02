using Microsoft.EntityFrameworkCore.Migrations;

namespace recibo.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelefoneEmissor",
                table: "Recibos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FormaPagamento",
                table: "Recibos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentoPagador",
                table: "Recibos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentoEmissor",
                table: "Recibos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Recibos",
                columns: new[] { "Id", "DocumentoEmissor", "DocumentoPagador", "FormaPagamento", "NomeEmissor", "NomePagador", "TelefoneEmissor", "cidade", "data", "referente", "valor" },
                values: new object[] { 1, "12345678912", "21987654321", "Dinheiro", "Marcia Amaral", "Cliente Teste 1", "32991411071", "Mirai", "01102020", "Pagamento para teste", 300.00m });

            migrationBuilder.InsertData(
                table: "Recibos",
                columns: new[] { "Id", "DocumentoEmissor", "DocumentoPagador", "FormaPagamento", "NomeEmissor", "NomePagador", "TelefoneEmissor", "cidade", "data", "referente", "valor" },
                values: new object[] { 2, "12345678912", "21987654321", "Cartao", "Marcia Amaral", "Cliente Teste 2", "32991411071", "Mirai", "02102020", "Pagamento para teste Novo", 300.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "TelefoneEmissor",
                table: "Recibos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FormaPagamento",
                table: "Recibos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentoPagador",
                table: "Recibos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentoEmissor",
                table: "Recibos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
