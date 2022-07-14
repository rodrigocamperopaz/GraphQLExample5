using GraphQLExample5.Models;

namespace GraphQLExample5.Queries
{
    public class Query
    {
        public Book GetBook() =>
        new Book
        {
            Title = "Backend module example",
            Author = new Author
            {
                Name = "John Doe"
            }
        };
    }
}
