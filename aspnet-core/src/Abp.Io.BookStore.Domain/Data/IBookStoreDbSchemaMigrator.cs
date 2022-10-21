using System.Threading.Tasks;

namespace Abp.Io.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
