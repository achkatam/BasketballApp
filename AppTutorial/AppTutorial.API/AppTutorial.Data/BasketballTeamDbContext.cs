namespace BasketballTeam.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class BasketballTeamDbContext : IdentityDbContext<User>
    {
        public BasketballTeamDbContext(DbContextOptions<BasketballTeamDbContext> options)
            : base(options)
        {
        }

        public DbSet<BasketballTeam> Teams { get; set; } = null!;
        public DbSet<Coach> Coaches { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Tournament> Tournaments { get; set; } = null!;
        public DbSet<TeamPlayer> TeamPlayers { get; set; } = null!;

        public DbSet<Merchandize> MerchandizeProducts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<TeamPlayer>()
                .HasKey(tp => new { tp.PlayerId, tp.TeamId });

            builder
                .Entity<Merchandize>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(builder);
        }
    }
}