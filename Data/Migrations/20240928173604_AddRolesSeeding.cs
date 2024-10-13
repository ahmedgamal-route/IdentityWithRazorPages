using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityWithRazorPages.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Roles",
                new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                new[] { Guid.NewGuid().ToString(), "User", "USER", Guid.NewGuid().ToString() },
                "Security"
                );
            migrationBuilder.InsertData(
               "Roles",
               new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
               new[] { Guid.NewGuid().ToString(), "Admin", "ADMIN", Guid.NewGuid().ToString() },
               "Security"
               );
            migrationBuilder.InsertData(
               "Roles",
               new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
               new[] { Guid.NewGuid().ToString(), "HR", "HR", Guid.NewGuid().ToString() },
               "Security"
               );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from [Security].[Roles]");

        }
    }
}
