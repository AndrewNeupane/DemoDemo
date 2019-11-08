using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ItSutra.SecondDemo.Configuration;
using ItSutra.SecondDemo.Web;

namespace ItSutra.SecondDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SecondDemoDbContextFactory : IDesignTimeDbContextFactory<SecondDemoDbContext>
    {
        public SecondDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SecondDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SecondDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SecondDemoConsts.ConnectionStringName));

            return new SecondDemoDbContext(builder.Options);
        }
    }
}
