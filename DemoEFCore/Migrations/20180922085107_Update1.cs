using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoEFCore.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Eventos",
                newName: "EventoID");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Eventos",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventoID",
                table: "Eventos",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Eventos",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);
        }
    }
}
