using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Settings;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(myAbpVNnextDomainModule),
        typeof(myAbpVNnextApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class myAbpVNnextApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<myAbpVNnextApplicationAutoMapperProfile>(validate: true);
            });

            Configure<SettingOptions>(options =>
            {
                options.DefinitionProviders.Add<myAbpVNnextSettingDefinitionProvider>();
            });
        }
    }
}
