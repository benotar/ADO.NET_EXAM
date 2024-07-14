using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exam2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Journeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityDepartureId = table.Column<int>(type: "INTEGER", nullable: false),
                    CityArrivalId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateDispatch = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Journeys_Cities_CityArrivalId",
                        column: x => x.CityArrivalId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Journeys_Cities_CityDepartureId",
                        column: x => x.CityDepartureId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JourneyId = table.Column<int>(type: "INTEGER", nullable: false),
                    Seat = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsPurchased = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Journeys_JourneyId",
                        column: x => x.JourneyId,
                        principalTable: "Journeys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "Latitude", "Longitude", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4741), 50.450099999999999, 30.523399999999999, "Kyiv", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4824) },
                    { 2, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4833), 49.839700000000001, 24.029699999999998, "Lviv", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4836) },
                    { 3, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4841), 46.482500000000002, 30.723299999999998, "Odesa", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4843) },
                    { 4, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4900), 48.464700000000001, 35.046199999999999, "Dnipro", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4902) },
                    { 5, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4907), 49.993499999999997, 36.230400000000003, "Kharkiv", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4909) },
                    { 6, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4913), 47.838799999999999, 35.139600000000002, "Zaporizhzhia", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4915) },
                    { 7, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4920), 46.975000000000001, 31.994599999999998, "Mykolaiv", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4922) },
                    { 8, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4926), 49.2331, 28.4682, "Vinnytsia", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4928) },
                    { 9, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4933), 49.588299999999997, 34.551400000000001, "Poltava", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4935) },
                    { 10, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4939), 51.498199999999997, 31.289300000000001, "Chernihiv", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4941) },
                    { 11, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4945), 48.290799999999997, 25.9345, "Chernivtsi", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4947) },
                    { 12, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4951), 46.635399999999997, 32.616900000000001, "Kherson", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4953) },
                    { 13, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4957), 48.922600000000003, 24.7103, "Ivano-Frankivsk", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4959) },
                    { 14, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4963), 50.907699999999998, 34.798099999999998, "Sumy", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4965) },
                    { 15, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4969), 49.5535, 25.594799999999999, "Ternopil", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4971) },
                    { 16, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4975), 48.620800000000003, 22.2879, "Uzhhorod", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4977) },
                    { 17, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4981), 50.264899999999997, 28.6767, "Zhytomyr", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4983) },
                    { 18, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4987), 50.619900000000001, 26.2516, "Rivne", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4989) },
                    { 19, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4993), 50.747199999999999, 25.325399999999998, "Lutsk", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4995) },
                    { 20, new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4998), 48.507899999999999, 32.262300000000003, "Kropyvnytskyi", new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(5000) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_CityArrivalId",
                table: "Journeys",
                column: "CityArrivalId");

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_CityDepartureId",
                table: "Journeys",
                column: "CityDepartureId");

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_DateDispatch",
                table: "Journeys",
                column: "DateDispatch",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_IsPurchased",
                table: "Tickets",
                column: "IsPurchased",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_JourneyId",
                table: "Tickets",
                column: "JourneyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Journeys");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
