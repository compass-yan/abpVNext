using Volo.Abp.Modularity;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(myAbpVNnextApplicationModule),
        typeof(myAbpVNnextDomainTestModule)
        )]
    public class myAbpVNnextApplicationTestModule : AbpModule
    {

    }
}
