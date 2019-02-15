using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Forums.Data.Migrations
{
    public partial class changevaluesinForumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Forums_FormId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "FormId",
                table: "Posts",
                newName: "ForumId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_FormId",
                table: "Posts",
                newName: "IX_Posts_ForumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Forums_ForumId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "ForumId",
                table: "Posts",
                newName: "FormId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_ForumId",
                table: "Posts",
                newName: "IX_Posts_FormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Forums_FormId",
                table: "Posts",
                column: "FormId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
