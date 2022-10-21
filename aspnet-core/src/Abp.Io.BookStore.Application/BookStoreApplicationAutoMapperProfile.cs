using Abp.Io.BookStore.Books;
using AutoMapper;

namespace Abp.Io.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<Book, CreateUpdateBookDto>().ReverseMap();
    }
}