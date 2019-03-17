using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using myAbpVNnext.Localization;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(AbpLocalizationModule)
        )]
    public class myAbpVNnextDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Add<myAbpVNnextResource>("en");
            });
        }
    }
}
