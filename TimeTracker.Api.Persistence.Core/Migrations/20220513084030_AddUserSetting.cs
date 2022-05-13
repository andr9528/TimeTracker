using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.Api.Persistence.Core.Migrations
{
    public partial class AddUserSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "User",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserSetting",
                columns: table => new
                {
                    UserSettingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Version = table.Column<string>(type: "BLOB", rowVersion: true, nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartHidden = table.Column<bool>(type: "INTEGER", nullable: false),
                    NavigationLocation = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSetting", x => x.UserSettingId);
                    table.ForeignKey(
                        name: "FK_UserSetting_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSetting_UserId",
                table: "UserSetting",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSetting");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "User");
        }
    }
}
