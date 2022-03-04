using System;
using AbpDz.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations.ObjectExtending;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.FeatureManagement.Localization;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace AbpDz.Extensions
{
    [DependsOn(
    typeof(AbpAccountApplicationModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpIdentityEntityFrameworkCoreModule)
    )]
    public class AbpDzExtensionsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpDzExtensionsModule>();
            });

            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers.Create(typeof(AbpDzExtensionsModule).Assembly);
            });
            context.Services.Replace(ServiceDescriptor.Transient<CachedObjectExtensionsDtoService, EnumsCachedObjectExtensionsDtoService>());
            context.Services.Add(ServiceDescriptor.Transient<ICachedObjectExtensionsDtoService, EnumsCachedObjectExtensionsDtoService>());

        }
    }
    public class AbpDzPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        //TODO Adding new permissions
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroupname = "ABPDZ.";
            var myGroup = context.AddGroup(myGroupname, L("Administration"));
            myGroup.AddPermission(myGroupname + "Enums", L("Enums"));
            myGroup.AddPermission(myGroupname + "AuditLog", L("AuditLogs"));
            myGroup.AddPermission(myGroupname + "OrganizationUnit", L("OrganizationUnit"));
            myGroup.AddPermission(myGroupname + "Maps", L("Maps"));
            myGroup.AddPermission(myGroupname + "Vehicules", L("Vehicules"));
            myGroup.AddPermission(myGroupname + "Personnes", L("Personnes"));
            myGroup.AddPermission(myGroupname + "Commands", L("Commands"));
        }
        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpDzResource>(name);
        }
    }

}
