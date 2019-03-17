using Microsoft.Extensions.DependencyInjection;
using myAbpVNnext.Localization;
using Volo.Abp.Application;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(myAbpVNnextDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class myAbpVNnextApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<myAbpVNnextPermissionDefinitionProvider>();
            });

            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<myAbpVNnextApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<myAbpVNnextResource>()
                    .AddVirtualJson("/MyCompanyName/myAbpVNnext/Localization/ApplicationContracts");
            });
        }
    }
}
