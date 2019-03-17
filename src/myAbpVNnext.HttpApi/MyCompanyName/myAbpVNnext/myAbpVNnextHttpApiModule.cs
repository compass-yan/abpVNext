using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(myAbpVNnextApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class myAbpVNnextHttpApiModule : AbpModule
    {
        
    }
}
