using FluentValidation;

namespace Abp.Io.BookStore.Authors;

public class UpdateAuthorDtoValidator : AbstractValidator<UpdateAuthorDto>
{
    public UpdateAuthorDtoValidator()
    {
        RuleFor(a => a.Name)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(AuthorConsts.MaxNameLength);

        RuleFor(a => a.BirthDate)
            .NotEmpty();
    }
}