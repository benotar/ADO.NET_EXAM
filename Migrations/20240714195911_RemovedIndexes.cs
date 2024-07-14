using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exam2.Migrations
{
    /// <inheritdoc />
    public partial class RemovedIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_IsPurchased",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Journeys_DispatchAt",
                table: "Journeys");

            migrationBuilder.DropIndex(
                name: "IX_Cities_Name",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6713), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6721), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6729), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6736), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6744), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6752), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6789), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6847), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6858), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6869), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6879), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 7, 14, 22, 59, 11, 440, DateTimeKind.Local).AddTicks(6901) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_IsPurchased",
                table: "Tickets",
                column: "IsPurchased",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_DispatchAt",
                table: "Journeys",
                column: "DispatchAt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name",
                unique: true);
        }
    }
}
