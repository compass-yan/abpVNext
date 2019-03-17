using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace myAbpVNnext.MongoDB
{
    [DependsOn(
        typeof(myAbpVNnextDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class myAbpVNnextMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<myAbpVNnextMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
