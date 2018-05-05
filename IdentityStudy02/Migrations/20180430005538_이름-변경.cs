using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace IdentityStudy02.Migrations
{
    public partial class 이름변경 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "이름",
                table: "AspNetUsers",
                newName: "이름_변경");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "이름_변경",
                table: "AspNetUsers",
                newName: "이름");
        }
    }
}
