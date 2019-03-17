using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace myAbpVNnext
{
    public class myAbpVNnextTestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private myAbpVNnextTestData _testData;

        public myAbpVNnextTestDataBuilder(
            IGuidGenerator guidGenerator,
            myAbpVNnextTestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}