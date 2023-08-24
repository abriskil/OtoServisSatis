using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    /// <inheritdoc />
    public partial class SliderEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AracPlaka",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "AracSorunu",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "GarantiKapsamindaMi",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "KasaTipi",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "Marka",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "Notlar",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "SaseNo",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "ServisUcreti",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "ServiseGelisTarihi",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "ServistenCikisTarihi",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "YapilanIslemler",
                table: "Servisler");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Servisler",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "Servisler",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Servisler",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Servisler",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiseGelisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AracSorunu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServisUcreti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServistenCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YapilanIslemler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GarantiKapsamindaMi = table.Column<bool>(type: "bit", nullable: false),
                    AracPlaka = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KasaTipi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SaseNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2023, 8, 21, 20, 18, 5, 481, DateTimeKind.Local).AddTicks(764));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Servisler");

            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Servisler");

            migrationBuilder.AddColumn<string>(
                name: "AracPlaka",
                table: "Servisler",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AracSorunu",
                table: "Servisler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "GarantiKapsamindaMi",
                table: "Servisler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "KasaTipi",
                table: "Servisler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Marka",
                table: "Servisler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Servisler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notlar",
                table: "Servisler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SaseNo",
                table: "Servisler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ServisUcreti",
                table: "Servisler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "ServiseGelisTarihi",
                table: "Servisler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ServistenCikisTarihi",
                table: "Servisler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "YapilanIslemler",
                table: "Servisler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2023, 8, 21, 20, 12, 17, 48, DateTimeKind.Local).AddTicks(8031));
        }
    }
}
