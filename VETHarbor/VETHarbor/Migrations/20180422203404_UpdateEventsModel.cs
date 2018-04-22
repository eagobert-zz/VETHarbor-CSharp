using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VETHarbor.Migrations
{
    public partial class UpdateEventsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProgramTitle",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProgramsProgramId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ProgramsProgramId",
                table: "Events",
                column: "ProgramsProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Programs_ProgramsProgramId",
                table: "Events",
                column: "ProgramsProgramId",
                principalTable: "Programs",
                principalColumn: "ProgramId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Programs_ProgramsProgramId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ProgramsProgramId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ProgramTitle",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ProgramsProgramId",
                table: "Events");
        }
    }
}
