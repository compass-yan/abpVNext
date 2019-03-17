using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace myAbpVNnext.EntityFrameworkCore
{
    [ConnectionStringName("myAbpVNnext")]
    public class myAbpVNnextDbContext : AbpDbContext<myAbpVNnextDbContext>, ImyAbpVNnextDbContext
    {
        public static string TablePrefix { get; set; } = myAbpVNnextConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = myAbpVNnextConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public myAbpVNnextDbContext(DbContextOptions<myAbpVNnextDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfiguremyAbpVNnext(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}