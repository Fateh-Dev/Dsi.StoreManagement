using System;
using Volo.Abp.Account;
using Volo.Abp.AspNetCore.SignalR;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDz.Messaging
{
    [DependsOn(
        typeof(AbpAccountApplicationModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpAspNetCoreSignalRModule)
    )]
    public class AbpDzMessagingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpDzMessagingModule>();
            });

            // context.Services.Configure<AbpDbContextOptions>(options =>
            //   {
            //       options.PreConfigure<IdentityDbContext>(context =>
            //       {
            //           Console.WriteLine("---notifcation--");
            //           // options.AddRepository<Book, BookRepository>();
            //       });
            //   });

            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers.Create(typeof(AbpDzMessagingModule).Assembly);
            });

            Configure<AbpSignalROptions>(options =>
            {
                options.Hubs.AddOrUpdate(
                    typeof(AbpDzMessagingHub), //Hub type
                    config => //Additional configuration
                    {
                        config.RoutePattern = "/abpdz-Messaging-hub"; //override the default route
                        config.ConfigureActions.Add(hubOptions =>
                        {
                            //Additional options
                            hubOptions.LongPolling.PollTimeout = TimeSpan.FromSeconds(30);
                        });
                    }
                );
            });
        }
    }
}
