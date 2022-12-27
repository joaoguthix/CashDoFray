using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashDoFray.Migrations
{
    public partial class atualizandodados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pictures",
                table: "Pictures",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Pictures",
                newName: "Pictures");
        }
    }
}
