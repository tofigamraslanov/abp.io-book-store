using System.Threading.Tasks;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Io.BookStore.Authors;

public interface IAuthorAppService : IApplicationService
{
    Task<AuthorDto> GetAsync(Guid id);
    Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);
    Task<AuthorDto> CreateAsync(CreateAuthorDto input);
    Task UpdateAsync(Guid id, UpdateAuthorDto input);
    Task DeleteAsync(Guid id);
}