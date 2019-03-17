using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace myAbpVNnext
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : myAbpVNnextTestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
