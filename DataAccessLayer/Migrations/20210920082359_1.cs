using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KategoriVT",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriVT", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciVT",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciIsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSoyisim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciYetki = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciVT", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "MarkaVT",
                columns: table => new
                {
                    MarkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarkaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkaAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarkaDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkaVT", x => x.MarkaID);
                });

            migrationBuilder.CreateTable(
                name: "MusteriVT",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriTel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriTel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriVT", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "ServisVT",
                columns: table => new
                {
                    ServisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServisAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServisSonuc = table.Column<bool>(type: "bit", nullable: false),
                    ServisDurum = table.Column<bool>(type: "bit", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    MusteriID = table.Column<int>(type: "int", nullable: false),
                    MarkaID = table.Column<int>(type: "int", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServisVT", x => x.ServisID);
                    table.ForeignKey(
                        name: "FK_ServisVT_KategoriVT_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "KategoriVT",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServisVT_KullaniciVT_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "KullaniciVT",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServisVT_MarkaVT_MarkaID",
                        column: x => x.MarkaID,
                        principalTable: "MarkaVT",
                        principalColumn: "MarkaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServisVT_MusteriVT_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "MusteriVT",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IslemVT",
                columns: table => new
                {
                    IslemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IslemDurum = table.Column<bool>(type: "bit", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    ServisID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IslemVT", x => x.IslemID);
                    table.ForeignKey(
                        name: "FK_IslemVT_KullaniciVT_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "KullaniciVT",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IslemVT_ServisVT_ServisID",
                        column: x => x.ServisID,
                        principalTable: "ServisVT",
                        principalColumn: "ServisID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IslemVT_KullaniciID",
                table: "IslemVT",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_IslemVT_ServisID",
                table: "IslemVT",
                column: "ServisID");

            migrationBuilder.CreateIndex(
                name: "IX_ServisVT_KategoriID",
                table: "ServisVT",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_ServisVT_KullaniciID",
                table: "ServisVT",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_ServisVT_MarkaID",
                table: "ServisVT",
                column: "MarkaID");

            migrationBuilder.CreateIndex(
                name: "IX_ServisVT_MusteriID",
                table: "ServisVT",
                column: "MusteriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IslemVT");

            migrationBuilder.DropTable(
                name: "ServisVT");

            migrationBuilder.DropTable(
                name: "KategoriVT");

            migrationBuilder.DropTable(
                name: "KullaniciVT");

            migrationBuilder.DropTable(
                name: "MarkaVT");

            migrationBuilder.DropTable(
                name: "MusteriVT");
        }
    }
}
