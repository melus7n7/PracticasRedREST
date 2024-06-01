using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class CreacionBitacora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4850e1b5-0722-4bdd-bcd2-b5a677e16778", "38600ef9-1fe1-4db9-a5f1-5f5cd3168ed5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f910fdf-04f2-4966-9909-f773902e8d37", "6a68393d-ffba-4e5a-9727-4f6e9a7b5b53" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f910fdf-04f2-4966-9909-f773902e8d37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4850e1b5-0722-4bdd-bcd2-b5a677e16778");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38600ef9-1fe1-4db9-a5f1-5f5cd3168ed5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a68393d-ffba-4e5a-9727-4f6e9a7b5b53");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f910fdf-04f2-4966-9909-f773902e8d37", null, "Usuario", "USUARIO" },
                    { "4850e1b5-0722-4bdd-bcd2-b5a677e16778", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Protegido", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "38600ef9-1fe1-4db9-a5f1-5f5cd3168ed5", 0, "ce89f22f-22fe-46ed-8c62-0631dc236462", "gvera@uv.mx", false, false, null, "Guillermo Humberto Vera Amaro", "GVERA@UV.MX", "GVERA@UV.MX", "AQAAAAIAAYagAAAAEL+TXloomGqDzjRUUtgRlTEuiZWqyy64yoi2RldLl+VPjM9Zsf5E5Lj91Hut3CQ3tA==", null, false, true, "ac509c11-21a9-457b-951f-905e5e2160c2", false, "gvera@uv.mx" },
                    { "6a68393d-ffba-4e5a-9727-4f6e9a7b5b53", 0, "4c4a4e08-c932-473f-a1d0-ba55fa2b3987", "patito@uv.mx", false, false, null, "Usuario patito", "PATITO@UV.MX", "PATITO@UV.MX", "AQAAAAIAAYagAAAAEMhWLYBNidCBrzY/9ImGqNpyihZ/29/toky/X/FV/SvhdMCmhZZ05OS4glZFBJ6jTQ==", null, false, false, "b0e6a1e8-414f-4f45-a33d-9fdf128c5392", false, "patito@uv.mx" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4850e1b5-0722-4bdd-bcd2-b5a677e16778", "38600ef9-1fe1-4db9-a5f1-5f5cd3168ed5" },
                    { "1f910fdf-04f2-4966-9909-f773902e8d37", "6a68393d-ffba-4e5a-9727-4f6e9a7b5b53" }
                });
        }
    }
}
