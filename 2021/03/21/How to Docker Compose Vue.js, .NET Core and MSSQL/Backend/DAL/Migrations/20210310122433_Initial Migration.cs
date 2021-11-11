using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneBookEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 500, nullable: false),
                    LastName = table.Column<string>(maxLength: 500, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneBookEntries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PhoneBookEntries",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Emilia-Romagna, Italy", "Seneca", "Farhana", "+35943815315" },
                    { 2, "	Ingushetia, Russia", "Dorofey", "Juraj", "+359 43 985 602" },
                    { 3, "Ireland", "Feidhlimidh", "Benigna", "+359 43 061 126" },
                    { 4, "Icelandic", "Katla", "Gumarich", "+359 437 695 17" },
                    { 5, "Austria", "Gregor", "Eugène", "+359 48 083 694" },
                    { 6, "Ceredigion, Wales, United Kingdom", "Afon", "Joetta", "+359 437 099 56" },
                    { 7, "Baden-Württemberg, Germany", "Henrik", "Liudevit", "+359 43 049 097" },
                    { 8, "Gujarat, India", "Sachin", "Esteve", "+359 98 568 6606" },
                    { 9, "Brazil", "Filipa", "Cillian", "+359 89 825 1635" },
                    { 10, "Lombardy, Italy", "Crescenzo", "Stine", "+359 43 862 362" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneBookEntries");
        }
    }
}
