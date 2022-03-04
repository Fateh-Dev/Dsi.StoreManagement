using Dsi.StoreManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dsi.StoreManagement;

[DependsOn(
    typeof(StoreManagementEntityFrameworkCoreTestModule)
    )]
public class StoreManagementDomainTestModule : AbpModule
{

}
