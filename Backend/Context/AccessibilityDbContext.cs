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





    public void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Interesse>()
        .HasKey(i => i.InteresseId);

    modelBuilder.Entity<Interesse>()
        .HasOne(i => i.Ervaringsdeskundige)
        .WithMany(e => e.GetoondeInteresses)
        .HasForeignKey(i => i.ErvaringsdeskundigeId);

    modelBuilder.Entity<Interesse>()
        .HasOne(i => i.Onderzoek)
        .WithMany(o => o.GeinteresseerdeErvaringsdeskundigen)
        .HasForeignKey(i => i.OnderzoekId);

    }
}