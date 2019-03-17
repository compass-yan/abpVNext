using Microsoft.Extensions.DependencyInjection;
using myAbpVNnext.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(myAbpVNnextDomainSharedModule)
        )]
    public class myAbpVNnextDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<myAbpVNnextDomainModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources.Get<myAbpVNnextResource>().AddVirtualJson("/MyCompanyName/myAbpVNnext/Localization/Domain");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("myAbpVNnext", typeof(myAbpVNnextResource));
            });
        }
    }
}
