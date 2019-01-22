using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace aiguoguo.EntityFrameworkCore
{
    public static class aiguoguoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<aiguoguoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<aiguoguoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
