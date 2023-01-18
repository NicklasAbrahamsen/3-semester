using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efsjov.Migrations
{
    /// <inheritdoc />
    public partial class CategoryaddedtoTodoTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TodoTaskId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    User = table.Column<string>(type: "TEXT", nullable: false),
                    Catagory = table.Column<string>(type: "TEXT", nullable: false),
                    Område = table.Column<int>(type: "INTEGER", nullable: false),
                    Done = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TodoTaskId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
