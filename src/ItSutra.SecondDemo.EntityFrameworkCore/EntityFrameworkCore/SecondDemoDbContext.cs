using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ItSutra.SecondDemo.Authorization.Roles;
using ItSutra.SecondDemo.Authorization.Users;
using ItSutra.SecondDemo.MultiTenancy;
using ItSutra.SecondDemo.GameModel;
using System.Linq;

namespace ItSutra.SecondDemo.EntityFrameworkCore
{
    public class SecondDemoDbContext : AbpZeroDbContext<Tenant, Role, User, SecondDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }

        public SecondDemoDbContext(DbContextOptions<SecondDemoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Match>()
                .HasOne(x => x.FirstPlayer)
                .WithMany()
                .HasForeignKey(m => m.FirstPlayerId);
            modelBuilder.Entity<Match>()
              .HasOne(x => x.SecondPlayer)
              .WithMany()
              .HasForeignKey(m => m.SecondPlayerId);
            modelBuilder.Entity<Match>()
              .HasOne(x => x.WinningPlayer)
              .WithMany()
              .HasForeignKey(m => m.WinningPlayerId);

        //    var cascadeFKs = modelBuilder.Model.GetEntityTypes()
        //.SelectMany(t => t.GetForeignKeys())
        //.Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

        //    foreach (var fk in cascadeFKs)
        //        fk.DeleteBehavior = DeleteBehavior.Restrict;



        }
    }
}
