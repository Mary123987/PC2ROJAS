using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PC2ROJAS.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial_TablaCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreTitular = table.Column<string>(type: "TEXT", nullable: true),
                    TipoCuenta = table.Column<string>(type: "TEXT", nullable: true),
                    SaldoInicial = table.Column<decimal>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_cliente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_cliente");
        }
    }
}
