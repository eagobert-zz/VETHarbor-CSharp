using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VETHarbor.Migrations
{
    public partial class ChangeProgramIdTypeToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Organizations_OrganizationOrgId",
                table: "Programs");

            migrationBuilder.DropIndex(
                name: "IX_Programs_OrganizationOrgId",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "OrganizationOrgId",
                table: "Programs");

            migrationBuilder.AlterColumn<string>(
                name: "OrgId",
                table: "Programs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Programs_OrgId",
                table: "Programs",
                column: "OrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Organizations_OrgId",
                table: "Programs",
                column: "OrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Organizations_OrgId",
                table: "Programs");

            migrationBuilder.DropIndex(
                name: "IX_Programs_OrgId",
                table: "Programs");

            migrationBuilder.AlterColumn<int>(
                name: "OrgId",
                table: "Programs",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganizationOrgId",
                table: "Programs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programs_OrganizationOrgId",
                table: "Programs",
                column: "OrganizationOrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Organizations_OrganizationOrgId",
                table: "Programs",
                column: "OrganizationOrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
