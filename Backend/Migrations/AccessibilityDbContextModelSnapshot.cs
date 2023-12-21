﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(AccessibilityDbContext))]
    partial class AccessibilityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccessibilityModels.Beperking", b =>
                {
                    b.Property<int>("BeperkingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BeperkingId"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BeperkingId");

                    b.ToTable("Beperkingen");
                });

            modelBuilder.Entity("AccessibilityModels.ChatBericht", b =>
                {
                    b.Property<int>("ChatBerichtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChatBerichtId"));

                    b.Property<int>("AfzenderBedrijfGebruikerId")
                        .HasColumnType("int");

                    b.Property<int>("AfzenderErvaringsdeskundigeGebruikerId")
                        .HasColumnType("int");

                    b.Property<int>("AfzenderId")
                        .HasColumnType("int");

                    b.Property<string>("BerichtInhoud")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OntvangerBedrijfGebruikerId")
                        .HasColumnType("int");

                    b.Property<int>("OntvangerErvaringsdeskundigeGebruikerId")
                        .HasColumnType("int");

                    b.Property<int>("OntvangerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tijdstempel")
                        .HasColumnType("datetime2");

                    b.HasKey("ChatBerichtId");

                    b.HasIndex("AfzenderBedrijfGebruikerId");

                    b.HasIndex("AfzenderErvaringsdeskundigeGebruikerId");

                    b.HasIndex("OntvangerBedrijfGebruikerId");

                    b.HasIndex("OntvangerErvaringsdeskundigeGebruikerId");

                    b.ToTable("ChatBerichten");
                });

            modelBuilder.Entity("AccessibilityModels.ErvaringsdeskundigeBeperking", b =>
                {
                    b.Property<int>("ErvaringsdeskundigeBeperkingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ErvaringsdeskundigeBeperkingId"));

                    b.Property<int>("BeperkingId")
                        .HasColumnType("int");

                    b.Property<int>("ErvaringsdeskundigeId")
                        .HasColumnType("int");

                    b.HasKey("ErvaringsdeskundigeBeperkingId");

                    b.HasIndex("BeperkingId");

                    b.HasIndex("ErvaringsdeskundigeId");

                    b.ToTable("ErvaringsdeskundigeBeperkingen");
                });

            modelBuilder.Entity("AccessibilityModels.ErvaringsdeskundigeHulpmiddel", b =>
                {
                    b.Property<int>("ErvaringsdeskundigeHulpmiddelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ErvaringsdeskundigeHulpmiddelId"));

                    b.Property<int>("ErvaringsdeskundigeId")
                        .HasColumnType("int");

                    b.Property<int>("HulpmiddelId")
                        .HasColumnType("int");

                    b.HasKey("ErvaringsdeskundigeHulpmiddelId");

                    b.HasIndex("ErvaringsdeskundigeId");

                    b.HasIndex("HulpmiddelId");

                    b.ToTable("ErvaringsdeskundigeHulpmiddelen");
                });

            modelBuilder.Entity("AccessibilityModels.Gebruiker", b =>
                {
                    b.Property<int>("GebruikerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GebruikerId"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefoonnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GebruikerId");

                    b.ToTable("Gebruikers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Gebruiker");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AccessibilityModels.Hulpmiddel", b =>
                {
                    b.Property<int>("HulpmiddelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HulpmiddelId"));

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HulpmiddelId");

                    b.ToTable("Hulpmiddelen");
                });

            modelBuilder.Entity("AccessibilityModels.Interesse", b =>
                {
                    b.Property<int>("InteresseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InteresseId"));

                    b.Property<int>("ErvaringsdeskundigeId")
                        .HasColumnType("int");

                    b.Property<int>("OnderzoekId")
                        .HasColumnType("int");

                    b.HasKey("InteresseId");

                    b.HasIndex("ErvaringsdeskundigeId");

                    b.HasIndex("OnderzoekId");

                    b.ToTable("Interesses");
                });

            modelBuilder.Entity("AccessibilityModels.Onderzoek", b =>
                {
                    b.Property<int>("OnderzoekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OnderzoekId"));

                    b.Property<string>("Beloning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("KorteBeschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locatie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MaxLeeftijd")
                        .HasColumnType("int");

                    b.Property<int?>("MinLeeftijd")
                        .HasColumnType("int");

                    b.Property<string>("PostcodeCriteria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoortOnderzoek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusDeelname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeBeperking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UitvoerendBedrijfGebruikerId")
                        .HasColumnType("int");

                    b.HasKey("OnderzoekId");

                    b.HasIndex("UitvoerendBedrijfGebruikerId");

                    b.ToTable("Onderzoeken");
                });

            modelBuilder.Entity("AccessibilityModels.OnderzoekDeelname", b =>
                {
                    b.Property<int>("DeelnameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeelnameId"));

                    b.Property<int>("ErvaringsdeskundigeId")
                        .HasColumnType("int");

                    b.Property<int>("OnderzoekId")
                        .HasColumnType("int");

                    b.HasKey("DeelnameId");

                    b.HasIndex("ErvaringsdeskundigeId");

                    b.HasIndex("OnderzoekId");

                    b.ToTable("OnderzoekDeelnames");
                });

            modelBuilder.Entity("AccessibilityModels.Bedrijf", b =>
                {
                    b.HasBaseType("AccessibilityModels.Gebruiker");

                    b.Property<string>("BedrijfsInformatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bedrijfsnaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Bedrijf");
                });

            modelBuilder.Entity("AccessibilityModels.Ervaringsdeskundige", b =>
                {
                    b.HasBaseType("AccessibilityModels.Gebruiker");

                    b.Property<string>("AandoeningOfZiekte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Achternaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeschikbareTijden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailVoogd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GeboorteDatum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MagCommercieelBenaderdWorden")
                        .HasColumnType("bit");

                    b.Property<string>("NaamVoogd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoonnummerVoogd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoorkeurBenadering")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Ervaringsdeskundige");
                });

            modelBuilder.Entity("AccessibilityModels.ChatBericht", b =>
                {
                    b.HasOne("AccessibilityModels.Bedrijf", "AfzenderBedrijf")
                        .WithMany()
                        .HasForeignKey("AfzenderBedrijfGebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessibilityModels.Ervaringsdeskundige", "AfzenderErvaringsdeskundige")
                        .WithMany()
                        .HasForeignKey("AfzenderErvaringsdeskundigeGebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessibilityModels.Bedrijf", "OntvangerBedrijf")
                        .WithMany()
                        .HasForeignKey("OntvangerBedrijfGebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessibilityModels.Ervaringsdeskundige", "OntvangerErvaringsdeskundige")
                        .WithMany()
                        .HasForeignKey("OntvangerErvaringsdeskundigeGebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AfzenderBedrijf");

                    b.Navigation("AfzenderErvaringsdeskundige");

                    b.Navigation("OntvangerBedrijf");

                    b.Navigation("OntvangerErvaringsdeskundige");
                });

            modelBuilder.Entity("AccessibilityModels.ErvaringsdeskundigeBeperking", b =>
                {
                    b.HasOne("AccessibilityModels.Beperking", "Beperking")
                        .WithMany("Ervaringsdeskundigen")
                        .HasForeignKey("BeperkingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessibilityModels.Ervaringsdeskundige", "Ervaringsdeskundige")
                        .WithMany("Beperkingen")
                        .HasForeignKey("ErvaringsdeskundigeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Beperking");

                    b.Navigation("Ervaringsdeskundige");
                });

            modelBuilder.Entity("AccessibilityModels.ErvaringsdeskundigeHulpmiddel", b =>
                {
                    b.HasOne("AccessibilityModels.Ervaringsdeskundige", "Ervaringsdeskundige")
                        .WithMany("GebruikteHulpmiddelen")
                        .HasForeignKey("ErvaringsdeskundigeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessibilityModels.Hulpmiddel", "Hulpmiddel")
                        .WithMany("GebruiktDoorErvaringsdeskundigen")
                        .HasForeignKey("HulpmiddelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ervaringsdeskundige");

                    b.Navigation("Hulpmiddel");
                });

            modelBuilder.Entity("AccessibilityModels.Interesse", b =>
                {
                    b.HasOne("AccessibilityModels.Ervaringsdeskundige", "Ervaringsdeskundige")
                        .WithMany("GetoondeInteresses")
                        .HasForeignKey("ErvaringsdeskundigeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessibilityModels.Onderzoek", "Onderzoek")
                        .WithMany("GeinteresseerdeErvaringsdeskundigen")
                        .HasForeignKey("OnderzoekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ervaringsdeskundige");

                    b.Navigation("Onderzoek");
                });

            modelBuilder.Entity("AccessibilityModels.Onderzoek", b =>
                {
                    b.HasOne("AccessibilityModels.Bedrijf", "UitvoerendBedrijf")
                        .WithMany("Onderzoeken")
                        .HasForeignKey("UitvoerendBedrijfGebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UitvoerendBedrijf");
                });

            modelBuilder.Entity("AccessibilityModels.OnderzoekDeelname", b =>
                {
                    b.HasOne("AccessibilityModels.Ervaringsdeskundige", "Ervaringsdeskundige")
                        .WithMany("OnderzoekDeelnames")
                        .HasForeignKey("ErvaringsdeskundigeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccessibilityModels.Onderzoek", "Onderzoek")
                        .WithMany("OnderzoekDeelnemers")
                        .HasForeignKey("OnderzoekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ervaringsdeskundige");

                    b.Navigation("Onderzoek");
                });

            modelBuilder.Entity("AccessibilityModels.Beperking", b =>
                {
                    b.Navigation("Ervaringsdeskundigen");
                });

            modelBuilder.Entity("AccessibilityModels.Hulpmiddel", b =>
                {
                    b.Navigation("GebruiktDoorErvaringsdeskundigen");
                });

            modelBuilder.Entity("AccessibilityModels.Onderzoek", b =>
                {
                    b.Navigation("GeinteresseerdeErvaringsdeskundigen");

                    b.Navigation("OnderzoekDeelnemers");
                });

            modelBuilder.Entity("AccessibilityModels.Bedrijf", b =>
                {
                    b.Navigation("Onderzoeken");
                });

            modelBuilder.Entity("AccessibilityModels.Ervaringsdeskundige", b =>
                {
                    b.Navigation("Beperkingen");

                    b.Navigation("GebruikteHulpmiddelen");

                    b.Navigation("GetoondeInteresses");

                    b.Navigation("OnderzoekDeelnames");
                });
#pragma warning restore 612, 618
        }
    }
}
