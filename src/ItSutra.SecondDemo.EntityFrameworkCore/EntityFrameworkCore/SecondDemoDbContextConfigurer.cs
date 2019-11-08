using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ItSutra.SecondDemo.EntityFrameworkCore
{
    public static class SecondDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SecondDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SecondDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
