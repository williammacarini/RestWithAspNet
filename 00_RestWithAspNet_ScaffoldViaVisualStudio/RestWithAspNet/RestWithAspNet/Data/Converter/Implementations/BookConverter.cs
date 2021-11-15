using RestWithAspNet.Data.Contract;
using RestWithAspNet.Data.VO;
using RestWithAspNet.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithAspNet.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;

            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;

            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
