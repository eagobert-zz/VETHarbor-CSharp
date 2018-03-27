using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VETHarbor.Migrations
{
    public partial class UpdateAppUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_User_Events_UserEventsUserEventId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Events_AspNetUsers_ApplicationUserId",
                table: "User_Events");

            migrationBuilder.DropIndex(
                name: "IX_User_Events_ApplicationUserId",
                table: "User_Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserEventsUserEventId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserEventId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "User_Events");

            migrationBuilder.DropColumn(
                name: "UserEventsUserEventId",
                table: "Events");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserEventId",
                table: "AspNetUsers",
                column: "UserEventId",
                unique: true,
                filter: "[UserEventId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserEventId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "User_Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserEventsUserEventId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Events_ApplicationUserId",
                table: "User_Events",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserEventsUserEventId",
                table: "Events",
                column: "UserEventsUserEventId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserEventId",
                table: "AspNetUsers",
                column: "UserEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_User_Events_UserEventsUserEventId",
                table: "Events",
                column: "UserEventsUserEventId",
                principalTable: "User_Events",
                principalColumn: "UserEventId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Events_AspNetUsers_ApplicationUserId",
                table: "User_Events",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
