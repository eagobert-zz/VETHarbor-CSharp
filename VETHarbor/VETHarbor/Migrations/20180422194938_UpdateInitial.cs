using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VETHarbor.Migrations
{
    public partial class UpdateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Organizations_OrganizationOrgId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizations_OrganizationOrgId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Organizations_OrganizationOrgId",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "OrgName",
                table: "Programs");

            migrationBuilder.RenameColumn(
                name: "OrganizationOrgId",
                table: "Programs",
                newName: "OrgId");

            migrationBuilder.RenameIndex(
                name: "IX_Programs_OrganizationOrgId",
                table: "Programs",
                newName: "IX_Programs_OrgId");

            migrationBuilder.RenameColumn(
                name: "OrganizationOrgId",
                table: "Events",
                newName: "OrgId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_OrganizationOrgId",
                table: "Events",
                newName: "IX_Events_OrgId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizations_OrgId",
                table: "Events",
                column: "OrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_AspNetUsers_Organizations_OrgId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizations_OrgId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Organizations_OrgId",
                table: "Programs");

            migrationBuilder.RenameColumn(
                name: "OrgId",
                table: "Programs",
                newName: "OrganizationOrgId");

            migrationBuilder.RenameIndex(
                name: "IX_Programs_OrgId",
                table: "Programs",
                newName: "IX_Programs_OrganizationOrgId");

            migrationBuilder.RenameColumn(
                name: "OrgId",
                table: "Events",
                newName: "OrganizationOrgId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_OrgId",
                table: "Events",
                newName: "IX_Events_OrganizationOrgId");

            migrationBuilder.RenameColumn(
                name: "OrgId",
                table: "AspNetUsers",
                newName: "OrganizationOrgId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_OrgId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_OrganizationOrgId");

            migrationBuilder.AddColumn<string>(
                name: "OrgName",
                table: "Programs",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Organizations_OrganizationOrgId",
                table: "AspNetUsers",
                column: "OrganizationOrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizations_OrganizationOrgId",
                table: "Events",
                column: "OrganizationOrgId",
                principalTable: "Organizations",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Restrict);

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
