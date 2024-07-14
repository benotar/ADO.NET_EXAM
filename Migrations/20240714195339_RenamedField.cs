using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exam2.Migrations
{
    /// <inheritdoc />
    public partial class RenamedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Seat",
                table: "Tickets",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "DateDispatch",
                table: "Journeys",
                newName: "DispatchAt");

            migrationBuilder.RenameIndex(
                name: "IX_Journeys_DateDispatch",
                table: "Journeys",
                newName: "IX_Journeys_DispatchAt");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3520), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3533), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3539), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3545), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3562), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3568), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3585), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3618), new DateTime(2024, 7, 14, 22, 53, 38, 550, DateTimeKind.Local).AddTicks(3620) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Place",
                table: "Tickets",
                newName: "Seat");

            migrationBuilder.RenameColumn(
                name: "DispatchAt",
                table: "Journeys",
                newName: "DateDispatch");

            migrationBuilder.RenameIndex(
                name: "IX_Journeys_DispatchAt",
                table: "Journeys",
                newName: "IX_Journeys_DateDispatch");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4833), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4900), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4913), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4945), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4951), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4957), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4963), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4969), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4975), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4981), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4993), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(4998), new DateTime(2024, 7, 14, 20, 52, 2, 666, DateTimeKind.Local).AddTicks(5000) });
        }
    }
}
