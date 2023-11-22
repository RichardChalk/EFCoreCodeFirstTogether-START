using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreCodeFirstTogether_START.Migrations
{
    /// <inheritdoc />
    public partial class ConnectedPersontoCounty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountyId",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Person_CountyId",
                table: "Person",
                column: "CountyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_County_CountyId",
                table: "Person",
                column: "CountyId",
                principalTable: "County",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_County_CountyId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_CountyId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CountyId",
                table: "Person");
        }
    }
}
