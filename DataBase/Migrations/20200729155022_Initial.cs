using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Costumer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Costumer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    MaxPeopleCapacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: true),
                    CostumerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_Costumer_CostumerId",
                        column: x => x.CostumerId,
                        principalTable: "Costumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.Sql("set identity_insert Costumer on");

            migrationBuilder.InsertData(
                table: "Costumer",
                columns: new[] { "Id", "CPF", "Name" },
                values: new object[,]
                {
                    { 1, "70535892187", "Helder Carvalho de Sousa" },
                    { 2, "01234567890", "Glauber Carvalho de Sousa" }
                });

            migrationBuilder.Sql("set identity_insert Costumer off");

            migrationBuilder.Sql("set identity_insert Event on");

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "MaxPeopleCapacity", "Title" },
                values: new object[,]
                {
                    { 1, 5, "Megashow Pink Floyd" },
                    { 2, 3, "Circo du Solei" }
                });

            migrationBuilder.Sql("set identity_insert Event off");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CostumerId",
                table: "Ticket",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_EventId",
                table: "Ticket",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Costumer");

            migrationBuilder.DropTable(
                name: "Event");
        }
    }
}
