using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace myAbpVNnext.MongoDB
{
    [ConnectionStringName("myAbpVNnext")]
    public class myAbpVNnextMongoDbContext : AbpMongoDbContext, ImyAbpVNnextMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = myAbpVNnextConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfiguremyAbpVNnext(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}