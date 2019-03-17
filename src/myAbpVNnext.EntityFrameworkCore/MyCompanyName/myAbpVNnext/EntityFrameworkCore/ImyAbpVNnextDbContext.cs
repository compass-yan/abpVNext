using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace myAbpVNnext.EntityFrameworkCore
{
    [ConnectionStringName("myAbpVNnext")]
    public interface ImyAbpVNnextDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}