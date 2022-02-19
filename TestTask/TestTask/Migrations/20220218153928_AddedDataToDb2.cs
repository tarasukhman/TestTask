using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Migrations
{
    public partial class AddedDataToDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VisitorsVisitors",
                columns: new[] { "VisitId", "VisitorId" },
                values: new object[] { 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VisitorsVisitors",
                keyColumns: new[] { "VisitId", "VisitorId" },
                keyValues: new object[] { 2, 1 });
        }
    }
}
