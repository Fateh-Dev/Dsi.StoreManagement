using System;
using Dsi.StoreManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;
using Volo.Abp.Timing;

namespace Dsi.StoreManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StoreManagementEntityFrameworkCoreModule),
    typeof(StoreManagementApplicationContractsModule)
    )]
public class StoreManagementDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        //TODO configure TimeZone UTC 
        Configure<AbpClockOptions>(options =>
        {
            options.Kind = DateTimeKind.Utc;
        });
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
