using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beperkingen",
                columns: table => new
                {
                    BeperkingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beperkingen", x => x.BeperkingId);
                });

            migrationBuilder.CreateTable(
                name: "Gebruikers",
                columns: table => new
                {
                    GebruikerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefoonnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Bedrijfsnaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedrijfsInformatie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AandoeningOfZiekte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoorkeurBenadering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagCommercieelBenaderdWorden = table.Column<bool>(type: "bit", nullable: true),
                    BeschikbareTijden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NaamVoogd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVoogd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefoonnummerVoogd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruikers", x => x.GebruikerId);
                });

            migrationBuilder.CreateTable(
                name: "Hulpmiddelen",
                columns: table => new
                {
                    HulpmiddelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hulpmiddelen", x => x.HulpmiddelId);
                });

            migrationBuilder.CreateTable(
                name: "ChatBerichten",
                columns: table => new
                {
                    ChatBerichtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BerichtInhoud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tijdstempel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AfzenderId = table.Column<int>(type: "int", nullable: false),
                    OntvangerId = table.Column<int>(type: "int", nullable: false),
                    AfzenderErvaringsdeskundigeGebruikerId = table.Column<int>(type: "int", nullable: false),
                    AfzenderBedrijfGebruikerId = table.Column<int>(type: "int", nullable: false),
                    OntvangerErvaringsdeskundigeGebruikerId = table.Column<int>(type: "int", nullable: false),
                    OntvangerBedrijfGebruikerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatBerichten", x => x.ChatBerichtId);
                    table.ForeignKey(
                        name: "FK_ChatBerichten_Gebruikers_AfzenderBedrijfGebruikerId",
                        column: x => x.AfzenderBedrijfGebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatBerichten_Gebruikers_AfzenderErvaringsdeskundigeGebruikerId",
                        column: x => x.AfzenderErvaringsdeskundigeGebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatBerichten_Gebruikers_OntvangerBedrijfGebruikerId",
                        column: x => x.OntvangerBedrijfGebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatBerichten_Gebruikers_OntvangerErvaringsdeskundigeGebruikerId",
                        column: x => x.OntvangerErvaringsdeskundigeGebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ErvaringsdeskundigeBeperkingen",
                columns: table => new
                {
                    ErvaringsdeskundigeBeperkingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErvaringsdeskundigeId = table.Column<int>(type: "int", nullable: false),
                    BeperkingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErvaringsdeskundigeBeperkingen", x => x.ErvaringsdeskundigeBeperkingId);
                    table.ForeignKey(
                        name: "FK_ErvaringsdeskundigeBeperkingen_Beperkingen_BeperkingId",
                        column: x => x.BeperkingId,
                        principalTable: "Beperkingen",
                        principalColumn: "BeperkingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ErvaringsdeskundigeBeperkingen_Gebruikers_ErvaringsdeskundigeId",
                        column: x => x.ErvaringsdeskundigeId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Onderzoeken",
                columns: table => new
                {
                    OnderzoekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorteBeschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Locatie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beloning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoortOnderzoek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusDeelname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UitvoerendBedrijfGebruikerId = table.Column<int>(type: "int", nullable: false),
                    TypeBeperking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostcodeCriteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinLeeftijd = table.Column<int>(type: "int", nullable: true),
                    MaxLeeftijd = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onderzoeken", x => x.OnderzoekId);
                    table.ForeignKey(
                        name: "FK_Onderzoeken_Gebruikers_UitvoerendBedrijfGebruikerId",
                        column: x => x.UitvoerendBedrijfGebruikerId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ErvaringsdeskundigeHulpmiddelen",
                columns: table => new
                {
                    ErvaringsdeskundigeHulpmiddelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErvaringsdeskundigeId = table.Column<int>(type: "int", nullable: false),
                    HulpmiddelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErvaringsdeskundigeHulpmiddelen", x => x.ErvaringsdeskundigeHulpmiddelId);
                    table.ForeignKey(
                        name: "FK_ErvaringsdeskundigeHulpmiddelen_Gebruikers_ErvaringsdeskundigeId",
                        column: x => x.ErvaringsdeskundigeId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ErvaringsdeskundigeHulpmiddelen_Hulpmiddelen_HulpmiddelId",
                        column: x => x.HulpmiddelId,
                        principalTable: "Hulpmiddelen",
                        principalColumn: "HulpmiddelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interesses",
                columns: table => new
                {
                    InteresseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErvaringsdeskundigeId = table.Column<int>(type: "int", nullable: false),
                    OnderzoekId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesses", x => x.InteresseId);
                    table.ForeignKey(
                        name: "FK_Interesses_Gebruikers_ErvaringsdeskundigeId",
                        column: x => x.ErvaringsdeskundigeId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Interesses_Onderzoeken_OnderzoekId",
                        column: x => x.OnderzoekId,
                        principalTable: "Onderzoeken",
                        principalColumn: "OnderzoekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnderzoekDeelnames",
                columns: table => new
                {
                    DeelnameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ErvaringsdeskundigeId = table.Column<int>(type: "int", nullable: false),
                    OnderzoekId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnderzoekDeelnames", x => x.DeelnameId);
                    table.ForeignKey(
                        name: "FK_OnderzoekDeelnames_Gebruikers_ErvaringsdeskundigeId",
                        column: x => x.ErvaringsdeskundigeId,
                        principalTable: "Gebruikers",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnderzoekDeelnames_Onderzoeken_OnderzoekId",
                        column: x => x.OnderzoekId,
                        principalTable: "Onderzoeken",
                        principalColumn: "OnderzoekId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatBerichten_AfzenderBedrijfGebruikerId",
                table: "ChatBerichten",
                column: "AfzenderBedrijfGebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatBerichten_AfzenderErvaringsdeskundigeGebruikerId",
                table: "ChatBerichten",
                column: "AfzenderErvaringsdeskundigeGebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatBerichten_OntvangerBedrijfGebruikerId",
                table: "ChatBerichten",
                column: "OntvangerBedrijfGebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatBerichten_OntvangerErvaringsdeskundigeGebruikerId",
                table: "ChatBerichten",
                column: "OntvangerErvaringsdeskundigeGebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_ErvaringsdeskundigeBeperkingen_BeperkingId",
                table: "ErvaringsdeskundigeBeperkingen",
                column: "BeperkingId");

            migrationBuilder.CreateIndex(
                name: "IX_ErvaringsdeskundigeBeperkingen_ErvaringsdeskundigeId",
                table: "ErvaringsdeskundigeBeperkingen",
                column: "ErvaringsdeskundigeId");

            migrationBuilder.CreateIndex(
                name: "IX_ErvaringsdeskundigeHulpmiddelen_ErvaringsdeskundigeId",
                table: "ErvaringsdeskundigeHulpmiddelen",
                column: "ErvaringsdeskundigeId");

            migrationBuilder.CreateIndex(
                name: "IX_ErvaringsdeskundigeHulpmiddelen_HulpmiddelId",
                table: "ErvaringsdeskundigeHulpmiddelen",
                column: "HulpmiddelId");

            migrationBuilder.CreateIndex(
                name: "IX_Interesses_ErvaringsdeskundigeId",
                table: "Interesses",
                column: "ErvaringsdeskundigeId");

            migrationBuilder.CreateIndex(
                name: "IX_Interesses_OnderzoekId",
                table: "Interesses",
                column: "OnderzoekId");

            migrationBuilder.CreateIndex(
                name: "IX_OnderzoekDeelnames_ErvaringsdeskundigeId",
                table: "OnderzoekDeelnames",
                column: "ErvaringsdeskundigeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnderzoekDeelnames_OnderzoekId",
                table: "OnderzoekDeelnames",
                column: "OnderzoekId");

            migrationBuilder.CreateIndex(
                name: "IX_Onderzoeken_UitvoerendBedrijfGebruikerId",
                table: "Onderzoeken",
                column: "UitvoerendBedrijfGebruikerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatBerichten");

            migrationBuilder.DropTable(
                name: "ErvaringsdeskundigeBeperkingen");

            migrationBuilder.DropTable(
                name: "ErvaringsdeskundigeHulpmiddelen");

            migrationBuilder.DropTable(
                name: "Interesses");

            migrationBuilder.DropTable(
                name: "OnderzoekDeelnames");

            migrationBuilder.DropTable(
                name: "Beperkingen");

            migrationBuilder.DropTable(
                name: "Hulpmiddelen");

            migrationBuilder.DropTable(
                name: "Onderzoeken");

            migrationBuilder.DropTable(
                name: "Gebruikers");
        }
    }
}
