using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Canalog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OptionsUpdat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Users_UserId",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_UserId",
                table: "Options");

            migrationBuilder.AddColumn<Guid>(
                name: "OptionsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Options",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OptionsId",
                table: "Users",
                column: "OptionsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Options_OptionsId",
                table: "Users",
                column: "OptionsId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Options_OptionsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OptionsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OptionsId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Options",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Options_UserId",
                table: "Options",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Users_UserId",
                table: "Options",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
