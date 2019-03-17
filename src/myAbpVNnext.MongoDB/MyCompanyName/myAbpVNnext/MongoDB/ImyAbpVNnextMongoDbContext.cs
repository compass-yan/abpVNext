using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace myAbpVNnext.MongoDB
{
    [ConnectionStringName("myAbpVNnext")]
    public interface ImyAbpVNnextMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
