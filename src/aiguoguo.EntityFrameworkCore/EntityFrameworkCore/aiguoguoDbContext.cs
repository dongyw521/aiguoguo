using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using aiguoguo.Authorization.Roles;
using aiguoguo.Authorization.Users;
using aiguoguo.MultiTenancy;

namespace aiguoguo.EntityFrameworkCore
{
    public class aiguoguoDbContext : AbpZeroDbContext<Tenant, Role, User, aiguoguoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public aiguoguoDbContext(DbContextOptions<aiguoguoDbContext> options)
            : base(options)
        {
        }
    }
}
