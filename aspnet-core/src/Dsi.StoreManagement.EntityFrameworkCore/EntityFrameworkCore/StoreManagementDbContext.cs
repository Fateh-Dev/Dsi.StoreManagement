using Dsi.StoreManagement.Categories;
using Dsi.StoreManagement.Colors;
using Dsi.StoreManagement.Documents;
using Dsi.StoreManagement.Marques;
using Dsi.StoreManagement.Models;
using Dsi.StoreManagement.Operations;
using Dsi.StoreManagement.Products;
using Dsi.StoreManagement.Units;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Dsi.StoreManagement.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class StoreManagementDbContext :
    AbpDbContext<StoreManagementDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Dsi Store Management Entities
    public DbSet<Product> Products { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Marque> Marques { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Operation> Operations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public StoreManagementDbContext(DbContextOptions<StoreManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(StoreManagementConsts.DbTablePrefix + "YourEntities", StoreManagementConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
        builder.Entity<Product>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Products",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.DisplayFr).IsRequired().HasMaxLength(128);
                b.HasIndex(x => x.DisplayFr).IsUnique();
                b.HasOne(x => x.Marque)
                    .WithMany()
                    .HasForeignKey(x => x.MarqueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
                b.HasOne(x => x.Model)
                    .WithMany()
                    .HasForeignKey(x => x.ModelId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
                b.HasOne(x => x.Unit)
                    .WithMany()
                    .HasForeignKey(x => x.UnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
                b.HasOne(x => x.Color)
                    .WithMany()
                    .HasForeignKey(x => x.ColorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();
                b.HasOne(x => x.Category)
                    .WithMany()
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

            });
        builder.Entity<Document>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Documents",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.DisplayFr).IsRequired().HasMaxLength(128);
                b.Property(x => x.DocumentReference).IsRequired().HasMaxLength(128);
            });
        builder.Entity<Marque>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Marques",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.DisplayFr).IsRequired().HasMaxLength(128);
                b.HasIndex(x => x.DisplayFr).IsUnique();
            });
        builder.Entity<Model>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Models",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.DisplayFr).IsRequired().HasMaxLength(128);
                b.HasIndex(x => x.DisplayFr).IsUnique();
            });
        builder.Entity<Unit>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Units",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.DisplayFr).IsRequired().HasMaxLength(128);
                b.HasIndex(x => x.DisplayFr).IsUnique();
            });
        builder.Entity<Color>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Colors",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.DisplayFr).IsRequired().HasMaxLength(128);
                b.HasIndex(x => x.DisplayFr).IsUnique();
            });
        builder.Entity<Category>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Categories",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.DisplayFr).IsRequired().HasMaxLength(128);
                b.HasIndex(x => x.DisplayFr).IsUnique();
            });
        builder.Entity<Operation>(b =>
            {
                b.ToTable(StoreManagementConsts.DbTablePrefix + "Operations",
                    StoreManagementConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.ProductId).IsRequired().HasMaxLength(128);
                b.Property(x => x.DocumentId).IsRequired().HasMaxLength(128);

                b.HasIndex(x => x.ProductId);
                b.HasOne(k => k.Product).WithMany(k => k.OperationList).HasForeignKey(k => k.ProductId);

                b.HasIndex(x => x.DocumentId);
                b.HasOne(k => k.Document).WithMany(k => k.ProductList).HasForeignKey(k => k.DocumentId);

                b.Property(x => x.Quantity).IsRequired();
            });
    }
}
