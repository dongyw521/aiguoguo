using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using aiguoguo.Configuration;
using aiguoguo.Web;

namespace aiguoguo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class aiguoguoDbContextFactory : IDesignTimeDbContextFactory<aiguoguoDbContext>
    {
        public aiguoguoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<aiguoguoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            aiguoguoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(aiguoguoConsts.ConnectionStringName));

            return new aiguoguoDbContext(builder.Options);
        }
    }
}
