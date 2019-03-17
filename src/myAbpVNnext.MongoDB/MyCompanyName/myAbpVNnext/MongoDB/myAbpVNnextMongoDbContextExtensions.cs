using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace myAbpVNnext.MongoDB
{
    public static class myAbpVNnextMongoDbContextExtensions
    {
        public static void ConfiguremyAbpVNnext(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new myAbpVNnextMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}