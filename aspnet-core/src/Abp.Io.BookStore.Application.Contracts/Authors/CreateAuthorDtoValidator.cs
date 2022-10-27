using FluentValidation;

namespace Abp.Io.BookStore.Authors;

public class CreateAuthorDtoValidator : AbstractValidator<CreateAuthorDto>
{
    public CreateAuthorDtoValidator()
    {
        RuleFor(a => a.Name)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(AuthorConsts.MaxNameLength);

        RuleFor(a => a.BirthDate)
            .NotEmpty();
    }
}