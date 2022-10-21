using Abp.Io.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Io.BookStore;

[DependsOn(
    typeof(BookStoreEntityFrameworkCoreTestModule)
    )]
public class BookStoreDomainTestModule : AbpModule
{

}
