using Microsoft.EntityFrameworkCore.Migrations;

namespace WebUI.Data.Migrations
{
    public partial class HostelSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_CoateRecord_CoateRecordId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_CoateRecord_CountrysideOrCityId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_CoateRecord_DistrictOrCityId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_CoateRecord_RegionOrCityId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_CoateRecord_VillageId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_Student_VillageId",
                table: "Students",
                newName: "IX_Students_VillageId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_RegionOrCityId",
                table: "Students",
                newName: "IX_Students_RegionOrCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_DistrictOrCityId",
                table: "Students",
                newName: "IX_Students_DistrictOrCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CountrysideOrCityId",
                table: "Students",
                newName: "IX_Students_CountrysideOrCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_CoateRecordId",
                table: "Students",
                newName: "IX_Students_CoateRecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKN7V3NU9Gz3XCRms9MQL3xmHDwP/UZaWtXpQjyy81X0KJcQ9URL8ujOeDSCQWe2ww==");

            migrationBuilder.InsertData(
                table: "Hostels",
                columns: new[] { "Id", "Capacity", "Flooring", "LivingRoomCount", "Map", "Name", "OfficeRoomCount", "ServiceRoomCount" },
                values: new object[] { 1, "200", 4, 158, "Общежитие №1", "Общежитие №1", 5, 12 });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CoateRecord_CoateRecordId",
                table: "Students",
                column: "CoateRecordId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CoateRecord_CountrysideOrCityId",
                table: "Students",
                column: "CountrysideOrCityId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CoateRecord_DistrictOrCityId",
                table: "Students",
                column: "DistrictOrCityId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CoateRecord_RegionOrCityId",
                table: "Students",
                column: "RegionOrCityId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CoateRecord_VillageId",
                table: "Students",
                column: "VillageId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_CoateRecord_CoateRecordId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_CoateRecord_CountrysideOrCityId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_CoateRecord_DistrictOrCityId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_CoateRecord_RegionOrCityId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_CoateRecord_VillageId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Hostels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameIndex(
                name: "IX_Students_VillageId",
                table: "Student",
                newName: "IX_Student_VillageId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_RegionOrCityId",
                table: "Student",
                newName: "IX_Student_RegionOrCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DistrictOrCityId",
                table: "Student",
                newName: "IX_Student_DistrictOrCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CountrysideOrCityId",
                table: "Student",
                newName: "IX_Student_CountrysideOrCityId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CoateRecordId",
                table: "Student",
                newName: "IX_Student_CoateRecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEDjsGDDhbys8T3Y3C6obRuvK/NsKTwMFWdHbDVb1VSG5fB2D41wkt3Jttfq+IulADw==");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_CoateRecord_CoateRecordId",
                table: "Student",
                column: "CoateRecordId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_CoateRecord_CountrysideOrCityId",
                table: "Student",
                column: "CountrysideOrCityId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_CoateRecord_DistrictOrCityId",
                table: "Student",
                column: "DistrictOrCityId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_CoateRecord_RegionOrCityId",
                table: "Student",
                column: "RegionOrCityId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_CoateRecord_VillageId",
                table: "Student",
                column: "VillageId",
                principalTable: "CoateRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
