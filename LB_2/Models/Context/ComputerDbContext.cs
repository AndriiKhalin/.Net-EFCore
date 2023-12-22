using LB_2.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace LB_2.Models.Context
{
    public class ComputerDbContext : DbContext
    {
        public ComputerDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfigurationRoot config = builder.Build();


            var connectionString = config.GetConnectionString("ConStr");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>()
                .HasOne(x => x.ComponentComputer)
                .WithMany(y => y.Computers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ComponentComputer>()
                .HasOne(x => x.HardDrive)
                .WithMany(y => y.ComponentComputers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ComponentComputer>()
                .HasOne(x => x.MotherBoard)
                .WithMany(y => y.ComponentComputers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ComponentComputer>()
                .HasOne(x => x.Processor)
                .WithMany(y => y.ComponentComputers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ComponentComputer>()
                .HasOne(x => x.Ram)
                .WithMany(y => y.ComponentComputers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ComponentComputer>()
                .HasOne(x => x.Unit)
                .WithMany(y => y.ComponentComputers)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ComponentComputer>()
                .HasOne(x => x.VideoCard)
                .WithMany(y => y.ComponentComputers)
                .OnDelete(DeleteBehavior.SetNull);

        }

        public DbSet<Computer> Computers { get; set; } = null!;
        public DbSet<ComponentComputer> ComponentComputers { get; set; } = null!;
        public DbSet<Processor> Processors { get; set; } = null!;
        public DbSet<VideoCard> VideoCards { get; set; } = null!;
        public DbSet<HardDrive> HardDrives { get; set; } = null!;
        public DbSet<Ram> Rams { get; set; } = null!;
        public DbSet<MotherBoard> MotherBoards { get; set; } = null!;
        public DbSet<Unit> Units { get; set; } = null!;

    }
}
