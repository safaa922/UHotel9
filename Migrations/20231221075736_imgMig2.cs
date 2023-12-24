using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UHotel9.Migrations
{
    /// <inheritdoc />
    public partial class imgMig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    employeeFname = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    employeeLname = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeePhone = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    employeeAge = table.Column<int>(type: "int", nullable: false),
                    department = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    employeeSalary = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    employeePhoto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employeeId);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    roomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<int>(type: "int", nullable: false),
                    floorNumber = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.roomId);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    guestId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    guestFname = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    guestLname = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    roomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.guestId);
                    table.ForeignKey(
                        name: "FK_Guests_Rooms_roomId",
                        column: x => x.roomId,
                        principalTable: "Rooms",
                        principalColumn: "roomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    reservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    checkInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    checkOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    guestId = table.Column<string>(type: "nvarchar(14)", nullable: false),
                    roomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.reservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Guests_guestId",
                        column: x => x.guestId,
                        principalTable: "Guests",
                        principalColumn: "guestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Rooms_roomId",
                        column: x => x.roomId,
                        principalTable: "Rooms",
                        principalColumn: "roomId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guests_roomId",
                table: "Guests",
                column: "roomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_guestId",
                table: "Reservations",
                column: "guestId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_roomId",
                table: "Reservations",
                column: "roomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
