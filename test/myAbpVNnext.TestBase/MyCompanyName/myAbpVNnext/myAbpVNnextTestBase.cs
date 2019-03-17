using Volo.Abp;
using Volo.Abp.Modularity;

namespace myAbpVNnext
{
    public abstract class myAbpVNnextTestBase<TStartupModule> : AbpIntegratedTest<TStartupModule> 
        where TStartupModule : IAbpModule
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
