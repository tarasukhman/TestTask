using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTask.Migrations
{
    public partial class AddedDataToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "VisitorsVisitors",
                columns: new[] { "VisitId", "VisitorId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CountryVisitors",
                keyColumns: new[] { "CountryId", "VisitorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CountryVisitors",
                keyColumns: new[] { "CountryId", "VisitorId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "VisitorsVisitors",
                keyColumns: new[] { "VisitId", "VisitorId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
