using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VETHarbor.Migrations
{
    public partial class UpdateApplicationUserModelAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Organizations_OrganizationOrgId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_OrganizationOrgId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "OrganizationOrgId",
                table: "AspNetUsers",
                newName: "OrgState");

            migrationBuilder.AlterColumn<string>(
                name: "OrgState",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgCity",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrgName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OrgId",
                table: "AspNetUsers",
                column: "OrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Organizations_OrgId",
                table: "AspNetUsers",
                column: "OrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Organizations_OrgId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_OrgId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrgCity",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrgId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OrgName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "OrgState",
                table: "AspNetUsers",
                newName: "OrganizationOrgId");

            migrationBuilder.AlterColumn<string>(
                name: "OrganizationOrgId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OrganizationOrgId",
                table: "AspNetUsers",
                column: "OrganizationOrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Organizations_OrganizationOrgId",
                table: "AspNetUsers",
                column: "OrganizationOrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
