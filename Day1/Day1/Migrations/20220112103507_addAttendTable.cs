using Microsoft.EntityFrameworkCore.Migrations;

namespace Day1.Migrations
{
    public partial class addAttendTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attandance",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOFAbs = table.Column<int>(type: "int", nullable: false),
                    NoOFAttend = table.Column<int>(type: "int", nullable: false),
                    std_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attandance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Attandance_Student_std_id",
                        column: x => x.std_id,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attandance_std_id",
                table: "Attandance",
                column: "std_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attandance");
        }
    }
}
