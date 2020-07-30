using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class furtherSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaxPeopleCapacity",
                value: 35);

            migrationBuilder.Sql("set identity_insert Event on");

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "MaxPeopleCapacity", "Title" },
                values: new object[,]
                {
                    { 3, 9, "Show Sandy Junior" },
                    { 4, 10, "Show Jorge Mateus" },
                    { 5, 8, "Show Capital Inicial" },
                    { 6, 6, "Show Paralamas Sucesso" },
                    { 7, 7, "Show Carlinhos Brown" },
                    { 8, 30, "Megashow Madonna" },
                    { 9, 11, "Turnê Chitãozinho e Xororó" },
                    { 10, 5, "Harmozia do Samba" }
                });

            migrationBuilder.Sql("set identity_insert Event off");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "MaxPeopleCapacity",
                value: 5);
        }
    }
}
