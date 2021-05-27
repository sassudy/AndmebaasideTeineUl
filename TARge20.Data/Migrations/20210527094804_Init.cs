using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactAddress",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactNumber",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdentificationCode",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkingFrom",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "AccessPermit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Permit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPermit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessPermit_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnonomysHint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proposal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Haigusleht",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alguskuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Loppkuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haigusleht", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haigusleht_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<int>(type: "int", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harukontor_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemLoaned = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenutus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puhkus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alguskuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Loppkuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tervisekontroll_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<int>(type: "int", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessPermitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_AccessPermit_AccessPermitId",
                        column: x => x.AccessPermitId,
                        principalTable: "AccessPermit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_Feedback_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedback",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_Harukontor_HarukontorId",
                        column: x => x.HarukontorId,
                        principalTable: "Harukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ametinimetus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LaenutusesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ametinimetus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ametinimetus_Laenutus_LaenutusesId",
                        column: x => x.LaenutusesId,
                        principalTable: "Laenutus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessPermit_EmployeeId",
                table: "AccessPermit",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetus_EmployeeId",
                table: "Ametinimetus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetus_LaenutusesId",
                table: "Ametinimetus",
                column: "LaenutusesId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AccessPermitId",
                table: "Company",
                column: "AccessPermitId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_EmployeeId",
                table: "Company",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_FeedbackId",
                table: "Company",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_HarukontorId",
                table: "Company",
                column: "HarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_EmployeeId",
                table: "Feedback",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Haigusleht_EmployeeId",
                table: "Haigusleht",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Harukontor_EmployeeId",
                table: "Harukontor",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_EmployeeId",
                table: "Laenutus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkus_EmployeeId",
                table: "Puhkus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontroll_EmployeeId",
                table: "Tervisekontroll",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ametinimetus");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Haigusleht");

            migrationBuilder.DropTable(
                name: "Puhkus");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "AccessPermit");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ContactAddress",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IdentificationCode",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "WorkingFrom",
                table: "Employee");
        }
    }
}
