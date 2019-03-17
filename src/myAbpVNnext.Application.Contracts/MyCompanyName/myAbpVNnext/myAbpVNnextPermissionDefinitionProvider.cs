using myAbpVNnext.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace myAbpVNnext
{
    public class myAbpVNnextPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(myAbpVNnextPermissions.GroupName, L("Permission:myAbpVNnext"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<myAbpVNnextResource>(name);
        }
    }
}