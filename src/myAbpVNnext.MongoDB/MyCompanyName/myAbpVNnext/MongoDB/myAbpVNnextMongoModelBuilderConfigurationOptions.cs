using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace myAbpVNnext.MongoDB
{
    public class myAbpVNnextMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public myAbpVNnextMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = myAbpVNnextConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}