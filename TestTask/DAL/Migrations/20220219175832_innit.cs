using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class innit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryVisitors",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false),
                    VisitorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryVisitors", x => new { x.CountryId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_CountryVisitors_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitVisitors",
                columns: table => new
                {
                    VisitId = table.Column<int>(nullable: false),
                    VisitorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitVisitors", x => new { x.VisitId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_VisitVisitors_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Spain" },
                    { 3, "Germany" },
                    { 4, "France" }
                });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Ivan", "Ivanov" },
                    { 2, "Petro", "Petrov" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 2, 1, "Kyiv" },
                    { 4, 2, "Madrid" },
                    { 1, 3, "Berlin" },
                    { 3, 4, "Paris" }
                });

            migrationBuilder.InsertData(
                table: "CountryVisitors",
                columns: new[] { "CountryId", "VisitorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "CityId", "Comment", "Rate" },
                values: new object[] { 1, 1, "sdsd", 5 });

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "CityId", "Comment", "Rate" },
                values: new object[] { 2, 3, "fdgf", 3 });

            migrationBuilder.InsertData(
                table: "VisitVisitors",
                columns: new[] { "VisitId", "VisitorId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "VisitVisitors",
                columns: new[] { "VisitId", "VisitorId" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryVisitors_VisitorId",
                table: "CountryVisitors",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_CityId",
                table: "Visits",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitVisitors_VisitorId",
                table: "VisitVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryVisitors");

            migrationBuilder.DropTable(
                name: "VisitVisitors");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
