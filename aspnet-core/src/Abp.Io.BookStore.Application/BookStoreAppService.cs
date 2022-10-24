using Abp.Io.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Io.BookStore;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
