using Abp.Io.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Io.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreController : AbpControllerBase
{
    protected BookStoreController()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
