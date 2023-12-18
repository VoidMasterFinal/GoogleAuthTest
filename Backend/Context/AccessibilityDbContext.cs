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
    public DbSet<ErvaringsdeskundigeHulpmiddel> ErvaringsdeskundigeHulpmiddelen { get; set; }
    public DbSet<OnderzoekDeelname> OnderzoekDeelnames { get; set; }



    public void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

    }
}