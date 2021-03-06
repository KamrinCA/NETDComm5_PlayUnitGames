/* Author: Kamrin Aubin
 * Last Modified: December 13, 2021
 * Description: Includes the code required to create the tables needed for the database and web application
 *              
 *              **GENERATED BY PACKAGE MANAGER CONSOLE**
 * 
 */

using Microsoft.EntityFrameworkCore.Migrations;

namespace NETDComm5.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Creates Stores Table
            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    // Creates the fields for the Stores Table
                    storeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    postalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    // Sets the primary key for Stores Table
                    table.PrimaryKey("PK_Stores", x => x.storeID);
                });

            // Creates Video Game Console Table
            migrationBuilder.CreateTable(
                name: "VideoGameConsole",
                columns: table => new
                {
                    // Creates the fields in the Video Game Console Table
                    videoGameConsoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    manufacturer = table.Column<string>(nullable: true),
                    isNew = table.Column<bool>(nullable: false),
                    storeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    // Sets the primary and foreign key for Video Game Console Table
                    table.PrimaryKey("PK_VideoGameConsole", x => x.videoGameConsoleID);
                    table.ForeignKey(
                        name: "FK_VideoGameConsole_Stores_storeID",
                        column: x => x.storeID,
                        principalTable: "Stores",
                        principalColumn: "storeID",
                        onDelete: ReferentialAction.Cascade);
                });

            // Creates Video Games Table
            migrationBuilder.CreateTable(
                name: "VideoGames",
                columns: table => new
                {
                    // Creates the fields in the Video Game Table
                    videoGameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    developer = table.Column<string>(nullable: true),
                    publisher = table.Column<string>(nullable: true),
                    yearOfRelease = table.Column<int>(nullable: false),
                    platform = table.Column<string>(nullable: true),
                    isNew = table.Column<bool>(nullable: false),
                    storeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    // Sets the primary and foreign key for Video Game Table
                    table.PrimaryKey("PK_VideoGames", x => x.videoGameID);
                    table.ForeignKey(
                        name: "FK_VideoGames_Stores_storeID",
                        column: x => x.storeID,
                        principalTable: "Stores",
                        principalColumn: "storeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameConsole_storeID",
                table: "VideoGameConsole",
                column: "storeID");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_storeID",
                table: "VideoGames",
                column: "storeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoGameConsole");

            migrationBuilder.DropTable(
                name: "VideoGames");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
