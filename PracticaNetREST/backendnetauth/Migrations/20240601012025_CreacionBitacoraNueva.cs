using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class CreacionBitacoraNueva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17c974d8-8053-484b-a054-9e5e64b1b876", "b84078d6-4f0b-4b19-a158-577bfd3b8790" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b09fe39-5bde-4d9d-93ac-02185895986f", "d6d2024f-1823-4282-a406-dd760ff55498" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17c974d8-8053-484b-a054-9e5e64b1b876");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b09fe39-5bde-4d9d-93ac-02185895986f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b84078d6-4f0b-4b19-a158-577bfd3b8790");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6d2024f-1823-4282-a406-dd760ff55498");

            migrationBuilder.CreateTable(
                name: "Bitacora",
                columns: table => new
                {
                    BitacoraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Evento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora", x => x.BitacoraId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "174f154b-179a-4c0e-aeca-49656a9f5e81", null, "Usuario", "USUARIO" },
                    { "a3eb09f8-6ff1-4d11-92e2-94bbb8cb1abd", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Protegido", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "566870e0-d007-4d0b-9b37-8bf006dd0920", 0, "42108400-7548-4d33-b360-e3de4a7a9cbc", "patito@uv.mx", false, false, null, "Usuario patito", "PATITO@UV.MX", "PATITO@UV.MX", "AQAAAAIAAYagAAAAEJTE6r/8PEzq/AkH4+sDxH7PaQXASmKEgi6aU3JfATdZA+iO03Ne9B1ylVGS+gDU1g==", null, false, false, "17da7e75-94f5-469c-9651-3f8e33ee60fd", false, "patito@uv.mx" },
                    { "80e08526-9d8a-4944-8f34-61793276a73c", 0, "604f2a25-a34f-4951-beee-168f2715cb18", "gvera@uv.mx", false, false, null, "Guillermo Humberto Vera Amaro", "GVERA@UV.MX", "GVERA@UV.MX", "AQAAAAIAAYagAAAAEJh/V2RQ+9Riy5NAKYfi+15OpH9G0+iB9Cl8duP8wBTtUVtInRuJIKa2HYg8+wXXiQ==", null, false, true, "ebeb8496-595d-4cba-af20-31584634f583", false, "gvera@uv.mx" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "174f154b-179a-4c0e-aeca-49656a9f5e81", "566870e0-d007-4d0b-9b37-8bf006dd0920" },
                    { "a3eb09f8-6ff1-4d11-92e2-94bbb8cb1abd", "80e08526-9d8a-4944-8f34-61793276a73c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bitacora");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "174f154b-179a-4c0e-aeca-49656a9f5e81", "566870e0-d007-4d0b-9b37-8bf006dd0920" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3eb09f8-6ff1-4d11-92e2-94bbb8cb1abd", "80e08526-9d8a-4944-8f34-61793276a73c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "174f154b-179a-4c0e-aeca-49656a9f5e81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3eb09f8-6ff1-4d11-92e2-94bbb8cb1abd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "566870e0-d007-4d0b-9b37-8bf006dd0920");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80e08526-9d8a-4944-8f34-61793276a73c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17c974d8-8053-484b-a054-9e5e64b1b876", null, "Usuario", "USUARIO" },
                    { "1b09fe39-5bde-4d9d-93ac-02185895986f", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Protegido", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b84078d6-4f0b-4b19-a158-577bfd3b8790", 0, "ca8682fc-b7d9-474d-859d-8f915a2c3624", "patito@uv.mx", false, false, null, "Usuario patito", "PATITO@UV.MX", "PATITO@UV.MX", "AQAAAAIAAYagAAAAENdWBtM5HGCnu10fCosTfZL8AgLpPbev771QDNmJfb/s5u8V8MNkzgwn12IVB+PI7g==", null, false, false, "bfc30f29-c94b-487c-9d81-6491c162f462", false, "patito@uv.mx" },
                    { "d6d2024f-1823-4282-a406-dd760ff55498", 0, "cbb5c4da-ec9e-4b37-b2fe-f2ee48c51b8f", "gvera@uv.mx", false, false, null, "Guillermo Humberto Vera Amaro", "GVERA@UV.MX", "GVERA@UV.MX", "AQAAAAIAAYagAAAAEEpoUnMRLpdk5kX5mF5oCvR4fZDwZ/oRl09UQYeRRZW/YbaH25Lzhyi1DTR4CTAsBg==", null, false, true, "208288a5-a91b-486c-8f47-1d565fe07d6b", false, "gvera@uv.mx" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "17c974d8-8053-484b-a054-9e5e64b1b876", "b84078d6-4f0b-4b19-a158-577bfd3b8790" },
                    { "1b09fe39-5bde-4d9d-93ac-02185895986f", "d6d2024f-1823-4282-a406-dd760ff55498" }
                });
        }
    }
}
