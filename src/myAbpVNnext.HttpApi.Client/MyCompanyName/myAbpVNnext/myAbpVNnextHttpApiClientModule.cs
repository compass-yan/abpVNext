using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(myAbpVNnextApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class myAbpVNnextHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "myAbpVNnext";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(myAbpVNnextApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
