using System.ComponentModel.DataAnnotations;
using System;

namespace Abp.Io.BookStore.Books;

public class CreateUpdateBookDto
{
    public Guid AuthorId { get; set; }
    public string Name { get; set; }
    public BookType Type { get; set; } = BookType.Undefined;

    [DataType(DataType.Date)] 
    public DateTime PublishDate { get; set; } = DateTime.Now;
    public float Price { get; set; }
}