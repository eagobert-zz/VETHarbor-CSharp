using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VETHarbor.Migrations
{
    public partial class UpdateAppUserModelagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_User_Events_UserEventId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserEventId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "User_Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Events_ApplicationUserId",
                table: "User_Events",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Events_AspNetUsers_ApplicationUserId",
                table: "User_Events",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Events_AspNetUsers_ApplicationUserId",
                table: "User_Events");

            migrationBuilder.DropIndex(
                name: "IX_User_Events_ApplicationUserId",
                table: "User_Events");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "User_Events");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserEventId",
                table: "AspNetUsers",
                column: "UserEventId",
                unique: true,
                filter: "[UserEventId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_User_Events_UserEventId",
                table: "AspNetUsers",
                column: "UserEventId",
                principalTable: "User_Events",
                principalColumn: "UserEventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
