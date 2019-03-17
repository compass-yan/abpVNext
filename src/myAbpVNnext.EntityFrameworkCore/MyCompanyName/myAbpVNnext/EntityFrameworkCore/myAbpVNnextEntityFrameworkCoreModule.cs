using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace myAbpVNnext.EntityFrameworkCore
{
    [DependsOn(
        typeof(myAbpVNnextDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class myAbpVNnextEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<myAbpVNnextDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}