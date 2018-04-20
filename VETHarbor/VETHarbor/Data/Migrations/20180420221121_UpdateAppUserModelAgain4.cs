using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VETHarbor.Migrations
{
    public partial class UpdateAppUserModelAgain4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Organizations_OrgId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "OrgId",
                table: "AspNetUsers",
                newName: "OrganizationOrgId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_OrgId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_OrganizationOrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Organizations_OrganizationOrgId",
                table: "AspNetUsers",
                column: "OrganizationOrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Organizations_OrganizationOrgId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "OrganizationOrgId",
                table: "AspNetUsers",
                newName: "OrgId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_OrganizationOrgId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_OrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Organizations_OrgId",
                table: "AspNetUsers",
                column: "OrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
