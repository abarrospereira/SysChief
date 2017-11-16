using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SysChief.Infra.Data.Migrations.EventStoreSQL
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "AggregateId",
                table: "StoredEvent",
                type: "int8",
                nullable: false,
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "AggregateId",
                table: "StoredEvent",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "int8");
        }
    }
}
