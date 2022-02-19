using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Migrations
{
    public partial class FixedTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorsVisitors_Visits_VisitId",
                table: "VisitorsVisitors");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorsVisitors_Visitors_VisitorId",
                table: "VisitorsVisitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorsVisitors",
                table: "VisitorsVisitors");

            migrationBuilder.RenameTable(
                name: "VisitorsVisitors",
                newName: "VisitVisitors");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorsVisitors_VisitorId",
                table: "VisitVisitors",
                newName: "IX_VisitVisitors_VisitorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitVisitors",
                table: "VisitVisitors",
                columns: new[] { "VisitId", "VisitorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_VisitVisitors_Visits_VisitId",
                table: "VisitVisitors",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitVisitors_Visitors_VisitorId",
                table: "VisitVisitors",
                column: "VisitorId",
                principalTable: "Visitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitVisitors_Visits_VisitId",
                table: "VisitVisitors");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitVisitors_Visitors_VisitorId",
                table: "VisitVisitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitVisitors",
                table: "VisitVisitors");

            migrationBuilder.RenameTable(
                name: "VisitVisitors",
                newName: "VisitorsVisitors");

            migrationBuilder.RenameIndex(
                name: "IX_VisitVisitors_VisitorId",
                table: "VisitorsVisitors",
                newName: "IX_VisitorsVisitors_VisitorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorsVisitors",
                table: "VisitorsVisitors",
                columns: new[] { "VisitId", "VisitorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorsVisitors_Visits_VisitId",
                table: "VisitorsVisitors",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorsVisitors_Visitors_VisitorId",
                table: "VisitorsVisitors",
                column: "VisitorId",
                principalTable: "Visitors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
