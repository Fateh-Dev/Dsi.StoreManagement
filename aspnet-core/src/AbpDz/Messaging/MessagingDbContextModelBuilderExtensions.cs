using System;
using AbpDz.Models;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore.Modeling;


namespace Microsoft.EntityFrameworkCore
{
    public static class MessagingDbContextModelBuilderExtensions
    {
        public static void ConfigureMessaging(
          this ModelBuilder builder,
            Action<AbpModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AbpModelBuilderConfigurationOptions(
                AbpCommonDbProperties.DbTablePrefix,
                AbpCommonDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            builder.Entity<AbpDzMessagingInfo>(b =>
            {
                b.ToTable(nameof(AbpDzMessagingInfo), options.Schema);
                b.HasIndex(k => k.SenderId);
                b.HasIndex(k => k.RecipientId);
                b.HasIndex(k => k.RecipientRoleId);
                b.HasIndex(k => k.Code);
                b.HasIndex(k => k.RecipientPermission);
                b.HasIndex(k => k.DataTypeName);
                b.HasIndex(k => k.EntityId);
                b.HasIndex(k => k.Severity);
                b.HasIndex(k => k.State);
                b.ConfigureByConvention();


            });


        }
    }
}