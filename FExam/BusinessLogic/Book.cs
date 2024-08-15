using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FExam.BusinessLogic
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
        public int PublishedYear { get; set; }
        public decimal Price { get; set; }

        public Book() { }

        public Book(int id, string title, string authorName, string genre, int publishedYear, decimal price)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
            Genre = genre;
            PublishedYear = publishedYear;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Title} by {AuthorName}";
        }
    }
}

    

