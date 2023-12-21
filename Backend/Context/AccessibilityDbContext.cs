using Microsoft.EntityFrameworkCore;
using AccessibilityModels;

public class AccessibilityDbContext : DbContext
{


    public AccessibilityDbContext(DbContextOptions<AccessibilityDbContext> options) : base(options)
    {

    }

    public DbSet<Gebruiker> Gebruikers { get; set; }
    public DbSet<Bedrijf> Bedrijven { get; set; }
    public DbSet<Ervaringsdeskundige> Ervaringsdeskundigen { get; set; }
    public DbSet<ChatBericht> ChatBerichten { get; set; }
    public DbSet<Hulpmiddel> Hulpmiddelen { get; set; }
    public DbSet<Onderzoek> Onderzoeken { get; set; }
    public DbSet<Beperking> Beperkingen { get; set; }
    public DbSet<ErvaringsdeskundigeHulpmiddel> ErvaringsdeskundigeHulpmiddelen { get; set; }
    public DbSet<OnderzoekDeelname> OnderzoekDeelnames { get; set; }
    public DbSet<ErvaringsdeskundigeBeperking> ErvaringsdeskundigeBeperkingen { get; set; }
    public DbSet<Interesse> Interesses { get; set; }





    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Gebruiker>()
            .HasKey(g => g.GebruikerId);

        modelBuilder.Entity<Ervaringsdeskundige>()
            .HasBaseType<Gebruiker>();

        modelBuilder.Entity<Bedrijf>()
            .HasBaseType<Gebruiker>();

        modelBuilder.Entity<ChatBericht>()
            .HasKey(c => c.ChatBerichtId);

        modelBuilder.Entity<Hulpmiddel>()
            .HasKey(h => h.HulpmiddelId);

        modelBuilder.Entity<Onderzoek>()
            .HasKey(o => o.OnderzoekId);

        modelBuilder.Entity<Beperking>()
            .HasKey(b => b.BeperkingId);

        
        modelBuilder.Entity<Interesse>()
            .HasOne(i => i.Ervaringsdeskundige)
            .WithMany(e => e.GetoondeInteresses)
            .HasForeignKey(i => i.ErvaringsdeskundigeId);

        modelBuilder.Entity<Interesse>()
            .HasOne(i => i.Onderzoek)
            .WithMany(o => o.GeinteresseerdeErvaringsdeskundigen)
            .HasForeignKey(i => i.OnderzoekId);

        modelBuilder.Entity<ErvaringsdeskundigeHulpmiddel>()
            .HasOne(e => e.Ervaringsdeskundige)
            .WithMany(e => e.GebruikteHulpmiddelen)
            .HasForeignKey(e => e.ErvaringsdeskundigeId);

        modelBuilder.Entity<ErvaringsdeskundigeHulpmiddel>()
            .HasOne(e => e.Hulpmiddel)
            .WithMany(e => e.GebruiktDoorErvaringsdeskundigen)
            .HasForeignKey(h => h.HulpmiddelId);

        modelBuilder.Entity<ErvaringsdeskundigeBeperking>()
            .HasOne(e => e.Ervaringsdeskundige)
            .WithMany(e => e.Beperkingen)
            .HasForeignKey(e => e.ErvaringsdeskundigeId);

        modelBuilder.Entity<ErvaringsdeskundigeBeperking>()
            .HasOne(e => e.Beperking)
            .WithMany(e => e.Ervaringsdeskundigen)
            .HasForeignKey(b => b.BeperkingId);

        modelBuilder.Entity<OnderzoekDeelname>()
            .HasOne(o => o.Ervaringsdeskundige)
            .WithMany(o => o.OnderzoekDeelnames)
            .HasForeignKey(e => e.ErvaringsdeskundigeId);

        modelBuilder.Entity<OnderzoekDeelname>()
            .HasOne(o => o.Onderzoek)
            .WithMany(o => o.OnderzoekDeelnemers)
            .HasForeignKey(o => o.OnderzoekId);

    }
}