using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotelar.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class MG01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_PersonAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProvinceName = table.Column<string>(type: "TEXT", nullable: true),
                    SquareName = table.Column<string>(type: "TEXT", nullable: true),
                    NeighborNamr = table.Column<string>(type: "TEXT", nullable: true),
                    StreetName = table.Column<string>(type: "TEXT", nullable: true),
                    HouseNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_PersonAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_PersonContact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FaxNumber = table.Column<string>(type: "TEXT", nullable: true),
                    ModileNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_PersonContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomType = table.Column<string>(type: "TEXT", nullable: true),
                    RoomNumber = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_RoomService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServicePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ServiceName = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_RoomService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DocIdtype = table.Column<string>(type: "TEXT", nullable: true),
                    DocIdNumber = table.Column<string>(type: "TEXT", nullable: true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Person_Tb_PersonAddress_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Tb_PersonAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Person_Tb_PersonContact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Tb_PersonContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsHosted = table.Column<bool>(type: "INTEGER", nullable: false),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Customer_Tb_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Tb_Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_DirectSell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    TimeIn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeOut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_DirectSell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_DirectSell_Tb_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tb_Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_DirectSell_Tb_RoomService_RoomServiceId",
                        column: x => x.RoomServiceId,
                        principalTable: "Tb_RoomService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_DirectSell_Tb_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Tb_Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoomServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    WishDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Reservation_Tb_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tb_Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tb_Reservation_Tb_RoomService_RoomServiceId",
                        column: x => x.RoomServiceId,
                        principalTable: "Tb_RoomService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Reservation_Tb_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Tb_Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Customer_PersonId",
                table: "Tb_Customer",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_DirectSell_CustomerId",
                table: "Tb_DirectSell",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_DirectSell_RoomId",
                table: "Tb_DirectSell",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_DirectSell_RoomServiceId",
                table: "Tb_DirectSell",
                column: "RoomServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Person_AddressId",
                table: "Tb_Person",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Person_ContactId",
                table: "Tb_Person",
                column: "ContactId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Reservation_CustomerId",
                table: "Tb_Reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Reservation_RoomId",
                table: "Tb_Reservation",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Reservation_RoomServiceId",
                table: "Tb_Reservation",
                column: "RoomServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_DirectSell");

            migrationBuilder.DropTable(
                name: "Tb_Reservation");

            migrationBuilder.DropTable(
                name: "Tb_Customer");

            migrationBuilder.DropTable(
                name: "Tb_RoomService");

            migrationBuilder.DropTable(
                name: "Tb_Room");

            migrationBuilder.DropTable(
                name: "Tb_Person");

            migrationBuilder.DropTable(
                name: "Tb_PersonAddress");

            migrationBuilder.DropTable(
                name: "Tb_PersonContact");
        }
    }
}
