using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArellanoSysDevExam.Migrations
{
    /// <inheritdoc />
    public partial class BranchMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    branchid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    branchname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    barangay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    permitnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch_manager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateopened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.branchid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
