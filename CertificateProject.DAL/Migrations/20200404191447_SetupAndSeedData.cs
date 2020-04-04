using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CertificateProject.Infrastructure.Migrations
{
    public partial class SetupAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SequenceNumber = table.Column<int>(nullable: false),
                    IssueDate = table.Column<DateTime>(nullable: false),
                    Document = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificate", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Document", "IssueDate", "SequenceNumber" },
                values: new object[] { 1, null, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1110 });

            migrationBuilder.InsertData(
                table: "Certificate",
                columns: new[] { "Id", "Document", "IssueDate", "SequenceNumber" },
                values: new object[] { 2, null, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1111 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificate");
        }
    }
}
