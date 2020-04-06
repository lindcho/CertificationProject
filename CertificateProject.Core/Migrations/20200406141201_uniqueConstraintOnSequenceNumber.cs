using Microsoft.EntityFrameworkCore.Migrations;

namespace CertificateProject.Infrastructure.Migrations
{
    public partial class uniqueConstraintOnSequenceNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CertificateEntities_SequenceNumber",
                table: "CertificateEntities",
                column: "SequenceNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CertificateEntities_SequenceNumber",
                table: "CertificateEntities");
        }
    }
}
