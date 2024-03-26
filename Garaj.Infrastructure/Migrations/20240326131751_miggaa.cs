using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garaj.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class miggaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Description", "Model", "OwnerId", "Price", "isSold" },
                values: new object[] { new Guid("7f0c95dc-746e-4899-9ec7-c1d2419c7ac2"), "Chevrolet", "Zo'r buxanka", "Damas", new Guid("00000000-0000-0000-0000-000000000000"), 60000m, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7f0c95dc-746e-4899-9ec7-c1d2419c7ac2"));
        }
    }
}
