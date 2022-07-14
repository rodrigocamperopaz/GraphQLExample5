﻿namespace GraphQLExample5.Models
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;

        public Author Author { get; set; } = new Author();
    }
}
