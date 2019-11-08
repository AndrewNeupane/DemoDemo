using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ItSutra.SecondDemo.Authorization.Roles;
using ItSutra.SecondDemo.Authorization.Users;
using ItSutra.SecondDemo.MultiTenancy;
using ItSutra.SecondDemo.GameModel;

namespace ItSutra.SecondDemo.EntityFrameworkCore
{
    public class SecondDemoDbContext : AbpZeroDbContext<Tenant, Role, User, SecondDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Player> Players { get; set; }
        public SecondDemoDbContext(DbContextOptions<SecondDemoDbContext> options)
            : base(options)
        {
        }
    }
}
