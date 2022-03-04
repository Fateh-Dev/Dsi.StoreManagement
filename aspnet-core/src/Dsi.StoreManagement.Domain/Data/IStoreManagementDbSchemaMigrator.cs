using System.Threading.Tasks;

namespace Dsi.StoreManagement.Data;

public interface IStoreManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
