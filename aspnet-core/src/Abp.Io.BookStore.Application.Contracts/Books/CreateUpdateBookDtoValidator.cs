using FluentValidation;

namespace Abp.Io.BookStore.Books;

public class CreateUpdateBookDtoValidator : AbstractValidator<CreateUpdateBookDto>
{
    public CreateUpdateBookDtoValidator()
    {
        RuleFor(b => b.Name)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(128);

        RuleFor(b => b.Type)
            .NotEmpty();

        RuleFor(b => b.PublishDate)
            .NotEmpty();

        RuleFor(b => b.Price)
            .NotEmpty();
    }
}