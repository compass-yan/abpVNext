using myAbpVNnext.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace myAbpVNnext
{
    [DependsOn(
        typeof(myAbpVNnextEntityFrameworkCoreTestModule)
        )]
    public class myAbpVNnextDomainTestModule : AbpModule
    {
        
    }
}
