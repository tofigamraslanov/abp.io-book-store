using JetBrains.Annotations;
using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp;

namespace Abp.Io.BookStore.Authors;

public class Author : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; private set; }
    public DateTime BirthDate { get; set; }
    public string ShortBio { get; set; }

    private Author()
    {
    }

    internal Author(
        Guid id,
        [NotNull] string name,
        DateTime birthDate,
        [CanBeNull] string shortBio = null)
        : base(id)
    {
        SetName(name);
        BirthDate = birthDate;
        ShortBio = shortBio;
    }

    internal Author ChangeName([NotNull] string name)
    {
        SetName(name);
        return this;
    }

    private void SetName([NotNull] string name)
    {
        Name = Check.NotNullOrWhiteSpace(
            name,
            nameof(name),
            maxLength: AuthorConsts.MaxNameLength
        );
    }
}