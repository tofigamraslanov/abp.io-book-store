using Volo.Abp.Application.Dtos;

namespace Abp.Io.BookStore.Authors;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}