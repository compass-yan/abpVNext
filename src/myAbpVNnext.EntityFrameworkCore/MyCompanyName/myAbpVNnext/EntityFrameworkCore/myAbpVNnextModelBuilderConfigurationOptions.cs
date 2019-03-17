using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace myAbpVNnext.EntityFrameworkCore
{
    public class myAbpVNnextModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public myAbpVNnextModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = myAbpVNnextConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = myAbpVNnextConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}